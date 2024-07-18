namespace Sarasavi_Book_library
{
    partial class home_page
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.loan_return_btn = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dash_btn = new System.Windows.Forms.Button();
            this.reservation_btn = new System.Windows.Forms.Button();
            this.sl_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.inquiry_btn = new System.Windows.Forms.Button();
            this.book_rej_btn = new System.Windows.Forms.Button();
            this.user_rej_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.minimize_lbl = new System.Windows.Forms.Label();
            this.close_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loadpanel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightPink;
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.loan_return_btn);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dash_btn);
            this.panel1.Controls.Add(this.reservation_btn);
            this.panel1.Controls.Add(this.sl_lbl);
            this.panel1.Controls.Add(this.date_lbl);
            this.panel1.Controls.Add(this.time_lbl);
            this.panel1.Controls.Add(this.inquiry_btn);
            this.panel1.Controls.Add(this.book_rej_btn);
            this.panel1.Controls.Add(this.user_rej_btn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 683);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // loan_return_btn
            // 
            this.loan_return_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loan_return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loan_return_btn.Location = new System.Drawing.Point(83, 247);
            this.loan_return_btn.Name = "loan_return_btn";
            this.loan_return_btn.Size = new System.Drawing.Size(203, 45);
            this.loan_return_btn.TabIndex = 18;
            this.loan_return_btn.Text = "Loan Process / Return Process";
            this.loan_return_btn.UseVisualStyleBackColor = true;
            this.loan_return_btn.Click += new System.EventHandler(this.loan_return_btn_Click_1);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Sarasavi_Book_library.Properties.Resources.user;
            this.pictureBox7.Location = new System.Drawing.Point(45, 532);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(31, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Sarasavi_Book_library.Properties.Resources.book;
            this.pictureBox6.Location = new System.Drawing.Point(45, 462);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Sarasavi_Book_library.Properties.Resources.inquiry;
            this.pictureBox5.Location = new System.Drawing.Point(45, 392);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(31, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Sarasavi_Book_library.Properties.Resources.reservation;
            this.pictureBox4.Location = new System.Drawing.Point(45, 323);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(31, 33);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Sarasavi_Book_library.Properties.Resources.loan;
            this.pictureBox2.Location = new System.Drawing.Point(45, 254);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sarasavi_Book_library.Properties.Resources.homepage;
            this.pictureBox1.Location = new System.Drawing.Point(44, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // dash_btn
            // 
            this.dash_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dash_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dash_btn.Location = new System.Drawing.Point(83, 179);
            this.dash_btn.Name = "dash_btn";
            this.dash_btn.Size = new System.Drawing.Size(203, 45);
            this.dash_btn.TabIndex = 10;
            this.dash_btn.Text = "Dashboard";
            this.dash_btn.UseVisualStyleBackColor = true;
            this.dash_btn.Click += new System.EventHandler(this.dash_btn_Click);
            // 
            // reservation_btn
            // 
            this.reservation_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservation_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reservation_btn.Location = new System.Drawing.Point(83, 317);
            this.reservation_btn.Name = "reservation_btn";
            this.reservation_btn.Size = new System.Drawing.Size(203, 45);
            this.reservation_btn.TabIndex = 9;
            this.reservation_btn.Text = "Reservation Process";
            this.reservation_btn.UseVisualStyleBackColor = true;
            this.reservation_btn.Click += new System.EventHandler(this.reservation_btn_Click);
            // 
            // sl_lbl
            // 
            this.sl_lbl.AutoSize = true;
            this.sl_lbl.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_lbl.Location = new System.Drawing.Point(42, 32);
            this.sl_lbl.Name = "sl_lbl";
            this.sl_lbl.Size = new System.Drawing.Size(226, 33);
            this.sl_lbl.TabIndex = 7;
            this.sl_lbl.Text = "Sarasavi library";
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbl.Location = new System.Drawing.Point(44, 125);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(38, 19);
            this.date_lbl.TabIndex = 8;
            this.date_lbl.Text = "Date";
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.Location = new System.Drawing.Point(43, 89);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(60, 27);
            this.time_lbl.TabIndex = 7;
            this.time_lbl.Text = "Time";
            // 
            // inquiry_btn
            // 
            this.inquiry_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inquiry_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inquiry_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inquiry_btn.Location = new System.Drawing.Point(83, 386);
            this.inquiry_btn.Name = "inquiry_btn";
            this.inquiry_btn.Size = new System.Drawing.Size(203, 45);
            this.inquiry_btn.TabIndex = 6;
            this.inquiry_btn.Text = "Inquiry Process";
            this.inquiry_btn.UseVisualStyleBackColor = true;
            this.inquiry_btn.Click += new System.EventHandler(this.inquiry_btn_Click);
            // 
            // book_rej_btn
            // 
            this.book_rej_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.book_rej_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book_rej_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.book_rej_btn.Location = new System.Drawing.Point(83, 456);
            this.book_rej_btn.Name = "book_rej_btn";
            this.book_rej_btn.Size = new System.Drawing.Size(203, 45);
            this.book_rej_btn.TabIndex = 5;
            this.book_rej_btn.Text = "Book Registration";
            this.book_rej_btn.UseVisualStyleBackColor = true;
            this.book_rej_btn.Click += new System.EventHandler(this.book_rej_btn_Click);
            // 
            // user_rej_btn
            // 
            this.user_rej_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_rej_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_rej_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.user_rej_btn.Location = new System.Drawing.Point(83, 526);
            this.user_rej_btn.Name = "user_rej_btn";
            this.user_rej_btn.Size = new System.Drawing.Size(203, 45);
            this.user_rej_btn.TabIndex = 4;
            this.user_rej_btn.Text = "User Registration";
            this.user_rej_btn.UseVisualStyleBackColor = true;
            this.user_rej_btn.Click += new System.EventHandler(this.user_rej_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.minimize_lbl);
            this.panel3.Controls.Add(this.close_lbl);
            this.panel3.Location = new System.Drawing.Point(308, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 38);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // minimize_lbl
            // 
            this.minimize_lbl.AutoSize = true;
            this.minimize_lbl.BackColor = System.Drawing.Color.Transparent;
            this.minimize_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_lbl.Location = new System.Drawing.Point(834, 2);
            this.minimize_lbl.Name = "minimize_lbl";
            this.minimize_lbl.Size = new System.Drawing.Size(25, 33);
            this.minimize_lbl.TabIndex = 0;
            this.minimize_lbl.Text = "-";
            this.minimize_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // close_lbl
            // 
            this.close_lbl.AutoSize = true;
            this.close_lbl.BackColor = System.Drawing.Color.Transparent;
            this.close_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_lbl.Location = new System.Drawing.Point(870, 3);
            this.close_lbl.Name = "close_lbl";
            this.close_lbl.Size = new System.Drawing.Size(32, 33);
            this.close_lbl.TabIndex = 1;
            this.close_lbl.Text = "×";
            this.close_lbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loadpanel2
            // 
            this.loadpanel2.BackColor = System.Drawing.Color.White;
            this.loadpanel2.Location = new System.Drawing.Point(308, 38);
            this.loadpanel2.Name = "loadpanel2";
            this.loadpanel2.Size = new System.Drawing.Size(904, 645);
            this.loadpanel2.TabIndex = 3;
            // 
            // logout_btn
            // 
            this.logout_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout_btn.Location = new System.Drawing.Point(83, 597);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(203, 36);
            this.logout_btn.TabIndex = 19;
            this.logout_btn.Text = "LogOut";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 683);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loadpanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_page";
            this.Load += new System.EventHandler(this.home_page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label minimize_lbl;
        private System.Windows.Forms.Label close_lbl;
        private System.Windows.Forms.Button inquiry_btn;
        private System.Windows.Forms.Button book_rej_btn;
        private System.Windows.Forms.Button user_rej_btn;
        private System.Windows.Forms.Label sl_lbl;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button reservation_btn;
        private System.Windows.Forms.Panel loadpanel2;
        private System.Windows.Forms.Button dash_btn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button loan_return_btn;
        private System.Windows.Forms.Button logout_btn;
    }
}

