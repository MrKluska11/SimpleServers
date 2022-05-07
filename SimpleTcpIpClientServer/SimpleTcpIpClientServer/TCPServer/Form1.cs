using SuperSimpleTcp;
using System.Text;

namespace SimpleTcpIpClientServer
{
    public partial class Form1 : Form
    {
        private SimpleTcpServer server;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            server.Start();
            txtBoxInfo.Text = $"Starting.... {Environment.NewLine}";
            btnStart.Enabled = false;
            btnSend.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            server = new SimpleTcpServer(txtBoxIp.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtBoxInfo.Text = $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)} /n";
            });
            
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtBoxInfo.Text = $"{e.IpPort} disconnected./n";
                listClientIP.Items.Remove(e.IpPort);
            });

        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
           {
               txtBoxInfo.Text = $"{e.IpPort} connected./n";
               listClientIP.Items.Add(e.IpPort);
           });

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(server.IsListening)
            {
                if(!string.IsNullOrWhiteSpace(txtBoxMessage.Text) && listClientIP.SelectedItem != null)
                {
                    server.Send(listClientIP.SelectedItem.ToString(), txtBoxMessage.Text);
                    txtBoxInfo.Text += $"Server: {txtBoxMessage.Text} /n";
                    txtBoxMessage.Text = "";
                }
            }
        }
    }
}