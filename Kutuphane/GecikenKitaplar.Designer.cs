
namespace Kutuphane
{
    partial class GecikenKitaplar
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
            this.Geri_button = new System.Windows.Forms.Button();
            this.GecikenKitaplar_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GecikenKitaplar_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Geri_button
            // 
            this.Geri_button.BackColor = System.Drawing.Color.Transparent;
            this.Geri_button.BackgroundImage = global::Kutuphane.Properties.Resources.geri;
            this.Geri_button.FlatAppearance.BorderSize = 0;
            this.Geri_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Geri_button.Location = new System.Drawing.Point(12, 12);
            this.Geri_button.Name = "Geri_button";
            this.Geri_button.Size = new System.Drawing.Size(64, 60);
            this.Geri_button.TabIndex = 175;
            this.Geri_button.UseVisualStyleBackColor = false;
            this.Geri_button.Click += new System.EventHandler(this.Geri_button_Click);
            // 
            // GecikenKitaplar_dataGridView
            // 
            this.GecikenKitaplar_dataGridView.AllowUserToAddRows = false;
            this.GecikenKitaplar_dataGridView.AllowUserToDeleteRows = false;
            this.GecikenKitaplar_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GecikenKitaplar_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GecikenKitaplar_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.GecikenKitaplar_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GecikenKitaplar_dataGridView.Location = new System.Drawing.Point(65, 89);
            this.GecikenKitaplar_dataGridView.Name = "GecikenKitaplar_dataGridView";
            this.GecikenKitaplar_dataGridView.ReadOnly = true;
            this.GecikenKitaplar_dataGridView.Size = new System.Drawing.Size(565, 169);
            this.GecikenKitaplar_dataGridView.TabIndex = 176;
            // 
            // GecikenKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(705, 375);
            this.Controls.Add(this.GecikenKitaplar_dataGridView);
            this.Controls.Add(this.Geri_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GecikenKitaplar";
            this.Text = "Geciken Kitaplar";
            this.Load += new System.EventHandler(this.GecikenKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GecikenKitaplar_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Geri_button;
        private System.Windows.Forms.DataGridView GecikenKitaplar_dataGridView;
    }
}