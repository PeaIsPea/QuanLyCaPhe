using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DTO
{
    public class Account
    {
        public Account(string userName, string displayName, int type, string passWord = null)
        {
            this.userName = userName;
            this.displayName = displayName;
            this.type = type;
            this.passWord = passWord;
        }

        public Account(DataRow rows)
        {
            this.userName = (string)rows["userName"];
            this.displayName = (string)rows["displayName"];
            this.type = (int)rows["type"];
            
            this.passWord = rows["passWord"].ToString();
        }


        private int type;
        private string passWord;

        private string displayName;


        private string userName;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int Type { get => type; set => type = value; }
    }
}
