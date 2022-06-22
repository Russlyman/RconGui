using System.Net.Sockets;
using Russlyman.Rcon;

namespace RconGui
{
    public partial class Form1 : Form
    {
        private readonly RconClient _rconClient;
        private readonly ConnectForm _connectForm;

        public Form1()
        {
            InitializeComponent();
            _rconClient = new RconClient();
            _connectForm = new ConnectForm(_rconClient);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.AppendText("Connect to a server to send commands.");
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _connectForm.ShowDialog();
        }

        private void clearConsoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Console cleared.";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string reply;

            if (_rconClient.Ip == null)
            {
                reply = "Not connected to a server.";
            }
            else
            {
                try
                {
                    reply = await _rconClient.SendAsync(textBox1.Text);
                }
                catch (SocketException)
                {
                    reply = "Server unreachable.";
                }
            }

            textBox2.AppendText($"{Environment.NewLine}{Environment.NewLine}> {textBox1.Text}{Environment.NewLine}{reply}");
            textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            button1_Click(this, EventArgs.Empty);
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _rconClient.Close();
            _connectForm.Dispose();
        }
    }
}