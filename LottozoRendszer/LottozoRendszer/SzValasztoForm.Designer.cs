
namespace LottozoRendszer
{
    partial class SzValasztoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SzValasztoForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_HatosLotto = new System.Windows.Forms.Button();
            this.btn_SkandinavLotto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_OtosLotto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Válassza ki a kitölteni kívánt szelvényt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_HatosLotto
            // 
            this.btn_HatosLotto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_HatosLotto.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HatosLotto.Location = new System.Drawing.Point(33, 248);
            this.btn_HatosLotto.Name = "btn_HatosLotto";
            this.btn_HatosLotto.Size = new System.Drawing.Size(327, 61);
            this.btn_HatosLotto.TabIndex = 2;
            this.btn_HatosLotto.Text = "Hatoslottó";
            this.btn_HatosLotto.UseVisualStyleBackColor = false;
            // 
            // btn_SkandinavLotto
            // 
            this.btn_SkandinavLotto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_SkandinavLotto.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SkandinavLotto.Location = new System.Drawing.Point(33, 327);
            this.btn_SkandinavLotto.Name = "btn_SkandinavLotto";
            this.btn_SkandinavLotto.Size = new System.Drawing.Size(327, 61);
            this.btn_SkandinavLotto.TabIndex = 3;
            this.btn_SkandinavLotto.Text = "Skandináv";
            this.btn_SkandinavLotto.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_OtosLotto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_SkandinavLotto);
            this.panel1.Controls.Add(this.btn_HatosLotto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 409);
            this.panel1.TabIndex = 4;
            // 
            // btn_OtosLotto
            // 
            this.btn_OtosLotto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_OtosLotto.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OtosLotto.Location = new System.Drawing.Point(33, 161);
            this.btn_OtosLotto.Name = "btn_OtosLotto";
            this.btn_OtosLotto.Size = new System.Drawing.Size(327, 61);
            this.btn_OtosLotto.TabIndex = 4;
            this.btn_OtosLotto.Text = "Ötöslottó";
            this.btn_OtosLotto.UseVisualStyleBackColor = false;
            this.btn_OtosLotto.Click += new System.EventHandler(this.btn_OtosLotto_Click);
            // 
            // SzValasztoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 409);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SzValasztoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szelvény választás";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_HatosLotto;
        private System.Windows.Forms.Button btn_SkandinavLotto;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btn_OtosLotto;
    }
}

