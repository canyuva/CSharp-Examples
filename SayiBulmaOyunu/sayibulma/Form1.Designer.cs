namespace sayibulma
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.baslabtn = new System.Windows.Forms.Button();
            this.textBox0 = new System.Windows.Forms.TextBox();
            this.sayigirpanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel0 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sure = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.paneltime = new System.Windows.Forms.Panel();
            this.panelhak = new System.Windows.Forms.Panel();
            this.haklabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbsure = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbhak = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tekrar = new System.Windows.Forms.RadioButton();
            this.tekrarsiz = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btntahmin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeresim = new System.Windows.Forms.PictureBox();
            this.hakresim = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sayigirpanel.SuspendLayout();
            this.paneltime.SuspendLayout();
            this.panelhak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hakresim)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(674, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayı Bulma Oyunu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbisim
            // 
            this.tbisim.Location = new System.Drawing.Point(268, 78);
            this.tbisim.MaxLength = 8;
            this.tbisim.Name = "tbisim";
            this.tbisim.Size = new System.Drawing.Size(138, 20);
            this.tbisim.TabIndex = 1;
            this.tbisim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbisim_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "İsminizi girin (Max. 8 harf) :";
            // 
            // baslabtn
            // 
            this.baslabtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.baslabtn.Location = new System.Drawing.Point(291, 231);
            this.baslabtn.Name = "baslabtn";
            this.baslabtn.Size = new System.Drawing.Size(106, 32);
            this.baslabtn.TabIndex = 3;
            this.baslabtn.Text = "BAŞLA";
            this.baslabtn.UseVisualStyleBackColor = true;
            this.baslabtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox0
            // 
            this.textBox0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox0.Location = new System.Drawing.Point(26, 24);
            this.textBox0.MaxLength = 1;
            this.textBox0.Multiline = true;
            this.textBox0.Name = "textBox0";
            this.textBox0.Size = new System.Drawing.Size(50, 48);
            this.textBox0.TabIndex = 4;
            this.textBox0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox0.Visible = false;
            this.textBox0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // sayigirpanel
            // 
            this.sayigirpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sayigirpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sayigirpanel.Controls.Add(this.panel7);
            this.sayigirpanel.Controls.Add(this.panel6);
            this.sayigirpanel.Controls.Add(this.panel5);
            this.sayigirpanel.Controls.Add(this.panel4);
            this.sayigirpanel.Controls.Add(this.panel3);
            this.sayigirpanel.Controls.Add(this.panel2);
            this.sayigirpanel.Controls.Add(this.panel1);
            this.sayigirpanel.Controls.Add(this.panel0);
            this.sayigirpanel.Controls.Add(this.textBox7);
            this.sayigirpanel.Controls.Add(this.textBox6);
            this.sayigirpanel.Controls.Add(this.textBox5);
            this.sayigirpanel.Controls.Add(this.textBox4);
            this.sayigirpanel.Controls.Add(this.textBox3);
            this.sayigirpanel.Controls.Add(this.textBox2);
            this.sayigirpanel.Controls.Add(this.textBox1);
            this.sayigirpanel.Controls.Add(this.textBox0);
            this.sayigirpanel.Location = new System.Drawing.Point(95, 309);
            this.sayigirpanel.Name = "sayigirpanel";
            this.sayigirpanel.Size = new System.Drawing.Size(495, 127);
            this.sayigirpanel.TabIndex = 5;
            this.sayigirpanel.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(418, 78);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(50, 20);
            this.panel7.TabIndex = 18;
            this.panel7.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(362, 78);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(50, 20);
            this.panel6.TabIndex = 18;
            this.panel6.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(306, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 20);
            this.panel5.TabIndex = 13;
            this.panel5.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(250, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 20);
            this.panel4.TabIndex = 13;
            this.panel4.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(194, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 20);
            this.panel3.TabIndex = 13;
            this.panel3.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(138, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 20);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(82, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 20);
            this.panel1.TabIndex = 18;
            this.panel1.Visible = false;
            // 
            // panel0
            // 
            this.panel0.BackColor = System.Drawing.Color.Silver;
            this.panel0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel0.Location = new System.Drawing.Point(26, 79);
            this.panel0.Name = "panel0";
            this.panel0.Size = new System.Drawing.Size(50, 20);
            this.panel0.TabIndex = 12;
            this.panel0.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(418, 24);
            this.textBox7.MaxLength = 1;
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(50, 48);
            this.textBox7.TabIndex = 11;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.Visible = false;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(362, 24);
            this.textBox6.MaxLength = 1;
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(50, 48);
            this.textBox6.TabIndex = 10;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.Visible = false;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(306, 24);
            this.textBox5.MaxLength = 1;
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(50, 48);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.Visible = false;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(250, 24);
            this.textBox4.MaxLength = 1;
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(50, 48);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.Visible = false;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(194, 24);
            this.textBox3.MaxLength = 1;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(50, 48);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Visible = false;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(138, 24);
            this.textBox2.MaxLength = 1;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(50, 48);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(82, 24);
            this.textBox1.MaxLength = 1;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(50, 48);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // sure
            // 
            this.sure.AutoSize = true;
            this.sure.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sure.ForeColor = System.Drawing.Color.Red;
            this.sure.Location = new System.Drawing.Point(33, 40);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(0, 34);
            this.sure.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kalan Süre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // paneltime
            // 
            this.paneltime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.paneltime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltime.Controls.Add(this.sure);
            this.paneltime.Controls.Add(this.label4);
            this.paneltime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paneltime.Location = new System.Drawing.Point(12, 52);
            this.paneltime.Name = "paneltime";
            this.paneltime.Size = new System.Drawing.Size(121, 101);
            this.paneltime.TabIndex = 8;
            this.paneltime.Visible = false;
            // 
            // panelhak
            // 
            this.panelhak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panelhak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelhak.Controls.Add(this.haklabel);
            this.panelhak.Controls.Add(this.label6);
            this.panelhak.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelhak.Location = new System.Drawing.Point(554, 52);
            this.panelhak.Name = "panelhak";
            this.panelhak.Size = new System.Drawing.Size(121, 101);
            this.panelhak.TabIndex = 9;
            this.panelhak.Visible = false;
            // 
            // haklabel
            // 
            this.haklabel.AutoSize = true;
            this.haklabel.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haklabel.ForeColor = System.Drawing.Color.Red;
            this.haklabel.Location = new System.Drawing.Point(33, 40);
            this.haklabel.Name = "haklabel";
            this.haklabel.Size = new System.Drawing.Size(0, 34);
            this.haklabel.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kalan Hak";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kalan süreyi seçin :";
            // 
            // tbsure
            // 
            this.tbsure.Location = new System.Drawing.Point(269, 117);
            this.tbsure.MaxLength = 999;
            this.tbsure.Name = "tbsure";
            this.tbsure.Size = new System.Drawing.Size(138, 20);
            this.tbsure.TabIndex = 10;
            this.tbsure.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsure_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Toplam hakkı seçin";
            // 
            // tbhak
            // 
            this.tbhak.Location = new System.Drawing.Point(268, 156);
            this.tbhak.MaxLength = 999;
            this.tbhak.Name = "tbhak";
            this.tbhak.Size = new System.Drawing.Size(138, 20);
            this.tbhak.TabIndex = 12;
            this.tbhak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbhak_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(265, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rastgele sayılar?";
            // 
            // tekrar
            // 
            this.tekrar.AutoSize = true;
            this.tekrar.Location = new System.Drawing.Point(268, 195);
            this.tekrar.Name = "tekrar";
            this.tekrar.Size = new System.Drawing.Size(60, 17);
            this.tekrar.TabIndex = 15;
            this.tekrar.TabStop = true;
            this.tekrar.Text = "Tekrarlı";
            this.tekrar.UseVisualStyleBackColor = true;
            // 
            // tekrarsiz
            // 
            this.tekrarsiz.AutoSize = true;
            this.tekrarsiz.Location = new System.Drawing.Point(334, 195);
            this.tekrarsiz.Name = "tekrarsiz";
            this.tekrarsiz.Size = new System.Drawing.Size(68, 17);
            this.tekrarsiz.TabIndex = 16;
            this.tekrarsiz.TabStop = true;
            this.tekrarsiz.Text = "Tekrarsız";
            this.tekrarsiz.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(235, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 173);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // btntahmin
            // 
            this.btntahmin.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntahmin.Location = new System.Drawing.Point(291, 269);
            this.btntahmin.Name = "btntahmin";
            this.btntahmin.Size = new System.Drawing.Size(106, 34);
            this.btntahmin.TabIndex = 20;
            this.btntahmin.Text = "BİLDİM Mİ?";
            this.btntahmin.UseVisualStyleBackColor = true;
            this.btntahmin.Visible = false;
            this.btntahmin.Click += new System.EventHandler(this.btntahmin_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeresim
            // 
            this.timeresim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeresim.Image = global::sayibulma.Properties.Resources.time;
            this.timeresim.Location = new System.Drawing.Point(52, 9);
            this.timeresim.Name = "timeresim";
            this.timeresim.Size = new System.Drawing.Size(33, 37);
            this.timeresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.timeresim.TabIndex = 19;
            this.timeresim.TabStop = false;
            this.timeresim.Visible = false;
            // 
            // hakresim
            // 
            this.hakresim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hakresim.Image = global::sayibulma.Properties.Resources.Heart;
            this.hakresim.Location = new System.Drawing.Point(604, 12);
            this.hakresim.Name = "hakresim";
            this.hakresim.Size = new System.Drawing.Size(33, 37);
            this.hakresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hakresim.TabIndex = 18;
            this.hakresim.TabStop = false;
            this.hakresim.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(9, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "163301015";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(9, 456);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Bekir Can YUVA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 478);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btntahmin);
            this.Controls.Add(this.timeresim);
            this.Controls.Add(this.hakresim);
            this.Controls.Add(this.tekrarsiz);
            this.Controls.Add(this.tekrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbhak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbsure);
            this.Controls.Add(this.panelhak);
            this.Controls.Add(this.baslabtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbisim);
            this.Controls.Add(this.sayigirpanel);
            this.Controls.Add(this.paneltime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sayı Bulma Oyunu";
            this.sayigirpanel.ResumeLayout(false);
            this.sayigirpanel.PerformLayout();
            this.paneltime.ResumeLayout(false);
            this.paneltime.PerformLayout();
            this.panelhak.ResumeLayout(false);
            this.panelhak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hakresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button baslabtn;
        private System.Windows.Forms.TextBox textBox0;
        private System.Windows.Forms.Panel sayigirpanel;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label sure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel paneltime;
        private System.Windows.Forms.Panel panelhak;
        private System.Windows.Forms.Label haklabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbsure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbhak;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton tekrar;
        private System.Windows.Forms.RadioButton tekrarsiz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox hakresim;
        private System.Windows.Forms.PictureBox timeresim;
        private System.Windows.Forms.Button btntahmin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

