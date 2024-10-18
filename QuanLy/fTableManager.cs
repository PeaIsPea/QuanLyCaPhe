
using QuanLy.DAO;
using QuanLy.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Menu = QuanLy.DTO.Menu;

namespace QuanLy
{
    public partial class fTableManager : Form
    {
        private Account loginAcc;

        public Account LoginAcc { get => loginAcc; set { loginAcc = value; ChangeAccount(loginAcc.Type);}
    }

        public fTableManager(Account acc)
        {
            InitializeComponent();

            this.LoginAcc = acc;
            LoadTable();
            LoadCategory();
            LoadCbTable(cbChuyenBan);
        }



        #region Method

        void ChangeAccount(int type)
        {
            if(type == 1)
            {
                admintool.Enabled = true;
            }
            else
            {
                admintool.Enabled = false;
            }

            inforAcc.Text += "Đây là " + LoginAcc.DisplayName;

            
        }


        void LoadCategory()
        {
            List<Category> categories = CategoryDAO.Instance.GetListCateGory();
            cbDanhMuc.DataSource = categories;
            cbDanhMuc.DisplayMember = "Name";

        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> foods = FoodDAO.Instance.GetListFoodByCategoryID(id);
            cbThucAn.DataSource = foods;
            cbThucAn.DisplayMember = "Name";
        }


        void LoadTable()
        {
            flowTable.Controls.Clear();


            List<Table> list = TableDAO.Instance.LoadTableList();

            foreach (Table item in list)
            {
                Button button = new Button()
                {
                    Width = TableDAO.TableWidth,
                    Height = TableDAO.TableHeight

                };

                button.Text = item.Name + Environment.NewLine + item.Status;
                button.Click += btn_Click;
                button.Tag = item;
                
                
                if (item.Status == "Trống")
                {
                    button.BackColor = Color.Cyan;
                }
                else
                {
                    button.BackColor = Color.Red;
                }
                flowTable.Controls.Add(button);
            }

        }




        void ShowBill(int id)
        {
            listHoaDon.Items.Clear();
            List<Menu> lisBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float TongTien = 0;
            foreach (Menu item in lisBillInfo)
            {
                ListViewItem listViewItem = new ListViewItem(item.FoodName.ToString());
                listViewItem.SubItems.Add(item.Count.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.TotalPrice.ToString());
                TongTien += item.TotalPrice;


                listHoaDon.Items.Add(listViewItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            txtTongTien.Text = TongTien.ToString("c", culture);


        }
        void LoadCbTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }



        #endregion




        #region Events

        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            listHoaDon.Tag = (sender as Button).Tag;
            ShowBill(tableID);
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile fAccountProfile = new fAccountProfile(loginAcc);
            
            fAccountProfile.ShowDialog();
        }

        

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ThemFood += f_ThemFood;
            f.SuaFood += f_SuaFood;
            f.XoaFood += f_XoaFood;
            f.ShowDialog();
        }

        private void f_XoaFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbDanhMuc.SelectedItem as Category).Id);
            if (listHoaDon.Tag != null)
            {
                ShowBill((listHoaDon.Tag as Table).ID);
            }
            LoadTable();
        }

        private void f_SuaFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbDanhMuc.SelectedItem as Category).Id);
            if(listHoaDon.Tag != null)
            {
                ShowBill((listHoaDon.Tag as Table).ID);
            }
            
        }

        private void f_ThemFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbDanhMuc.SelectedItem as Category).Id);
            if (listHoaDon.Tag != null)
            {
                ShowBill((listHoaDon.Tag as Table).ID);
            }
        }

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if(cb.SelectedItem == null)
            {
                return;
            }


            Category selected = cb.SelectedItem as Category;
            id = selected.Id;

            LoadFoodListByCategoryID(id);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {


            Table table = listHoaDon.Tag as Table;


            if(table == null)
            {
                MessageBox.Show("Hãy chọn bàn ");
                return;
            }

            int idBill = BillDAO.Instance.GetBillIDByTableIDUnCheck(table.ID);
            int idFood = (cbThucAn.SelectedItem as Food).Id;
            int count = (int)numCount.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.ThemBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfor(BillDAO.Instance.GetMaxIDBill(table.ID), idFood, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfor(idBill, idFood, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Table table = listHoaDon.Tag as Table;
            int idBill = BillDAO.Instance.GetBillIDByTableIDUnCheck(table.ID);
            int discount = (int)ggcount.Value;
            double totalPrice = Convert.ToDouble(txtTongTien.Text.Split(',')[0].Replace(".", ""));

            double final = totalPrice - (totalPrice / 100) * discount;



            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn sẽ thanh toán hóa đơn cho {0}\n Tổng tiền - (Tổng tiền / 100) x Giảm giá = {1} - ({1}/100) * {2} = {3}", table.Name, totalPrice, discount, final), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)final);
                    ShowBill(table.ID);
                }
            }
            LoadTable();

        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {


            int id1 = (listHoaDon.Tag as Table).ID;
            int id2 = (cbChuyenBan.SelectedItem as Table).ID;


            string name1 = (listHoaDon.Tag as Table).Name;
            string name2 = (cbChuyenBan.SelectedItem as Table).Name;

            if (MessageBox.Show(string.Format("Bạn mún chuyển bàn {0} qua bàn {1}? ", name1, name2),"Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.DoiBan(id1, id2);
                LoadTable();

            }
            


        }







        #endregion

        
    }
}
