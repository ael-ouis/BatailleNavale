namespace BatailleNavale
{
    public class Networking
    {
        public static string input { get; set; }
        public static void Server()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int received;
            byte[] data = new byte[1024];
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("192.168.1.51"), 49221);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(ip);
            socket.Listen(1);
            Console.WriteLine("Connexion en attente...");
            Socket client = socket.Accept();
            Console.WriteLine("Connecté !");
            //string input;
            while (true)
            {
                data = new byte[1024];
                received = client.Receive(data);
                Console.WriteLine("Entrez des coordonnées (de A0 à J9)");
                Console.WriteLine("Client: " + Encoding.UTF8.GetString(data, 0, received));
                input = Console.ReadLine();
                if (input == "exit")
                    break;
                //else if (verif == false)
                //    input = "c'est encore à toi";
                Console.WriteLine("Vous: " + input);
                client.Send(Encoding.UTF8.GetBytes(input));
            }
            Console.WriteLine("Déconnecté !");
            client.Close();
            socket.Close();
            Console.ReadLine();
        }

        public static void Client()
        {
            Console.OutputEncoding = Encoding.UTF8;
            byte[] data = new byte[1024];
            string stringData;
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse("192.168.1.14"), 60299);
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ip);
                Console.WriteLine("Connecté !");
            }
            catch
            {
                Console.WriteLine("Connexion impossible.");
                return;
            }
            int received = server.Receive(data);
            while (true)
            {
                input = Console.ReadLine();
                if (input == "exit")
                    break;
                //if (verif == false)
                //    input = "c'est encore à toi";
                Console.WriteLine("Vous: " + input);
                server.Send(Encoding.UTF8.GetBytes(input));
                data = new byte[1024];
                received = server.Receive(data);
                Console.WriteLine("Entrez des coordonnées (de A0 à J9)");
                Console.WriteLine("Serveur: " + Encoding.UTF8.GetString(data, 0, received));
            }
            Console.WriteLine("Déconnexion du serveur");
            server.Shutdown(SocketShutdown.Both);
            server.Close();
            Console.WriteLine("Déconnecté !");
            Console.ReadLine();
        }
    }
}