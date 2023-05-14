using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public bool IsActive
        {
            get
            {
                return this.IsActive;
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Code executed when the form is loaded
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Code executed when the text in textBox1 is changed
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Code executed when the text in textBox2 is changed
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            // Code executed when the text in textBox3 is changed
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // Close the current form and show the login form
            ITFoxSystem form1 = new ITFoxSystem();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the input fields are not empty
            if (loginSuc.Text == "")
            {
                MessageBox.Show("Invalid name");
                return;
            }
            if (passSuc.Text == "")
            {
                MessageBox.Show("Invalid password");
                return;
            }
            if (emailSuc.Text == "")
            {
                MessageBox.Show("Invalid email");
                return;
            }

            // Check if the user already exists in the database
            if (isUserExists())
                return;

            // Insert the new user into the database
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `login` (`user`, `password`, `email`) VALUES (@login, @password, @email)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginSuc.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passSuc.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailSuc.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                // If the insertion was successful, show a success message and close the form
                MessageBox.Show("Successful");
                this.Close();
            }
            else
            {
                // If there was an error inserting the user, show an error message
                MessageBox.Show("Error");
            }
            db.closeConnection();
        }

        public Boolean isUserExists()
        {
            // Check if the user already exists in the database
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `login` WHERE `user` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginSuc.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                // If the user exists, show a message and return true
                MessageBox.Show("This user is already registered");
                return true;
            }
            else
            {
                // If the user does not exist, return false
                return false;
            }
        }
    }
}
