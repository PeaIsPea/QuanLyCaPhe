using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace QuanLy.DTO
{
    public class Food
    {

        public Food(int id, string name, int categoryId, float price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.CategoryID = categoryId;
        }



        public Food(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = (string)row["name"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.CategoryID = (int)row["idcategory"];

           
        }


        private float price;

        private int categoryID;
        private string name;
        private int id;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public float Price { get => price; set => price = value; }
    }
}
