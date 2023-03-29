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
    public partial class adddoor : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public adddoor()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= markaz.db");
            var col = Application.OpenForms["editstud"] as editstud;
            textBox1.Text = col.textBox1.Text;
            textBox2.Text = col.textBox2.Text;
            comboBox2.Text = col.comboBox2.Text;
            comboBox3.Text = col.comboBox3.Text;

        }

        private void adddoor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                qu = "INSERT INTO learntb (name,natid,dep,gen,mon,year,qty) VALUES ($name,$natid,$dep,$gen,$mon,$year,$qty)";
                cmd = new SqliteCommand(qu, con);
                cmd.Parameters.AddWithValue("$name", textBox1.Text);
                cmd.Parameters.AddWithValue("$natid", textBox2.Text);
                cmd.Parameters.AddWithValue("$gen", comboBox3.Text);
                cmd.Parameters.AddWithValue("$dep", comboBox2.Text);
                cmd.Parameters.AddWithValue("$mon", comboBox1.Text);
                cmd.Parameters.AddWithValue("$year", numericUpDown1.Value.ToString());
                cmd.Parameters.AddWithValue("$qty", textBox3.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                PopupNotifier pop = new PopupNotifier();
                pop.TitleText = "إعلام";
                pop.ContentText = "تمت إضافة البيانات بنجاح";
                pop.Popup();
               
                var vaim = Application.OpenForms["editstud"] as editstud;
                vaim.loadlearn();
                vaim.updatestate();
                vaim.updatenumss();
                comboBox1.SelectedIndex = -1;
                textBox3.Text = "";

                

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
