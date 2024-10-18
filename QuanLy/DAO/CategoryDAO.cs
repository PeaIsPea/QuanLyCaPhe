using QuanLy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;




        

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryDAO();
                }
                return CategoryDAO.instance;
            }
            private set
            {
                CategoryDAO.instance = value;
            }
        }

        public CategoryDAO() { }


        public List<Category> GetListCateGory()
        {
            List<Category> list = new List<Category>();
            string query = "select * from FoodCategory";

            DataTable data = DataPro.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }

            return list;
        }

        public Category GetCategoryByID(int id)
        {
            Category cate = null;

            string query = "select * from FoodCategory where id = " + id;

            DataTable data = DataPro.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                cate= new Category(item);
                return cate;
            }


            return cate;
        }


        //thêm cate
        public bool ThemCateNe(string ten)
        {
            string query = string.Format("INSERT dbo.FoodCategory ( name )VALUES  ( N'{0}')", ten);


            int res = DataPro.Instance.ExecuteNonQuery(query);
            return res > 0;
        }


        //sửa cate
        public bool SuaCateNe(int idCate, string ten)
        {
            string query = string.Format("update dbo.FoodCategory set name = N'{0}' where id = {1}", ten, idCate);


            int res = DataPro.Instance.ExecuteNonQuery(query);
            return res > 0;
        }



        //xóa cate

        public bool XoaCateNe(int idCate)
        {

            BillInfoDAO.Instance.XoaBillInfoByFoodID(idCate);


            string query = string.Format("delete FoodCategory where id = {0}", idCate);


            int res = DataPro.Instance.ExecuteNonQuery(query);
            return res > 0;
        }

        //check Var

        public bool CheckRelatedFood(int categoryId)
        {
            string query = "SELECT COUNT(*) FROM Food WHERE idCategory = @categoryId";
            object[] parameters = { categoryId };
            object result = DataPro.Instance.ExecuteScalar(query, parameters);
            return (int)result > 0;
        }
    }
}
