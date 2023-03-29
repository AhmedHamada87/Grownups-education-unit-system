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
    public partial class mufasonedep : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public mufasonedep()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= markaz.db");
            var get = Application.OpenForms["reports"] as reports;
            label1.Text = get.comboBox2.Text;
            loaddep(label1.Text);
            totalmf();
        }

        private void totalmf()
        {
            double f = 0, m = 0;
            con.Open();
            cmd = new SqliteCommand("Select * From tbstud Where dep=$dep", con);
            cmd.Parameters.AddWithValue("$dep",label1.Text);
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    if (read.GetString(2) == "انثي") { f += 1; }
                    if (read.GetString(2) == "ذكر") { m += 1; }
                }
            }
            label4.Text = f.ToString();
            label2.Text = m.ToString();
        }

        private void loaddep(string dep)
        {
            double allnum = 0;
            double zero = 0, one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, seven = 0, eight = 0;
            double zerof = 0, onef = 0, twof = 0, threef = 0, fourf = 0, fivef = 0, sixf = 0, sevenf = 0, eightf = 0;

            con.Open();
            cmd = new SqliteCommand("Select * From tbstud Where dep=$dep", con);
            cmd.Parameters.AddWithValue("$dep", dep);
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    allnum += 1;
                    if (read.GetDouble(6) == 0 && read.GetString(2) == "ذكر") { zero += 1; }
                    if (read.GetDouble(6) == 0 && read.GetString(2) == "انثي") { zerof += 1; }
                    if (read.GetDouble(6) == 1 && read.GetString(2) == "ذكر") { one += 1; }
                    if (read.GetDouble(6) == 1 && read.GetString(2) == "انثي") { onef += 1; }
                    if (read.GetDouble(6) == 2 && read.GetString(2) == "ذكر") { two += 1; }
                    if (read.GetDouble(6) == 2 && read.GetString(2) == "انثي") { twof += 1; }
                    if (read.GetDouble(6) == 3 && read.GetString(2) == "ذكر") { three += 1; }
                    if (read.GetDouble(6) == 3 && read.GetString(2) == "انثي") { threef += 1; }
                    if (read.GetDouble(6) == 4 && read.GetString(2) == "ذكر") { four += 1; }
                    if (read.GetDouble(6) == 4 && read.GetString(2) == "انثي") { fourf += 1; }
                    if (read.GetDouble(6) == 5 && read.GetString(2) == "ذكر") { five += 1; }
                    if (read.GetDouble(6) == 5 && read.GetString(2) == "انثي") { fivef += 1; }
                    if (read.GetDouble(6) == 6 && read.GetString(2) == "ذكر") { six += 1; }
                    if (read.GetDouble(6) == 6 && read.GetString(2) == "انثي") { sixf += 1; }
                    if (read.GetDouble(6) == 7 && read.GetString(2) == "ذكر") { seven += 1; }
                    if (read.GetDouble(6) == 7 && read.GetString(2) == "انثي") { sevenf += 1; }
                    if (read.GetDouble(6) >= 8 && read.GetString(2) == "ذكر") { eight += 1; }
                    if (read.GetDouble(6) >= 8 && read.GetString(2) == "انثي") { eightf += 1; }

                }
            }

            label7.Text = allnum.ToString();
            label10.Text = eight.ToString();
            label26.Text = eightf.ToString();
            label12.Text = seven.ToString();
            label25.Text = sevenf.ToString();
            label14.Text = six.ToString();
            label24.Text = sixf.ToString();
            label16.Text = five.ToString();
            label23.Text = fivef.ToString();
            label30.Text = four.ToString();
            label32.Text = fourf.ToString();
            label19.Text = three.ToString();
            label20.Text = threef.ToString();
            label18.Text = two.ToString();
            label22.Text = twof.ToString();
            label36.Text = one.ToString();
            label37.Text = onef.ToString();
            label39.Text = zero.ToString();
            label40.Text = zerof.ToString();


        }

        private void mufasonedep_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label41.Text = textBox1.Text;
            using (var bmp = new Bitmap(panel1.Width, panel1.Height))
            {

                panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

                bmp.Save(@"asd.bmp");
                MessageBox.Show("تمت العملية بنجاح");
                string stda = "asd.bmp";
                Process.Start(stda);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}
