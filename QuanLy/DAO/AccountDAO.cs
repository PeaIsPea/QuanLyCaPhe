using QuanLy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DAO
{
    public class AccountDAO
    {
        private  static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new AccountDAO();

                }
                return AccountDAO.instance;
            }
            private set
            {
                AccountDAO.instance = value;
            }
        }
        private AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = "USP_Login @userName , @passWord"; 
            DataTable res = DataPro.Instance.ExecuteQuery(query, new object[] {username, password});
            int resData = res.Rows.Count;

            return resData > 0;
        }


        public bool UpdateAccount(string user, string dp, string pass, string newPass)
        {
            int res = DataPro.Instance.ExecuteNonQuery("exec USP_UpdateAcc @userName , @displayName , @password , @newPassword" , new object[] {user,dp, pass, newPass});
            return res > 0;
        }


        public Account GetAccountByUserName(string userName)
        {
            string query = ("select * from Account where userName = '" + userName +"'");
            DataTable data = DataPro.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
    }
}
