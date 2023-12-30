namespace RMSystem
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

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide();
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtusername.Text;
            string enteredPassword = txtpassword.Text;

            if (CheckCredentials(enteredUsername, enteredPassword))
            {
                Dashboard ds = new Dashboard("ADMIN");
                ds.Show();
                this.Hide();
            }
            else if (string.IsNullOrWhiteSpace(enteredUsername) || string.IsNullOrWhiteSpace(enteredPassword))
            {
                MessageBox.Show("Username or password cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Incorrect credentials. Please enter correct username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckCredentials(string enteredUsername, string enteredPassword)
        {
            string filePath = "credentials.txt";

            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(',');

                        if (parts.Length == 2 && parts[0] == enteredUsername && parts[1] == enteredPassword)
                        {
                            return true;
                        }
                    }
                }

                return false; // Credentials do not match
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading credentials: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Return false in case of an exception
            }
        }


        /*private void SaveCredentials(string username, string password)
        {
            string filePath = "credentials.txt";

            // Append the new credentials to the file
            File.AppendAllText(filePath, $"{username},{password}\n");
        }*/



        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
