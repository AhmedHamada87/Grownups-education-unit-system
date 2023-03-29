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
    public partial class login : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public string usser = "";
        public login()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= markaz.db");
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                qu = "SELECT * FROM tbusers WHERE user=$na AND pass=$pa";
                cmd = new SqliteCommand(qu, con);
                cmd.Parameters.AddWithValue("$na", textBox1.Text);
                cmd.Parameters.AddWithValue("$pa", textBox2.Text);
                cmd.ExecuteNonQuery();
                dr = cmd.ExecuteReader();
                int count = 0;
                string j = "";
                while (dr.Read())
                {
                    count++;
                    j = dr.GetString(1);

                }
                if (count == 1)
                {
                    PopupNotifier pop = new PopupNotifier();
                    pop.TitleText = "تمت تسجيل الدخول بنجاح";
                    pop.ContentText =  textBox1.Text+ "مرحبا بك";
                    pop.Popup();
                    /*var frm = Application.OpenForms["Form1"] as Form1;
                    frm.button2.Visible = true;
                    frm.button3.Visible = true;
                    frm.label1.Visible = false;
                    frm.button1.Visible = false;
                    frm.panel2.Visible = true;
                    frm.panel3.Visible = true;*/


                    /*if (isadmin() == true)
                    {
                        frm.button4.Visible = true;
                        frm.panel4.Visible = true;
                    }
                    */
                    usser = textBox1.Text;
                    Form1 frm = new Form1();
                    frm.Show();
                    var bkm = Application.OpenForms["Form1"] as Form1;
                    bkm.label1.Text = usser;
                    Hide();
                }
                if (count < 1) { MessageBox.Show("خطأ في اسم المستخدم أو كلمة المرور"); }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private bool isadmin()
        {
            con.Open();
            qu = "SELECT * FROM tbusers WHERE user=$nama";
            cmd = new SqliteCommand(qu, con);
            cmd.Parameters.AddWithValue("$nama", textBox1.Text);
            string st = "";
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    st = read.GetString(4);
                }

            }
            con.Close();
            if (st == "admin") { return true; }
            else { return false; }
        }
    }
}
