
namespace Kutuphane
{
    partial class Kitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitaplar));
            this.Kitaplar_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Guncelle_button = new System.Windows.Forms.Button();
            this.Sil_button = new System.Windows.Forms.Button();
            this.Ekle_button = new System.Windows.Forms.Button();
            this.Geri_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Kitaplar_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Kitaplar_dataGridView
            // 
            this.Kitaplar_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Kitaplar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kitaplar_dataGridView.Location = new System.Drawing.Point(85, 77);
            this.Kitaplar_dataGridView.Name = "Kitaplar_dataGridView";
            this.Kitaplar_dataGridView.ReadOnly = true;
            this.Kitaplar_dataGridView.Size = new System.Drawing.Size(507, 187);
            this.Kitaplar_dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(301, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 129;
            this.label1.Text = "   Sil   ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(100, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 130;
            this.label3.Text = "  Ekle ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(517, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 132;
            this.label2.Text = "Güncelle";
            // 
            // Guncelle_button
            // 
            this.Guncelle_button.BackColor = System.Drawing.Color.Transparent;
            this.Guncelle_button.FlatAppearance.BorderSize = 0;
            this.Guncelle_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Guncelle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Guncelle_button.Image = ((System.Drawing.Image)(resources.GetObject("Guncelle_button.Image")));
            this.Guncelle_button.Location = new System.Drawing.Point(505, 282);
            this.Guncelle_button.Margin = new System.Windows.Forms.Padding(2);
            this.Guncelle_button.Name = "Guncelle_button";
            this.Guncelle_button.Size = new System.Drawing.Size(87, 90);
            this.Guncelle_button.TabIndex = 131;
            this.Guncelle_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guncelle_button.UseVisualStyleBackColor = false;
            this.Guncelle_button.Click += new System.EventHandler(this.Guncelle_button_Click);
            // 
            // Sil_button
            // 
            this.Sil_button.BackColor = System.Drawing.Color.Transparent;
            this.Sil_button.FlatAppearance.BorderSize = 0;
            this.Sil_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sil_button.Image = ((System.Drawing.Image)(resources.GetObject("Sil_button.Image")));
            this.Sil_button.Location = new System.Drawing.Point(288, 282);
            this.Sil_button.Margin = new System.Windows.Forms.Padding(2);
            this.Sil_button.Name = "Sil_button";
            this.Sil_button.Size = new System.Drawing.Size(88, 90);
            this.Sil_button.TabIndex = 128;
            this.Sil_button.UseVisualStyleBackColor = false;
            this.Sil_button.Click += new System.EventHandler(this.Sil_button_Click);
            // 
            // Ekle_button
            // 
            this.Ekle_button.BackColor = System.Drawing.Color.Transparent;
            this.Ekle_button.FlatAppearance.BorderSize = 0;
            this.Ekle_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ekle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Ekle_button.Image = ((System.Drawing.Image)(resources.GetObject("Ekle_button.Image")));
            this.Ekle_button.Location = new System.Drawing.Point(85, 282);
            this.Ekle_button.Margin = new System.Windows.Forms.Padding(2);
            this.Ekle_button.Name = "Ekle_button";
            this.Ekle_button.Size = new System.Drawing.Size(90, 90);
            this.Ekle_button.TabIndex = 127;
            this.Ekle_button.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Ekle_button.UseVisualStyleBackColor = false;
            this.Ekle_button.Click += new System.EventHandler(this.Ekle_button_Click);
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
            this.Geri_button.TabIndex = 133;
            this.Geri_button.UseVisualStyleBackColor = false;
            this.Geri_button.Click += new System.EventHandler(this.Geri_button_Click);
            // 
            // Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Kutuphane.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(655, 430);
            this.Controls.Add(this.Geri_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Guncelle_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sil_button);
            this.Controls.Add(this.Ekle_button);
            this.Controls.Add(this.Kitaplar_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Kitaplar";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Kitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kitaplar_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Sil_button;
        private System.Windows.Forms.Button Ekle_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Guncelle_button;
        private System.Windows.Forms.Button Geri_button;
        public System.Windows.Forms.DataGridView Kitaplar_dataGridView;
    }
}