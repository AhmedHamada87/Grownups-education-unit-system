using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace markazta3leem.forms
{
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "شعبة واحدة -مفصل" || comboBox1.Text == "شعبة واحدة -بسيط")
            {
                comboBox2.Visible = true; label4.Visible = true; button2.Visible = true;
            }
            else { comboBox2.Visible = false; label4.Visible = false; button2.Visible = false; }
            if (comboBox1.Text == "كل الشعب-مفصل" || comboBox1.Text == "كل الشعب -بسيط")
            {
                button1.Visible = true;
            }
            else { button1.Visible = false; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text== "شعبة واحدة -بسيط" && comboBox2.Text!="") { 
                simpledepreport smp = new simpledepreport(); smp.ShowDialog(); }
            if (comboBox1.Text == "شعبة واحدة -مفصل" && comboBox2.Text != "") { 
                mufasonedep mus = new mufasonedep(); mus.ShowDialog(); }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "كل الشعب -بسيط") { simblealldeb sdp = new simblealldeb(); sdp.ShowDialog(); }
            if (comboBox1.Text == "كل الشعب-مفصل") { mafasalldeb mfsdb = new mafasalldeb(); mfsdb.ShowDialog(); }

        }
    }
}
