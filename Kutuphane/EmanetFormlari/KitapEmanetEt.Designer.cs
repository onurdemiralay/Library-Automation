
namespace Kutuphane
{
    partial class KitapEmanetEt
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
            this.Kitaplar_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Verilis_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Alinis_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Emanet_button = new System.Windows.Forms.Button();
            this.Geri_button = new System.Windows.Forms.Button();
            this.UyeNo_textBox = new System.Windows.Forms.TextBox();
            this.Uye_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 168;
            this.label1.Text = "Kitap Seçiniz";
            // 
            // Kitaplar_comboBox
            // 
            this.Kitaplar_comboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Kitaplar_comboBox.FormattingEnabled = true;
            this.Kitaplar_comboBox.Location = new System.Drawing.Point(90, 69);
            this.Kitaplar_comboBox.Name = "Kitaplar_comboBox";
            this.Kitaplar_comboBox.Size = new System.Drawing.Size(169, 21);
            this.Kitaplar_comboBox.TabIndex = 169;
            this.Kitaplar_comboBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 168;
            this.label2.Text = "Üye No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 168;
            this.label3.Text = "Kitabın Veriliş Tarihi";
            // 
            // Verilis_dateTimePicker
            // 
            this.Verilis_dateTimePicker.Location = new System.Drawing.Point(90, 217);
            this.Verilis_dateTimePicker.Name = "Verilis_dateTimePicker";
            this.Verilis_dateTimePicker.Size = new System.Drawing.Size(169, 20);
            this.Verilis_dateTimePicker.TabIndex = 171;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(91, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 17);
            this.label4.TabIndex = 168;
            this.label4.Text = "Kitabın Alınacağı Tarih";
            // 
            // Alinis_dateTimePicker
            // 
            this.Alinis_dateTimePicker.Location = new System.Drawing.Point(90, 279);
            this.Alinis_dateTimePicker.Name = "Alinis_dateTimePicker";
            this.Alinis_dateTimePicker.Size = new System.Drawing.Size(169, 20);
            this.Alinis_dateTimePicker.TabIndex = 171;
            // 
            // Emanet_button
            // 
            this.Emanet_button.BackColor = System.Drawing.Color.Transparent;
            this.Emanet_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Emanet_button.FlatAppearance.BorderSize = 2;
            this.Emanet_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Emanet_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Emanet_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Emanet_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Emanet_button.ForeColor = System.Drawing.Color.White;
            this.Emanet_button.Location = new System.Drawing.Point(90, 329);
            this.Emanet_button.Name = "Emanet_button";
            this.Emanet_button.Size = new System.Drawing.Size(200, 47);
            this.Emanet_button.TabIndex = 172;
            this.Emanet_button.Text = "Kitap Emanet Et";
            this.Emanet_button.UseVisualStyleBackColor = false;
            this.Emanet_button.Click += new System.EventHandler(this.Emanet_button_Click);
            // 
            // Geri_button
            // 
            this.Geri_button.BackColor = System.Drawing.Color.Transparent;
            this.Geri_button.FlatAppearance.BorderSize = 0;
            this.Geri_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Geri_button.Image = global::Kutuphane.Properties.Resources.geri;
            this.Geri_button.Location = new System.Drawing.Point(12, 12);
            this.Geri_button.Name = "Geri_button";
            this.Geri_button.Size = new System.Drawing.Size(55, 54);
            this.Geri_button.TabIndex = 173;
            this.Geri_button.UseVisualStyleBackColor = false;
            this.Geri_button.Click += new System.EventHandler(this.Geri_button_Click);
            // 
            // UyeNo_textBox
            // 
            this.UyeNo_textBox.Location = new System.Drawing.Point(90, 136);
            this.UyeNo_textBox.Name = "UyeNo_textBox";
            this.UyeNo_textBox.Size = new System.Drawing.Size(169, 20);
            this.UyeNo_textBox.TabIndex = 174;
            this.UyeNo_textBox.TextChanged += new System.EventHandler(this.UyeNo_textBox_TextChanged);
            // 
            // Uye_label
            // 
            this.Uye_label.AutoSize = true;
            this.Uye_label.BackColor = System.Drawing.Color.Transparent;
            this.Uye_label.ForeColor = System.Drawing.Color.White;
            this.Uye_label.Location = new System.Drawing.Point(90, 162);
            this.Uye_label.Name = "Uye_label";
            this.Uye_label.Size = new System.Drawing.Size(0, 13);
            this.Uye_label.TabIndex = 175;
            // 
            // KitapEmanetEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(340, 414);
            this.Controls.Add(this.Uye_label);
            this.Controls.Add(this.UyeNo_textBox);
            this.Controls.Add(this.Geri_button);
            this.Controls.Add(this.Emanet_button);
            this.Controls.Add(this.Alinis_dateTimePicker);
            this.Controls.Add(this.Verilis_dateTimePicker);
            this.Controls.Add(this.Kitaplar_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "KitapEmanetEt";
            this.Text = "Kitap Emanet Et";
            this.Load += new System.EventHandler(this.KitapEmanetEt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Kitaplar_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker Verilis_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Alinis_dateTimePicker;
        private System.Windows.Forms.Button Emanet_button;
        private System.Windows.Forms.Button Geri_button;
        private System.Windows.Forms.TextBox UyeNo_textBox;
        private System.Windows.Forms.Label Uye_label;
    }
}