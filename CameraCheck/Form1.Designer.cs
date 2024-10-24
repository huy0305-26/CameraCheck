namespace CameraCheck
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCamera = new System.Windows.Forms.ComboBox();
            this.ptbIMG = new System.Windows.Forms.PictureBox();
            this.txtQR = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Notification = new System.Windows.Forms.Label();
            this.bButton2 = new CustomControls.RJControls.bButton();
            this.bButton1 = new CustomControls.RJControls.bButton();
            this.btStop = new CustomControls.RJControls.bButton();
            this.btStart = new CustomControls.RJControls.bButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm danh tự động";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Camera";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbCamera
            // 
            this.cbCamera.FormattingEnabled = true;
            this.cbCamera.Location = new System.Drawing.Point(192, 408);
            this.cbCamera.Name = "cbCamera";
            this.cbCamera.Size = new System.Drawing.Size(238, 24);
            this.cbCamera.TabIndex = 2;
            this.cbCamera.SelectedIndexChanged += new System.EventHandler(this.cbCamera_SelectedIndexChanged);
            // 
            // ptbIMG
            // 
            this.ptbIMG.BackColor = System.Drawing.SystemColors.Control;
            this.ptbIMG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbIMG.BackgroundImage")));
            this.ptbIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbIMG.Location = new System.Drawing.Point(53, 46);
            this.ptbIMG.Name = "ptbIMG";
            this.ptbIMG.Size = new System.Drawing.Size(377, 359);
            this.ptbIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbIMG.TabIndex = 3;
            this.ptbIMG.TabStop = false;
            this.ptbIMG.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtQR
            // 
            this.txtQR.Location = new System.Drawing.Point(436, 46);
            this.txtQR.Multiline = true;
            this.txtQR.Name = "txtQR";
            this.txtQR.Size = new System.Drawing.Size(315, 359);
            this.txtQR.TabIndex = 8;
            this.txtQR.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Danh sách điểm danh";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Notification
            // 
            this.Notification.AutoSize = true;
            this.Notification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notification.Location = new System.Drawing.Point(436, 412);
            this.Notification.Name = "Notification";
            this.Notification.Size = new System.Drawing.Size(93, 20);
            this.Notification.TabIndex = 10;
            this.Notification.Text = "Notification";
            this.Notification.Click += new System.EventHandler(this.Notification_Click);
            // 
            // bButton2
            // 
            this.bButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(218)))), ((int)(((byte)(216)))));
            this.bButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(218)))), ((int)(((byte)(216)))));
            this.bButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bButton2.BorderRadius = 20;
            this.bButton2.BorderSize = 0;
            this.bButton2.FlatAppearance.BorderSize = 0;
            this.bButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bButton2.ForeColor = System.Drawing.Color.Black;
            this.bButton2.Location = new System.Drawing.Point(264, 521);
            this.bButton2.Name = "bButton2";
            this.bButton2.Size = new System.Drawing.Size(166, 54);
            this.bButton2.TabIndex = 15;
            this.bButton2.Text = "null";
            this.bButton2.TextColor = System.Drawing.Color.Black;
            this.bButton2.UseVisualStyleBackColor = false;
            this.bButton2.Click += new System.EventHandler(this.bButton2_Click);
            // 
            // bButton1
            // 
            this.bButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(218)))), ((int)(((byte)(216)))));
            this.bButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(218)))), ((int)(((byte)(216)))));
            this.bButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bButton1.BorderRadius = 20;
            this.bButton1.BorderSize = 0;
            this.bButton1.FlatAppearance.BorderSize = 0;
            this.bButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bButton1.ForeColor = System.Drawing.Color.Black;
            this.bButton1.Location = new System.Drawing.Point(53, 521);
            this.bButton1.Name = "bButton1";
            this.bButton1.Size = new System.Drawing.Size(166, 54);
            this.bButton1.TabIndex = 14;
            this.bButton1.Text = "null";
            this.bButton1.TextColor = System.Drawing.Color.Black;
            this.bButton1.UseVisualStyleBackColor = false;
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(218)))), ((int)(((byte)(216)))));
            this.btStop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(218)))), ((int)(((byte)(216)))));
            this.btStop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btStop.BorderRadius = 20;
            this.btStop.BorderSize = 0;
            this.btStop.FlatAppearance.BorderSize = 0;
            this.btStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStop.ForeColor = System.Drawing.Color.Black;
            this.btStop.Location = new System.Drawing.Point(264, 452);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(166, 54);
            this.btStop.TabIndex = 13;
            this.btStop.Text = "Kết thúc điểm danh";
            this.btStop.TextColor = System.Drawing.Color.Black;
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click_1);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(218)))), ((int)(((byte)(216)))));
            this.btStart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(218)))), ((int)(((byte)(216)))));
            this.btStart.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btStart.BorderRadius = 20;
            this.btStart.BorderSize = 0;
            this.btStart.FlatAppearance.BorderSize = 0;
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.ForeColor = System.Drawing.Color.Black;
            this.btStart.Location = new System.Drawing.Point(53, 452);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(166, 54);
            this.btStart.TabIndex = 12;
            this.btStart.Text = "Bắt đầu điểm danh";
            this.btStart.TextColor = System.Drawing.Color.Black;
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 593);
            this.Controls.Add(this.bButton2);
            this.Controls.Add(this.bButton1);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.Notification);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQR);
            this.Controls.Add(this.ptbIMG);
            this.Controls.Add(this.cbCamera);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Điểm danh tự động";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCamera;
        private System.Windows.Forms.PictureBox ptbIMG;
        private System.Windows.Forms.TextBox txtQR;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Notification;
        private CustomControls.RJControls.bButton btStart;
        private CustomControls.RJControls.bButton btStop;
        private CustomControls.RJControls.bButton bButton1;
        private CustomControls.RJControls.bButton bButton2;
    }
}

