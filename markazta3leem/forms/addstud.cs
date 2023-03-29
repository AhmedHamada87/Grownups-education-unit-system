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
    public partial class addstud : Form
    {

        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public addstud()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= markaz.db");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                qu = "INSERT INTO tbstud (natid,name,gender,dep,level) VALUES ($nat,$nam,$gen,$dep,$lev)";
                cmd = new SqliteCommand(qu, con);
                cmd.Parameters.AddWithValue("$nam", textBox1.Text);
                cmd.Parameters.AddWithValue("$nat", textBox2.Text);
                cmd.Parameters.AddWithValue("$gen", comboBox3.Text);
                cmd.Parameters.AddWithValue("$dep", comboBox2.Text);
                cmd.Parameters.AddWithValue("$lev", comboBox1.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                var apa = Application.OpenForms["studs"] as studs;
                apa.loaddata();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                comboBox3.SelectedIndex = -1;
                textBox1.Text = "";
                textBox2.Text = "";
                PopupNotifier pop = new PopupNotifier();
                pop.TitleText = "إعلام";
                pop.ContentText = "تمت إضافة الطالب بنجاح";
                pop.Popup();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void addstud_Load(object sender, EventArgs e)
        {

        }
    }
}
