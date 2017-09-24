namespace ABSCBN
{
    partial class CashierHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonRegisterCustomer = new System.Windows.Forms.Button();
            this.ButtonLoadCard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2043, 199);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(790, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 181);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonRegisterCustomer
            // 
            this.buttonRegisterCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRegisterCustomer.BackgroundImage")));
            this.buttonRegisterCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRegisterCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegisterCustomer.Location = new System.Drawing.Point(441, 394);
            this.buttonRegisterCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegisterCustomer.Name = "buttonRegisterCustomer";
            this.buttonRegisterCustomer.Size = new System.Drawing.Size(498, 201);
            this.buttonRegisterCustomer.TabIndex = 1;
            this.buttonRegisterCustomer.UseVisualStyleBackColor = true;
            this.buttonRegisterCustomer.Click += new System.EventHandler(this.ButtonRegisterCustomer_Click);
            // 
            // ButtonLoadCard
            // 
            this.ButtonLoadCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLoadCard.BackgroundImage")));
            this.ButtonLoadCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonLoadCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLoadCard.Location = new System.Drawing.Point(1039, 391);
            this.ButtonLoadCard.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonLoadCard.Name = "ButtonLoadCard";
            this.ButtonLoadCard.Size = new System.Drawing.Size(498, 201);
            this.ButtonLoadCard.TabIndex = 2;
            this.ButtonLoadCard.UseVisualStyleBackColor = true;
            this.ButtonLoadCard.Click += new System.EventHandler(this.ButtonLoadCard_Click);
            // 
            // CashierHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1932, 1092);
            this.Controls.Add(this.ButtonLoadCard);
            this.Controls.Add(this.buttonRegisterCustomer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CashierHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonRegisterCustomer;
        private System.Windows.Forms.Button ButtonLoadCard;
    }
}