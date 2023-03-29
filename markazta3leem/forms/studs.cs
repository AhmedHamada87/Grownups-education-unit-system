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

namespace markazta3leem.forms
{
    public partial class studs : Form
    {
        SqliteConnection con;
        SqliteCommand cmd;
        SqliteDataReader dr;
        string qu;
        public studs()
        {
            InitializeComponent();
            con = new SqliteConnection("Data Source= markaz.db");
            loaddata();

        }
        public void loaddata()
        {
            dataGridView1.Rows.Clear();
            con.Open();
            cmd = new SqliteCommand("Select * From tbstud", con);
            dataGridView1.RowTemplate.Height = 30;
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                    read.GetValue(5),
                    read.GetValue(1),
                    read.GetValue(3),
                    read.GetValue(4),
                    read.GetValue(0),
                    read.GetValue(6),

                    });
                }
            }
            doneorfun();
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(175, 220, 220);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

        }

        private void doneorfun()
        {
            for (int i=0;i<dataGridView1.Rows.Count;i++) {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) >= 8) { dataGridView1.Rows[i].Cells[6].Value = 1; }
                else { dataGridView1.Rows[i].Cells[6].Value = 0; }
            } 
        }

        private void studs_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            try {
                if (textBox1.Text == "") { loaddata(); }
                else {
                    dataGridView1.Rows.Clear();
                    con.Open();
                    cmd = new SqliteCommand("Select * From tbstud Where natid Like $se", con);
                    dataGridView1.RowTemplate.Height = 30;
                    cmd.Parameters.AddWithValue("$se", textBox1.Text);
                    using (SqliteDataReader read = cmd.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            dataGridView1.Rows.Add(new object[] {
                    read.GetValue(5),
                    read.GetValue(1),
                    read.GetValue(3),
                    read.GetValue(4),
                    read.GetValue(0),
                    read.GetValue(6),


                    });
                        }
                    }
                    dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(175, 220, 220);
                    dataGridView1.EnableHeadersVisualStyles = false;
                    dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
                    dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id;
            if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("هل أنت متأكد من حذف هذا الطالب؟", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    dataGridView1.Rows.Clear();
                    qu = "DELETE FROM tbstud WHERE id=$ida";
                    cmd = new SqliteCommand(qu, con);
                    cmd.Parameters.AddWithValue("$ida", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    loaddata();
                }


            }
            if (e.ColumnIndex == 7)
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                label2.Text = id.ToString();
                editstud edsi = new editstud();
                edsi.ShowDialog();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addstud ads = new addstud();
            ads.ShowDialog();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text=="الكل") { loaddata(); }
            else { loaddataex(); }
        }

        private void loaddataex()
        {
            dataGridView1.Rows.Clear();
            con.Open();
            cmd = new SqliteCommand("Select * From tbstud Where dep=$dep", con);
            cmd.Parameters.AddWithValue("$dep",comboBox2.Text);
            dataGridView1.RowTemplate.Height = 30;
            using (SqliteDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[] {
                    read.GetValue(5),
                    read.GetValue(1),
                    read.GetValue(3),
                    read.GetValue(4),
                    read.GetValue(0),
                    read.GetValue(6),

                    });
                }
            }
            doneorfun();
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(175, 220, 220);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

        }
    }
}
