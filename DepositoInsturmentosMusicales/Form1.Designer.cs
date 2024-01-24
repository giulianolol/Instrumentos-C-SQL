namespace DepositoInsturmentosMusicales
{
    partial class wfrmAppDeposito
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvElementos = new System.Windows.Forms.DataGridView();
            this.pbxGuitarra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGuitarra)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvElementos
            // 
            this.dgvElementos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvElementos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElementos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvElementos.Location = new System.Drawing.Point(12, 12);
            this.dgvElementos.Name = "dgvElementos";
            this.dgvElementos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvElementos.Size = new System.Drawing.Size(675, 303);
            this.dgvElementos.TabIndex = 0;
            this.dgvElementos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElementos_CellContentClick);
            this.dgvElementos.SelectionChanged += new System.EventHandler(this.dgvElementos_SelectionChanged);
            // 
            // pbxGuitarra
            // 
            this.pbxGuitarra.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxGuitarra.Location = new System.Drawing.Point(708, 12);
            this.pbxGuitarra.Name = "pbxGuitarra";
            this.pbxGuitarra.Size = new System.Drawing.Size(334, 303);
            this.pbxGuitarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGuitarra.TabIndex = 1;
            this.pbxGuitarra.TabStop = false;
            this.pbxGuitarra.Click += new System.EventHandler(this.pbxGuitarra_Click);
            // 
            // wfrmAppDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1054, 334);
            this.Controls.Add(this.pbxGuitarra);
            this.Controls.Add(this.dgvElementos);
            this.Name = "wfrmAppDeposito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Deposito";
            this.Load += new System.EventHandler(this.wfrmAppDeposito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElementos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGuitarra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvElementos;
        private System.Windows.Forms.PictureBox pbxGuitarra;
    }
}

