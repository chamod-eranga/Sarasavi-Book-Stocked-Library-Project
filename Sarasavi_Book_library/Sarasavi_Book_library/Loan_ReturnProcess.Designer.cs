namespace Sarasavi_Book_library
{
    partial class Loan_ReturnProcess
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
            this.loanprocess_tp = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.returnprocess_tp = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.bookid_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.find_btn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.loanprocess_tp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.returnprocess_tp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.loanprocess_tp);
            this.tabControl1.Controls.Add(this.returnprocess_tp);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(903, 643);
            this.tabControl1.TabIndex = 2;
            // 
            // loanprocess_tp
            // 
            this.loanprocess_tp.Controls.Add(this.find_btn);
            this.loanprocess_tp.Controls.Add(this.label4);
            this.loanprocess_tp.Controls.Add(this.dataGridView2);
            this.loanprocess_tp.Controls.Add(this.label2);
            this.loanprocess_tp.Controls.Add(this.dataGridView1);
            this.loanprocess_tp.Controls.Add(this.label1);
            this.loanprocess_tp.Location = new System.Drawing.Point(4, 22);
            this.loanprocess_tp.Name = "loanprocess_tp";
            this.loanprocess_tp.Size = new System.Drawing.Size(895, 617);
            this.loanprocess_tp.TabIndex = 0;
            this.loanprocess_tp.Text = "Loan Process";
            this.loanprocess_tp.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label4.Location = new System.Drawing.Point(332, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 33);
            this.label4.TabIndex = 30;
            this.label4.Text = "Loan Process ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.Black;
            this.dataGridView2.Location = new System.Drawing.Point(403, 147);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(463, 224);
            this.dataGridView2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unavailable books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(30, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 224);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrower\'s overdue books";
            // 
            // returnprocess_tp
            // 
            this.returnprocess_tp.Controls.Add(this.dateTimePicker1);
            this.returnprocess_tp.Controls.Add(this.label3);
            this.returnprocess_tp.Controls.Add(this.bookid_txt);
            this.returnprocess_tp.Controls.Add(this.username_txt);
            this.returnprocess_tp.Controls.Add(this.submit_btn);
            this.returnprocess_tp.Controls.Add(this.label6);
            this.returnprocess_tp.Controls.Add(this.label7);
            this.returnprocess_tp.Controls.Add(this.label8);
            this.returnprocess_tp.Location = new System.Drawing.Point(4, 22);
            this.returnprocess_tp.Name = "returnprocess_tp";
            this.returnprocess_tp.Size = new System.Drawing.Size(895, 617);
            this.returnprocess_tp.TabIndex = 0;
            this.returnprocess_tp.Text = "Return Process";
            this.returnprocess_tp.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(311, 265);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.label3.Location = new System.Drawing.Point(305, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 33);
            this.label3.TabIndex = 29;
            this.label3.Text = "User Return Process ";
            // 
            // bookid_txt
            // 
            this.bookid_txt.Location = new System.Drawing.Point(311, 218);
            this.bookid_txt.Name = "bookid_txt";
            this.bookid_txt.Size = new System.Drawing.Size(200, 20);
            this.bookid_txt.TabIndex = 27;
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(311, 167);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(200, 20);
            this.username_txt.TabIndex = 26;
            this.username_txt.TextChanged += new System.EventHandler(this.username_txt_TextChanged);
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.Color.PowderBlue;
            this.submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submit_btn.Location = new System.Drawing.Point(425, 318);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(86, 33);
            this.submit_btn.TabIndex = 25;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Date of delivered of the book";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Book ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Username";
            // 
            // find_btn
            // 
            this.find_btn.BackColor = System.Drawing.Color.Pink;
            this.find_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.find_btn.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.find_btn.Location = new System.Drawing.Point(263, 102);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(81, 28);
            this.find_btn.TabIndex = 31;
            this.find_btn.Text = "Find";
            this.find_btn.UseVisualStyleBackColor = false;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click_1);
            // 
            // Loan_ReturnProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 645);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loan_ReturnProcess";
            this.Text = "Loan_ReturnProcess";
            this.tabControl1.ResumeLayout(false);
            this.loanprocess_tp.ResumeLayout(false);
            this.loanprocess_tp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.returnprocess_tp.ResumeLayout(false);
            this.returnprocess_tp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage loanprocess_tp;
        private System.Windows.Forms.TabPage returnprocess_tp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookid_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button find_btn;
    }
}