
namespace Kutuphane
{
    partial class KitapSil
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
            this.ID_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Kitaplar_dataGridView = new System.Windows.Forms.DataGridView();
            this.Sil_button = new System.Windows.Forms.Button();
            this.Ara_button = new System.Windows.Forms.Button();
            this.Geri_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Kitaplar_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ID_textBox
            // 
            this.ID_textBox.BackColor = System.Drawing.Color.White;
            this.ID_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID_textBox.Location = new System.Drawing.Point(121, 65);
            this.ID_textBox.Name = "ID_textBox";
            this.ID_textBox.Size = new System.Drawing.Size(209, 27);
            this.ID_textBox.TabIndex = 2;
            this.ID_textBox.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(122, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 135;
            this.label2.Text = "Kitap ID";
            // 
            // Kitaplar_dataGridView
            // 
            this.Kitaplar_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Kitaplar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kitaplar_dataGridView.Location = new System.Drawing.Point(51, 98);
            this.Kitaplar_dataGridView.Name = "Kitaplar_dataGridView";
            this.Kitaplar_dataGridView.ReadOnly = true;
            this.Kitaplar_dataGridView.Size = new System.Drawing.Size(437, 187);
            this.Kitaplar_dataGridView.TabIndex = 1;
            // 
            // Sil_button
            // 
            this.Sil_button.BackColor = System.Drawing.Color.Transparent;
            this.Sil_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Sil_button.FlatAppearance.BorderSize = 2;
            this.Sil_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Sil_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Sil_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sil_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sil_button.ForeColor = System.Drawing.Color.White;
            this.Sil_button.Location = new System.Drawing.Point(157, 311);
            this.Sil_button.Name = "Sil_button";
            this.Sil_button.Size = new System.Drawing.Size(209, 47);
            this.Sil_button.TabIndex = 3;
            this.Sil_button.Text = "Sil";
            this.Sil_button.UseVisualStyleBackColor = false;
            this.Sil_button.Click += new System.EventHandler(this.Sil_button_Click);
            // 
            // Ara_button
            // 
            this.Ara_button.BackColor = System.Drawing.Color.Transparent;
            this.Ara_button.BackgroundImage = global::Kutuphane.Properties.Resources.buyutec;
            this.Ara_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ara_button.FlatAppearance.BorderSize = 0;
            this.Ara_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ara_button.Location = new System.Drawing.Point(349, 55);
            this.Ara_button.Name = "Ara_button";
            this.Ara_button.Size = new System.Drawing.Size(44, 37);
            this.Ara_button.TabIndex = 139;
            this.Ara_button.UseVisualStyleBackColor = false;
            this.Ara_button.Click += new System.EventHandler(this.Ara_button_Click);
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
            this.Geri_button.TabIndex = 140;
            this.Geri_button.UseVisualStyleBackColor = false;
            this.Geri_button.Click += new System.EventHandler(this.Geri_button_Click);
            // 
            // KitapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane.Properties.Resources.arkaplan1;
            this.ClientSize = new System.Drawing.Size(520, 420);
            this.Controls.Add(this.Geri_button);
            this.Controls.Add(this.Ara_button);
            this.Controls.Add(this.Sil_button);
            this.Controls.Add(this.Kitaplar_dataGridView);
            this.Controls.Add(this.ID_textBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "KitapSil";
            this.Text = "Kitap Sil";
            this.Load += new System.EventHandler(this.KitapSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kitaplar_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ID_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Kitaplar_dataGridView;
        private System.Windows.Forms.Button Sil_button;
        private System.Windows.Forms.Button Ara_button;
        private System.Windows.Forms.Button Geri_button;
    }
}