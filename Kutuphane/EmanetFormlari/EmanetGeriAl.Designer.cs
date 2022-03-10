
namespace Kutuphane
{
    partial class EmanetGeriAl
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
            this.Ara_button = new System.Windows.Forms.Button();
            this.GeriAl_button = new System.Windows.Forms.Button();
            this.Emanetler_dataGridView = new System.Windows.Forms.DataGridView();
            this.UyeNo_textBox = new System.Windows.Forms.TextBox();
            this.UyeNo_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Emanetler_dataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.Geri_button.TabIndex = 172;
            this.Geri_button.UseVisualStyleBackColor = false;
            this.Geri_button.Click += new System.EventHandler(this.Geri_button_Click);
            // 
            // Ara_button
            // 
            this.Ara_button.BackColor = System.Drawing.Color.Transparent;
            this.Ara_button.BackgroundImage = global::Kutuphane.Properties.Resources.buyutec;
            this.Ara_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ara_button.FlatAppearance.BorderSize = 0;
            this.Ara_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ara_button.Location = new System.Drawing.Point(384, 59);
            this.Ara_button.Name = "Ara_button";
            this.Ara_button.Size = new System.Drawing.Size(44, 37);
            this.Ara_button.TabIndex = 177;
            this.Ara_button.UseVisualStyleBackColor = false;
            this.Ara_button.Click += new System.EventHandler(this.Ara_button_Click);
            // 
            // GeriAl_button
            // 
            this.GeriAl_button.BackColor = System.Drawing.Color.Transparent;
            this.GeriAl_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.GeriAl_button.FlatAppearance.BorderSize = 2;
            this.GeriAl_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GeriAl_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GeriAl_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeriAl_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.GeriAl_button.ForeColor = System.Drawing.Color.White;
            this.GeriAl_button.Location = new System.Drawing.Point(192, 315);
            this.GeriAl_button.Name = "GeriAl_button";
            this.GeriAl_button.Size = new System.Drawing.Size(209, 47);
            this.GeriAl_button.TabIndex = 175;
            this.GeriAl_button.Text = "Geri Al";
            this.GeriAl_button.UseVisualStyleBackColor = false;
            this.GeriAl_button.Click += new System.EventHandler(this.GeriAl_button_Click);
            // 
            // Emanetler_dataGridView
            // 
            this.Emanetler_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Emanetler_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Emanetler_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.Emanetler_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Emanetler_dataGridView.Location = new System.Drawing.Point(86, 102);
            this.Emanetler_dataGridView.Name = "Emanetler_dataGridView";
            this.Emanetler_dataGridView.ReadOnly = true;
            this.Emanetler_dataGridView.Size = new System.Drawing.Size(437, 187);
            this.Emanetler_dataGridView.TabIndex = 173;
            // 
            // UyeNo_textBox
            // 
            this.UyeNo_textBox.BackColor = System.Drawing.Color.White;
            this.UyeNo_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeNo_textBox.Location = new System.Drawing.Point(156, 69);
            this.UyeNo_textBox.Name = "UyeNo_textBox";
            this.UyeNo_textBox.Size = new System.Drawing.Size(209, 27);
            this.UyeNo_textBox.TabIndex = 174;
            this.UyeNo_textBox.Tag = "";
            // 
            // UyeNo_label
            // 
            this.UyeNo_label.AutoSize = true;
            this.UyeNo_label.BackColor = System.Drawing.Color.Transparent;
            this.UyeNo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UyeNo_label.ForeColor = System.Drawing.Color.White;
            this.UyeNo_label.Location = new System.Drawing.Point(157, 49);
            this.UyeNo_label.Name = "UyeNo_label";
            this.UyeNo_label.Size = new System.Drawing.Size(55, 17);
            this.UyeNo_label.TabIndex = 176;
            this.UyeNo_label.Text = "Üye No";
            // 
            // EmanetGeriAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kutuphane.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(600, 441);
            this.Controls.Add(this.Ara_button);
            this.Controls.Add(this.GeriAl_button);
            this.Controls.Add(this.Emanetler_dataGridView);
            this.Controls.Add(this.UyeNo_textBox);
            this.Controls.Add(this.UyeNo_label);
            this.Controls.Add(this.Geri_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EmanetGeriAl";
            this.Text = "Emanet Geri Al";
            this.Load += new System.EventHandler(this.EmanetGeriAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Emanetler_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Geri_button;
        private System.Windows.Forms.Button Ara_button;
        private System.Windows.Forms.Button GeriAl_button;
        private System.Windows.Forms.DataGridView Emanetler_dataGridView;
        private System.Windows.Forms.TextBox UyeNo_textBox;
        private System.Windows.Forms.Label UyeNo_label;
    }
}