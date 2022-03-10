
namespace Kutuphane
{
    partial class EmanetEdilenKitaplar
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
            this.Emanet_dataGridView = new System.Windows.Forms.DataGridView();
            this.Geri_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Emanet_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Emanet_dataGridView
            // 
            this.Emanet_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Emanet_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Emanet_dataGridView.Location = new System.Drawing.Point(89, 69);
            this.Emanet_dataGridView.Name = "Emanet_dataGridView";
            this.Emanet_dataGridView.ReadOnly = true;
            this.Emanet_dataGridView.Size = new System.Drawing.Size(507, 187);
            this.Emanet_dataGridView.TabIndex = 172;
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
            // EmanetEdilenKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(657, 362);
            this.Controls.Add(this.Geri_button);
            this.Controls.Add(this.Emanet_dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EmanetEdilenKitaplar";
            this.Text = "Emanet Edilen Kitaplar";
            this.Load += new System.EventHandler(this.EmanetEdilenKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Emanet_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView Emanet_dataGridView;
        private System.Windows.Forms.Button Geri_button;
    }
}