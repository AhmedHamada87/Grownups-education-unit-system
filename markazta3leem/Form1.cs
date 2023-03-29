using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using markazta3leem.forms;
using Microsoft.Data.Sqlite;
using Tulpep.NotificationWindow;

namespace markazta3leem
{
    public partial class Form1 : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(StatrForm));
            t.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            t.Abort();
            con = new SqliteConnection("Data Source= markaz.db");
            

        }
        private void isadmin()
        {
            con.Open();
            qu = "SELECT * FROM tbusers WHERE user=$nama";
            cmd = new SqliteCommand(qu, con);
            cmd.Parameters.AddWithValue("$nama", label1.Text);
            string st = "";
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    st = read.GetString(4);
                }

            }
            con.Close();
            if (st == "admin") { button4.Visible = true; }
            //else {  }
        }

        public void StatrForm()
        {
            Application.Run(new splashscreen());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isadmin();
            studs std = new studs();
            std.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reports rep = new reports();
            rep.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            usersettings usr = new usersettings();
            usr.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.facebook.com/DiGenAU/");
            Process.Start(sInfo);
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            info inf = new info();
            inf.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            isadmin();
        }
    }
}
