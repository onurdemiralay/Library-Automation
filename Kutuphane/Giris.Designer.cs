
namespace Kutuphane
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Parola_textBox = new System.Windows.Forms.TextBox();
            this.YetkiliNo_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Giris_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Parola_textBox
            // 
            this.Parola_textBox.BackColor = System.Drawing.Color.White;
            this.Parola_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Parola_textBox.Location = new System.Drawing.Point(72, 128);
            this.Parola_textBox.Name = "Parola_textBox";
            this.Parola_textBox.PasswordChar = '*';
            this.Parola_textBox.Size = new System.Drawing.Size(203, 27);
            this.Parola_textBox.TabIndex = 2;
            // 
            // YetkiliNo_textBox
            // 
            this.YetkiliNo_textBox.BackColor = System.Drawing.Color.White;
            this.YetkiliNo_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YetkiliNo_textBox.Location = new System.Drawing.Point(72, 73);
            this.YetkiliNo_textBox.Name = "YetkiliNo_textBox";
            this.YetkiliNo_textBox.Size = new System.Drawing.Size(203, 27);
            this.YetkiliNo_textBox.TabIndex = 1;
            this.YetkiliNo_textBox.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yetkili No";
            // 
            // Giris_button
            // 
            this.Giris_button.BackColor = System.Drawing.Color.Transparent;
            this.Giris_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Giris_button.FlatAppearance.BorderSize = 2;
            this.Giris_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Giris_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Giris_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Giris_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Giris_button.ForeColor = System.Drawing.Color.White;
            this.Giris_button.Location = new System.Drawing.Point(72, 181);
            this.Giris_button.Name = "Giris_button";
            this.Giris_button.Size = new System.Drawing.Size(203, 47);
            this.Giris_button.TabIndex = 12;
            this.Giris_button.Text = "Giriş";
            this.Giris_button.UseVisualStyleBackColor = false;
            this.Giris_button.Click += new System.EventHandler(this.Giris_button_Click);
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Kutuphane.Properties.Resources.arkaplan1;
            this.ClientSize = new System.Drawing.Size(362, 293);
            this.Controls.Add(this.Giris_button);
            this.Controls.Add(this.Parola_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YetkiliNo_textBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Parola_textBox;
        private System.Windows.Forms.TextBox YetkiliNo_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Giris_button;
    }
}

