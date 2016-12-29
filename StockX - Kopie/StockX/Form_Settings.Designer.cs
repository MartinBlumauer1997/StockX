namespace StockX
{
    partial class Form_Settings
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
            this.tlp_box = new System.Windows.Forms.TableLayoutPanel();
            this.b_addCategorie = new System.Windows.Forms.Button();
            this.b_saveChanges = new System.Windows.Forms.Button();
            this.p_buttonColor = new System.Windows.Forms.Panel();
            this.p_backgroundColor = new System.Windows.Forms.Panel();
            this.b_changeButtonColor = new System.Windows.Forms.Button();
            this.b_changeBackgroundColor = new System.Windows.Forms.Button();
            this.cd_buttonColor = new System.Windows.Forms.ColorDialog();
            this.cd_backgroundColor = new System.Windows.Forms.ColorDialog();
            this.tlp_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_box
            // 
            this.tlp_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tlp_box.ColumnCount = 7;
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.287133F));
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.99882F));
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.098126F));
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.15184F));
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.17694F));
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.287133F));
            this.tlp_box.Controls.Add(this.b_addCategorie, 2, 7);
            this.tlp_box.Controls.Add(this.b_saveChanges, 3, 5);
            this.tlp_box.Controls.Add(this.p_buttonColor, 3, 2);
            this.tlp_box.Controls.Add(this.p_backgroundColor, 3, 4);
            this.tlp_box.Controls.Add(this.b_changeButtonColor, 4, 2);
            this.tlp_box.Controls.Add(this.b_changeBackgroundColor, 4, 4);
            this.tlp_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_box.Location = new System.Drawing.Point(0, 0);
            this.tlp_box.Name = "tlp_box";
            this.tlp_box.RowCount = 9;
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66116F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.07488F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.07757F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.1864F));
            this.tlp_box.Size = new System.Drawing.Size(1186, 765);
            this.tlp_box.TabIndex = 0;
            // 
            // b_addCategorie
            // 
            this.b_addCategorie.BackColor = System.Drawing.Color.Silver;
            this.tlp_box.SetColumnSpan(this.b_addCategorie, 4);
            this.b_addCategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_addCategorie.FlatAppearance.BorderSize = 0;
            this.b_addCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_addCategorie.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.b_addCategorie.Location = new System.Drawing.Point(113, 490);
            this.b_addCategorie.Margin = new System.Windows.Forms.Padding(50, 30, 50, 30);
            this.b_addCategorie.Name = "b_addCategorie";
            this.b_addCategorie.Size = new System.Drawing.Size(958, 156);
            this.b_addCategorie.TabIndex = 0;
            this.b_addCategorie.Text = "Kategorie hinzufügen";
            this.b_addCategorie.UseVisualStyleBackColor = false;
            // 
            // b_saveChanges
            // 
            this.b_saveChanges.BackColor = System.Drawing.Color.LightGray;
            this.tlp_box.SetColumnSpan(this.b_saveChanges, 2);
            this.b_saveChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_saveChanges.FlatAppearance.BorderSize = 0;
            this.b_saveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_saveChanges.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_saveChanges.Location = new System.Drawing.Point(279, 340);
            this.b_saveChanges.Margin = new System.Windows.Forms.Padding(3, 65, 3, 3);
            this.b_saveChanges.Name = "b_saveChanges";
            this.b_saveChanges.Size = new System.Drawing.Size(636, 78);
            this.b_saveChanges.TabIndex = 1;
            this.b_saveChanges.Text = "Farbschema ändern";
            this.b_saveChanges.UseVisualStyleBackColor = false;
            // 
            // p_buttonColor
            // 
            this.p_buttonColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.p_buttonColor.Location = new System.Drawing.Point(279, 93);
            this.p_buttonColor.Name = "p_buttonColor";
            this.p_buttonColor.Size = new System.Drawing.Size(78, 74);
            this.p_buttonColor.TabIndex = 2;
            // 
            // p_backgroundColor
            // 
            this.p_backgroundColor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.p_backgroundColor.Location = new System.Drawing.Point(279, 198);
            this.p_backgroundColor.Name = "p_backgroundColor";
            this.p_backgroundColor.Size = new System.Drawing.Size(78, 74);
            this.p_backgroundColor.TabIndex = 3;
            // 
            // b_changeButtonColor
            // 
            this.b_changeButtonColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(153)))), ((int)(((byte)(198)))));
            this.b_changeButtonColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_changeButtonColor.FlatAppearance.BorderSize = 0;
            this.b_changeButtonColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_changeButtonColor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_changeButtonColor.Location = new System.Drawing.Point(490, 90);
            this.b_changeButtonColor.Margin = new System.Windows.Forms.Padding(130, 0, 3, 3);
            this.b_changeButtonColor.Name = "b_changeButtonColor";
            this.b_changeButtonColor.Size = new System.Drawing.Size(425, 77);
            this.b_changeButtonColor.TabIndex = 4;
            this.b_changeButtonColor.Text = "Buttonfarbe";
            this.b_changeButtonColor.UseVisualStyleBackColor = false;
            // 
            // b_changeBackgroundColor
            // 
            this.b_changeBackgroundColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(153)))), ((int)(((byte)(198)))));
            this.b_changeBackgroundColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_changeBackgroundColor.FlatAppearance.BorderSize = 0;
            this.b_changeBackgroundColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_changeBackgroundColor.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_changeBackgroundColor.Location = new System.Drawing.Point(490, 195);
            this.b_changeBackgroundColor.Margin = new System.Windows.Forms.Padding(130, 0, 3, 3);
            this.b_changeBackgroundColor.Name = "b_changeBackgroundColor";
            this.b_changeBackgroundColor.Size = new System.Drawing.Size(425, 77);
            this.b_changeBackgroundColor.TabIndex = 5;
            this.b_changeBackgroundColor.Text = "Hintergrundfarbe";
            this.b_changeBackgroundColor.UseVisualStyleBackColor = false;
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 765);
            this.Controls.Add(this.tlp_box);
            this.Name = "Form_Settings";
            this.Text = "Form_Settings";
            this.tlp_box.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_box;
        private System.Windows.Forms.Button b_addCategorie;
        private System.Windows.Forms.Button b_saveChanges;
        private System.Windows.Forms.Panel p_buttonColor;
        private System.Windows.Forms.Panel p_backgroundColor;
        private System.Windows.Forms.Button b_changeButtonColor;
        private System.Windows.Forms.Button b_changeBackgroundColor;
        private System.Windows.Forms.ColorDialog cd_buttonColor;
        private System.Windows.Forms.ColorDialog cd_backgroundColor;
    }
}