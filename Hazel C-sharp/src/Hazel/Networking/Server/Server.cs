using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace Hazel.Networking.Server
{
    class Server
    {
        // Max amount of players set in Start.
        public static int MaxPlayers { get; private set; }
        // Port that server is hosted on at ip address.
        public static int Port { get; private set; }

        // all clients with found with id.
        public static Dictionary<int, Client> clients = new Dictionary<int, Client>();
        // PacketHandler delegate...
        public delegate void PacketHandler(int _fromClient, Packet _packet);
        //dictionary that saves all PacketHandler delegates.
        public static Dictionary<int, PacketHandler> packetHandlers;

        // listen to Incoming clients and messages via TCP...
        private static TcpListener tcpListener;
        // listen to Incoming messages via UDP...
        private static UdpClient udpListener;
        public ThreadManager TM { get; private set; } = new ThreadManager();

        public Server(int _maxPlayers, int _port, Dictionary<int, PacketHandler> _packetHandlers, string ipaddress = "any")
        {
            packetHandlers = _packetHandlers;
            Start(_maxPlayers, _port, ipaddress);
        }

        /// <summary>
        /// This is where the server starts from it sets the Max Players and the port.
        /// it initializes the server data,
        /// starts and begins to recieve from UDP and TCP
        /// </summary>
        /// <param name="_maxPlayers"></param>
        /// <param name="_port"></param>
        public void Start(int _maxPlayers, int _port, string ipaddress)
        {
            MaxPlayers = _maxPlayers;
            Port = _port;

            Debug.DLog("Starting server...");
            InitializeServerData();

            if (ipaddress == "any")
                tcpListener = new TcpListener(IPAddress.Any, Port);
            else 
            {
                IPAddress ip;
                IPAddress.TryParse(ipaddress, out ip);
                tcpListener = new TcpListener(ip, Port);
            }
            tcpListener.Start();
            tcpListener.BeginAcceptTcpClient(TCPConnectCallback, null);

            udpListener = new UdpClient(Port);
            udpListener.BeginReceive(UDPReceiveCallback, null);

            Debug.DLog($"Server started on port {Port}.");
        }

        /// <summary> 
        /// this is called if the TCP listener accepts a client.
        /// it creates a client and checks if there is an open slot,
        /// if there is the client is assigned and connected.
        /// otherwise the server must be full.
        /// </summary>
        private static void TCPConnectCallback(IAsyncResult _result)
        {
            TcpClient _client = tcpListener.EndAcceptTcpClient(_result);
            tcpListener.BeginAcceptTcpClient(TCPConnectCallback, null);
            Debug.DLog($"Incoming connection from {_client.Client.RemoteEndPoint}...");

            for (int i = 1; i <= MaxPlayers; i++)
            {
                if (clients[i].tcp.socket == null)
                {
                    clients[i].tcp.Connect(_client);
                    return;
                }
            }

            Debug.DLogError($"{_client.Client.RemoteEndPoint} failed to connect: Server full!");
        }

        /// <summary>
        /// this is called when the UDP listener recieves a datagram
        /// it listens to which data it recieves.
        /// </summary>
        private static void UDPReceiveCallback(IAsyncResult _result)
        {
            try
            {
                IPEndPoint _clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
                byte[] _data = udpListener.EndReceive(_result, ref _clientEndPoint);
                udpListener.BeginReceive(UDPReceiveCallback, null);

                if (_data.Length < 4)
                {
                    return;
                }

                using (Packet _packet = new Packet(_data))
                {
                    int _clientId = _packet.ReadInt();

                    if (_clientId == 0)
                    {
                        return;
                    }

                    if (clients[_clientId].udp.endPoint == null)
                    {
                        clients[_clientId].udp.Connect(_clientEndPoint);
                        return;
                    }

                    if (clients[_clientId].udp.endPoint.ToString() == _clientEndPoint.ToString())
                    {
                        clients[_clientId].udp.HandleData(_packet);
                    }
                }
            }
            catch (Exception _ex)
            {
                Debug.DLogError($"Error receiving UDP data: {_ex}");
            }
        }

        /// <summary>
        /// this sends UDP data.
        /// </summary>
        /// <param name="_clientEndPoint"> this is the client to which it has to be send to </param>
        /// <param name="_packet"> this is the packet that gets send </param>
        public static void SendUDPData(IPEndPoint _clientEndPoint, Packet _packet)
        {
            try
            {
                if (_clientEndPoint != null)
                {
                    udpListener.BeginSend(_packet.ToArray(), _packet.Length(), _clientEndPoint, null, null);
                }
            }
            catch (Exception _ex)
            {
                Debug.DLogError($"Error sending data to {_clientEndPoint} via UDP: {_ex}");
            }
        }

        /// <summary>
        /// this sets the starting data for the server and adds all the clients slots to the dictionary.
        /// it also sets the packetHandlers.
        /// it's called at start.
        /// </summary>
        private void InitializeServerData()
        {
            for (int i = 1; i <= MaxPlayers; i++)
            {
                clients.Add(i, new Client(i,this));
            }

            Debug.DLog("Initialized packets.");
        }

        public void SendTCPData(int _toClient, Packet _packet)
        {
            _packet.WriteLength();
            Server.clients[_toClient].tcp.SendData(_packet);
        }

        public void SendUDPData(int _toClient, Packet _packet)
        {
            _packet.WriteLength();
            Server.clients[_toClient].udp.SendData(_packet);
        }

        public void SendTCPDataToAllMatch(Dictionary<int, Client> _clients, Packet _packet)
        {
            _packet.WriteLength();
            foreach (KeyValuePair<int, Client> C in _clients)
            {
                Client _C = C.Value;
                _C.tcp.SendData(_packet);
            }
        }

        public void SendTCPDataToAllMatch(Dictionary<int, Client> _clients, int _exceptClient, Packet _packet)
        {
            _packet.WriteLength();
            foreach (KeyValuePair<int, Client> C in _clients)
            {
                if (C.Value.id != _exceptClient)
                {
                    Client _C = C.Value;
                    _C.tcp.SendData(_packet);
                }
            }
        }

        public void SendTCPDataToAll(Packet _packet)
        {
            _packet.WriteLength();
            for (int i = 1; i <= Server.MaxPlayers; i++)
            {
                Server.clients[i].tcp.SendData(_packet);
            }
        }

        public void SendTCPDataToAll(int _exceptClient, Packet _packet)
        {
            _packet.WriteLength();
            for (int i = 1; i <= Server.MaxPlayers; i++)
            {
                if (i != _exceptClient)
                {
                    Server.clients[i].tcp.SendData(_packet);
                }
            }
        }

        public void SendUDPDataToAllMatch(Dictionary<int, Client> _clients, Packet _packet)
        {
            _packet.WriteLength();
            foreach (KeyValuePair<int, Client> C in _clients)
            {
                Client _C = C.Value;
                _C.tcp.SendData(_packet);
            }
        }

        public void SendUDPDataToAllMatch(Dictionary<int, Client> _clients, int _exceptClient, Packet _packet)
        {
            _packet.WriteLength();
            foreach (KeyValuePair<int, Client> C in _clients)
            {
                if (C.Value.id != _exceptClient)
                {
                    Client _C = C.Value;
                    _C.udp.SendData(_packet);
                }
            }
        }

        public void SendUDPDataToAll(Packet _packet)
        {
            _packet.WriteLength();
            for (int i = 1; i <= Server.MaxPlayers; i++)
            {
                Server.clients[i].udp.SendData(_packet);
            }
        }
        public void SendUDPDataToAll(int _exceptClient, Packet _packet)
        {
            _packet.WriteLength();
            for (int i = 1; i <= Server.MaxPlayers; i++)
            {
                if (i != _exceptClient)
                {
                    Server.clients[i].udp.SendData(_packet);
                }
            }
        }

    }
}
