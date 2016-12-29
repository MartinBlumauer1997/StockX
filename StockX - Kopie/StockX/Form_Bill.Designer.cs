namespace StockX
{
    partial class Form_Bill
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
            this.ColumnGesamtpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_subcategories = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.b_installation = new System.Windows.Forms.Button();
            this.b_sanitaer = new System.Windows.Forms.Button();
            this.b_heizung = new System.Windows.Forms.Button();
            this.b_dienstleistungen = new System.Windows.Forms.Button();
            this.ColumnRabatt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEinheit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAnzahl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_serach = new System.Windows.Forms.TextBox();
            this.dgv_storedItems = new System.Windows.Forms.DataGridView();
            this.ColumnRabattpreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_search = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_billItems = new System.Windows.Forms.DataGridView();
            this.dgv_anz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_bez = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_preis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_rabatt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_gesPreis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_preview = new System.Windows.Forms.Button();
            this.b_backToMenu = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_storedItems)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_billItems)).BeginInit();
            this.SuspendLayout();
            // 
            // ColumnGesamtpreis
            // 
            this.ColumnGesamtpreis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnGesamtpreis.HeaderText = "Gesamtpreis";
            this.ColumnGesamtpreis.Name = "ColumnGesamtpreis";
            // 
            // lb_subcategories
            // 
            this.lb_subcategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_subcategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subcategories.FormattingEnabled = true;
            this.lb_subcategories.ItemHeight = 40;
            this.lb_subcategories.Items.AddRange(new object[] {
            "Michael Oberwimmer",
            "Martin Blumauer"});
            this.lb_subcategories.Location = new System.Drawing.Point(23, 114);
            this.lb_subcategories.Name = "lb_subcategories";
            this.tableLayoutPanel1.SetRowSpan(this.lb_subcategories, 2);
            this.lb_subcategories.Size = new System.Drawing.Size(228, 461);
            this.lb_subcategories.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.b_installation, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.b_sanitaer, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.b_heizung, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.b_dienstleistungen, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 9);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1414, 99);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // b_installation
            // 
            this.b_installation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(153)))), ((int)(((byte)(198)))));
            this.b_installation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_installation.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.b_installation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_installation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_installation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_installation.Location = new System.Drawing.Point(3, 9);
            this.b_installation.Name = "b_installation";
            this.b_installation.Size = new System.Drawing.Size(347, 67);
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
            this.b_sanitaer.Location = new System.Drawing.Point(363, 9);
            this.b_sanitaer.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.b_sanitaer.Name = "b_sanitaer";
            this.b_sanitaer.Size = new System.Drawing.Size(333, 67);
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
            this.b_heizung.Location = new System.Drawing.Point(709, 9);
            this.b_heizung.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.b_heizung.Name = "b_heizung";
            this.b_heizung.Size = new System.Drawing.Size(340, 67);
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
            this.b_dienstleistungen.Location = new System.Drawing.Point(1062, 9);
            this.b_dienstleistungen.Name = "b_dienstleistungen";
            this.b_dienstleistungen.Size = new System.Drawing.Size(349, 67);
            this.b_dienstleistungen.TabIndex = 3;
            this.b_dienstleistungen.Text = "Dienstleistungen";
            this.b_dienstleistungen.UseVisualStyleBackColor = false;
            // 
            // ColumnRabatt
            // 
            this.ColumnRabatt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRabatt.HeaderText = "Rabatt";
            this.ColumnRabatt.Name = "ColumnRabatt";
            // 
            // ColumnPreis
            // 
            this.ColumnPreis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPreis.HeaderText = "Preis";
            this.ColumnPreis.Name = "ColumnPreis";
            // 
            // ColumnBezeichnung
            // 
            this.ColumnBezeichnung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnBezeichnung.HeaderText = "Bezeichnung";
            this.ColumnBezeichnung.Name = "ColumnBezeichnung";
            // 
            // ColumnEinheit
            // 
            this.ColumnEinheit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnEinheit.HeaderText = "Einheit";
            this.ColumnEinheit.Name = "ColumnEinheit";
            // 
            // ColumnAnzahl
            // 
            this.ColumnAnzahl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnAnzahl.HeaderText = "Anzahl";
            this.ColumnAnzahl.Name = "ColumnAnzahl";
            // 
            // tb_serach
            // 
            this.tb_serach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_serach.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_serach.Location = new System.Drawing.Point(986, 114);
            this.tb_serach.Name = "tb_serach";
            this.tb_serach.Size = new System.Drawing.Size(451, 50);
            this.tb_serach.TabIndex = 5;
            // 
            // dgv_storedItems
            // 
            this.dgv_storedItems.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_storedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_storedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAnzahl,
            this.ColumnEinheit,
            this.ColumnBezeichnung,
            this.ColumnPreis,
            this.ColumnRabatt,
            this.ColumnRabattpreis,
            this.ColumnGesamtpreis});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_storedItems, 3);
            this.dgv_storedItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_storedItems.Location = new System.Drawing.Point(271, 211);
            this.dgv_storedItems.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.dgv_storedItems.Name = "dgv_storedItems";
            this.dgv_storedItems.RowTemplate.Height = 35;
            this.dgv_storedItems.Size = new System.Drawing.Size(1166, 364);
            this.dgv_storedItems.TabIndex = 7;
            // 
            // ColumnRabattpreis
            // 
            this.ColumnRabattpreis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRabattpreis.HeaderText = "Rabattpreis";
            this.ColumnRabattpreis.Name = "ColumnRabattpreis";
            // 
            // l_search
            // 
            this.l_search.AutoSize = true;
            this.l_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.l_search.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_search.Location = new System.Drawing.Point(649, 111);
            this.l_search.Name = "l_search";
            this.l_search.Size = new System.Drawing.Size(331, 80);
            this.l_search.TabIndex = 6;
            this.l_search.Text = "Suchbegriff eingeben:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.48214F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9887084F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.59683F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.73011F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.20221F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lb_subcategories, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_serach, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.l_search, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgv_storedItems, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.dgv_billItems, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.b_preview, 5, 7);
            this.tableLayoutPanel1.Controls.Add(this.b_backToMenu, 7, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1599, 1021);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // dgv_billItems
            // 
            this.dgv_billItems.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_billItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_billItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_anz,
            this.dgv_bez,
            this.dgv_preis,
            this.dgv_rabatt,
            this.dgv_gesPreis});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_billItems, 5);
            this.dgv_billItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_billItems.Location = new System.Drawing.Point(23, 606);
            this.dgv_billItems.Name = "dgv_billItems";
            this.dgv_billItems.RowTemplate.Height = 28;
            this.dgv_billItems.Size = new System.Drawing.Size(1414, 310);
            this.dgv_billItems.TabIndex = 8;
            // 
            // dgv_anz
            // 
            this.dgv_anz.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_anz.HeaderText = "Anzahl";
            this.dgv_anz.Name = "dgv_anz";
            // 
            // dgv_bez
            // 
            this.dgv_bez.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_bez.HeaderText = "Bezeichnung";
            this.dgv_bez.Name = "dgv_bez";
            // 
            // dgv_preis
            // 
            this.dgv_preis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_preis.HeaderText = "Preis";
            this.dgv_preis.Name = "dgv_preis";
            // 
            // dgv_rabatt
            // 
            this.dgv_rabatt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_rabatt.HeaderText = "Rabatt";
            this.dgv_rabatt.Name = "dgv_rabatt";
            // 
            // dgv_gesPreis
            // 
            this.dgv_gesPreis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_gesPreis.HeaderText = "Gesamtpreis";
            this.dgv_gesPreis.Name = "dgv_gesPreis";
            // 
            // b_preview
            // 
            this.b_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.b_preview.Location = new System.Drawing.Point(1053, 939);
            this.b_preview.Margin = new System.Windows.Forms.Padding(70, 20, 3, 3);
            this.b_preview.Name = "b_preview";
            this.b_preview.Size = new System.Drawing.Size(384, 70);
            this.b_preview.TabIndex = 9;
            this.b_preview.Text = "Vorschau";
            this.b_preview.UseVisualStyleBackColor = true;
            // 
            // b_backToMenu
            // 
            this.b_backToMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_backToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_backToMenu.Location = new System.Drawing.Point(1454, 15);
            this.b_backToMenu.Margin = new System.Windows.Forms.Padding(3, 9, 3, 3);
            this.b_backToMenu.Name = "b_backToMenu";
            this.tableLayoutPanel1.SetRowSpan(this.b_backToMenu, 5);
            this.b_backToMenu.Size = new System.Drawing.Size(120, 901);
            this.b_backToMenu.TabIndex = 10;
            this.b_backToMenu.Text = "Zurück zum Menü";
            this.b_backToMenu.UseVisualStyleBackColor = true;
            // 
            // Form_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 1021);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form_Bill";
            this.Text = "Form_Bill";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_storedItems)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_billItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGesamtpreis;
        private System.Windows.Forms.ListBox lb_subcategories;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button b_installation;
        private System.Windows.Forms.Button b_sanitaer;
        private System.Windows.Forms.Button b_heizung;
        private System.Windows.Forms.Button b_dienstleistungen;
        private System.Windows.Forms.TextBox tb_serach;
        private System.Windows.Forms.Label l_search;
        private System.Windows.Forms.DataGridView dgv_storedItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAnzahl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEinheit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBezeichnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRabatt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRabattpreis;
        private System.Windows.Forms.DataGridView dgv_billItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_anz;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_bez;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_preis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_rabatt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_gesPreis;
        private System.Windows.Forms.Button b_preview;
        private System.Windows.Forms.Button b_backToMenu;
    }
}