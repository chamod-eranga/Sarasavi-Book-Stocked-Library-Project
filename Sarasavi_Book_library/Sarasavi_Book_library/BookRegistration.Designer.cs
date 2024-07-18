namespace Sarasavi_Book_library
{
    partial class BookRegistration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.classification_cmb = new System.Windows.Forms.ComboBox();
            this.title_txt = new System.Windows.Forms.TextBox();
            this.publisher_txt = new System.Windows.Forms.TextBox();
            this.borrowable_status_cmb = new System.Windows.Forms.ComboBox();
            this.bookcopies_txt = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bookID_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(332, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Classification :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Title :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Publisher :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Borrowable Status :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Number of Book Copies :";
            // 
            // classification_cmb
            // 
            this.classification_cmb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classification_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classification_cmb.FormattingEnabled = true;
            this.classification_cmb.Items.AddRange(new object[] {
            "",
            "Adventure",
            "History and Politics",
            "Novels",
            "Drama",
            "Short stories"});
            this.classification_cmb.Location = new System.Drawing.Point(226, 211);
            this.classification_cmb.Name = "classification_cmb";
            this.classification_cmb.Size = new System.Drawing.Size(197, 21);
            this.classification_cmb.TabIndex = 12;
            // 
            // title_txt
            // 
            this.title_txt.Location = new System.Drawing.Point(226, 267);
            this.title_txt.Name = "title_txt";
            this.title_txt.Size = new System.Drawing.Size(197, 20);
            this.title_txt.TabIndex = 13;
            // 
            // publisher_txt
            // 
            this.publisher_txt.Location = new System.Drawing.Point(226, 324);
            this.publisher_txt.Name = "publisher_txt";
            this.publisher_txt.Size = new System.Drawing.Size(197, 20);
            this.publisher_txt.TabIndex = 14;
            // 
            // borrowable_status_cmb
            // 
            this.borrowable_status_cmb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowable_status_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.borrowable_status_cmb.FormattingEnabled = true;
            this.borrowable_status_cmb.Items.AddRange(new object[] {
            "",
            "Available",
            "Not available"});
            this.borrowable_status_cmb.Location = new System.Drawing.Point(226, 378);
            this.borrowable_status_cmb.Name = "borrowable_status_cmb";
            this.borrowable_status_cmb.Size = new System.Drawing.Size(197, 21);
            this.borrowable_status_cmb.TabIndex = 15;
            // 
            // bookcopies_txt
            // 
            this.bookcopies_txt.Location = new System.Drawing.Point(226, 434);
            this.bookcopies_txt.Name = "bookcopies_txt";
            this.bookcopies_txt.Size = new System.Drawing.Size(197, 20);
            this.bookcopies_txt.TabIndex = 16;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.PaleGreen;
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_btn.Location = new System.Drawing.Point(341, 480);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(82, 29);
            this.update_btn.TabIndex = 19;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Location = new System.Drawing.Point(226, 515);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(197, 29);
            this.delete_btn.TabIndex = 18;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Location = new System.Drawing.Point(226, 480);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(109, 29);
            this.add_btn.TabIndex = 17;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(465, 165);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(412, 224);
            this.dataGridView3.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(461, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Registered books";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(223, 563);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "everything can be done when entering \"Book ID\".)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(223, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "(To change and delete this settled user data, ";
            // 
            // bookID_txt
            // 
            this.bookID_txt.Location = new System.Drawing.Point(226, 163);
            this.bookID_txt.Name = "bookID_txt";
            this.bookID_txt.Size = new System.Drawing.Size(197, 20);
            this.bookID_txt.TabIndex = 25;
            this.bookID_txt.TextChanged += new System.EventHandler(this.bookID_txt_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Book ID";
            // 
            // BookRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 645);
            this.Controls.Add(this.bookID_txt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.bookcopies_txt);
            this.Controls.Add(this.borrowable_status_cmb);
            this.Controls.Add(this.publisher_txt);
            this.Controls.Add(this.title_txt);
            this.Controls.Add(this.classification_cmb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookRegistration";
            this.Text = "BookRegistration";
            this.Load += new System.EventHandler(this.BookRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox classification_cmb;
        private System.Windows.Forms.TextBox title_txt;
        private System.Windows.Forms.TextBox publisher_txt;
        private System.Windows.Forms.ComboBox borrowable_status_cmb;
        private System.Windows.Forms.TextBox bookcopies_txt;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bookID_txt;
        private System.Windows.Forms.Label label10;
    }
}