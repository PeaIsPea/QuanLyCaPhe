using QuanLy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QuanLy.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;


        private FoodDAO() { }

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodDAO();
                }
                return FoodDAO.instance;
            }
            private set
            {
                FoodDAO.instance = value;
            }
        }


        public List<Food> GetListFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "select * from Food where idCategory = " + id;

            DataTable data = DataPro.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }

        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = "select * from Food";


            DataTable data = DataPro.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }



        //thêm food
        public bool ThemThucAnNe(string ten, int id, float price)
        {
            string query = string.Format("INSERT dbo.Food ( name, idCategory, price )VALUES  ( N'{0}', {1}, {2})", ten, id, price);


            int res = DataPro.Instance.ExecuteNonQuery(query);
            return res > 0;
        }



        //sửa food
        public bool SuaThucAnNe(int idFood, string ten, int id, float price)
        {
            string query = string.Format("update dbo.Food set name = N'{0}', idCategory = {1} , price = {2} where id = {3}", ten, id, price, idFood);


            int res = DataPro.Instance.ExecuteNonQuery(query);
            return res > 0;
        }



        //xóa food
        public bool XoaThucAnNe(int idFood)
        {

            BillInfoDAO.Instance.XoaBillInfoByFoodID(idFood);

            string query = string.Format("delete Food where id = {0}", idFood);


            int res = DataPro.Instance.ExecuteNonQuery(query);
            return res > 0;
        }


        //tìm kiếm

        public List<Food> SearchFoodName(string name)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("select * from dbo.Food where dbo.fuConvertToUnsign1 (name) like N'%' + dbo.fuConvertToUnsign1(N'{0}') +'%'", name);


            DataTable data = DataPro.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
    }

}
