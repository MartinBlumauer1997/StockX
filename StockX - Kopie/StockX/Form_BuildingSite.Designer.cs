

namespace StockX
{
    partial class Form_BuildingSite
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
            this.tlp_bigbox = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_top = new System.Windows.Forms.TableLayoutPanel();
            this.cb_BuildingSites = new System.Windows.Forms.ComboBox();
            this.tb_NewBuildingSite = new System.Windows.Forms.TextBox();
            this.b_createNewBuildingSite = new System.Windows.Forms.Button();
            this.tlp_bottom = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_delivered = new System.Windows.Forms.DataGridView();
            this.bezDeliveredDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stkDeliveredDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_needed = new System.Windows.Forms.DataGridView();
            this.bezNeededDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stkNeededDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tlp_bigbox.SuspendLayout();
            this.tlp_top.SuspendLayout();
            this.tlp_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_delivered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_needed)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_bigbox
            // 
            this.tlp_bigbox.ColumnCount = 3;
            this.tlp_bigbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_bigbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_bigbox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_bigbox.Controls.Add(this.tlp_top, 1, 1);
            this.tlp_bigbox.Controls.Add(this.tlp_bottom, 1, 2);
            this.tlp_bigbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_bigbox.Location = new System.Drawing.Point(0, 0);
            this.tlp_bigbox.Name = "tlp_bigbox";
            this.tlp_bigbox.RowCount = 4;
            this.tlp_bigbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_bigbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlp_bigbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_bigbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_bigbox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_bigbox.Size = new System.Drawing.Size(1405, 898);
            this.tlp_bigbox.TabIndex = 0;
            // 
            // tlp_top
            // 
            this.tlp_top.ColumnCount = 3;
            this.tlp_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_top.Controls.Add(this.cb_BuildingSites, 0, 0);
            this.tlp_top.Controls.Add(this.tb_NewBuildingSite, 2, 0);
            this.tlp_top.Controls.Add(this.b_createNewBuildingSite, 2, 1);
            this.tlp_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_top.Location = new System.Drawing.Point(50, 50);
            this.tlp_top.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_top.Name = "tlp_top";
            this.tlp_top.RowCount = 2;
            this.tlp_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_top.Size = new System.Drawing.Size(1305, 140);
            this.tlp_top.TabIndex = 0;
            // 
            // cb_BuildingSites
            // 
            this.cb_BuildingSites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_BuildingSites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BuildingSites.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_BuildingSites.FormattingEnabled = true;
            this.cb_BuildingSites.Items.AddRange(new object[] {
            "Haus Maier",
            "Manuel Kases Baustelle",
            "Hubers Heizung",
            "Hans Fugger Wasserleitungen verlegen"});
            this.cb_BuildingSites.Location = new System.Drawing.Point(3, 13);
            this.cb_BuildingSites.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.cb_BuildingSites.Name = "cb_BuildingSites";
            this.cb_BuildingSites.Size = new System.Drawing.Size(586, 45);
            this.cb_BuildingSites.TabIndex = 0;
            // 
            // tb_NewBuildingSite
            // 
            this.tb_NewBuildingSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_NewBuildingSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NewBuildingSite.Location = new System.Drawing.Point(715, 13);
            this.tb_NewBuildingSite.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.tb_NewBuildingSite.Name = "tb_NewBuildingSite";
            this.tb_NewBuildingSite.Size = new System.Drawing.Size(587, 44);
            this.tb_NewBuildingSite.TabIndex = 1;
            // 
            // b_createNewBuildingSite
            // 
            this.b_createNewBuildingSite.Dock = System.Windows.Forms.DockStyle.Right;
            this.b_createNewBuildingSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_createNewBuildingSite.Location = new System.Drawing.Point(1089, 73);
            this.b_createNewBuildingSite.Name = "b_createNewBuildingSite";
            this.b_createNewBuildingSite.Size = new System.Drawing.Size(213, 64);
            this.b_createNewBuildingSite.TabIndex = 2;
            this.b_createNewBuildingSite.Text = "Neue Baustelle";
            this.b_createNewBuildingSite.UseVisualStyleBackColor = true;
            this.b_createNewBuildingSite.Click += new System.EventHandler(this.b_createNewBuildingSite_Click);
            // 
            // tlp_bottom
            // 
            this.tlp_bottom.ColumnCount = 3;
            this.tlp_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_bottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_bottom.Controls.Add(this.dgv_delivered, 0, 2);
            this.tlp_bottom.Controls.Add(this.dgv_needed, 2, 2);
            this.tlp_bottom.Controls.Add(this.label1, 0, 1);
            this.tlp_bottom.Controls.Add(this.label2, 2, 1);
            this.tlp_bottom.Controls.Add(this.button1, 0, 3);
            this.tlp_bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_bottom.Location = new System.Drawing.Point(53, 193);
            this.tlp_bottom.Name = "tlp_bottom";
            this.tlp_bottom.RowCount = 4;
            this.tlp_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlp_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_bottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlp_bottom.Size = new System.Drawing.Size(1299, 652);
            this.tlp_bottom.TabIndex = 1;
            // 
            // dgv_delivered
            // 
            this.dgv_delivered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_delivered.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_delivered.ColumnHeadersHeight = 40;
            this.dgv_delivered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_delivered.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bezDeliveredDGV,
            this.stkDeliveredDGV});
            this.dgv_delivered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_delivered.Location = new System.Drawing.Point(3, 93);
            this.dgv_delivered.Name = "dgv_delivered";
            this.dgv_delivered.RowTemplate.Height = 28;
            this.dgv_delivered.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_delivered.Size = new System.Drawing.Size(583, 501);
            this.dgv_delivered.TabIndex = 0;
            // 
            // bezDeliveredDGV
            // 
            this.bezDeliveredDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bezDeliveredDGV.HeaderText = "Bezeichnung";
            this.bezDeliveredDGV.Name = "bezDeliveredDGV";
            // 
            // stkDeliveredDGV
            // 
            this.stkDeliveredDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stkDeliveredDGV.FillWeight = 30F;
            this.stkDeliveredDGV.HeaderText = "Stückzahl";
            this.stkDeliveredDGV.Name = "stkDeliveredDGV";
            // 
            // dgv_needed
            // 
            this.dgv_needed.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_needed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_needed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bezNeededDGV,
            this.stkNeededDGV});
            this.dgv_needed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_needed.Location = new System.Drawing.Point(712, 93);
            this.dgv_needed.Name = "dgv_needed";
            this.dgv_needed.RowTemplate.Height = 28;
            this.dgv_needed.Size = new System.Drawing.Size(584, 501);
            this.dgv_needed.TabIndex = 1;
            // 
            // bezNeededDGV
            // 
            this.bezNeededDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bezNeededDGV.HeaderText = "Bezeichnung";
            this.bezNeededDGV.Name = "bezNeededDGV";
            // 
            // stkNeededDGV
            // 
            this.stkNeededDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stkNeededDGV.FillWeight = 30F;
            this.stkNeededDGV.HeaderText = "Stückzahl";
            this.stkNeededDGV.Name = "stkNeededDGV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 32, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ausgelieferte Materialien:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(712, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 32, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Benötigte Materialien:";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(402, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Rechnung erstellen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form_BuildingSite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 898);
            this.Controls.Add(this.tlp_bigbox);
            this.Name = "Form_BuildingSite";
            this.Text = "Form_BuildingSite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlp_bigbox.ResumeLayout(false);
            this.tlp_top.ResumeLayout(false);
            this.tlp_top.PerformLayout();
            this.tlp_bottom.ResumeLayout(false);
            this.tlp_bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_delivered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_needed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_bigbox;
        private System.Windows.Forms.TableLayoutPanel tlp_top;
        private System.Windows.Forms.ComboBox cb_BuildingSites;
        private System.Windows.Forms.TextBox tb_NewBuildingSite;
        private System.Windows.Forms.Button b_createNewBuildingSite;
        private System.Windows.Forms.TableLayoutPanel tlp_bottom;
        private System.Windows.Forms.DataGridView dgv_delivered;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezDeliveredDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkDeliveredDGV;
        private System.Windows.Forms.DataGridView dgv_needed;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezNeededDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn stkNeededDGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}