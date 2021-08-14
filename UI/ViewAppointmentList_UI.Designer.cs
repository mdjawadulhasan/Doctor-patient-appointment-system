
namespace HMA
{
    partial class ViewAppointmentList_UI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAppointmentList_UI));
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LogoutPicbox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TreatPicbox = new System.Windows.Forms.PictureBox();
            this.Doctorlb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DrAptList = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.dltlb = new System.Windows.Forms.Label();
            this.printBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPicbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreatPicbox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrAptList)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Teal;
            this.pictureBox4.Image = global::HMA.Properties.Resources.L;
            this.pictureBox4.Location = new System.Drawing.Point(39, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(101, 101);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(82, 659);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Logout";
            // 
            // LogoutPicbox
            // 
            this.LogoutPicbox.Image = global::HMA.Properties.Resources.logout;
            this.LogoutPicbox.Location = new System.Drawing.Point(21, 633);
            this.LogoutPicbox.Name = "LogoutPicbox";
            this.LogoutPicbox.Size = new System.Drawing.Size(48, 67);
            this.LogoutPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoutPicbox.TabIndex = 13;
            this.LogoutPicbox.TabStop = false;
            this.LogoutPicbox.Click += new System.EventHandler(this.LogoutPicbox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(83, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 44);
            this.label5.TabIndex = 10;
            this.label5.Text = "Give \r\nTreatment";
            // 
            // TreatPicbox
            // 
            this.TreatPicbox.Image = global::HMA.Properties.Resources.prescription;
            this.TreatPicbox.Location = new System.Drawing.Point(21, 334);
            this.TreatPicbox.Name = "TreatPicbox";
            this.TreatPicbox.Size = new System.Drawing.Size(48, 74);
            this.TreatPicbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TreatPicbox.TabIndex = 9;
            this.TreatPicbox.TabStop = false;
            this.TreatPicbox.Click += new System.EventHandler(this.TreatPicbox_Click);
            // 
            // Doctorlb
            // 
            this.Doctorlb.AutoSize = true;
            this.Doctorlb.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doctorlb.ForeColor = System.Drawing.Color.White;
            this.Doctorlb.Location = new System.Drawing.Point(46, 132);
            this.Doctorlb.Name = "Doctorlb";
            this.Doctorlb.Size = new System.Drawing.Size(83, 25);
            this.Doctorlb.TabIndex = 4;
            this.Doctorlb.Text = "Doctor";
            this.Doctorlb.Click += new System.EventHandler(this.Doctorlb_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.LogoutPicbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TreatPicbox);
            this.panel1.Controls.Add(this.Doctorlb);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 754);
            this.panel1.TabIndex = 186;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Lime;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::HMA.Properties.Resources.v870_tang_36;
            this.pictureBox2.Location = new System.Drawing.Point(195, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1381, 751);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 184;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(605, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 23);
            this.label12.TabIndex = 214;
            this.label12.Text = "Appointment List";
            // 
            // DrAptList
            // 
            this.DrAptList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DrAptList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DrAptList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DrAptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DrAptList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DrAptList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DrAptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrAptList.EnableHeadersVisualStyles = false;
            this.DrAptList.GridColor = System.Drawing.Color.MidnightBlue;
            this.DrAptList.Location = new System.Drawing.Point(275, 206);
            this.DrAptList.Name = "DrAptList";
            this.DrAptList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DrAptList.RowHeadersVisible = false;
            this.DrAptList.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.DrAptList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DrAptList.RowTemplate.Height = 24;
            this.DrAptList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DrAptList.Size = new System.Drawing.Size(867, 327);
            this.DrAptList.TabIndex = 213;
            this.DrAptList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DrAptList_CellContentClick);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Teal;
            this.DeleteBtn.FlatAppearance.BorderSize = 2;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(972, 550);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(170, 48);
            this.DeleteBtn.TabIndex = 216;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // dltlb
            // 
            this.dltlb.AutoSize = true;
            this.dltlb.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltlb.ForeColor = System.Drawing.Color.White;
            this.dltlb.Location = new System.Drawing.Point(928, 132);
            this.dltlb.Name = "dltlb";
            this.dltlb.Size = new System.Drawing.Size(48, 25);
            this.dltlb.TabIndex = 217;
            this.dltlb.Text = "See";
            this.dltlb.Visible = false;
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.Navy;
            this.printBtn.FlatAppearance.BorderSize = 2;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(654, 677);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(119, 48);
            this.printBtn.TabIndex = 218;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ViewAppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 746);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.dltlb);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DrAptList);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAppointmentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewAppointmentList";
            this.Load += new System.EventHandler(this.ViewAppointmentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoutPicbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TreatPicbox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrAptList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox LogoutPicbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox TreatPicbox;
        private System.Windows.Forms.Label Doctorlb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DrAptList;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label dltlb;
        private System.Windows.Forms.Button printBtn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}