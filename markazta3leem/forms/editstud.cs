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
    public partial class editstud : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        double sum=0;
        public editstud()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= markaz.db");
            sum = 0;
            var frm = Application.OpenForms["studs"] as studs;
            label7.Text = frm.label2.Text;
            loaddata();
            loadlearn();
            updatestate();
        }

        public void updatestate()
        {
            label12.Text = sum.ToString();
            label11.Text = (8 - Convert.ToDouble(label12.Text)).ToString();
            if (Convert.ToDouble(label12.Text) >= 8) { label13.Text = "نعم"; label13.ForeColor = Color.Green; }
            else { label13.Text = "لا"; label13.ForeColor = Color.Red; }
            if (Convert.ToDouble(label11.Text) < 0) { label11.Text = "0"; }
        }

        public void loadlearn()
        {
            sum = 0;
            dataGridView1.Rows.Clear();
            con.Open();
            cmd = new SqliteCommand("Select * From learntb Where name=$nam", con);
            cmd.Parameters.AddWithValue("$nam", textBox1.Text);
            dataGridView1.RowTemplate.Height = 30;
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                    read.GetValue(0),
                    read.GetValue(5),
                    read.GetValue(6),
                    read.GetValue(7),



                    });
                    sum += read.GetDouble(7);
                }
            }
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(175, 220, 220);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        }

        private void loaddata()
        {
            con.Open();
            qu = "SELECT * FROM tbstud WHERE id=$id";
            cmd = new SqliteCommand(qu, con);
            cmd.Parameters.AddWithValue("$id", label7.Text);
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    textBox2.Text = read.GetString(0);
                    textBox1.Text = read.GetString(1);
                    comboBox3.Text = read.GetString(2);
                    comboBox2.Text = read.GetString(3);
                    comboBox1.Text = read.GetString(4);
                }

            }
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //(natid,name,gender,dep,level)
            qu = "UPDATE tbstud SET natid=$nat,name=$nam,gender=$gen,dep=$dep,level=$lev WHERE id=$id";
            cmd = new SqliteCommand(qu, con);
            cmd.Parameters.AddWithValue("$id", label7.Text);
            cmd.Parameters.AddWithValue("$nat", textBox2.Text);
            cmd.Parameters.AddWithValue("$nam", textBox1.Text);
            cmd.Parameters.AddWithValue("$gen", comboBox3.Text);
            cmd.Parameters.AddWithValue("$dep", comboBox2.Text);
            cmd.Parameters.AddWithValue("$lev", comboBox1.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            PopupNotifier pop = new PopupNotifier();
            pop.TitleText = "إعلام";
            pop.ContentText = "تمت تعديل بيانات الطالب بنجاح";
            pop.Popup();
            updatenumss();
            var appo = Application.OpenForms["studs"] as studs;
            appo.loaddata();

            Close();
            
        }

        public void updatenumss()
        {
            qu = "UPDATE tbstud SET number=$num WHERE id=$id";
            cmd = new SqliteCommand(qu, con);
            cmd.Parameters.AddWithValue("$id", label7.Text);
            cmd.Parameters.AddWithValue("$num", label12.Text);
           
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            
        }

        private void editstud_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adddoor ado = new adddoor();
            ado.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("هل أنت متأكد من حذف هذا التسجيل؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    dataGridView1.Rows.Clear();
                    qu = "DELETE FROM learntb WHERE id=$ida";
                    cmd = new SqliteCommand(qu, con);
                    cmd.Parameters.AddWithValue("$ida", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    loadlearn();
                    updatestate();
                }
            }
        }
    }
}