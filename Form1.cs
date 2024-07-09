using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txt_username.Text;
            string password = txt_password.Text;
            
            MessageBox.Show($"Username: {username}\nPassword: {password}", "Login Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
