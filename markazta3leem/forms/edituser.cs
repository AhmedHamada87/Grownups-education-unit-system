using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Tulpep.NotificationWindow;

namespace markazta3leem.forms
{
    public partial class edituser : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public edituser()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= markaz.db");
            var frm = Application.OpenForms["usersettings"] as usersettings;
            label5.Text = frm.ida.ToString();
            loaduser(label5.Text);
            if (frm.dataGridView1.Rows.Count == 1) { comboBox1.Enabled = false; }
        }

        private void edituser_Load(object sender, EventArgs e)
        {

        }
        private void loaduser(string text)
        {
            con.Open();
            qu = "SELECT * FROM tbusers WHERE id=$id";
            cmd = new SqliteCommand(qu, con);
            cmd.Parameters.AddWithValue("$id", label5.Text);
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    textBox1.Text = read.GetString(1);
                    textBox2.Text = read.GetString(2);
                    textBox3.Text = read.GetString(3);
                    comboBox1.SelectedItem = read.GetString(4);
                }

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                qu = "UPDATE tbusers SET fullname=$nam,user=$uname,pass=$pas,prem=$prm WHERE id=$id";
                cmd = new SqliteCommand(qu, con);
                cmd.Parameters.AddWithValue("$id", label5.Text);
                cmd.Parameters.AddWithValue("$nam", textBox1.Text);
                cmd.Parameters.AddWithValue("$uname", textBox2.Text);
                cmd.Parameters.AddWithValue("$pas", textBox3.Text);
                cmd.Parameters.AddWithValue("$prm", comboBox1.SelectedItem);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                var frm = Application.OpenForms["usersettings"] as usersettings;
                frm.loaddata();
                this.Close();
            
        }
        private bool exsit(string text)
        {
            con.Open();
            qu = "SELECT * FROM tbusers WHERE user=$na";
            cmd = new SqliteCommand(qu, con);
            cmd.Parameters.AddWithValue("$na", textBox2.Text);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
            }
            if (count > 0) { return true; }
            else { return false; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
