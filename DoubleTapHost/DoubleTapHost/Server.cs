using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace DoubleTapHost
{
    internal class Server
    {

        public static void startServer(ref RichTextBox consoleLogBox)
        {
            // Get Host IP Address that is used to establish a connection
            // In this case, we get one IP address of localhost that is IP : 127.0.0.1
            // If a host has multiple addresses, you will get a list of addresses
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 11000);

            try
            {
                // Create a Socket that will use Tcp protocol
                Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                // A Socket must be associated with an endpoint using the Bind method
                listener.Bind(localEndPoint);
                // Specify how many requests a Socket can listen before it gives Server busy response.
                // We will listen 10 requests at a time
                listener.Listen(10);

                consoleLogBox.AppendText("Waiting for a connection...\r\n");
                consoleLogBox.ScrollToCaret();
                Socket handler = listener.Accept();

                // Incoming data from the client.
                string data = null;
                byte[] bytes = null;

                while (true)
                {
                    bytes = new byte[1024];
                    int bytesRec = handler.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                    if (data.IndexOf("<EOF>") > -1)
                    {
                        break;
                    }
                }

                string recievedData = "Text received : {" + data + "}";
                consoleLogBox.AppendText(recievedData + "\r\n");
                consoleLogBox.ScrollToCaret();

                byte[] msg = Encoding.ASCII.GetBytes(data);
                handler.Send(msg);
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
            }
            catch (Exception e)
            {
                consoleLogBox.AppendText(e.ToString() + "\r\n");
                consoleLogBox.ScrollToCaret();
            }

            consoleLogBox.AppendText("\n Press any key to continue...\r\n");
            consoleLogBox.ScrollToCaret();

        }

        public static void closeServer()
        {

        }

        public static string[] getConnections()
        {
            string[] connections = new string[5];
            connections[0] = "Mobile Device 1";
            connections[1] = "Mobile Device 2";
            connections[2] = "Mobile Device 3";
            connections[3] = "Mobile Device 4";
            connections[4] = "Mobile Device 5";

            return connections;
        }

    }
}
