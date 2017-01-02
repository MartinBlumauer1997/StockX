namespace StockX
{
    partial class Form_Storage
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
            this.lb_subcategories = new System.Windows.Forms.ListBox();
            this.tlp_littleBox = new System.Windows.Forms.TableLayoutPanel();
            this.b_installation = new System.Windows.Forms.Button();
            this.b_sanitaer = new System.Windows.Forms.Button();
            this.b_heizung = new System.Windows.Forms.Button();
            this.b_dienstleistungen = new System.Windows.Forms.Button();
            this.b_newEntry = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.l_search = new System.Windows.Forms.Label();
            this.dgv_storeditems = new System.Windows.Forms.DataGridView();
            this.tlp_box.SuspendLayout();
            this.tlp_littleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_storeditems)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_box
            // 
            this.tlp_box.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tlp_box.ColumnCount = 7;
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.49038F));
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9892028F));
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.60563F));
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.74648F));
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.21831F));
            this.tlp_box.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlp_box.Controls.Add(this.lb_subcategories, 1, 3);
            this.tlp_box.Controls.Add(this.tlp_littleBox, 1, 2);
            this.tlp_box.Controls.Add(this.b_newEntry, 3, 3);
            this.tlp_box.Controls.Add(this.tb_search, 5, 3);
            this.tlp_box.Controls.Add(this.l_search, 4, 3);
            this.tlp_box.Controls.Add(this.dgv_storeditems, 3, 4);
            this.tlp_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_box.Location = new System.Drawing.Point(0, 0);
            this.tlp_box.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.tlp_box.Name = "tlp_box";
            this.tlp_box.RowCount = 6;
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlp_box.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlp_box.Size = new System.Drawing.Size(785, 482);
            this.tlp_box.TabIndex = 7;
            // 
            // lb_subcategories
            // 
            this.lb_subcategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_subcategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subcategories.FormattingEnabled = true;
            this.lb_subcategories.ItemHeight = 29;
            this.lb_subcategories.Items.AddRange(new object[] {
            "Michael Oberwimmer",
            "Martin Blumauer"});
            this.lb_subcategories.Location = new System.Drawing.Point(15, 74);
            this.lb_subcategories.Margin = new System.Windows.Forms.Padding(2);
            this.lb_subcategories.Name = "lb_subcategories";
            this.tlp_box.SetRowSpan(this.lb_subcategories, 2);
            this.lb_subcategories.Size = new System.Drawing.Size(118, 393);
            this.lb_subcategories.TabIndex = 1;
            // 
            // tlp_littleBox
            // 
            this.tlp_littleBox.BackColor = System.Drawing.SystemColors.Control;
            this.tlp_littleBox.ColumnCount = 4;
            this.tlp_box.SetColumnSpan(this.tlp_littleBox, 5);
            this.tlp_littleBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_littleBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_littleBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_littleBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_littleBox.Controls.Add(this.b_installation, 0, 1);
            this.tlp_littleBox.Controls.Add(this.b_sanitaer, 1, 1);
            this.tlp_littleBox.Controls.Add(this.b_heizung, 2, 1);
            this.tlp_littleBox.Controls.Add(this.b_dienstleistungen, 3, 1);
            this.tlp_littleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_littleBox.Location = new System.Drawing.Point(15, 6);
            this.tlp_littleBox.Margin = new System.Windows.Forms.Padding(2);
            this.tlp_littleBox.Name = "tlp_littleBox";
            this.tlp_littleBox.RowCount = 3;
            this.tlp_littleBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tlp_littleBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_littleBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlp_littleBox.Size = new System.Drawing.Size(738, 64);
            this.tlp_littleBox.TabIndex = 2;
            // 
            // b_installation
            // 
            this.b_installation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(153)))), ((int)(((byte)(198)))));
            this.b_installation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_installation.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.b_installation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_installation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_installation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_installation.Location = new System.Drawing.Point(2, 6);
            this.b_installation.Margin = new System.Windows.Forms.Padding(2);
            this.b_installation.Name = "b_installation";
            this.b_installation.Size = new System.Drawing.Size(180, 43);
            this.b_installation.TabIndex = 0;
            this.b_installation.Text = "Installation";
            this.b_installation.UseVisualStyleBackColor = false;
            // 
            // b_sanitaer
            // 
            this.b_sanitaer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(153)))), ((int)(((byte)(198)))));
            this.b_sanitaer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_sanitaer.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.b_sanitaer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_sanitaer.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_sanitaer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_sanitaer.Location = new System.Drawing.Point(191, 6);
            this.b_sanitaer.Margin = new System.Windows.Forms.Padding(7, 2, 7, 2);
            this.b_sanitaer.Name = "b_sanitaer";
            this.b_sanitaer.Size = new System.Drawing.Size(170, 43);
            this.b_sanitaer.TabIndex = 1;
            this.b_sanitaer.Text = "Sanitär";
            this.b_sanitaer.UseVisualStyleBackColor = false;
            // 
            // b_heizung
            // 
            this.b_heizung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(153)))), ((int)(((byte)(198)))));
            this.b_heizung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_heizung.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.b_heizung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_heizung.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_heizung.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_heizung.Location = new System.Drawing.Point(370, 6);
            this.b_heizung.Margin = new System.Windows.Forms.Padding(2, 2, 7, 2);
            this.b_heizung.Name = "b_heizung";
            this.b_heizung.Size = new System.Drawing.Size(175, 43);
            this.b_heizung.TabIndex = 2;
            this.b_heizung.Text = "Heizung";
            this.b_heizung.UseVisualStyleBackColor = false;
            // 
            // b_dienstleistungen
            // 
            this.b_dienstleistungen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(153)))), ((int)(((byte)(198)))));
            this.b_dienstleistungen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_dienstleistungen.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.b_dienstleistungen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_dienstleistungen.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_dienstleistungen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_dienstleistungen.Location = new System.Drawing.Point(554, 6);
            this.b_dienstleistungen.Margin = new System.Windows.Forms.Padding(2);
            this.b_dienstleistungen.Name = "b_dienstleistungen";
            this.b_dienstleistungen.Size = new System.Drawing.Size(182, 43);
            this.b_dienstleistungen.TabIndex = 3;
            this.b_dienstleistungen.Text = "Dienstleistungen";
            this.b_dienstleistungen.UseVisualStyleBackColor = false;
            // 
            // b_newEntry
            // 
            this.b_newEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(176)))), ((int)(((byte)(119)))));
            this.b_newEntry.Cursor = System.Windows.Forms.Cursors.Default;
            this.b_newEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_newEntry.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.b_newEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_newEntry.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_newEntry.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_newEntry.Location = new System.Drawing.Point(143, 73);
            this.b_newEntry.Margin = new System.Windows.Forms.Padding(1, 1, 50, 6);
            this.b_newEntry.MaximumSize = new System.Drawing.Size(67, 45);
            this.b_newEntry.Name = "b_newEntry";
            this.b_newEntry.Size = new System.Drawing.Size(67, 45);
            this.b_newEntry.TabIndex = 4;
            this.b_newEntry.Text = "+";
            this.b_newEntry.UseVisualStyleBackColor = false;
            // 
            // tb_search
            // 
            this.tb_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_search.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(518, 74);
            this.tb_search.Margin = new System.Windows.Forms.Padding(2);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(235, 36);
            this.tb_search.TabIndex = 5;
            // 
            // l_search
            // 
            this.l_search.AutoSize = true;
            this.l_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.l_search.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_search.Location = new System.Drawing.Point(288, 72);
            this.l_search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_search.Name = "l_search";
            this.l_search.Size = new System.Drawing.Size(226, 52);
            this.l_search.TabIndex = 6;
            this.l_search.Text = "Suchbegriff eingeben:";
            // 
            // dgv_storeditems
            // 
            this.dgv_storeditems.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_storeditems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlp_box.SetColumnSpan(this.dgv_storeditems, 3);
            this.dgv_storeditems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_storeditems.Location = new System.Drawing.Point(144, 137);
            this.dgv_storeditems.Margin = new System.Windows.Forms.Padding(2, 13, 2, 2);
            this.dgv_storeditems.Name = "dgv_storeditems";
            this.dgv_storeditems.RowTemplate.Height = 35;
            this.dgv_storeditems.Size = new System.Drawing.Size(609, 330);
            this.dgv_storeditems.TabIndex = 7;
            // 
            // Form_Storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 482);
            this.Controls.Add(this.tlp_box);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_Storage";
            this.Text = "Form_Storage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlp_box.ResumeLayout(false);
            this.tlp_box.PerformLayout();
            this.tlp_littleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_storeditems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_box;
        private System.Windows.Forms.ListBox lb_subcategories;
        private System.Windows.Forms.TableLayoutPanel tlp_littleBox;
        private System.Windows.Forms.Button b_installation;
        private System.Windows.Forms.Button b_sanitaer;
        private System.Windows.Forms.Button b_heizung;
        private System.Windows.Forms.Button b_dienstleistungen;
        private System.Windows.Forms.Button b_newEntry;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label l_search;
        private System.Windows.Forms.DataGridView dgv_storeditems;
    }
}