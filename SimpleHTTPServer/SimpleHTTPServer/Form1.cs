using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SimpleHTTPServer
{
    public partial class Form1 : Form
    {
        private Socket httpServer;
        private int serverPort = 80;
        private Thread thread;

        public Form1()
        {
            InitializeComponent();
        }

        private void StartServerBtn_Click(object sender, EventArgs e)
        {
            ServerLogsTxtBox.Text = "";

            try
            {
                httpServer = new Socket(SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    serverPort = int.Parse(PortTxtBox.Text.ToString());

                    if(serverPort > 65535 || serverPort <= 0)
                    {
                        throw new Exception("Server port not within the range");
                    }
                }
                catch(Exception ex)
                {
                    serverPort = 80;
                    ServerLogsTxtBox.Text = "Server failed to start on specified port \n";
                }

                thread = new Thread(new ThreadStart(this.connectionThreadMethod));  //Żeby nie blokować wykonania obecnego wątku, jeżeli zamiast wątku wywołasz connectionThreadMethod to potem są pętlę while(true)
                thread.Start();

                StartServerBtn.Enabled = false;
                StopServerBtn.Enabled = true;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error while starting the server");
                ServerLogsTxtBox.Text = "Server starting failed /n";

            }

            ServerLogsTxtBox.Text = "Server started";
        }

        private void StopServerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                httpServer.Close();

                //kill the thread
                thread.Abort();

                StartServerBtn.Enabled = true;
                StopServerBtn.Enabled = false;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Stopping failed");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StopServerBtn.Enabled = false;
        }

        private void connectionThreadMethod()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, serverPort);
            httpServer.Bind(endPoint);  //rezerwujesz port w systemie, czyli mówisz że serwer będzie stał na porcie np. 1234
            httpServer.Listen(1);  //nasłuchuje żeby odbierać pakiety

            startListeningForConnection();
        }

        private void startListeningForConnection()
        {
            while(true)
            {
                DateTime time = DateTime.Now;
                string data = "";
                byte[] bytes = new byte[2048];  //Na początku jest wartość domyślną czyli 0, a tworzy ją się po to żeby serwer miał gdzie zapisać dane które przychodzą po sieci

                Socket client = httpServer.Accept();  //Blocking Statement

                while(true)
                {
                    int numBytes = client.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, numBytes);

                    if(data.IndexOf("\r\n") > -1)
                    {
                        break;
                    }
                }

                //data read
                ServerLogsTxtBox.Invoke((MethodInvoker)delegate
                {
                    //Runs inside UI Thread
                    ServerLogsTxtBox.Text += "\r\n\r\n";
                    ServerLogsTxtBox.Text += data;
                    ServerLogsTxtBox.Text += "\n\n ----- End of Request -----";
                });

                //Send back to response
                string responseHeader = "HTTP/1.1 200 Everything is fine\nServer: my_csharp_server\n Content-Type: " +
                    "text/html; charset: UTF-8;";
                string responseBody = "<!DOCTYPE html> <html>" +
                    "<Head><title></title>></head>" +
                    "<body><h4>" +"Server time is: " + time.ToString() + "</h4></body>" +
                    "</html>";
                string responseString = responseHeader + responseBody;
                byte[] responseData = Encoding.ASCII.GetBytes(responseString);
                client.SendTo(responseData, client.RemoteEndPoint);

                client.Close();

            }
        }
    }
}
