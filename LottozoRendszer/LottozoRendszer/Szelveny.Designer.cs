namespace LottozoRendszer
{
    partial class Szelveny
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Szelveny));
            this.ujJatekBt = new System.Windows.Forms.Button();
            this.sorsolasBt = new System.Windows.Forms.Button();
            this.valasztottTextLb = new System.Windows.Forms.Label();
            this.nyertesTextLb = new System.Windows.Forms.Label();
            this.valasztottLb = new System.Windows.Forms.Label();
            this.nyertesLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ujJatekBt
            // 
            this.ujJatekBt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ujJatekBt.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.ujJatekBt.Location = new System.Drawing.Point(12, 9);
            this.ujJatekBt.Name = "ujJatekBt";
            this.ujJatekBt.Size = new System.Drawing.Size(190, 61);
            this.ujJatekBt.TabIndex = 0;
            this.ujJatekBt.Text = "Új játék";
            this.ujJatekBt.UseVisualStyleBackColor = false;
            this.ujJatekBt.Click += new System.EventHandler(this.ujJatekBt_Click);
            // 
            // sorsolasBt
            // 
            this.sorsolasBt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sorsolasBt.Font = new System.Drawing.Font("Cooper Black", 16.2F);
            this.sorsolasBt.Location = new System.Drawing.Point(12, 86);
            this.sorsolasBt.Name = "sorsolasBt";
            this.sorsolasBt.Size = new System.Drawing.Size(190, 61);
            this.sorsolasBt.TabIndex = 1;
            this.sorsolasBt.Text = "Sorsolás";
            this.sorsolasBt.UseVisualStyleBackColor = false;
            this.sorsolasBt.Click += new System.EventHandler(this.sorsolasBt_Click);
            // 
            // valasztottTextLb
            // 
            this.valasztottTextLb.AutoSize = true;
            this.valasztottTextLb.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.valasztottTextLb.Location = new System.Drawing.Point(294, 46);
            this.valasztottTextLb.Name = "valasztottTextLb";
            this.valasztottTextLb.Size = new System.Drawing.Size(264, 31);
            this.valasztottTextLb.TabIndex = 3;
            this.valasztottTextLb.Text = "Válaszott számok:";
            // 
            // nyertesTextLb
            // 
            this.nyertesTextLb.AutoSize = true;
            this.nyertesTextLb.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.nyertesTextLb.Location = new System.Drawing.Point(294, 13);
            this.nyertesTextLb.Name = "nyertesTextLb";
            this.nyertesTextLb.Size = new System.Drawing.Size(240, 31);
            this.nyertesTextLb.TabIndex = 4;
            this.nyertesTextLb.Text = "Nyertes számok:";
            // 
            // valasztottLb
            // 
            this.valasztottLb.AutoSize = true;
            this.valasztottLb.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.valasztottLb.Location = new System.Drawing.Point(595, 46);
            this.valasztottLb.Name = "valasztottLb";
            this.valasztottLb.Size = new System.Drawing.Size(0, 31);
            this.valasztottLb.TabIndex = 5;
            // 
            // nyertesLb
            // 
            this.nyertesLb.AutoSize = true;
            this.nyertesLb.Font = new System.Drawing.Font("Cooper Black", 16F);
            this.nyertesLb.Location = new System.Drawing.Point(595, 13);
            this.nyertesLb.Name = "nyertesLb";
            this.nyertesLb.Size = new System.Drawing.Size(0, 31);
            this.nyertesLb.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ujJatekBt);
            this.panel1.Controls.Add(this.sorsolasBt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 610);
            this.panel1.TabIndex = 7;
            // 
            // Szelveny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(953, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nyertesLb);
            this.Controls.Add(this.valasztottLb);
            this.Controls.Add(this.nyertesTextLb);
            this.Controls.Add(this.valasztottTextLb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Szelveny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szelveny";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Szelveny_FormClosing);
            this.Load += new System.EventHandler(this.Szelveny_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ujJatekBt;
        private System.Windows.Forms.Button sorsolasBt;
        private System.Windows.Forms.Label valasztottTextLb;
        private System.Windows.Forms.Label nyertesTextLb;
        private System.Windows.Forms.Label valasztottLb;
        private System.Windows.Forms.Label nyertesLb;
        private System.Windows.Forms.Panel panel1;
    }
}