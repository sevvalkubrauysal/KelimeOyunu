
namespace KelimeOyunu
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_soru = new System.Windows.Forms.TextBox();
            this.textBox_kelime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eklenecek Soru :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cevap(Kelime) :";
            // 
            // textBox_soru
            // 
            this.textBox_soru.Location = new System.Drawing.Point(455, 159);
            this.textBox_soru.Name = "textBox_soru";
            this.textBox_soru.Size = new System.Drawing.Size(401, 22);
            this.textBox_soru.TabIndex = 2;
            // 
            // textBox_kelime
            // 
            this.textBox_kelime.Location = new System.Drawing.Point(455, 239);
            this.textBox_kelime.Name = "textBox_kelime";
            this.textBox_kelime.Size = new System.Drawing.Size(401, 22);
            this.textBox_kelime.TabIndex = 3;
            this.textBox_kelime.TextChanged += new System.EventHandler(this.textBox_kelime_TextChanged);
            this.textBox_kelime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_kelime_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 576);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_kelime);
            this.Controls.Add(this.textBox_soru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_soru;
        private System.Windows.Forms.TextBox textBox_kelime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}