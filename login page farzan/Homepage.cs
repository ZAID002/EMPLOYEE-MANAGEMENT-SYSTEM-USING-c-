using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace login_page_farzan
{
    public partial class Homepage : Form
    {
        public string Email { get; set; }
        public Homepage()
        {
            InitializeComponent();
           
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;uid=root;pwd=zaid4265@@;database=employeemanagementsystem";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string Query = "SELECT * FROM employees";
                MySqlCommand command = new MySqlCommand(Query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;uid=root;pwd=zaid4265@@;database=employeemanagementsystem";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string ID = textboxid.Text;
                string firstname = textboxfirstname.Text;
                string lastname = textboxlastname.Text;
                string department = textboxdep.Text;
                string position = textboxposition.Text;
                string salary = textboxsalary.Text;

                string Query = "UDATE employees SET FIRST_NAME ='" + firstname + "',LAST_NAME='" + lastname + "',DEPARTMENT='" + department + "',POSITION='" + position + "',SALARY='" + salary + "' WHERE EMPLOYEE_ID='" + ID + "' ";
                MySqlCommand command = new MySqlCommand(Query, connection);
                command.ExecuteNonQuery();


            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;uid=root;pwd=zaid4265@@;database=employeemanagementsystem";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string ID = textboxid1.Text;
                string firstname = textboxfirstname1.Text;
                string lastname = textboxlastname1.Text;
                string department = textboxdep1.Text;
                string position = textboxposition1.Text;
                string salary = textBox7.Text;

                string Query = "UPDATE employees SET FIRST_NAME ='" + firstname + "',LAST_NAME='" + lastname + "',DEPARTMENT='" + department + "',POSITION='" + position + "',SALARY='" + salary + "' WHERE EMPLOYEE_ID='" + ID + "' ";
                MySqlCommand command = new MySqlCommand(Query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("DATA UPDATED");
                textboxid1.Text = "";
                textboxfirstname1.Text = "";
                textboxlastname1.Text = "";
                textboxdep1.Text = "";
                textboxposition1.Text = "";
                textBox7.Text = "";
                button5_Click(null, null);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = "server=127.0.0.1;uid=root;pwd=zaid4265@@;database=employeemanagementsystem";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string Query = "SELECT * FROM employees";
                MySqlCommand command = new MySqlCommand(Query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView2.DataSource = table;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server=127.0.0.1;uid=root;pwd=zaid4265@@;database=employeemanagementsystem";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string ID = textboxid1.Text;


                    string Query = "select * from employees where EMPLOYEE_ID =" + ID;
                    MySqlCommand command = new MySqlCommand(Query, connection);
                    var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        textboxfirstname1.Text = reader["FIRST_NAME"].ToString();
                        textboxlastname1.Text = reader["LAST_NAME"].ToString();
                        textboxdep1.Text = reader["DEPARTMENT"].ToString();
                        textboxposition1.Text = reader["POSITION"].ToString();
                        textBox7.Text = reader["SALARY"].ToString();
                    }
                    else
                        MessageBox.Show("NO RECORD FOUND");
                }
            }
            catch (Exception)
            {
                string Msg = "Please Enter ID.";
                MessageBox.Show("Error: " + Msg);
            }
        }

            private void button8_Click(object sender, EventArgs e)
        {
                string connectionString = "server=127.0.0.1;uid=root;pwd=zaid4265@@;database=employeemanagementsystem";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string ID = textboxid1.Text;


                string Query = "delete from employees where EMPLOYEE_ID =" +ID;
                MySqlCommand command = new MySqlCommand(Query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("DATA HAS BEEN DELETED SUCCESSFULLY ");
                textboxid1.Text = "";
                 textboxfirstname1.Text = "";
                textboxlastname1.Text = "";
                textboxdep1.Text = "";
                textboxposition1.Text = "";
                textBox7.Text = "";
                button5_Click(null, null);
            }
        }

        private void Homepage_Load_1(object sender, EventArgs e)
        {
            label13.Text = Login.username;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxid1.Text) || string.IsNullOrEmpty(textboxfirstname1.Text) || string.IsNullOrEmpty(textboxlastname1.Text) || string.IsNullOrEmpty(textboxdep1.Text) || string.IsNullOrEmpty(textboxposition1.Text) || string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            string cmdString = "";

            try
            {
                // Create a new MySQLConnection object with the connection string
                conn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=zaid4265@@;database=employeemanagementsystem");
                conn.Open();

                // Prepare the SQL insert statement
                cmdString = "insert into employees values(@EMPLOYEEID, @FIRST_NAME, @LAST_NAME, @DEPARTMENT, @POSITION, @SALARY)";
                cmd = new MySqlCommand(cmdString, conn);

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@EMPLOYEEID", textboxid1.Text);
                cmd.Parameters.AddWithValue("@FIRST_NAME", textboxfirstname1.Text);
                cmd.Parameters.AddWithValue("@LAST_NAME", textboxlastname1.Text);
                cmd.Parameters.AddWithValue("@DEPARTMENT", textboxdep1.Text);
                cmd.Parameters.AddWithValue("@POSITION", textboxposition1.Text);
                cmd.Parameters.AddWithValue("@SALARY", textBox7.Text);
                // Execute the SQL insert statement
                cmd.ExecuteNonQuery();

                // Display a message indicating that the data was stored successfully
                MessageBox.Show("Data Stored Successfully");
                textboxid1.Text = "";
                textboxfirstname1.Text = "";
                textboxlastname1.Text = "";
                textboxdep1.Text = "";
                textboxposition1.Text = "";
                textBox7.Text = "";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void labelemail_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click_2(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxid1.Text) || string.IsNullOrEmpty(textboxfirstname1.Text) || string.IsNullOrEmpty(textboxlastname1.Text) || string.IsNullOrEmpty(textboxdep1.Text) || string.IsNullOrEmpty(textboxposition1.Text) || string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            string cmdString = "";

            try
            {
                // Create a new MySQLConnection object with the connection string
                conn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=zaid4265@@;database=employeemanagementsystem");
                conn.Open();

                // Prepare the SQL insert statement
                cmdString = "insert into employees values(@EMPLOYEEID, @FIRST_NAME, @LAST_NAME, @DEPARTMENT, @POSITION, @SALARY)";
                cmd = new MySqlCommand(cmdString, conn);

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@EMPLOYEEID", textboxid1.Text);
                cmd.Parameters.AddWithValue("@FIRST_NAME", textboxfirstname1.Text);
                cmd.Parameters.AddWithValue("@LAST_NAME", textboxlastname1.Text);
                cmd.Parameters.AddWithValue("@DEPARTMENT", textboxdep1.Text);
                cmd.Parameters.AddWithValue("@POSITION", textboxposition1.Text);
                cmd.Parameters.AddWithValue("@SALARY", textBox7.Text);
                // Execute the SQL insert statement
                cmd.ExecuteNonQuery();

                // Display a message indicating that the data was stored successfully
                MessageBox.Show("Data Stored Successfully");
                textboxid1.Text = "";
                textboxfirstname1.Text = "";
                textboxlastname1.Text = "";
                textboxdep1.Text = "";
                textboxposition1.Text = "";
                textBox7.Text = "";
                button5_Click(null, null);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        private void label13_Click_3(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}