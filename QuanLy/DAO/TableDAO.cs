using QuanLy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new TableDAO();
                }
                return TableDAO.instance;
            }
            private set
            {
                TableDAO.instance = value;
            }
        }

        public static int TableWidth = 80;
        public static int TableHeight = 80;



        private TableDAO() { }

        public void DoiBan(int id1, int id2)
        {
            DataPro.Instance.ExecuteQuery("USP_DoiBan @idTable1 , @idTable2", new object[] {id1, id2});

        }

        public List<Table> LoadTableList()
        {
            List<Table> list = new List<Table>();
            DataTable data = DataPro.Instance.ExecuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                list.Add(table);
                
            }
            return list;
        }
    }
}
