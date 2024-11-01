namespace PictureboxForm
{
    partial class frControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frControl));
            this.btn_StratGame = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Palyers = new DevExpress.XtraEditors.LabelControl();
            this.lbl_Winner = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btn_StratGame
            // 
            this.btn_StratGame.AutoSize = true;
            this.btn_StratGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_StratGame.BackColor = System.Drawing.Color.White;
            this.btn_StratGame.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_StratGame.FlatAppearance.BorderSize = 0;
            this.btn_StratGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_StratGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_StratGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StratGame.Font = new System.Drawing.Font("Algerian", 13F);
            this.btn_StratGame.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_StratGame.Location = new System.Drawing.Point(498, 268);
            this.btn_StratGame.Name = "btn_StratGame";
            this.btn_StratGame.Size = new System.Drawing.Size(192, 39);
            this.btn_StratGame.TabIndex = 1;
            this.btn_StratGame.Text = "START ROUND";
            this.btn_StratGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_StratGame.UseVisualStyleBackColor = false;
            this.btn_StratGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.LineColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(234, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(321, 66);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tic Tak To";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseBackColor = true;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.LineColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(38, 342);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(80, 38);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Turn";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseBackColor = true;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.LineColor = System.Drawing.Color.Transparent;
            this.labelControl3.Location = new System.Drawing.Point(38, 172);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(120, 38);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Winner";
            // 
            // lbl_Palyers
            // 
            this.lbl_Palyers.Appearance.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Palyers.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_Palyers.Appearance.Options.UseFont = true;
            this.lbl_Palyers.Appearance.Options.UseForeColor = true;
            this.lbl_Palyers.Location = new System.Drawing.Point(38, 388);
            this.lbl_Palyers.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_Palyers.Name = "lbl_Palyers";
            this.lbl_Palyers.Size = new System.Drawing.Size(0, 38);
            this.lbl_Palyers.TabIndex = 5;
            // 
            // lbl_Winner
            // 
            this.lbl_Winner.Appearance.Font = new System.Drawing.Font("Bookman Old Style", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_Winner.Appearance.ForeColor = System.Drawing.Color.Orange;
            this.lbl_Winner.Appearance.Options.UseFont = true;
            this.lbl_Winner.Appearance.Options.UseForeColor = true;
            this.lbl_Winner.Location = new System.Drawing.Point(38, 255);
            this.lbl_Winner.Margin = new System.Windows.Forms.Padding(4);
            this.lbl_Winner.Name = "lbl_Winner";
            this.lbl_Winner.Size = new System.Drawing.Size(0, 38);
            this.lbl_Winner.TabIndex = 6;
            // 
            // frControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::PictureboxForm.Properties.Resources.istockphoto_1824559459_1024x1024;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(833, 517);
            this.Controls.Add(this.lbl_Winner);
            this.Controls.Add(this.lbl_Palyers);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_StratGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frControl";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btn_StratGame;
        public DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.LabelControl lbl_Palyers;
        public DevExpress.XtraEditors.LabelControl lbl_Winner;
    }
}