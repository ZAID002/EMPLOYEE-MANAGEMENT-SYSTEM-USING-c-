using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;



namespace login_page_farzan
{
    public partial class Login : Form
    {
        public static string username;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                    
            


            string connectionString = "server=127.0.0.1;uid=root;pwd=PASSWORD;database=employeemanagementsystem";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM logintable WHERE email= @email and password= @password", connection);
                command.Parameters.AddWithValue("@email", emailButton.Text);
                command.Parameters.AddWithValue("@password", passwordButton.Text);
                string Email = emailButton.Text;
                
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Login successful! Moving to the next page...");
                    this.Hide();
                    username = emailButton.Text;
                    Homepage home = new Homepage();
                    home.Email = Email;
                    home.Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid email or password!");
                }
            }
        }

        private void passwordButton_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
