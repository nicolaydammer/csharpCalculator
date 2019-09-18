using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = TextBoxUserName.Text;
            string password = txtBoxPasswd.Text;
            User user = new User();
            user.username = "pietje";
            user.password = "puk";
            if (username == user.username && password == user.password)
            {
                Form2 secondForm = new Form2();
                secondForm.ShowDialog();
               
            }
            else
            {
                Form3 thirdForm = new Form3();
                thirdForm.ShowDialog();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Form4 fourthForm = new Form4();
            fourthForm.ShowDialog();
        }
    }
}
