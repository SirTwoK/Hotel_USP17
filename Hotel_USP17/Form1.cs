using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace Hotel_USP17
{
    public partial class Form1 : Form
    {

        string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory() + "\\DB_Tema17.mdb";
        OleDbConnection dbConnect = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string type, status;
            type = textBox1.Text;
            status = textBox2.Text;

            dbConnect.ConnectionString = ConnectionString;
            string myInsert = "INSERT INTO ROOMS(ROOM_TYPE, ROOM_STATUS) VALUES(" + type + "," + status + ")";

            OleDbCommand dbCommand = new OleDbCommand(myInsert, dbConnect);
            dbConnect.Open();

            dbCommand.CommandText = myInsert;
            dbCommand.Connection = dbConnect;
            dbCommand.ExecuteNonQuery();

            MessageBox.Show("Успешно добавяне на запис.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dbConnect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id, type, status;
            id = textBox3.Text;
            type = textBox4.Text;
            status = textBox5.Text;

            dbConnect.ConnectionString = ConnectionString;
            string myInsert = "UPDATE ROOMS SET ROOM_TYPE = " + type + ", ROOM_STATUS = " + status + " WHERE ID = "+ id +";";

            OleDbCommand dbCommand = new OleDbCommand(myInsert, dbConnect);
            dbConnect.Open();

            dbCommand.CommandText = myInsert;
            dbCommand.Connection = dbConnect;
            dbCommand.ExecuteNonQuery();

            MessageBox.Show("Успешно актуализиране на запис.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dbConnect.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int kris = 6;
        }
    }
}
