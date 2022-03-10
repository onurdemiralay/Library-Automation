
namespace Kutuphane
{
    partial class KitapEkle
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
            this.KitapAdi_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ekle_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Yazar_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ISBN_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SayfaSayisi_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Yayinevi_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BasimYili_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Aciklama_textBox = new System.Windows.Forms.TextBox();
            this.Geri_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KitapAdi_textBox
            // 
            this.KitapAdi_textBox.BackColor = System.Drawing.Color.White;
            this.KitapAdi_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KitapAdi_textBox.Location = new System.Drawing.Point(122, 51);
            this.KitapAdi_textBox.Name = "KitapAdi_textBox";
            this.KitapAdi_textBox.Size = new System.Drawing.Size(209, 27);
            this.KitapAdi_textBox.TabIndex = 1;
            this.KitapAdi_textBox.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kitap Adı";
            // 
            // Ekle_button
            // 
            this.Ekle_button.BackColor = System.Drawing.Color.Transparent;
            this.Ekle_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Ekle_button.FlatAppearance.BorderSize = 2;
            this.Ekle_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Ekle_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Ekle_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Ekle_button.ForeColor = System.Drawing.Color.White;
            this.Ekle_button.Location = new System.Drawing.Point(122, 477);
            this.Ekle_button.Name = "Ekle_button";
            this.Ekle_button.Size = new System.Drawing.Size(209, 47);
            this.Ekle_button.TabIndex = 8;
            this.Ekle_button.Text = "Ekle";
            this.Ekle_button.UseVisualStyleBackColor = false;
            this.Ekle_button.Click += new System.EventHandler(this.Ekle_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Yazar";
            // 
            // Yazar_textBox
            // 
            this.Yazar_textBox.BackColor = System.Drawing.Color.White;
            this.Yazar_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yazar_textBox.Location = new System.Drawing.Point(122, 109);
            this.Yazar_textBox.Name = "Yazar_textBox";
            this.Yazar_textBox.Size = new System.Drawing.Size(209, 27);
            this.Yazar_textBox.TabIndex = 2;
            this.Yazar_textBox.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(123, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "ISBN No";
            // 
            // ISBN_textBox
            // 
            this.ISBN_textBox.BackColor = System.Drawing.Color.White;
            this.ISBN_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ISBN_textBox.Location = new System.Drawing.Point(122, 165);
            this.ISBN_textBox.MaxLength = 13;
            this.ISBN_textBox.Name = "ISBN_textBox";
            this.ISBN_textBox.Size = new System.Drawing.Size(209, 27);
            this.ISBN_textBox.TabIndex = 3;
            this.ISBN_textBox.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(123, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // SayfaSayisi_textBox
            // 
            this.SayfaSayisi_textBox.BackColor = System.Drawing.Color.White;
            this.SayfaSayisi_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SayfaSayisi_textBox.Location = new System.Drawing.Point(122, 215);
            this.SayfaSayisi_textBox.Name = "SayfaSayisi_textBox";
            this.SayfaSayisi_textBox.Size = new System.Drawing.Size(209, 27);
            this.SayfaSayisi_textBox.TabIndex = 4;
            this.SayfaSayisi_textBox.Tag = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(123, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yayınevi";
            // 
            // Yayinevi_textBox
            // 
            this.Yayinevi_textBox.BackColor = System.Drawing.Color.White;
            this.Yayinevi_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yayinevi_textBox.Location = new System.Drawing.Point(122, 273);
            this.Yayinevi_textBox.Name = "Yayinevi_textBox";
            this.Yayinevi_textBox.Size = new System.Drawing.Size(209, 27);
            this.Yayinevi_textBox.TabIndex = 5;
            this.Yayinevi_textBox.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(123, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Basım Yılı";
            // 
            // BasimYili_textBox
            // 
            this.BasimYili_textBox.BackColor = System.Drawing.Color.White;
            this.BasimYili_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BasimYili_textBox.Location = new System.Drawing.Point(122, 329);
            this.BasimYili_textBox.Name = "BasimYili_textBox";
            this.BasimYili_textBox.Size = new System.Drawing.Size(209, 27);
            this.BasimYili_textBox.TabIndex = 6;
            this.BasimYili_textBox.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(123, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Açıklama";
            // 
            // Aciklama_textBox
            // 
            this.Aciklama_textBox.BackColor = System.Drawing.Color.White;
            this.Aciklama_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Aciklama_textBox.Location = new System.Drawing.Point(122, 382);
            this.Aciklama_textBox.Multiline = true;
            this.Aciklama_textBox.Name = "Aciklama_textBox";
            this.Aciklama_textBox.Size = new System.Drawing.Size(209, 63);
            this.Aciklama_textBox.TabIndex = 7;
            this.Aciklama_textBox.Tag = "";
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
            this.Geri_button.TabIndex = 12;
            this.Geri_button.UseVisualStyleBackColor = false;
            this.Geri_button.Click += new System.EventHandler(this.Geri_button_Click);
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(413, 536);
            this.Controls.Add(this.Geri_button);
            this.Controls.Add(this.Ekle_button);
            this.Controls.Add(this.Aciklama_textBox);
            this.Controls.Add(this.BasimYili_textBox);
            this.Controls.Add(this.ISBN_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Yayinevi_textBox);
            this.Controls.Add(this.Yazar_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SayfaSayisi_textBox);
            this.Controls.Add(this.KitapAdi_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "KitapEkle";
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KitapAdi_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ekle_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Yazar_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ISBN_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SayfaSayisi_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Yayinevi_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BasimYili_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Aciklama_textBox;
        private System.Windows.Forms.Button Geri_button;
    }
}