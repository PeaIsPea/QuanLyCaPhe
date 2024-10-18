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
    public partial class fAccountProfile : Form
    {

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public fAccountProfile(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txtUser.Text = LoginAccount.UserName;
            txtUN.Text = LoginAccount.DisplayName;
        }

        void UpdateAcc()
        {
            string displayName = txtUN.Text;
            string passWord = txtPass_.Text;
            string newPass = txtPassNew.Text;
            string reenterPass = txtPassNewAgain.Text;
            string userName = txtUser.Text;

            if (!newPass.Equals(reenterPass))
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(AccountDAO.Instance.UpdateAccount(userName, displayName, passWord, newPass))
                {
                    MessageBox.Show("Cập nhật thành công");

                }
                else
                {
                    MessageBox.Show("Vui lòng điền cho đúng mật khẩu");
                }
            }
        }

        



        private void btnEscape_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            UpdateAcc();
        }
        
    }

    
}
