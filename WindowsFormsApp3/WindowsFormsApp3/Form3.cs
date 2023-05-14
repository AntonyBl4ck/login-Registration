using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp3
{
    public partial class Form3 : Form
    {
        int selectedRow; // declaring a variable

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && dataGridView1.SelectedCells.Count > 0)
            {
                dataGridView1.ClearSelection();
            }
        }


        private void CreateColumns() // a method to create columns in a datagridview
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("user", "user");
            dataGridView1.Columns.Add("password", "password");
            dataGridView1.Columns.Add("email", "email");
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[3].Width = 307;
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record) // a method to read a single row in a datagridview
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3)); // adding a row with two columns (an int and a string)

        }

        private void RefreshDataGrid(DataGridView dgw) // a method to refresh a datagridview
        {
            DB db = new DB(); // creating a DB object

            dgw.Rows.Clear(); // clearing all rows in the datagridview

            string queryString = $"SELECT * from login"; // SQL query string

            MySqlCommand command = new MySqlCommand(queryString, db.getConnection()); // creating a MySqlCommand object with the SQL query and the connection to the database

            db.openConnection(); // opening a connection to the database
            MySqlDataReader reader = command.ExecuteReader(); // executing the SQL query and creating a MySqlDataReader object

            while (reader.Read()) // reading the data from the database one row at a time
            {
                ReadSingleRow(dgw, reader); // calling the ReadSingleRow method to add a row to the datagridview
            }
            reader.Close(); // closing the MySqlDataReader object


        }







        public string loginUser; // declaring a public string variable

        public Form3()//string user) // constructor with a string parameter
        {

            InitializeComponent(); // initializing the components

            this.loginUser = user; // assigning the parameter value to the loginUser variable

            string mytext = loginUser; // creating a new string variable and assigning the value of loginUser
            name.Text = mytext; // setting the text property of the name label to the value of mytext


        }

        private void Form3_Load(object sender, EventArgs e) // event handler for when the Form3 is loaded
        {
            CreateColumns(); // calling the CreateColumns method
            RefreshDataGrid(dataGridView1); // calling the RefreshDataGrid method
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // event handler for when the text in textBox1 is changed
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) // another event handler for when the text in textBox1 is changed
        {
            
        }

        private void button1_Click(object sender, EventArgs e) // event handler for when button1 is clicked
        {
            DialogResult result = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo); // creating a dialog box with a Yes or No option
            if (result == DialogResult.Yes) // if the Yes button is clicked
            {
                Application.Exit(); // exit the application
            }
        }

        private void button4_Click(object sender, EventArgs e) // event handler for when button4 is clicked
        {
            
        }

    }
}
