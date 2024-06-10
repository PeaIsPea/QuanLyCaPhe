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
        private static AccountDAO insance;

        public static AccountDAO Insance { 

            get { if (insance == null) insance = new AccountDAO(); return insance; }
            private set { insance = value; }
        }
        public AccountDAO() { }

        public bool Login(string username, string password)
        {
            string query = "Select * from dbo.Account Where Username  = N'"+ username + "' AND PassWord = N'" + password + "' ";

            DataTable res = DataProvider.Instance.ExecuteQuery(query);
            return res.Rows.Count > 0;
        }
    }
}
