namespace App_GSB_Danny_G
{
    partial class AjoutMotif
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
            this.txb_nomMotif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_descrMotif = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CreerMotif = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_nomMotif
            // 
            this.txb_nomMotif.Location = new System.Drawing.Point(155, 132);
            this.txb_nomMotif.Name = "txb_nomMotif";
            this.txb_nomMotif.Size = new System.Drawing.Size(100, 20);
            this.txb_nomMotif.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom du motif :";
            // 
            // txb_descrMotif
            // 
            this.txb_descrMotif.Location = new System.Drawing.Point(12, 214);
            this.txb_descrMotif.Multiline = true;
            this.txb_descrMotif.Name = "txb_descrMotif";
            this.txb_descrMotif.Size = new System.Drawing.Size(391, 94);
            this.txb_descrMotif.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ajout d\'un motif de visite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description du motif : ";
            // 
            // btn_CreerMotif
            // 
            this.btn_CreerMotif.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_CreerMotif.FlatAppearance.BorderSize = 0;
            this.btn_CreerMotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreerMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreerMotif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_CreerMotif.Location = new System.Drawing.Point(102, 327);
            this.btn_CreerMotif.Name = "btn_CreerMotif";
            this.btn_CreerMotif.Size = new System.Drawing.Size(199, 34);
            this.btn_CreerMotif.TabIndex = 20;
            this.btn_CreerMotif.Text = "Ajouter";
            this.btn_CreerMotif.UseVisualStyleBackColor = false;
            this.btn_CreerMotif.Click += new System.EventHandler(this.btn_CreerMotif_Click);
            // 
            // AjoutMotif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 373);
            this.Controls.Add(this.btn_CreerMotif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_descrMotif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_nomMotif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AjoutMotif";
            this.Text = "AjoutMotif";
            this.Load += new System.EventHandler(this.AjoutMotif_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_nomMotif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_descrMotif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_CreerMotif;
    }
}