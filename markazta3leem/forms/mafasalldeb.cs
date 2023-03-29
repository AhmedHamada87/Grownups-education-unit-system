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
    public partial class mafasalldeb : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public mafasalldeb()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= markaz.db");
            loaddep("اللغة العربية");
            loaddep("اللغة الانجليزية");
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
            totalmf();
        }

        private void totalmf()
        {
            double f = 0, m = 0;
            con.Open();
            cmd = new SqliteCommand("Select * From tbstud", con);
            
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    if (read.GetString(2)=="انثي") { f += 1; }
                    if (read.GetString(2) == "ذكر") { m += 1; }
                }
            }
            label2.Text = f.ToString();
            label3.Text = m.ToString();
        }

        private void sumall()
        {
            dataGridView1.Rows.Add(new object[] {
                    "المجموع",
                    sumstud(),
                    sumeight(),
                    sumeightf(),
                    sumseven(),
                    sumsevenf(),
                    sumsix(),
                    sumsixf(),
                    sumfive(),
                    sumfivef(),
                    sumfour(),
                    sumfourf(),
                    sumthree(),
                    sumthreef(),
                    sumtwo(),
                    sumtwof(),
                    sumone(),
                    sumonef(),
                    sumzero(),
                    sumzerof(),



                    });
        }

        private double sumstud()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
            }
            return sum;
        }
        private double sumeight()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;
        }
        private double sumeightf()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
            return sum;
        }
        private double sumseven()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
            }
            return sum;
        }
        private double sumsevenf()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
            }
            return sum;
        }
        private double sumsix()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
            }
            return sum;
        }
        private double sumsixf()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value);
            }
            return sum;
        }
        private double sumfive()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[8].Value);
            }
            return sum;
        }
        private double sumfivef()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[9].Value);
            }
            return sum;
        }
        private double sumfour()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[10].Value);
            }
            return sum;
        }
        private double sumfourf()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[11].Value);
            }
            return sum;
        }
        private double sumthree()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[12].Value);
            }
            return sum;
        }
        private double sumthreef()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[13].Value);
            }
            return sum;
        }
        private double sumtwo()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[14].Value);
            }
            return sum;
        }
        private double sumtwof()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[15].Value);
            }
            return sum;
        }
        private double sumone()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[16].Value);
            }
            return sum;
        }
        private double sumonef()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[17].Value);
            }
            return sum;
        }
        private double sumzero()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[18].Value);
            }
            return sum;
        }
        private double sumzerof()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[19].Value);
            }
            return sum;
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
                    if (read.GetDouble(6) == 0 && read.GetString(2)=="ذكر") { zero += 1; }
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
            dataGridView1.Rows.Add(new object[] {
                    dep,
                    allnum,
                    eight,
                    eightf,
                    seven,
                    sevenf,
                    six,
                    sixf,
                    five,
                    fivef,
                    four,
                    fourf,
                    three,
                    threef,
                    two,
                    twof,
                    one,
                    onef,
                    zero,
                    zerof,

                    });
        }

        private void mafasalldeb_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = textBox1.Text;
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
