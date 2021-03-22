namespace App_GSB_Danny_G
{
    partial class Remplacement
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
            this.pl_remplacent = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_Rempla = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_CreerMotif = new System.Windows.Forms.Button();
            this.txb_InfoRempl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pl_remplacent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_remplacent
            // 
            this.pl_remplacent.Controls.Add(this.button1);
            this.pl_remplacent.Controls.Add(this.cb_Rempla);
            this.pl_remplacent.Controls.Add(this.label2);
            this.pl_remplacent.Location = new System.Drawing.Point(22, 57);
            this.pl_remplacent.Name = "pl_remplacent";
            this.pl_remplacent.Size = new System.Drawing.Size(259, 58);
            this.pl_remplacent.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(171, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 34);
            this.button1.TabIndex = 28;
            this.button1.Text = "Vérifier";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_Rempla
            // 
            this.cb_Rempla.FormattingEnabled = true;
            this.cb_Rempla.Location = new System.Drawing.Point(17, 20);
            this.cb_Rempla.Name = "cb_Rempla";
            this.cb_Rempla.Size = new System.Drawing.Size(148, 21);
            this.cb_Rempla.TabIndex = 27;
            this.cb_Rempla.SelectedIndexChanged += new System.EventHandler(this.cb_Rempla_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Praticien remplacé :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 31;
            this.label1.Text = "Praticien remplacé";
            // 
            // btn_CreerMotif
            // 
            this.btn_CreerMotif.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_CreerMotif.FlatAppearance.BorderSize = 0;
            this.btn_CreerMotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreerMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreerMotif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_CreerMotif.Location = new System.Drawing.Point(117, 278);
            this.btn_CreerMotif.Name = "btn_CreerMotif";
            this.btn_CreerMotif.Size = new System.Drawing.Size(199, 34);
            this.btn_CreerMotif.TabIndex = 36;
            this.btn_CreerMotif.Text = "Ajouter";
            this.btn_CreerMotif.UseVisualStyleBackColor = false;
            this.btn_CreerMotif.Click += new System.EventHandler(this.btn_CreerMotif_Click);
            // 
            // txb_InfoRempl
            // 
            this.txb_InfoRempl.Location = new System.Drawing.Point(22, 192);
            this.txb_InfoRempl.Multiline = true;
            this.txb_InfoRempl.Name = "txb_InfoRempl";
            this.txb_InfoRempl.Size = new System.Drawing.Size(391, 62);
            this.txb_InfoRempl.TabIndex = 35;
            this.txb_InfoRempl.TextChanged += new System.EventHandler(this.txb_descrMotif_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Informations supplémentaire :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker1.TabIndex = 37;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(228, 148);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(161, 20);
            this.dateTimePicker2.TabIndex = 37;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Date début remplacement :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Date fin remplacement :";
            // 
            // Remplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 367);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_CreerMotif);
            this.Controls.Add(this.txb_InfoRempl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pl_remplacent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Remplacement";
            this.Text = "Remplacement";
            this.Load += new System.EventHandler(this.Remplacement_Load);
            this.pl_remplacent.ResumeLayout(false);
            this.pl_remplacent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl_remplacent;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_Rempla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CreerMotif;
        private System.Windows.Forms.TextBox txb_InfoRempl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}