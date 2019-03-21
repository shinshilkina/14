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
using System.Data.SqlClient;

namespace DataGridViewWithDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbDataAdapter adapter;

        DataSet dataset;
        
        string kod;
        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new OleDbDataAdapter("Select * from Владельцы", new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + @"БД.mdb"));

            dataset = new DataSet();

            adapter.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];
            NameBox.ReadOnly = true;
            SernameBox.ReadOnly = true;
            SecondnameBox.ReadOnly = true;
            TelephoneBox.ReadOnly = true;
            Insert2Button.Enabled = false;
            Change2Button.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            Change2Button.Enabled = true;
            NameBox.ReadOnly = false;
            SernameBox.ReadOnly = false;
            SecondnameBox.ReadOnly = false;
            TelephoneBox.ReadOnly = false;
            int index = dataGridView1.SelectedCells[0].RowIndex;
            SernameBox.Text = dataGridView1[1, index].Value.ToString();
            NameBox.Text = dataGridView1[2, index].Value.ToString();
            SecondnameBox.Text = dataGridView1[3, index].Value.ToString();
            TelephoneBox.Text = dataGridView1[4, index].Value.ToString();
            kod = dataGridView1[0, index].Value.ToString();
            InsertButton.Enabled = false;
            DeleteButton.Enabled = false;
            ChangeButton.Enabled = false;

        }

        private void Change2Button_Click(object sender, EventArgs e)
        {
            NameBox.ReadOnly = false;
            SernameBox.ReadOnly = false;
            SecondnameBox.ReadOnly = false;
            TelephoneBox.ReadOnly = false;
            string conn_param = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = БД.mdb";

            OleDbConnection connection = new OleDbConnection(conn_param);

            OleDbCommand command1 = connection.CreateCommand();
            OleDbCommand command2 = connection.CreateCommand();
            OleDbCommand command3 = connection.CreateCommand();
            OleDbCommand command4 = connection.CreateCommand();
            
            command1.CommandText = "UPDATE Владельцы SET Фамилия = '" + SernameBox.Text +"' WHERE Код = "+kod;
            command2.CommandText =  "UPDATE Владельцы SET Имя =  '" + NameBox.Text + "' WHERE Код = "+kod;
            command3.CommandText =  "UPDATE Владельцы SET Отчество = '" + SecondnameBox.Text + "' WHERE Код = "+kod;
            command4.CommandText =  "UPDATE Владельцы SET Телефон =  '" + TelephoneBox.Text + "' WHERE Код = "+kod;
               
            connection.Open();

            command1.ExecuteNonQuery();
            command2.ExecuteNonQuery();
            command3.ExecuteNonQuery();
            command4.ExecuteNonQuery();

            connection.Close();
            Form1_Load(sender, e);
            NameBox.Text = "";
            SernameBox.Text = "";
            SecondnameBox.Text = "";
            TelephoneBox.Text = "";
            NameBox.ReadOnly = true;
            SernameBox.ReadOnly = true;
            SecondnameBox.ReadOnly = true;
            TelephoneBox.ReadOnly = true;
            Insert2Button.Enabled = false;
            Change2Button.Enabled = false;
            InsertButton.Enabled = true;
            DeleteButton.Enabled = true;
            ChangeButton.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить данную запись?", "Удалить",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                kod = dataGridView1[0, index].Value.ToString();
                string conn_param = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = БД.mdb";

                OleDbConnection connection = new OleDbConnection(conn_param);

                OleDbCommand command = connection.CreateCommand();

                command.CommandText = "DELETE FROM Владельцы WHERE Код = " + kod;

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
                dataGridView1.Rows.RemoveAt(index);

            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            NameBox.ReadOnly = false;
            SernameBox.ReadOnly = false;
            SecondnameBox.ReadOnly = false;
            TelephoneBox.ReadOnly = false;
            Insert2Button.Enabled = true;
            InsertButton.Enabled = false;
            DeleteButton.Enabled = false;
            ChangeButton.Enabled = false;
        }

        private void Insert2Button_Click(object sender, EventArgs e)
        {
            

            string conn_param = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = БД.mdb";

            OleDbConnection connection = new OleDbConnection(conn_param);

            OleDbCommand command = connection.CreateCommand();

             OleDbConnection connection1 = new OleDbConnection(conn_param);
             OleDbCommand command1 = connection.CreateCommand();
             command1.CommandText = "Select max(Код) from Владельцы";
             connection.Open();
             OleDbDataReader reader = command1.ExecuteReader();
             reader.Read();
             int id = Convert.ToInt32(reader[0]);
             id++;
             reader.Close();
             connection.Close(); 
           kod = Convert.ToString(id);

            command.CommandText = "INSERT INTO Владельцы(Код,Фамилия,Имя,Отчество,Телефон) VALUES ('"+kod+"','" + SernameBox.Text + "', '" + NameBox.Text + "','" + SecondnameBox.Text + "', '" + TelephoneBox.Text + "')";

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
            
            adapter = new OleDbDataAdapter("Select * from Владельцы", new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + @"БД.mdb"));

            dataset = new DataSet();

            adapter.Fill(dataset);

            dataGridView1.DataSource = dataset.Tables[0];
            NameBox.Text = "";
            SernameBox.Text = "";
            SecondnameBox.Text = "";
            TelephoneBox.Text = "";
            NameBox.ReadOnly = true;
            SernameBox.ReadOnly = true;
            SecondnameBox.ReadOnly = true;
            TelephoneBox.ReadOnly = true;
            Insert2Button.Enabled = false;
            Change2Button.Enabled = false;
            InsertButton.Enabled = true;
            DeleteButton.Enabled = true;
            ChangeButton.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            
            
        }
        private void TelephoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            char number = e.KeyChar;
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        
        }

        private void TelephoneBox_TextChanged(object sender, EventArgs ee)
        {
            
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            adapter = new OleDbDataAdapter("Select * from Владельцы", new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + @"БД.mdb"));

            dataset = new DataSet();

            adapter.Fill(dataset);

            InsertButton.Enabled = true;
            DeleteButton.Enabled = true;
            ChangeButton.Enabled = true; 
            dataGridView1.DataSource = dataset.Tables[0];
            NameBox.ReadOnly = true;
            SernameBox.ReadOnly = true;
            SecondnameBox.ReadOnly = true;
            TelephoneBox.ReadOnly = true;
            Insert2Button.Enabled = false;
            Change2Button.Enabled = false;

        }
    }
}
