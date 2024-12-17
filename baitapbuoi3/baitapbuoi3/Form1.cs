using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitapbuoi3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                // Cập nhật mục đã chọn với giá trị mới từ TextBox
                ListViewItem selectedItem = listView.SelectedItems[0];
                selectedItem.Text = txtItem.Text;  // Cập nhật text của mục đã chọn
                txtItem.Clear(); // Làm sạch TextBox sau khi sửa
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục để sửa.");
            }
        }
        

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItem.Text))
            {
                MessageBox.Show("Vui lòng nhập tên mục.");
                return;
            }

            // Tạo một ListViewItem mới và thêm vào ListView
            ListViewItem item = new ListViewItem(txtItem.Text); // Tạo một mục với tên từ TextBox
            listView.Items.Add(item); // Thêm mục vào ListView
            txtItem.Clear(); // Làm sạch TextBox sau khi thêm
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                // Xóa mục được chọn
                listView.Items.Remove(listView.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mục để xóa.");
            }
        }
    }
    }

