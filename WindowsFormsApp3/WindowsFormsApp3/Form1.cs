using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace WinFormsApp1
{
    public partial class ITFoxSystem : Form
    {
        public string loginUser;
        public ITFoxSystem()
        {
            InitializeComponent();
        }

        // This method is called when the button is clicked
        public void button1_Click(object sender, EventArgs e)
        {
            // Check if the login and password fields are empty
            if (loginField.Text == "")
            {
                MessageBox.Show("No user");
                return;
            }
            if (passField.Text == "")
            {
                MessageBox.Show("No user");
                return;
            }

            // Get the login and password values from the input fields
            string loginUser = loginField.Text;

            // Create a new instance of the ITFoxSystem form
            ITFoxSystem form1 = new ITFoxSystem();

            string passUser = passField.Text;

            // Create a new instance of the DB class
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            // Create a new MySqlCommand object with a parameterized SQL query
            MySqlCommand command = new MySqlCommand("SELECT * FROM `login` WHERE `user` = @uL AND `password` = @pU", db.getConnection());

            // Set the parameter values for the MySqlCommand object
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@pU", MySqlDbType.VarChar).Value = passUser;

            // Set the SelectCommand property of the MySqlDataAdapter object to the MySqlCommand object
            adapter.SelectCommand = command;

            // Fill the DataTable object with data from the database
            adapter.Fill(table);

            // Check if there is at least one row in the DataTable object
            if (table.Rows.Count > 0)
            {
                // If there is at least one row, show a welcome message and open the Form3 window
                MessageBox.Show($"Welcome {loginUser}");
                this.Hide();
                Form3 form3 = new Form3();//loginUser);
                form3.Show();
            }
            else
            {
                // If there are no rows, show an error message
                MessageBox.Show("No user");
            }
        }

        // This method is called when button2 is clicked
        private void button2_Click(object sender, EventArgs e)
        {
            // Create a new instance of Form2 and show it
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}