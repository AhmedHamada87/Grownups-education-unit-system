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
    public partial class simblealldeb : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public simblealldeb()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= markaz.db");
            loaddeparabic();
            loaddepenglish();
            loaddep("اللغة الفرنسية");
            loaddep("علم النفس");
            loaddep("جغرافيا");
            loaddep("تاريخ");
            loaddep("العلوم البيولوجية");
            loaddep("الفيزياء");
            loaddep("الكيمياء");
            loaddep("الرياضيات");
            loaddep("حاسب الى");
            loaddep("اساسي عربي");
            loaddep("اساسي انجليزي");
            loaddep("اساسي مواد اجتماعية");
            loaddep("اساسي علوم");
            loaddep("انجليزي خاص");
            loaddep("علوم خاص");
            loaddep("رياضيات خاص");
            sumall();


        }

        private void sumall()
        {
            dataGridView1.Rows.Add(new object[] {
                    "المجموع",
                    sumstud(),
                    sumeight(),
                    sumseven(),
                    sumsix(),
                    sumfive(),
                    sumfour(),
                    sumthree(),
                    sumtwo(),
                    sumone(),
                    sumzero(),



                    });
        }

        private object sumzero()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[10].Value);
            }
            return sum;
        }

        private object sumone()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[9].Value);
            }
            return sum;
        }

        private object sumtwo()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);
            }
            return sum;
        }

        private object sumthree()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
            }
            return sum;
        }

        private object sumfour()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
            }
            return sum;
        }

        private object sumfive()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            }
            return sum;
        }

        private object sumsix()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            return sum;
        }

        private object sumseven()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
            return sum;
        }

        private object sumeight()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;
        }

        private double sumstud()
        {
            double sum = 0;
            for (int i=0;i<dataGridView1.Rows.Count;i++) {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
            }
            return sum;
        }

        private void loaddep(string dep)
        {
            double allnum = 0;
            double zero = 0, one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, seven = 0, eight = 0;
            con.Open();
            cmd = new SqliteCommand("Select * From tbstud Where dep=$dep", con);
            cmd.Parameters.AddWithValue("$dep", dep);
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
                    if (read.GetDouble(6) >= 8) { eight += 1; }

                }
            }
            dataGridView1.Rows.Add(new object[] {
                    dep,
                    allnum,
                    eight,
                    seven,
                    six,
                    five,
                    four,
                    three,
                    two,
                    one,
                    zero,

                    });
            
        }

        private void loaddepenglish()
        {
            double allnum = 0;
            double zero = 0, one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, seven = 0, eight = 0;
            con.Open();
            cmd = new SqliteCommand("Select * From tbstud Where dep=$dep", con);
            cmd.Parameters.AddWithValue("$dep", "اللغة الانجليزية");
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
                    if (read.GetDouble(6) >= 8) { eight += 1; }

                }
            }
            dataGridView1.Rows.Add(new object[] {
                    "اللغة الانجليزية",
                    allnum,
                    eight,
                    seven,
                    six,
                    five,
                    four,
                    three,
                    two,
                    one,
                    zero,

                    });
        }

        private void loaddeparabic()
        {
            double allnum = 0;
            double zero = 0, one = 0, two = 0, three = 0, four = 0, five = 0, six = 0, seven = 0, eight = 0;
            con.Open();
            cmd = new SqliteCommand("Select * From tbstud Where dep=$dep", con);
            cmd.Parameters.AddWithValue("$dep", "اللغة العربية");
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
                    if (read.GetDouble(6) >= 8) { eight += 1; }

                }
            }
            dataGridView1.Rows.Add(new object[] {
                    "اللغة العربية",
                    allnum,
                    eight,
                    seven,
                    six,
                    five,
                    four,
                    three,
                    two,
                    one,
                    zero,

                    });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            using (var bmp = new Bitmap(panel1.Width, panel1.Height))
            {

                panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

                bmp.Save(@"asd.bmp");
                MessageBox.Show("تمت العملية بنجاح");
                string stda = "asd.bmp";
                Process.Start(stda);

            }
        }

        private void simblealldeb_Load(object sender, EventArgs e)
        {

        }
    }
}
