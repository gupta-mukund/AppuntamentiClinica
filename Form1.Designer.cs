
namespace AppuntamentiClinica
{
    partial class Form1
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
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tpPazienti = new System.Windows.Forms.TabPage();
            this.dgwPazienti = new System.Windows.Forms.DataGridView();
            this.tpMedici = new System.Windows.Forms.TabPage();
            this.dgwMedici = new System.Windows.Forms.DataGridView();
            this.tpPatologie = new System.Windows.Forms.TabPage();
            this.dgwPatologie = new System.Windows.Forms.DataGridView();
            this.tpSpecializzazioni = new System.Windows.Forms.TabPage();
            this.dgwSpecializzazioni = new System.Windows.Forms.DataGridView();
            this.tpAppuntamenti = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ckbPaziente = new System.Windows.Forms.CheckBox();
            this.ckbMedico = new System.Windows.Forms.CheckBox();
            this.cmbMedici = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPazienti = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.ckbData = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgwAppuntamenti = new System.Windows.Forms.DataGridView();
            this.tbcMain.SuspendLayout();
            this.tpPazienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPazienti)).BeginInit();
            this.tpMedici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedici)).BeginInit();
            this.tpPatologie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPatologie)).BeginInit();
            this.tpSpecializzazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSpecializzazioni)).BeginInit();
            this.tpAppuntamenti.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAppuntamenti)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tpPazienti);
            this.tbcMain.Controls.Add(this.tpMedici);
            this.tbcMain.Controls.Add(this.tpPatologie);
            this.tbcMain.Controls.Add(this.tpSpecializzazioni);
            this.tbcMain.Controls.Add(this.tpAppuntamenti);
            this.tbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMain.Location = new System.Drawing.Point(0, 0);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(800, 450);
            this.tbcMain.TabIndex = 0;
            // 
            // tpPazienti
            // 
            this.tpPazienti.Controls.Add(this.dgwPazienti);
            this.tpPazienti.Location = new System.Drawing.Point(4, 25);
            this.tpPazienti.Name = "tpPazienti";
            this.tpPazienti.Padding = new System.Windows.Forms.Padding(3);
            this.tpPazienti.Size = new System.Drawing.Size(792, 421);
            this.tpPazienti.TabIndex = 0;
            this.tpPazienti.Text = "Pazienti";
            this.tpPazienti.UseVisualStyleBackColor = true;
            // 
            // dgwPazienti
            // 
            this.dgwPazienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPazienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPazienti.Location = new System.Drawing.Point(3, 3);
            this.dgwPazienti.Name = "dgwPazienti";
            this.dgwPazienti.RowHeadersWidth = 51;
            this.dgwPazienti.RowTemplate.Height = 24;
            this.dgwPazienti.Size = new System.Drawing.Size(786, 415);
            this.dgwPazienti.TabIndex = 0;
            // 
            // tpMedici
            // 
            this.tpMedici.Controls.Add(this.dgwMedici);
            this.tpMedici.Location = new System.Drawing.Point(4, 25);
            this.tpMedici.Name = "tpMedici";
            this.tpMedici.Padding = new System.Windows.Forms.Padding(3);
            this.tpMedici.Size = new System.Drawing.Size(792, 421);
            this.tpMedici.TabIndex = 1;
            this.tpMedici.Text = "Medici";
            this.tpMedici.UseVisualStyleBackColor = true;
            // 
            // dgwMedici
            // 
            this.dgwMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMedici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwMedici.Location = new System.Drawing.Point(3, 3);
            this.dgwMedici.Name = "dgwMedici";
            this.dgwMedici.RowHeadersWidth = 51;
            this.dgwMedici.RowTemplate.Height = 24;
            this.dgwMedici.Size = new System.Drawing.Size(786, 415);
            this.dgwMedici.TabIndex = 0;
            // 
            // tpPatologie
            // 
            this.tpPatologie.Controls.Add(this.dgwPatologie);
            this.tpPatologie.Location = new System.Drawing.Point(4, 25);
            this.tpPatologie.Name = "tpPatologie";
            this.tpPatologie.Size = new System.Drawing.Size(792, 421);
            this.tpPatologie.TabIndex = 2;
            this.tpPatologie.Text = "Patologie";
            this.tpPatologie.UseVisualStyleBackColor = true;
            // 
            // dgwPatologie
            // 
            this.dgwPatologie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPatologie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwPatologie.Location = new System.Drawing.Point(0, 0);
            this.dgwPatologie.Name = "dgwPatologie";
            this.dgwPatologie.RowHeadersWidth = 51;
            this.dgwPatologie.RowTemplate.Height = 24;
            this.dgwPatologie.Size = new System.Drawing.Size(792, 421);
            this.dgwPatologie.TabIndex = 0;
            // 
            // tpSpecializzazioni
            // 
            this.tpSpecializzazioni.Controls.Add(this.dgwSpecializzazioni);
            this.tpSpecializzazioni.Location = new System.Drawing.Point(4, 25);
            this.tpSpecializzazioni.Name = "tpSpecializzazioni";
            this.tpSpecializzazioni.Size = new System.Drawing.Size(792, 421);
            this.tpSpecializzazioni.TabIndex = 3;
            this.tpSpecializzazioni.Text = "Specializzazioni";
            this.tpSpecializzazioni.UseVisualStyleBackColor = true;
            // 
            // dgwSpecializzazioni
            // 
            this.dgwSpecializzazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSpecializzazioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwSpecializzazioni.Location = new System.Drawing.Point(0, 0);
            this.dgwSpecializzazioni.Name = "dgwSpecializzazioni";
            this.dgwSpecializzazioni.RowHeadersWidth = 51;
            this.dgwSpecializzazioni.RowTemplate.Height = 24;
            this.dgwSpecializzazioni.Size = new System.Drawing.Size(792, 421);
            this.dgwSpecializzazioni.TabIndex = 0;
            // 
            // tpAppuntamenti
            // 
            this.tpAppuntamenti.Controls.Add(this.tableLayoutPanel1);
            this.tpAppuntamenti.Location = new System.Drawing.Point(4, 25);
            this.tpAppuntamenti.Name = "tpAppuntamenti";
            this.tpAppuntamenti.Size = new System.Drawing.Size(792, 421);
            this.tpAppuntamenti.TabIndex = 4;
            this.tpAppuntamenti.Text = "Appuntamenti";
            this.tpAppuntamenti.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgwAppuntamenti, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 421);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(792, 126);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.ckbPaziente, 5, 3);
            this.tableLayoutPanel3.Controls.Add(this.ckbMedico, 5, 5);
            this.tableLayoutPanel3.Controls.Add(this.cmbMedici, 3, 4);
            this.tableLayoutPanel3.Controls.Add(this.label3, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.cmbPazienti, 3, 3);
            this.tableLayoutPanel3.Controls.Add(this.dtpData, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.ckbData, 5, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(554, 126);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // ckbPaziente
            // 
            this.ckbPaziente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbPaziente.AutoSize = true;
            this.ckbPaziente.Location = new System.Drawing.Point(516, 54);
            this.ckbPaziente.Name = "ckbPaziente";
            this.ckbPaziente.Size = new System.Drawing.Size(18, 17);
            this.ckbPaziente.TabIndex = 8;
            this.ckbPaziente.Tag = "Paziente";
            this.ckbPaziente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbPaziente.UseVisualStyleBackColor = true;
            this.ckbPaziente.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // ckbMedico
            // 
            this.ckbMedico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbMedico.AutoSize = true;
            this.ckbMedico.Location = new System.Drawing.Point(516, 94);
            this.ckbMedico.Name = "ckbMedico";
            this.ckbMedico.Size = new System.Drawing.Size(18, 17);
            this.ckbMedico.TabIndex = 7;
            this.ckbMedico.Tag = "Medico";
            this.ckbMedico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbMedico.UseVisualStyleBackColor = true;
            this.ckbMedico.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // cmbMedici
            // 
            this.cmbMedici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbMedici.FormattingEnabled = true;
            this.cmbMedici.ItemHeight = 16;
            this.cmbMedici.Location = new System.Drawing.Point(254, 80);
            this.cmbMedici.Margin = new System.Windows.Forms.Padding(0);
            this.cmbMedici.Name = "cmbMedici";
            this.cmbMedici.Size = new System.Drawing.Size(232, 24);
            this.cmbMedici.TabIndex = 4;
            this.cmbMedici.Tag = "Medico";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medico";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paziente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbPazienti
            // 
            this.cmbPazienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPazienti.FormattingEnabled = true;
            this.cmbPazienti.ItemHeight = 16;
            this.cmbPazienti.Location = new System.Drawing.Point(254, 46);
            this.cmbPazienti.Margin = new System.Windows.Forms.Padding(0);
            this.cmbPazienti.Name = "cmbPazienti";
            this.cmbPazienti.Size = new System.Drawing.Size(232, 24);
            this.cmbPazienti.TabIndex = 3;
            this.cmbPazienti.Tag = "Paziente";
            // 
            // dtpData
            // 
            this.dtpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpData.Location = new System.Drawing.Point(257, 9);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(226, 22);
            this.dtpData.TabIndex = 5;
            this.dtpData.Tag = "Data";
            // 
            // ckbData
            // 
            this.ckbData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ckbData.AutoSize = true;
            this.ckbData.Location = new System.Drawing.Point(516, 14);
            this.ckbData.Name = "ckbData";
            this.ckbData.Size = new System.Drawing.Size(18, 17);
            this.ckbData.TabIndex = 6;
            this.ckbData.Tag = "Data";
            this.ckbData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbData.UseVisualStyleBackColor = true;
            this.ckbData.CheckedChanged += new System.EventHandler(this.CheckBoxChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.Controls.Add(this.btnReset, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnFiltra, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(554, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(238, 126);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnFiltra
            // 
            this.btnFiltra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFiltra.Location = new System.Drawing.Point(3, 28);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(101, 69);
            this.btnFiltra.TabIndex = 0;
            this.btnFiltra.Text = "Filtra";
            this.btnFiltra.UseVisualStyleBackColor = true;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Location = new System.Drawing.Point(121, 28);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 69);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgwAppuntamenti
            // 
            this.dgwAppuntamenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAppuntamenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwAppuntamenti.Location = new System.Drawing.Point(3, 129);
            this.dgwAppuntamenti.Name = "dgwAppuntamenti";
            this.dgwAppuntamenti.RowHeadersWidth = 51;
            this.dgwAppuntamenti.RowTemplate.Height = 24;
            this.dgwAppuntamenti.Size = new System.Drawing.Size(786, 289);
            this.dgwAppuntamenti.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcMain);
            this.Name = "Form1";
            this.Text = "Gestione Appuntamenti Clinica";
            this.tbcMain.ResumeLayout(false);
            this.tpPazienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPazienti)).EndInit();
            this.tpMedici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedici)).EndInit();
            this.tpPatologie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwPatologie)).EndInit();
            this.tpSpecializzazioni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSpecializzazioni)).EndInit();
            this.tpAppuntamenti.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAppuntamenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tpPazienti;
        private System.Windows.Forms.TabPage tpMedici;
        private System.Windows.Forms.TabPage tpPatologie;
        private System.Windows.Forms.TabPage tpSpecializzazioni;
        private System.Windows.Forms.DataGridView dgwPazienti;
        private System.Windows.Forms.DataGridView dgwMedici;
        private System.Windows.Forms.DataGridView dgwPatologie;
        private System.Windows.Forms.DataGridView dgwSpecializzazioni;
        private System.Windows.Forms.TabPage tpAppuntamenti;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cmbMedici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPazienti;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.CheckBox ckbPaziente;
        private System.Windows.Forms.CheckBox ckbMedico;
        private System.Windows.Forms.CheckBox ckbData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFiltra;
        private System.Windows.Forms.DataGridView dgwAppuntamenti;
    }
}

