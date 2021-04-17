
namespace KelimeOyunu
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
            this.butonharfal = new System.Windows.Forms.Button();
            this.butonsuredurdur = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDakika = new System.Windows.Forms.Label();
            this.lblSaniye = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.birinci = new System.Windows.Forms.TextBox();
            this.ikinci = new System.Windows.Forms.TextBox();
            this.ucuncu = new System.Windows.Forms.TextBox();
            this.dorduncu = new System.Windows.Forms.TextBox();
            this.besinci = new System.Windows.Forms.TextBox();
            this.altinci = new System.Windows.Forms.TextBox();
            this.yedinci = new System.Windows.Forms.TextBox();
            this.sekizinci = new System.Windows.Forms.TextBox();
            this.onuncu = new System.Windows.Forms.TextBox();
            this.dokuzuncu = new System.Windows.Forms.TextBox();
            this.cevapla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.sorupuan = new System.Windows.Forms.Label();
            this.toplampuan = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.yanıtlamasuresi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butonharfal
            // 
            this.butonharfal.Location = new System.Drawing.Point(814, 554);
            this.butonharfal.Name = "butonharfal";
            this.butonharfal.Size = new System.Drawing.Size(119, 49);
            this.butonharfal.TabIndex = 0;
            this.butonharfal.Text = "Harf Al";
            this.butonharfal.UseVisualStyleBackColor = true;
            this.butonharfal.Click += new System.EventHandler(this.butonharfal_Click);
            // 
            // butonsuredurdur
            // 
            this.butonsuredurdur.Location = new System.Drawing.Point(566, 552);
            this.butonsuredurdur.Name = "butonsuredurdur";
            this.butonsuredurdur.Size = new System.Drawing.Size(158, 43);
            this.butonsuredurdur.TabIndex = 1;
            this.butonsuredurdur.Text = "Süreyi Durdur";
            this.butonsuredurdur.UseVisualStyleBackColor = true;
            this.butonsuredurdur.Click += new System.EventHandler(this.butonsuredurdur_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listBox1.HideSelection = false;
            this.listBox1.Location = new System.Drawing.Point(31, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(769, 173);
            this.listBox1.TabIndex = 2;
            this.listBox1.UseCompatibleStateImageBehavior = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.soru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(914, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Soru Puan Değeri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1136, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Toplam Puan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(997, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Süre";
            // 
            // lblDakika
            // 
            this.lblDakika.AutoSize = true;
            this.lblDakika.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblDakika.Location = new System.Drawing.Point(951, 192);
            this.lblDakika.Name = "lblDakika";
            this.lblDakika.Size = new System.Drawing.Size(0, 17);
            this.lblDakika.TabIndex = 20;
            // 
            // lblSaniye
            // 
            this.lblSaniye.AutoSize = true;
            this.lblSaniye.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblSaniye.Location = new System.Drawing.Point(1044, 192);
            this.lblSaniye.Name = "lblSaniye";
            this.lblSaniye.Size = new System.Drawing.Size(0, 17);
            this.lblSaniye.TabIndex = 21;
            this.lblSaniye.Click += new System.EventHandler(this.lblSaniye_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1012, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = ":";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Red;
            this.btn_start.Location = new System.Drawing.Point(566, 363);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(199, 122);
            this.btn_start.TabIndex = 23;
            this.btn_start.Text = "BAŞLA";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 24;
            // 
            // birinci
            // 
            this.birinci.BackColor = System.Drawing.SystemColors.Window;
            this.birinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birinci.Location = new System.Drawing.Point(31, 251);
            this.birinci.MaxLength = 1;
            this.birinci.Name = "birinci";
            this.birinci.Size = new System.Drawing.Size(82, 98);
            this.birinci.TabIndex = 25;
            this.birinci.TextChanged += new System.EventHandler(this.birinci_TextChanged);
            this.birinci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.birinci_KeyPress);
            // 
            // ikinci
            // 
            this.ikinci.BackColor = System.Drawing.SystemColors.Window;
            this.ikinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ikinci.Location = new System.Drawing.Point(173, 251);
            this.ikinci.MaxLength = 1;
            this.ikinci.Name = "ikinci";
            this.ikinci.Size = new System.Drawing.Size(81, 98);
            this.ikinci.TabIndex = 26;
            this.ikinci.TextChanged += new System.EventHandler(this.ikinci_TextChanged);
            this.ikinci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ikinci_KeyPress);
            // 
            // ucuncu
            // 
            this.ucuncu.BackColor = System.Drawing.SystemColors.Window;
            this.ucuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucuncu.Location = new System.Drawing.Point(311, 251);
            this.ucuncu.MaxLength = 1;
            this.ucuncu.Name = "ucuncu";
            this.ucuncu.Size = new System.Drawing.Size(81, 98);
            this.ucuncu.TabIndex = 27;
            this.ucuncu.TextChanged += new System.EventHandler(this.ucuncu_TextChanged);
            this.ucuncu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ucuncu_KeyPress);
            // 
            // dorduncu
            // 
            this.dorduncu.BackColor = System.Drawing.SystemColors.Window;
            this.dorduncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dorduncu.Location = new System.Drawing.Point(442, 251);
            this.dorduncu.MaxLength = 1;
            this.dorduncu.Name = "dorduncu";
            this.dorduncu.Size = new System.Drawing.Size(81, 98);
            this.dorduncu.TabIndex = 28;
            this.dorduncu.TextChanged += new System.EventHandler(this.dorduncu_TextChanged);
            this.dorduncu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dorduncu_KeyPress);
            // 
            // besinci
            // 
            this.besinci.BackColor = System.Drawing.SystemColors.Window;
            this.besinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.besinci.Location = new System.Drawing.Point(576, 251);
            this.besinci.MaxLength = 1;
            this.besinci.Multiline = true;
            this.besinci.Name = "besinci";
            this.besinci.Size = new System.Drawing.Size(81, 98);
            this.besinci.TabIndex = 29;
            this.besinci.TextChanged += new System.EventHandler(this.besinci_TextChanged);
            this.besinci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.besinci_KeyPress);
            // 
            // altinci
            // 
            this.altinci.BackColor = System.Drawing.SystemColors.Window;
            this.altinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.altinci.Location = new System.Drawing.Point(716, 251);
            this.altinci.MaxLength = 1;
            this.altinci.Multiline = true;
            this.altinci.Name = "altinci";
            this.altinci.Size = new System.Drawing.Size(81, 98);
            this.altinci.TabIndex = 30;
            this.altinci.TextChanged += new System.EventHandler(this.altinci_TextChanged);
            this.altinci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.altinci_KeyPress);
            // 
            // yedinci
            // 
            this.yedinci.BackColor = System.Drawing.SystemColors.Window;
            this.yedinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yedinci.Location = new System.Drawing.Point(852, 251);
            this.yedinci.MaxLength = 1;
            this.yedinci.Multiline = true;
            this.yedinci.Name = "yedinci";
            this.yedinci.Size = new System.Drawing.Size(81, 98);
            this.yedinci.TabIndex = 31;
            this.yedinci.TextChanged += new System.EventHandler(this.yedinci_TextChanged);
            this.yedinci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yedinci_KeyPress);
            // 
            // sekizinci
            // 
            this.sekizinci.BackColor = System.Drawing.SystemColors.Window;
            this.sekizinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sekizinci.Location = new System.Drawing.Point(987, 251);
            this.sekizinci.MaxLength = 1;
            this.sekizinci.Multiline = true;
            this.sekizinci.Name = "sekizinci";
            this.sekizinci.Size = new System.Drawing.Size(81, 98);
            this.sekizinci.TabIndex = 32;
            this.sekizinci.TextChanged += new System.EventHandler(this.sekizinci_TextChanged);
            this.sekizinci.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sekizinci_KeyPress);
            // 
            // onuncu
            // 
            this.onuncu.BackColor = System.Drawing.SystemColors.Window;
            this.onuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onuncu.Location = new System.Drawing.Point(1230, 251);
            this.onuncu.MaxLength = 1;
            this.onuncu.Multiline = true;
            this.onuncu.Name = "onuncu";
            this.onuncu.Size = new System.Drawing.Size(81, 98);
            this.onuncu.TabIndex = 33;
            this.onuncu.TextChanged += new System.EventHandler(this.onuncu_TextChanged);
            this.onuncu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onuncu_KeyPress);
            // 
            // dokuzuncu
            // 
            this.dokuzuncu.BackColor = System.Drawing.SystemColors.Window;
            this.dokuzuncu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dokuzuncu.Location = new System.Drawing.Point(1117, 251);
            this.dokuzuncu.MaxLength = 1;
            this.dokuzuncu.Multiline = true;
            this.dokuzuncu.Name = "dokuzuncu";
            this.dokuzuncu.Size = new System.Drawing.Size(81, 98);
            this.dokuzuncu.TabIndex = 34;
            this.dokuzuncu.TextChanged += new System.EventHandler(this.dokuzuncu_TextChanged);
            this.dokuzuncu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dokuzuncu_KeyPress);
            // 
            // cevapla
            // 
            this.cevapla.Location = new System.Drawing.Point(266, 538);
            this.cevapla.Name = "cevapla";
            this.cevapla.Size = new System.Drawing.Size(175, 65);
            this.cevapla.TabIndex = 36;
            this.cevapla.Text = "Cevapla";
            this.cevapla.UseVisualStyleBackColor = true;
            this.cevapla.Click += new System.EventHandler(this.cevapla_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // sorupuan
            // 
            this.sorupuan.AutoSize = true;
            this.sorupuan.Location = new System.Drawing.Point(967, 77);
            this.sorupuan.Name = "sorupuan";
            this.sorupuan.Size = new System.Drawing.Size(0, 17);
            this.sorupuan.TabIndex = 37;
            // 
            // toplampuan
            // 
            this.toplampuan.AutoSize = true;
            this.toplampuan.Location = new System.Drawing.Point(1152, 77);
            this.toplampuan.Name = "toplampuan";
            this.toplampuan.Size = new System.Drawing.Size(0, 17);
            this.toplampuan.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1197, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Yanıtlama Süresi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1182, 603);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1185, 633);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "label8";
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // yanıtlamasuresi
            // 
            this.yanıtlamasuresi.AutoSize = true;
            this.yanıtlamasuresi.Location = new System.Drawing.Point(1230, 169);
            this.yanıtlamasuresi.Name = "yanıtlamasuresi";
            this.yanıtlamasuresi.Size = new System.Drawing.Size(0, 17);
            this.yanıtlamasuresi.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1367, 777);
            this.Controls.Add(this.yanıtlamasuresi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.toplampuan);
            this.Controls.Add(this.sorupuan);
            this.Controls.Add(this.cevapla);
            this.Controls.Add(this.dokuzuncu);
            this.Controls.Add(this.onuncu);
            this.Controls.Add(this.sekizinci);
            this.Controls.Add(this.yedinci);
            this.Controls.Add(this.altinci);
            this.Controls.Add(this.besinci);
            this.Controls.Add(this.dorduncu);
            this.Controls.Add(this.ucuncu);
            this.Controls.Add(this.ikinci);
            this.Controls.Add(this.birinci);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSaniye);
            this.Controls.Add(this.lblDakika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.butonsuredurdur);
            this.Controls.Add(this.butonharfal);
            this.Name = "Form1";
            this.Text = "Kelime Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butonharfal;
        private System.Windows.Forms.Button butonsuredurdur;
        private System.Windows.Forms.ListView listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDakika;
        private System.Windows.Forms.Label lblSaniye;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox birinci;
        private System.Windows.Forms.TextBox ikinci;
        private System.Windows.Forms.TextBox ucuncu;
        private System.Windows.Forms.TextBox dorduncu;
        private System.Windows.Forms.TextBox besinci;
        private System.Windows.Forms.TextBox altinci;
        private System.Windows.Forms.TextBox yedinci;
        private System.Windows.Forms.TextBox sekizinci;
        private System.Windows.Forms.TextBox onuncu;
        private System.Windows.Forms.TextBox dokuzuncu;
        private System.Windows.Forms.Button cevapla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label sorupuan;
        private System.Windows.Forms.Label toplampuan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label yanıtlamasuresi;
    }
}

