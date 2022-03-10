
namespace Kutuphane
{
    partial class KitapEmanet
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
            this.Emanet_button = new System.Windows.Forms.Button();
            this.GeriAl_button = new System.Windows.Forms.Button();
            this.Geri_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Emanet_button
            // 
            this.Emanet_button.BackColor = System.Drawing.Color.Transparent;
            this.Emanet_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Emanet_button.FlatAppearance.BorderSize = 2;
            this.Emanet_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Emanet_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Emanet_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Emanet_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Emanet_button.ForeColor = System.Drawing.SystemColors.Control;
            this.Emanet_button.Location = new System.Drawing.Point(67, 117);
            this.Emanet_button.Name = "Emanet_button";
            this.Emanet_button.Size = new System.Drawing.Size(200, 47);
            this.Emanet_button.TabIndex = 173;
            this.Emanet_button.Text = "Kitap Emanet Et";
            this.Emanet_button.UseVisualStyleBackColor = false;
            this.Emanet_button.Click += new System.EventHandler(this.Emanet_button_Click);
            // 
            // GeriAl_button
            // 
            this.GeriAl_button.BackColor = System.Drawing.Color.Transparent;
            this.GeriAl_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GeriAl_button.FlatAppearance.BorderSize = 2;
            this.GeriAl_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GeriAl_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GeriAl_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GeriAl_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.GeriAl_button.ForeColor = System.Drawing.Color.White;
            this.GeriAl_button.Location = new System.Drawing.Point(288, 117);
            this.GeriAl_button.Name = "GeriAl_button";
            this.GeriAl_button.Size = new System.Drawing.Size(200, 47);
            this.GeriAl_button.TabIndex = 173;
            this.GeriAl_button.Text = "Emanet Geri Al";
            this.GeriAl_button.UseVisualStyleBackColor = false;
            this.GeriAl_button.Click += new System.EventHandler(this.GeriAl_button_Click);
            // 
            // Geri_button
            // 
            this.Geri_button.BackColor = System.Drawing.Color.Transparent;
            this.Geri_button.BackgroundImage = global::Kutuphane.Properties.Resources.geri;
            this.Geri_button.FlatAppearance.BorderSize = 0;
            this.Geri_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Geri_button.Location = new System.Drawing.Point(12, 12);
            this.Geri_button.Name = "Geri_button";
            this.Geri_button.Size = new System.Drawing.Size(55, 60);
            this.Geri_button.TabIndex = 174;
            this.Geri_button.UseVisualStyleBackColor = false;
            this.Geri_button.Click += new System.EventHandler(this.Geri_button_Click);
            // 
            // KitapEmanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(554, 269);
            this.Controls.Add(this.Geri_button);
            this.Controls.Add(this.GeriAl_button);
            this.Controls.Add(this.Emanet_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "KitapEmanet";
            this.Text = "Kitap Emanet";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Emanet_button;
        private System.Windows.Forms.Button GeriAl_button;
        private System.Windows.Forms.Button Geri_button;
    }
}