using Russlyman.Rcon;

namespace RconGui
{
    public partial class ConnectForm : Form
    {
        private RconClient _rconClient;

        public ConnectForm(RconClient rconClient)
        {
            InitializeComponent();
            _rconClient = rconClient;
        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _rconClient.Connect(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text);
            }
            catch (Exception exception)
            {
                string errorMessage = exception switch
                {
                    FormatException => "Invalid IP or port format provided.",
                    ArgumentException => "Invalid password format provided.",
                    _ => exception.ToString()
                };

                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Close();
        }
    }
}
