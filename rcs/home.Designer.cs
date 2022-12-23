namespace rcs
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOrigin = new System.Windows.Forms.ComboBox();
            this.From = new System.Windows.Forms.Label();
            this.comboBoxDesti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxweight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calculatebtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxparcel = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.updatebtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.clearbtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxroute = new System.Windows.Forms.TextBox();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(452, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Booking";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxOrigin
            // 
            this.comboBoxOrigin.FormattingEnabled = true;
            this.comboBoxOrigin.Items.AddRange(new object[] {
            "APE",
            "BWP",
            "MLT",
            "LHR",
            "DGK"});
            this.comboBoxOrigin.Location = new System.Drawing.Point(205, 133);
            this.comboBoxOrigin.Name = "comboBoxOrigin";
            this.comboBoxOrigin.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOrigin.TabIndex = 1;
            this.comboBoxOrigin.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(205, 104);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(38, 15);
            this.From.TabIndex = 4;
            this.From.Text = "From:";
            // 
            // comboBoxDesti
            // 
            this.comboBoxDesti.FormattingEnabled = true;
            this.comboBoxDesti.Items.AddRange(new object[] {
            "APE",
            "BWP",
            "MLT",
            "LHR",
            "DGK"});
            this.comboBoxDesti.Location = new System.Drawing.Point(360, 133);
            this.comboBoxDesti.Name = "comboBoxDesti";
            this.comboBoxDesti.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDesti.TabIndex = 2;
            this.comboBoxDesti.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // textBoxweight
            // 
            this.textBoxweight.Location = new System.Drawing.Point(519, 133);
            this.textBoxweight.Name = "textBoxweight";
            this.textBoxweight.Size = new System.Drawing.Size(121, 23);
            this.textBoxweight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weight:";
            // 
            // calculatebtn
            // 
            this.calculatebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculatebtn.Location = new System.Drawing.Point(676, 128);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(75, 30);
            this.calculatebtn.TabIndex = 4;
            this.calculatebtn.Text = "Proceed";
            this.calculatebtn.UseVisualStyleBackColor = true;
            this.calculatebtn.Click += new System.EventHandler(this.calculatebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name:";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(52, 205);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(111, 23);
            this.textBoxname.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "ID:";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(213, 205);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(115, 23);
            this.textBoxid.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(366, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Paracel:";
            // 
            // textBoxparcel
            // 
            this.textBoxparcel.Location = new System.Drawing.Point(366, 205);
            this.textBoxparcel.Name = "textBoxparcel";
            this.textBoxparcel.Size = new System.Drawing.Size(115, 23);
            this.textBoxparcel.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(515, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 23);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(515, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(676, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Price:";
            // 
            // updatebtn
            // 
            this.updatebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updatebtn.Location = new System.Drawing.Point(310, 256);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 32);
            this.updatebtn.TabIndex = 11;
            this.updatebtn.Text = "Add";
            this.updatebtn.UseVisualStyleBackColor = true;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(416, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletebtn.Location = new System.Drawing.Point(515, 256);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 32);
            this.deletebtn.TabIndex = 13;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // clearbtn
            // 
            this.clearbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearbtn.Location = new System.Drawing.Point(618, 256);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(75, 32);
            this.clearbtn.TabIndex = 14;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(403, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 45);
            this.label10.TabIndex = 12;
            this.label10.Text = "Transaction ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(205, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(617, 213);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(825, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "ORG-DEST:";
            // 
            // textBoxroute
            // 
            this.textBoxroute.Location = new System.Drawing.Point(825, 205);
            this.textBoxroute.Name = "textBoxroute";
            this.textBoxroute.Size = new System.Drawing.Size(115, 23);
            this.textBoxroute.TabIndex = 10;
            // 
            // textBoxprice
            // 
            this.textBoxprice.Location = new System.Drawing.Point(676, 205);
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.Size = new System.Drawing.Size(115, 23);
            this.textBoxprice.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1018, 555);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxparcel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxroute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxprice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculatebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxweight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.From);
            this.Controls.Add(this.comboBoxDesti);
            this.Controls.Add(this.comboBoxOrigin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox comboBoxOrigin;
        private Label From;
        private ComboBox comboBoxDesti;
        private Label label2;
        private TextBox textBoxweight;
        private Label label3;
        private Button calculatebtn;
        private Label label4;
        private TextBox textBoxname;
        private Label label6;
        private TextBox textBoxid;
        private Label label7;
        private TextBox textBoxparcel;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label9;
        private Button updatebtn;
        private Button button3;
        private Button deletebtn;
        private Button clearbtn;
        private Label label10;
        private DataGridView dataGridView1;
        private Label label5;
        private TextBox textBoxroute;
        private TextBox textBoxprice;
        private PictureBox pictureBox2;
    }
}