using QuanLy.DAO;
using QuanLy.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLy
{
    public partial class fAdmin : Form
    {

        BindingSource foodList = new BindingSource();
        BindingSource cateList = new BindingSource();


        public fAdmin()
        {
            InitializeComponent();
            Loading();
        }


        //hàm Load tổng
        void Loading()
        {
            dgThucAn.DataSource = foodList;
            dgDanhMuc.DataSource = cateList;       
            LoadDateTimePicker();
            LoadTiengVietDateTime();
            LoadListBillByDate(dateBill1.Value, DateBill2.Value);
            LoadThucAn();
            LoadDanhMuc();
            AddFoodBinding();
            AddCateBinding();
            LoadDanhMucCB(cbTimDanhMuc);
        }


        void LoadTiengVietDateTime()
        {
            // Cập nhật các chuỗi hiển thị trên DateTimePicker
            dateBill1.Format = DateTimePickerFormat.Custom;
            dateBill1.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày tháng Việt Nam

            // Cập nhật các chuỗi hiển thị trên DateTimePicker
            DateBill2.Format = DateTimePickerFormat.Custom;
            DateBill2.CustomFormat = "dd/MM/yyyy"; // Định dạng ngày tháng Việt Nam
        }

        // Đặt ngôn ngữ mặc định cho ứng dụng       
        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dateBill1.Value = new DateTime(today.Year, today.Month, 1);
            DateBill2.Value = dateBill1.Value.AddMonths(1).AddDays(-1);
        }

        #region methods
        //----------------------------------Method xử lý Bill-----------------------


        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
           dgBill.DataSource =  BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }


        //****************************************************************************



        //-----------------------------Method Xử lý Food----------------------------
        
        List<Food> SearchFoodName(string name)
        {
            List<Food> listFood = new List<Food>();
            FoodDAO.Instance.SearchFoodName(name);

            return listFood;
        }
        
        
        void AddFoodBinding()
        {
            //kỹ thuật dataBinding
            //khi thằng này thay đổi thằng kia thay đổi theo do liên kết
            // từ txtTenMon, cho ta giá trị thuộc tính "Text" sẽ thay đổi theo giá trị của Name trong dgThucAn
            txtTenMon.DataBindings.Add(new Binding("Text", dgThucAn.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtID.DataBindings.Add(new Binding("Text", dgThucAn.DataSource, "id", true, DataSourceUpdateMode.Never));

            nbGia.DataBindings.Add(new Binding("Value", dgThucAn.DataSource, "price", true, DataSourceUpdateMode.Never));

        }
        void LoadDanhMucCB(ComboBox cb)//này load danh mục bên thức ăn
        {
            cb.DataSource = CategoryDAO.Instance.GetListCateGory();
            cb.DisplayMember = "Name";

        }
        //***********************************************************************************************************



        //----------------------------------Method Xử lý Cate------------------------------------------------------
        void AddCateBinding()
        {
            txtIDDanhMuc.DataBindings.Add(new Binding("Text", dgDanhMuc.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtDanhMuc.DataBindings.Add(new Binding("Text", dgDanhMuc.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }


        void LoadDanhMuc()
        {
            cateList.DataSource = CategoryDAO.Instance.GetListCateGory();

        }

        //********************************************************************************************************

        #endregion









        #region events

        //-----------------------------------------Event Xử lý Food-----------------------
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgThucAn.SelectedCells.Count > 0)
                {
                    int id = (int)dgThucAn.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);

                    cbTimDanhMuc.SelectedItem = cateogory;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbTimDanhMuc.Items)
                    {
                        if (item.Id == cateogory.Id)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbTimDanhMuc.SelectedIndex = index;
                }
            }
            catch { }




        }
        void LoadThucAn()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        private void btnXemThucAn_Click(object sender, EventArgs e)
        {
            LoadThucAn();
        }

        //thêm food
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txtTenMon.Text;
            int cateID = (cbTimDanhMuc.SelectedItem as Category).Id;
            float price = (float)(nbGia.Value);

            if (FoodDAO.Instance.ThemThucAnNe(name, cateID, price))
            {
                MessageBox.Show("Thêm món cồng thanh");
                LoadThucAn();
                if (themFood != null)
                {
                    themFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
            }

        }


        //sửa food
        private void btnSuaThucAn_Click(object sender, EventArgs e)
        {
            string name = txtTenMon.Text;
            int cateID = (cbTimDanhMuc.SelectedItem as Category).Id;
            float price = (float)(nbGia.Value);
            int idFood = Convert.ToInt32(txtID.Text);

            if (FoodDAO.Instance.SuaThucAnNe(idFood, name, cateID, price))
            {
                MessageBox.Show("Sửa món cồng thanh");
                LoadThucAn();
                if (suaFood != null)
                {
                    suaFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }


        //xóa food
        private void btnDeleteThucAn_Click(object sender, EventArgs e)
        {
            int idFood = Convert.ToInt32(txtID.Text);

            if (FoodDAO.Instance.XoaThucAnNe(idFood))
            {
                MessageBox.Show("Xóa món cồng thanh");
                LoadThucAn();
                if (xoaFood != null)
                {
                    xoaFood(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }


        //----------------Event tìm kiếm thức ăn-----------------
        private void btnTim_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodName(txtTim.Text);
        }


        //food
        private event EventHandler themFood;
        public event EventHandler ThemFood
        {
            add { themFood += value; }
            remove { themFood -= value; }
        }


        private event EventHandler suaFood;
        public event EventHandler SuaFood
        {
            add { suaFood += value; }
            remove { suaFood -= value; }
        }

        private event EventHandler xoaFood;
        public event EventHandler XoaFood
        {
            add { xoaFood += value; }
            remove { xoaFood -= value; }
        }

        //********************************************************************************





        //-----------------------------------------Even xử lý Bill------------------

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateBill1.Value, DateBill2.Value);
        }

        //**************************************************************************



        //----------------------------------------Event xử lý Cate------------------


        //Thêm Cate
        private void btnAddDanhMuc_Click(object sender, EventArgs e)
        {
            string name = txtDanhMuc.Text;
            //int cateID = Convert.ToInt32( txtIDDanhMuc.Text);
            

            if (CategoryDAO.Instance.ThemCateNe(name))
            {
                MessageBox.Show("Thêm danh mục cồng thanh");
                LoadDanhMuc();
                LoadDanhMucCB(cbTimDanhMuc);
                if (themCate != null)
                {
                    themCate(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm danh mục");
            }
        }


        //Sửa Cate

        private void btnSuaDanhMuc_Click(object sender, EventArgs e)
        {
            string name = txtDanhMuc.Text;
            
            int idCate = Convert.ToInt32(txtIDDanhMuc.Text);

            if (CategoryDAO.Instance.SuaCateNe(idCate, name))
            {
                MessageBox.Show("Sửa món cồng thanh");
                LoadDanhMuc();
                LoadDanhMucCB(cbTimDanhMuc);
                if (suaCate != null)
                {
                    suaCate(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }


        private void btnXoaDanhMuc_Click(object sender, EventArgs e)
        {
            int idCate = Convert.ToInt32(txtIDDanhMuc.Text);
            // Kiểm tra xem có món ăn nào thuộc danh mục cần xóa hay không
            bool hasRelatedFood = CategoryDAO.Instance.CheckRelatedFood(idCate);

            if (hasRelatedFood)
            {
                MessageBox.Show("Danh mục này đang được sử dụng. Vui lòng xóa các món ăn liên kết trước khi xóa danh mục.");
                return; // Thoát khỏi hàm nếu có món ăn liên kết
            }

            if (CategoryDAO.Instance.XoaCateNe(idCate))
            {
                MessageBox.Show("Xóa danh mục cồng thanh");
                LoadDanhMucCB(cbTimDanhMuc);
                LoadDanhMuc();
                if (xoaCate != null)
                {
                    xoaCate(this, new EventArgs());
                }
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }

        private void btnXemDanhMuc_Click(object sender, EventArgs e)
        {
            LoadDanhMuc();
        }


        


        //danh mục
        private event EventHandler themCate;
        public event EventHandler ThemCate
        {
            add { themCate += value; }
            remove { themCate -= value; }
        }


        private event EventHandler suaCate;
        public event EventHandler SuaCate
        {
            add { suaCate += value; }
            remove { suaCate -= value; }
        }

        private event EventHandler xoaCate;
        public event EventHandler XoaCate
        {
            add { xoaCate += value; }
            remove { xoaCate -= value; }
        }






        //**************************************************************************




        







        #endregion


    }
}
