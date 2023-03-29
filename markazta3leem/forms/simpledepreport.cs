using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace markazta3leem.forms
{
    public partial class simpledepreport : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public simpledepreport()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= markaz.db");
            var get=Application.OpenForms["reports"] as reports;
            label1.Text = get.comboBox2.Text;
            loaddep();
        }

        private void loaddep()
        {
            double allnum = 0;
            double zero=0, one=0, two=0, three=0, four=0, five=0, six=0, seven=0, eight=0;
            con.Open();
            cmd = new SqliteCommand("Select * From tbstud Where dep=$dep", con);
            cmd.Parameters.AddWithValue("$dep",label1.Text);
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    allnum += 1;
                    if (read.GetDouble(6) == 0) { zero += 1; }
                    if (read.GetDouble(6) == 1) { one += 1; }
                    if (read.GetDouble(6) == 2) { two += 1; }
                    if (read.GetDouble(6) == 3) { three += 1; }
                    if (read.GetDouble(6) == 4) { four += 1; }
                    if (read.GetDouble(6) == 5) { five += 1; }
                    if (read.GetDouble(6) == 6) { six += 1; }
                    if (read.GetDouble(6) == 7) { seven += 1; }
                    if (read.GetDouble(6) >=8) { eight += 1; }

                }
            }
            label7.Text = allnum.ToString();
            label10.Text = eight.ToString();
            label12.Text = seven.ToString();
            label14.Text = six.ToString();
            label16.Text = five.ToString();
            label21.Text = four.ToString();
            label20.Text = three.ToString();
            label22.Text = two.ToString();
            label24.Text = one.ToString();
            label26.Text = zero.ToString();
        }

        private void simpledepreport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
            using (var bmp = new Bitmap(panel1.Width, panel1.Height))
            {

                panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                
                bmp.Save(@"asd.bmp");
                MessageBox.Show("تمت العملية بنجاح");
                string stda = "asd.bmp";
                Process.Start(stda);

            }
        }
    }
}
