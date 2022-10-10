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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.valasztottTextLb = new System.Windows.Forms.Label();
            this.nyertesTextLb = new System.Windows.Forms.Label();
            this.valasztottLb = new System.Windows.Forms.Label();
            this.nyertesLb = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ujJatekBt
            // 
            this.ujJatekBt.Location = new System.Drawing.Point(3, 3);
            this.ujJatekBt.Name = "ujJatekBt";
            this.ujJatekBt.Size = new System.Drawing.Size(75, 29);
            this.ujJatekBt.TabIndex = 0;
            this.ujJatekBt.Text = "Új játék";
            this.ujJatekBt.UseVisualStyleBackColor = true;
            this.ujJatekBt.Click += new System.EventHandler(this.ujJatekBt_Click);
            // 
            // sorsolasBt
            // 
            this.sorsolasBt.Location = new System.Drawing.Point(84, 3);
            this.sorsolasBt.Name = "sorsolasBt";
            this.sorsolasBt.Size = new System.Drawing.Size(75, 23);
            this.sorsolasBt.TabIndex = 1;
            this.sorsolasBt.Text = "Sorsolás";
            this.sorsolasBt.UseVisualStyleBackColor = true;
            this.sorsolasBt.Click += new System.EventHandler(this.sorsolasBt_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ujJatekBt);
            this.flowLayoutPanel1.Controls.Add(this.sorsolasBt);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(196, 586);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // valasztottTextLb
            // 
            this.valasztottTextLb.AutoSize = true;
            this.valasztottTextLb.Location = new System.Drawing.Point(294, 44);
            this.valasztottTextLb.Name = "valasztottTextLb";
            this.valasztottTextLb.Size = new System.Drawing.Size(112, 16);
            this.valasztottTextLb.TabIndex = 3;
            this.valasztottTextLb.Text = "Válaszott számok";
            // 
            // nyertesTextLb
            // 
            this.nyertesTextLb.AutoSize = true;
            this.nyertesTextLb.Location = new System.Drawing.Point(302, 12);
            this.nyertesTextLb.Name = "nyertesTextLb";
            this.nyertesTextLb.Size = new System.Drawing.Size(104, 16);
            this.nyertesTextLb.TabIndex = 4;
            this.nyertesTextLb.Text = "Nyertes számok";
            // 
            // valasztottLb
            // 
            this.valasztottLb.AutoSize = true;
            this.valasztottLb.Location = new System.Drawing.Point(412, 44);
            this.valasztottLb.Name = "valasztottLb";
            this.valasztottLb.Size = new System.Drawing.Size(79, 16);
            this.valasztottLb.TabIndex = 5;
            this.valasztottLb.Text = "placeholder";
            // 
            // nyertesLb
            // 
            this.nyertesLb.AutoSize = true;
            this.nyertesLb.Location = new System.Drawing.Point(412, 12);
            this.nyertesLb.Name = "nyertesLb";
            this.nyertesLb.Size = new System.Drawing.Size(79, 16);
            this.nyertesLb.TabIndex = 6;
            this.nyertesLb.Text = "placeholder";
            // 
            // Szelveny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(953, 610);
            this.Controls.Add(this.nyertesLb);
            this.Controls.Add(this.valasztottLb);
            this.Controls.Add(this.nyertesTextLb);
            this.Controls.Add(this.valasztottTextLb);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Szelveny";
            this.Text = "Szelveny";
            this.Load += new System.EventHandler(this.Szelveny_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ujJatekBt;
        private System.Windows.Forms.Button sorsolasBt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label valasztottTextLb;
        private System.Windows.Forms.Label nyertesTextLb;
        private System.Windows.Forms.Label valasztottLb;
        private System.Windows.Forms.Label nyertesLb;
    }
}