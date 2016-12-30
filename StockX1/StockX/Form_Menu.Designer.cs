namespace StockX
{
    partial class Form_Menu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_box = new System.Windows.Forms.TableLayoutPanel();
            this.b_settings = new System.Windows.Forms.Button();
            this.b_buildingsite = new System.Windows.Forms.Button();
            this.b_bill = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlp_header = new System.Windows.Forms.TableLayoutPanel();
            this.l_header = new System.Windows.Forms.Label();
            this.b_storage = new System.Windows.Forms.Button();
            this.tlp_box.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tlp_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_box
            // 
            this.tlp_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tlp_box.ColumnCount = 2;
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_box.Controls.Add(this.b_settings, 1, 2);
            this.tlp_box.Controls.Add(this.b_buildingsite, 0, 2);
            this.tlp_box.Controls.Add(this.b_bill, 1, 1);
            this.tlp_box.Controls.Add(this.panel1, 0, 0);
            this.tlp_box.Controls.Add(this.b_storage, 0, 1);
            this.tlp_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_box.Location = new System.Drawing.Point(0, 0);
            this.tlp_box.Margin = new System.Windows.Forms.Padding(3, 159, 3, 3);
            this.tlp_box.Name = "tlp_box";
            this.tlp_box.RowCount = 3;
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_box.Size = new System.Drawing.Size(1648, 983);
            this.tlp_box.TabIndex = 0;
            // 
            // b_settings
            // 
            this.b_settings.BackColor = System.Drawing.Color.LightGray;
            this.b_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(139)))));
            this.b_settings.FlatAppearance.BorderSize = 0;
            this.b_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_settings.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_settings.ForeColor = System.Drawing.Color.Black;
            this.b_settings.Location = new System.Drawing.Point(904, 644);
            this.b_settings.Margin = new System.Windows.Forms.Padding(80, 70, 150, 70);
            this.b_settings.Name = "b_settings";
            this.b_settings.Size = new System.Drawing.Size(594, 269);
            this.b_settings.TabIndex = 4;
            this.b_settings.Text = "Einstellungen";
            this.b_settings.UseVisualStyleBackColor = false;
            this.b_settings.Click += new System.EventHandler(this.b_settings_Click);
            // 
            // b_buildingsite
            // 
            this.b_buildingsite.BackColor = System.Drawing.Color.LightGray;
            this.b_buildingsite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_buildingsite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(139)))));
            this.b_buildingsite.FlatAppearance.BorderSize = 0;
            this.b_buildingsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_buildingsite.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_buildingsite.ForeColor = System.Drawing.Color.Black;
            this.b_buildingsite.Location = new System.Drawing.Point(150, 644);
            this.b_buildingsite.Margin = new System.Windows.Forms.Padding(150, 70, 80, 70);
            this.b_buildingsite.Name = "b_buildingsite";
            this.b_buildingsite.Size = new System.Drawing.Size(594, 269);
            this.b_buildingsite.TabIndex = 3;
            this.b_buildingsite.Text = "Baustelle";
            this.b_buildingsite.UseVisualStyleBackColor = false;
            this.b_buildingsite.Click += new System.EventHandler(this.b_buildingsite_Click);
            // 
            // b_bill
            // 
            this.b_bill.BackColor = System.Drawing.Color.LightGray;
            this.b_bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_bill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(139)))));
            this.b_bill.FlatAppearance.BorderSize = 0;
            this.b_bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_bill.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_bill.ForeColor = System.Drawing.Color.Black;
            this.b_bill.Location = new System.Drawing.Point(904, 235);
            this.b_bill.Margin = new System.Windows.Forms.Padding(80, 70, 150, 70);
            this.b_bill.Name = "b_bill";
            this.b_bill.Size = new System.Drawing.Size(594, 269);
            this.b_bill.TabIndex = 2;
            this.b_bill.Text = "Rechnung";
            this.b_bill.UseVisualStyleBackColor = false;
            this.b_bill.Click += new System.EventHandler(this.b_bill_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(153)))), ((int)(((byte)(198)))));
            this.tlp_box.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.tlp_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1645, 159);
            this.panel1.TabIndex = 0;
            // 
            // tlp_header
            // 
            this.tlp_header.ColumnCount = 1;
            this.tlp_header.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_header.Controls.Add(this.l_header, 0, 0);
            this.tlp_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_header.Location = new System.Drawing.Point(0, 0);
            this.tlp_header.Name = "tlp_header";
            this.tlp_header.RowCount = 1;
            this.tlp_header.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_header.Size = new System.Drawing.Size(1645, 159);
            this.tlp_header.TabIndex = 2;
            // 
            // l_header
            // 
            this.l_header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_header.AutoSize = true;
            this.l_header.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_header.ForeColor = System.Drawing.SystemColors.Control;
            this.l_header.Location = new System.Drawing.Point(226, 39);
            this.l_header.Margin = new System.Windows.Forms.Padding(0);
            this.l_header.Name = "l_header";
            this.l_header.Size = new System.Drawing.Size(1192, 81);
            this.l_header.TabIndex = 0;
            this.l_header.Text = "STÖGER - Der Qualitätsinstallateur seit 1955";
            // 
            // b_storage
            // 
            this.b_storage.BackColor = System.Drawing.Color.LightGray;
            this.b_storage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_storage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(84)))), ((int)(((byte)(139)))));
            this.b_storage.FlatAppearance.BorderSize = 0;
            this.b_storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_storage.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_storage.ForeColor = System.Drawing.Color.Black;
            this.b_storage.Location = new System.Drawing.Point(150, 235);
            this.b_storage.Margin = new System.Windows.Forms.Padding(150, 70, 80, 70);
            this.b_storage.Name = "b_storage";
            this.b_storage.Size = new System.Drawing.Size(594, 269);
            this.b_storage.TabIndex = 1;
            this.b_storage.Text = "Lager";
            this.b_storage.UseVisualStyleBackColor = false;
            this.b_storage.Click += new System.EventHandler(this.b_storage_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 983);
            this.Controls.Add(this.tlp_box);
            this.Name = "Form_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlp_box.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tlp_header.ResumeLayout(false);
            this.tlp_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_box;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_storage;
        private System.Windows.Forms.Button b_settings;
        private System.Windows.Forms.Button b_buildingsite;
        private System.Windows.Forms.Button b_bill;
        private System.Windows.Forms.TableLayoutPanel tlp_header;
        private System.Windows.Forms.Label l_header;
    }
}

