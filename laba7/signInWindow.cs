using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba7
{
    public partial class signInWindow : Form
    {
        Thread thread;
        public signInWindow()
        {
            InitializeComponent();
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            if (!tb_password.Text.Equals("admin") & !tb_password.Text.Equals(""))
            {
                lbl_signIn.Text = "Пароль введен неправильно :(";
            }
            else if (tb_password.Text.Equals("admin")) {
                this.Close();
                thread = new Thread(appRunAdmin);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else if (tb_password.Text.Equals(""))
            {
                this.Close();
                thread = new Thread(appRunGuest);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
        }

        private void appRunAdmin(object sender)
        {
            Application.Run(new adminForm());
        }

        private void appRunGuest(object sender)
        {
            Application.Run(new guestForm());

        }

    }
}
