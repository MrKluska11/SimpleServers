using SuperSimpleTcp;
using System.Text;

namespace SimpleTcpIpClientServer
{
    public partial class Form1 : Form
    {
        private SimpleTcpClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                btnSend.Enabled = true;
                btnConnect.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(client.IsConnected)
            {
                if(!string.IsNullOrEmpty(txtBoxMessage.Text))
                {
                    client.Send(txtBoxMessage.Text);
                    txtBoxInfo.Text += $"Me: {txtBoxMessage.Text} /n";
                    txtBoxMessage.Text = "";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient(txtBoxIp.Text);
            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;
            client.Events.DataReceived += Events_DataReceived;
            btnSend.Enabled = false;
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtBoxInfo.Text += $"Server: {Encoding.UTF8.GetString(e.Data)} /n";
            });
            
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtBoxInfo.Text += "Server disconnected /n";
            });
            
        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtBoxInfo.Text += "Server connected /n";
            });       
        }
    }
}