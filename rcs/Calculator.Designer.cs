namespace rcs
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboboxorigin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboboxdest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxweight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labeldate = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.labelsurcharge = new System.Windows.Forms.Label();
            this.labelfare = new System.Windows.Forms.Label();
            this.labeldistance = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(368, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboboxorigin
            // 
            this.comboboxorigin.FormattingEnabled = true;
            this.comboboxorigin.Items.AddRange(new object[] {
            "APE",
            "BWP",
            "MLT",
            "LHR",
            "DGK"});
            this.comboboxorigin.Location = new System.Drawing.Point(42, 134);
            this.comboboxorigin.Name = "comboboxorigin";
            this.comboboxorigin.Size = new System.Drawing.Size(121, 23);
            this.comboboxorigin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(42, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "From:";
            // 
            // comboboxdest
            // 
            this.comboboxdest.FormattingEnabled = true;
            this.comboboxdest.Items.AddRange(new object[] {
            "APE",
            "BWP",
            "MLT",
            "LHR",
            "DGK"});
            this.comboboxdest.Location = new System.Drawing.Point(42, 210);
            this.comboboxdest.Name = "comboboxdest";
            this.comboboxdest.Size = new System.Drawing.Size(121, 23);
            this.comboboxdest.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(42, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxweight
            // 
            this.textBoxweight.Location = new System.Drawing.Point(42, 287);
            this.textBoxweight.Name = "textBoxweight";
            this.textBoxweight.Size = new System.Drawing.Size(121, 23);
            this.textBoxweight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(42, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 360);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(42, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labeldate);
            this.groupBox1.Controls.Add(this.labeltotal);
            this.groupBox1.Controls.Add(this.labelsurcharge);
            this.groupBox1.Controls.Add(this.labelfare);
            this.groupBox1.Controls.Add(this.labeldistance);
            this.groupBox1.Location = new System.Drawing.Point(225, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 326);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldate.Location = new System.Drawing.Point(84, 269);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(0, 21);
            this.labeldate.TabIndex = 1;
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltotal.Location = new System.Drawing.Point(43, 186);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(0, 28);
            this.labeltotal.TabIndex = 0;
            // 
            // labelsurcharge
            // 
            this.labelsurcharge.AutoSize = true;
            this.labelsurcharge.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelsurcharge.Location = new System.Drawing.Point(43, 139);
            this.labelsurcharge.Name = "labelsurcharge";
            this.labelsurcharge.Size = new System.Drawing.Size(0, 28);
            this.labelsurcharge.TabIndex = 0;
            // 
            // labelfare
            // 
            this.labelfare.AutoSize = true;
            this.labelfare.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelfare.Location = new System.Drawing.Point(43, 93);
            this.labelfare.Name = "labelfare";
            this.labelfare.Size = new System.Drawing.Size(0, 28);
            this.labelfare.TabIndex = 0;
            // 
            // labeldistance
            // 
            this.labeldistance.AutoSize = true;
            this.labeldistance.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldistance.Location = new System.Drawing.Point(43, 39);
            this.labeldistance.Name = "labeldistance";
            this.labeldistance.Size = new System.Drawing.Size(0, 28);
            this.labeldistance.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxweight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboboxdest);
            this.Controls.Add(this.comboboxorigin);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox comboboxorigin;
        private Label label1;
        private ComboBox comboboxdest;
        private Label label2;
        private TextBox textBoxweight;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button button1;
        private GroupBox groupBox1;
        private Label labeldistance;
        private Label labeltotal;
        private Label labelsurcharge;
        private Label labelfare;
        private Label labeldate;
        private PictureBox pictureBox2;
    }
}