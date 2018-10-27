namespace mifortm
{
    partial class Form1
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
            this.cmbplaylist = new System.Windows.Forms.ComboBox();
            this.dataTracks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTracks)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbplaylist
            // 
            this.cmbplaylist.FormattingEnabled = true;
            this.cmbplaylist.Location = new System.Drawing.Point(289, 72);
            this.cmbplaylist.Name = "cmbplaylist";
            this.cmbplaylist.Size = new System.Drawing.Size(121, 21);
            this.cmbplaylist.TabIndex = 0;
            this.cmbplaylist.SelectedIndexChanged += new System.EventHandler(this.cmbplaylist_SelectedIndexChanged);
            // 
            // dataTracks
            // 
            this.dataTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTracks.Location = new System.Drawing.Point(27, 134);
            this.dataTracks.Name = "dataTracks";
            this.dataTracks.Size = new System.Drawing.Size(744, 292);
            this.dataTracks.TabIndex = 1;
            this.dataTracks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLAYLIST:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTracks);
            this.Controls.Add(this.cmbplaylist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTracks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbplaylist;
        private System.Windows.Forms.DataGridView dataTracks;
        private System.Windows.Forms.Label label1;
    }
}

