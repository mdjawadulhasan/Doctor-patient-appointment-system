
namespace HMA
{
    partial class loginorsignup_UI
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
            this.signupbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rolecb = new System.Windows.Forms.ComboBox();
            this.adminlb = new System.Windows.Forms.Label();
            this.Exitpicbox = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Exitpicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // signupbtn
            // 
            this.signupbtn.BackColor = System.Drawing.Color.Teal;
            this.signupbtn.FlatAppearance.BorderSize = 2;
            this.signupbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupbtn.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.ForeColor = System.Drawing.Color.White;
            this.signupbtn.Location = new System.Drawing.Point(176, 399);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(478, 55);
            this.signupbtn.TabIndex = 19;
            this.signupbtn.Text = "SIGN UP";
            this.signupbtn.UseVisualStyleBackColor = false;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Teal;
            this.loginbtn.FlatAppearance.BorderSize = 2;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbtn.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.White;
            this.loginbtn.Location = new System.Drawing.Point(176, 329);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(478, 47);
            this.loginbtn.TabIndex = 18;
            this.loginbtn.Text = "LOG IN";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(393, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 43);
            this.label2.TabIndex = 17;
            this.label2.Text = "Join us Today .";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(268, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 89);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome !";
            // 
            // rolecb
            // 
            this.rolecb.BackColor = System.Drawing.Color.Teal;
            this.rolecb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolecb.ForeColor = System.Drawing.Color.White;
            this.rolecb.FormattingEnabled = true;
            this.rolecb.Items.AddRange(new object[] {
            "Patient",
            "Doctor"});
            this.rolecb.Location = new System.Drawing.Point(524, 285);
            this.rolecb.Name = "rolecb";
            this.rolecb.Size = new System.Drawing.Size(130, 30);
            this.rolecb.TabIndex = 23;
            this.rolecb.Text = "Select Role";
            // 
            // adminlb
            // 
            this.adminlb.AutoSize = true;
            this.adminlb.Font = new System.Drawing.Font("NSimSun", 15.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.adminlb.Location = new System.Drawing.Point(379, 470);
            this.adminlb.Name = "adminlb";
            this.adminlb.Size = new System.Drawing.Size(87, 27);
            this.adminlb.TabIndex = 24;
            this.adminlb.Text = "Admin";
            this.adminlb.Click += new System.EventHandler(this.adminlb_Click);
            // 
            // Exitpicbox
            // 
            this.Exitpicbox.BackColor = System.Drawing.Color.White;
            this.Exitpicbox.Image = global::HMA.Properties.Resources.cancel;
            this.Exitpicbox.Location = new System.Drawing.Point(902, 1);
            this.Exitpicbox.Name = "Exitpicbox";
            this.Exitpicbox.Size = new System.Drawing.Size(71, 56);
            this.Exitpicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exitpicbox.TabIndex = 25;
            this.Exitpicbox.TabStop = false;
            this.Exitpicbox.Click += new System.EventHandler(this.Exitpicbox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::HMA.Properties.Resources.L;
            this.pictureBox4.Location = new System.Drawing.Point(97, 84);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(176, 121);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HMA.Properties.Resources.see;
            this.pictureBox2.Location = new System.Drawing.Point(1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(972, 573);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // loginorsignup_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 574);
            this.Controls.Add(this.Exitpicbox);
            this.Controls.Add(this.adminlb);
            this.Controls.Add(this.rolecb);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginorsignup_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.loginorsignup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Exitpicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button signupbtn;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox rolecb;
        private System.Windows.Forms.Label adminlb;
        private System.Windows.Forms.PictureBox Exitpicbox;
    }
}