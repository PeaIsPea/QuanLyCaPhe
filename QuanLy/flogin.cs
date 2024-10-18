
using QuanLy.DAO;
using QuanLy.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?","Thông Báo",MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text;
            string passWord = txtPass.Text;

            if (Login(userName, passWord))
            {
                Account loginAcc = AccountDAO.Instance.GetAccountByUserName(userName);
                

                fTableManager fquanly = new fTableManager(loginAcc);
                this.Hide();
                fquanly.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản quặc mật khẩu");
            }

        }

        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName,passWord);
        }
    }
}
