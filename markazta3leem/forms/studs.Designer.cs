
namespace markazta3leem.forms
{
    partial class studs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(studs));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nums = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doneor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.dep,
            this.lev,
            this.natid,
            this.nums,
            this.doneor,
            this.edit,
            this.delete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1286, 460);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "الرقم";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "الاسم";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // dep
            // 
            this.dep.HeaderText = "الشعبة";
            this.dep.Name = "dep";
            this.dep.ReadOnly = true;
            // 
            // lev
            // 
            this.lev.HeaderText = "الفرقة";
            this.lev.Name = "lev";
            this.lev.ReadOnly = true;
            // 
            // natid
            // 
            this.natid.FillWeight = 120F;
            this.natid.HeaderText = "الرقم القومى";
            this.natid.Name = "natid";
            this.natid.ReadOnly = true;
            // 
            // nums
            // 
            this.nums.HeaderText = "عدد المتعلمين";
            this.nums.Name = "nums";
            this.nums.ReadOnly = true;
            // 
            // doneor
            // 
            this.doneor.FalseValue = "0";
            this.doneor.HeaderText = "انهى المشروع";
            this.doneor.Name = "doneor";
            this.doneor.ReadOnly = true;
            this.doneor.TrueValue = "1";
            // 
            // edit
            // 
            this.edit.FillWeight = 70F;
            this.edit.HeaderText = "تعديل";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "تعديل";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            this.delete.FillWeight = 70F;
            this.delete.HeaderText = "مسح";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "مسح";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1143, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "إضافة طالب";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(27, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 43);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(265, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "بحث عن طالب بالرقم القومى";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(593, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "رقم";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cairo", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(1041, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 40);
            this.label3.TabIndex = 40;
            this.label3.Text = "القسم";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "الكل",
            "اللغة العربية",
            "اللغة الانجليزية",
            "اللغة الفرنسية",
            "علم النفس",
            "جغرافيا",
            "تاريخ",
            "العلوم البيولوجية",
            "الفيزياء",
            "الكيمياء",
            "الرياضيات",
            "حاسب الى",
            "اساسي عربي",
            "اساسي انجليزي",
            "اساسي مواد اجتماعية",
            "اساسي علوم",
            "انجليزي خاص",
            "علوم خاص",
            "رياضيات خاص"});
            this.comboBox2.Location = new System.Drawing.Point(854, 30);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(181, 44);
            this.comboBox2.TabIndex = 45;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // studs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 574);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "studs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الطلاب";
            this.Load += new System.EventHandler(this.studs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dep;
        private System.Windows.Forms.DataGridViewTextBoxColumn lev;
        private System.Windows.Forms.DataGridViewTextBoxColumn natid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nums;
        private System.Windows.Forms.DataGridViewCheckBoxColumn doneor;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox2;
    }
}