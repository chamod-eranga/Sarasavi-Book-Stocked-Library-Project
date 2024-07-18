namespace Sarasavi_Book_library
{
    partial class ReservationProcess
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.notify_borrowers_dgv = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.find_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.book_availability_dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.search_books_txt = new System.Windows.Forms.TextBox();
            this.bookid_txt = new System.Windows.Forms.TextBox();
            this.reservebook_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.user_reservation_tp = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notify_borrowers_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_availability_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.user_reservation_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.user_reservation_tp);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(880, 621);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.notify_borrowers_dgv);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.find_btn);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.book_availability_dgv);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(872, 595);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Admin Reservation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(476, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Notify Borrowers";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Book Availability";
            // 
            // notify_borrowers_dgv
            // 
            this.notify_borrowers_dgv.AllowUserToAddRows = false;
            this.notify_borrowers_dgv.AllowUserToDeleteRows = false;
            this.notify_borrowers_dgv.BackgroundColor = System.Drawing.Color.White;
            this.notify_borrowers_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.notify_borrowers_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notify_borrowers_dgv.Location = new System.Drawing.Point(479, 266);
            this.notify_borrowers_dgv.Name = "notify_borrowers_dgv";
            this.notify_borrowers_dgv.ReadOnly = true;
            this.notify_borrowers_dgv.Size = new System.Drawing.Size(378, 287);
            this.notify_borrowers_dgv.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "Available",
            "Not Available"});
            this.comboBox1.Location = new System.Drawing.Point(194, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // find_btn
            // 
            this.find_btn.BackColor = System.Drawing.Color.Pink;
            this.find_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.find_btn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.find_btn.Location = new System.Drawing.Point(628, 79);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(81, 28);
            this.find_btn.TabIndex = 18;
            this.find_btn.Text = "Find";
            this.find_btn.UseVisualStyleBackColor = false;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Availability";
            // 
            // book_availability_dgv
            // 
            this.book_availability_dgv.BackgroundColor = System.Drawing.Color.White;
            this.book_availability_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.book_availability_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_availability_dgv.Location = new System.Drawing.Point(15, 266);
            this.book_availability_dgv.Name = "book_availability_dgv";
            this.book_availability_dgv.Size = new System.Drawing.Size(449, 287);
            this.book_availability_dgv.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label1.Location = new System.Drawing.Point(334, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label2.Location = new System.Drawing.Point(332, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Reservation";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(105, 266);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(642, 301);
            this.dataGridView2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search Books";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Book ID";
            // 
            // search_books_txt
            // 
            this.search_books_txt.Location = new System.Drawing.Point(188, 114);
            this.search_books_txt.Name = "search_books_txt";
            this.search_books_txt.Size = new System.Drawing.Size(169, 20);
            this.search_books_txt.TabIndex = 11;
            this.search_books_txt.TextChanged += new System.EventHandler(this.search_books_txt_TextChanged);
            // 
            // bookid_txt
            // 
            this.bookid_txt.Location = new System.Drawing.Point(535, 154);
            this.bookid_txt.Name = "bookid_txt";
            this.bookid_txt.Size = new System.Drawing.Size(166, 20);
            this.bookid_txt.TabIndex = 12;
            // 
            // reservebook_btn
            // 
            this.reservebook_btn.BackColor = System.Drawing.Color.Pink;
            this.reservebook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reservebook_btn.Location = new System.Drawing.Point(716, 204);
            this.reservebook_btn.Name = "reservebook_btn";
            this.reservebook_btn.Size = new System.Drawing.Size(85, 34);
            this.reservebook_btn.TabIndex = 14;
            this.reservebook_btn.Text = "Reserve Book";
            this.reservebook_btn.UseVisualStyleBackColor = false;
            this.reservebook_btn.Click += new System.EventHandler(this.reservebook_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Username";
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(535, 108);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(166, 20);
            this.username_txt.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(447, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Date of borrowing the book";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(450, 218);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(447, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Any book can be kept for a week.";
            // 
            // user_reservation_tp
            // 
            this.user_reservation_tp.Controls.Add(this.label6);
            this.user_reservation_tp.Controls.Add(this.dateTimePicker1);
            this.user_reservation_tp.Controls.Add(this.label11);
            this.user_reservation_tp.Controls.Add(this.username_txt);
            this.user_reservation_tp.Controls.Add(this.label7);
            this.user_reservation_tp.Controls.Add(this.reservebook_btn);
            this.user_reservation_tp.Controls.Add(this.bookid_txt);
            this.user_reservation_tp.Controls.Add(this.search_books_txt);
            this.user_reservation_tp.Controls.Add(this.label4);
            this.user_reservation_tp.Controls.Add(this.label3);
            this.user_reservation_tp.Controls.Add(this.dataGridView2);
            this.user_reservation_tp.Controls.Add(this.label2);
            this.user_reservation_tp.Location = new System.Drawing.Point(4, 22);
            this.user_reservation_tp.Name = "user_reservation_tp";
            this.user_reservation_tp.Padding = new System.Windows.Forms.Padding(3);
            this.user_reservation_tp.Size = new System.Drawing.Size(872, 595);
            this.user_reservation_tp.TabIndex = 1;
            this.user_reservation_tp.Text = "User Reservation";
            this.user_reservation_tp.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "outstanding reservation";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(479, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(378, 120);
            this.dataGridView1.TabIndex = 27;
            // 
            // ReservationProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 645);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationProcess";
            this.Text = "ReservationProcess";
            this.Load += new System.EventHandler(this.ReservationProcess_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notify_borrowers_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_availability_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.user_reservation_tp.ResumeLayout(false);
            this.user_reservation_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView book_availability_dgv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView notify_borrowers_dgv;
        private System.Windows.Forms.TabPage user_reservation_tp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button reservebook_btn;
        private System.Windows.Forms.TextBox bookid_txt;
        private System.Windows.Forms.TextBox search_books_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}