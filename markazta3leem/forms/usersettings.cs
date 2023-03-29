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
    public partial class usersettings : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public usersettings()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= markaz.db");
            loaddata();
        }

        public void loaddata()
        {
            dataGridView1.Rows.Clear();
            con.Open();
            cmd = new SqliteCommand("Select * From tbusers", con);
            dataGridView1.RowTemplate.Height = 30;
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                    read.GetValue(0),
                    read.GetValue(1),
                    read.GetValue(2),
                    read.GetValue(3),
                    read.GetValue(4),

                    });
                }
            }
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(175, 220, 220);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

        }
        public int ida;
        private void usersettings_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (dataGridView1.Rows.Count == 1) { MessageBox.Show("لا يمكن حذف هذا المستخدم لأنه المستخدم الوحيد على هذا النظام حاليا حذفه قد يؤدى إلى فقد وصولك بالنظام"); }
                else
                {
                    if (MessageBox.Show("هل أنت متأكد من حذف هذا المستخدم؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        ida = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        dataGridView1.Rows.Clear();
                        qu = "DELETE FROM tbusers WHERE id=$id";
                        cmd = new SqliteCommand(qu, con);
                        cmd.Parameters.AddWithValue("$id", ida);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        loaddata();
                    }
                }

            }
            if (e.ColumnIndex == 5)
            {
                ida = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                edituser frm = new edituser();
                frm.ShowDialog();

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (exsit(textBox2.Text) == true)
            {
                MessageBox.Show("المستخدم موجود بالفعل حاول تغيير اليوزرنيم");
            }
            else
            {
                try
                {


                    qu = "INSERT INTO tbusers (fullname,user,pass,prem) VALUES ($nam,$uname,$pas,$prm)";
                    cmd = new SqliteCommand(qu, con);
                    cmd.Parameters.AddWithValue("$nam", textBox1.Text);
                    cmd.Parameters.AddWithValue("$uname", textBox2.Text);
                    cmd.Parameters.AddWithValue("$pas", textBox3.Text);
                    cmd.Parameters.AddWithValue("$prm", comboBox1.SelectedItem);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    loaddata();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    comboBox1.SelectedIndex = -1;




                }
                catch (Exception ex)
                {
                    if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.SelectedIndex == -1)
                    { MessageBox.Show("من فضلك أدخل القيم الناقصة كاملة"); }
                    else { MessageBox.Show(ex.Message); }
                    loaddata();

                }

            }
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
    }
}
