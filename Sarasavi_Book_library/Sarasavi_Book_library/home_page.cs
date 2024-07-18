using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sarasavi_Book_library
{
    public partial class home_page : Form
    {

        int mov;
        int movX;
        int movY;
        int movZ;

        private string loggedInUsername;



        public home_page()
        {
            InitializeComponent();

        }


        private void home_page_Load(object sender, EventArgs e)
        {
            timer1.Start();
            time_lbl.Text = DateTime.Now.ToLongTimeString();
            date_lbl.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_lbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dash_btn_Click(object sender, EventArgs e)
        {
            dashboard form1 = new dashboard();
            form1.TopLevel = false;
            loadpanel2.Controls.Clear();
            loadpanel2.Controls.Add(form1);
            form1.Dock = DockStyle.Fill;
            form1.Show();
        }

        private void loan_return_btn_Click_1(object sender, EventArgs e)
        {
            Loan_ReturnProcess form2 = new Loan_ReturnProcess();
            form2.TopLevel = false;
            loadpanel2.Controls.Clear();
            loadpanel2.Controls.Add(form2);
            form2.Dock = DockStyle.Fill;
            form2.Show();

        }


        private void reservation_btn_Click(object sender, EventArgs e)
        {
            ReservationProcess form4 = new ReservationProcess();
            form4.TopLevel = false;
            loadpanel2.Controls.Clear();
            loadpanel2.Controls.Add(form4);
            form4.Dock = DockStyle.Fill;
            form4.Show();
        }

        private void inquiry_btn_Click(object sender, EventArgs e)
        {
            InquiryProcess form5 = new InquiryProcess();
            form5.TopLevel = false;
            loadpanel2.Controls.Clear();
            loadpanel2.Controls.Add(form5);
            form5.Dock = DockStyle.Fill;
            form5.Show();
        }

        private void book_rej_btn_Click(object sender, EventArgs e)
        {


            BookRegistration form6 = new BookRegistration();
            form6.TopLevel = false;
            loadpanel2.Controls.Clear();
            loadpanel2.Controls.Add(form6);
            form6.Dock = DockStyle.Fill;
            form6.Show();

        }

        private void user_rej_btn_Click(object sender, EventArgs e)
        {

            UserRegistration form7 = new UserRegistration();
            form7.TopLevel = false;
            loadpanel2.Controls.Clear();
            loadpanel2.Controls.Add(form7);
            form7.Dock = DockStyle.Fill;
            form7.Show();
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            login_page loginPage = new login_page();
            loginPage.Show();
            this.Close(); // Close the current form (home page)
        }
    }
}
