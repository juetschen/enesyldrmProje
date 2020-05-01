namespace WindowsFormsApp1
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kayitsil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.t10 = new System.Windows.Forms.TextBox();
            this.c2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.d2 = new System.Windows.Forms.DateTimePicker();
            this.d1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.t9 = new System.Windows.Forms.TextBox();
            this.t8 = new System.Windows.Forms.TextBox();
            this.t7 = new System.Windows.Forms.TextBox();
            this.t6 = new System.Windows.Forms.TextBox();
            this.c1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.t5 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(639, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(623, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // kayitsil
            // 
            this.kayitsil.Location = new System.Drawing.Point(869, 309);
            this.kayitsil.Name = "kayitsil";
            this.kayitsil.Size = new System.Drawing.Size(88, 40);
            this.kayitsil.TabIndex = 1;
            this.kayitsil.Text = "Sil";
            this.kayitsil.UseVisualStyleBackColor = true;
            this.kayitsil.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(931, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Veri Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(963, 318);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(118, 22);
            this.sil.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // t10
            // 
            this.t10.Location = new System.Drawing.Point(443, 280);
            this.t10.Name = "t10";
            this.t10.Size = new System.Drawing.Size(100, 22);
            this.t10.TabIndex = 70;
            // 
            // c2
            // 
            this.c2.FormattingEnabled = true;
            this.c2.Items.AddRange(new object[] {
            "Nakit",
            "Kredi Kartı"});
            this.c2.Location = new System.Drawing.Point(443, 232);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(121, 24);
            this.c2.TabIndex = 69;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(321, 286);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 68;
            this.label14.Text = "Tutar : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(321, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 17);
            this.label13.TabIndex = 67;
            this.label13.Text = "Ödeme Türü :";
            // 
            // d2
            // 
            this.d2.Location = new System.Drawing.Point(134, 290);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(146, 22);
            this.d2.TabIndex = 56;
            // 
            // d1
            // 
            this.d1.Location = new System.Drawing.Point(134, 236);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(146, 22);
            this.d1.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 17);
            this.label12.TabIndex = 54;
            this.label12.Text = "Çıkış Tarihi : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 17);
            this.label11.TabIndex = 53;
            this.label11.Text = "Giriş Tarihi : ";
            // 
            // t9
            // 
            this.t9.Location = new System.Drawing.Point(500, 186);
            this.t9.Name = "t9";
            this.t9.Size = new System.Drawing.Size(100, 22);
            this.t9.TabIndex = 90;
            // 
            // t8
            // 
            this.t8.Location = new System.Drawing.Point(500, 145);
            this.t8.Name = "t8";
            this.t8.Size = new System.Drawing.Size(100, 22);
            this.t8.TabIndex = 89;
            // 
            // t7
            // 
            this.t7.Location = new System.Drawing.Point(499, 97);
            this.t7.Name = "t7";
            this.t7.Size = new System.Drawing.Size(100, 22);
            this.t7.TabIndex = 88;
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(499, 59);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(100, 22);
            this.t6.TabIndex = 87;
            // 
            // c1
            // 
            this.c1.FormattingEnabled = true;
            this.c1.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "201",
            "202",
            "203",
            "204",
            "205"});
            this.c1.Location = new System.Drawing.Point(499, 16);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(121, 24);
            this.c1.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(392, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 85;
            this.label10.Text = "Cephe : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(392, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 84;
            this.label9.Text = "Banyo Sayısı : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 83;
            this.label8.Text = "Yatak Sayısı : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 82;
            this.label7.Text = "Kat : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 81;
            this.label6.Text = "Oda : ";
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(90, 164);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(100, 22);
            this.t5.TabIndex = 80;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(90, 130);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(100, 22);
            this.t4.TabIndex = 79;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(90, 92);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(100, 22);
            this.t3.TabIndex = 78;
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(90, 57);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(100, 22);
            this.t2.TabIndex = 77;
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(90, 18);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(100, 22);
            this.t1.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "Email : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 74;
            this.label3.Text = "Adres : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 73;
            this.label4.Text = "Telefon : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Soy Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 71;
            this.label1.Text = "Adı : ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 450);
            this.Controls.Add(this.t9);
            this.Controls.Add(this.t8);
            this.Controls.Add(this.t7);
            this.Controls.Add(this.t6);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t5);
            this.Controls.Add(this.t4);
            this.Controls.Add(this.t3);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t10);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.d1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kayitsil);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button kayitsil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox t10;
        private System.Windows.Forms.ComboBox c2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker d2;
        private System.Windows.Forms.DateTimePicker d1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox t9;
        private System.Windows.Forms.TextBox t8;
        private System.Windows.Forms.TextBox t7;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.ComboBox c1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}