using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            string query = "USP_Login @userName , @passWord";

            DataTable res = DataProvider.Instance.ExecuteQuery(query, new object[] {username,password});
            return res.Rows.Count > 0;
        }
    }
}
