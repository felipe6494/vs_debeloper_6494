namespace mifortm
{
    partial class newtrack
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
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Militxt = new System.Windows.Forms.TextBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.cbMedia = new System.Windows.Forms.ComboBox();
            this.cbAlbum = new System.Windows.Forms.ComboBox();
            this.unirpricetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btguardar = new System.Windows.Forms.Button();
            this.prog = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(261, 31);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(121, 20);
            this.Nametxt.TabIndex = 0;
            // 
            // Militxt
            // 
            this.Militxt.Location = new System.Drawing.Point(261, 197);
            this.Militxt.Name = "Militxt";
            this.Militxt.Size = new System.Drawing.Size(121, 20);
            this.Militxt.TabIndex = 1;
            // 
            // cbGenre
            // 
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(261, 69);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(121, 21);
            this.cbGenre.TabIndex = 2;
            // 
            // cbMedia
            // 
            this.cbMedia.FormattingEnabled = true;
            this.cbMedia.Location = new System.Drawing.Point(261, 108);
            this.cbMedia.Name = "cbMedia";
            this.cbMedia.Size = new System.Drawing.Size(121, 21);
            this.cbMedia.TabIndex = 3;
            // 
            // cbAlbum
            // 
            this.cbAlbum.FormattingEnabled = true;
            this.cbAlbum.Location = new System.Drawing.Point(261, 152);
            this.cbAlbum.Name = "cbAlbum";
            this.cbAlbum.Size = new System.Drawing.Size(121, 21);
            this.cbAlbum.TabIndex = 4;
            // 
            // unirpricetxt
            // 
            this.unirpricetxt.Location = new System.Drawing.Point(261, 235);
            this.unirpricetxt.Name = "unirpricetxt";
            this.unirpricetxt.Size = new System.Drawing.Size(121, 20);
            this.unirpricetxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Genre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "MediaType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Album";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Milliseconds";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "unitprice";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btguardar
            // 
            this.btguardar.Location = new System.Drawing.Point(225, 306);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(75, 23);
            this.btguardar.TabIndex = 12;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // prog
            // 
            this.prog.Location = new System.Drawing.Point(175, 362);
            this.prog.Name = "prog";
            this.prog.Size = new System.Drawing.Size(224, 39);
            this.prog.TabIndex = 13;
            // 
            // newtrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.prog);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unirpricetxt);
            this.Controls.Add(this.cbAlbum);
            this.Controls.Add(this.cbMedia);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.Militxt);
            this.Controls.Add(this.Nametxt);
            this.Name = "newtrack";
            this.Text = "newtrack";
            this.Load += new System.EventHandler(this.newtrack_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Militxt;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.ComboBox cbMedia;
        private System.Windows.Forms.ComboBox cbAlbum;
        private System.Windows.Forms.TextBox unirpricetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.ProgressBar prog;
    }
}