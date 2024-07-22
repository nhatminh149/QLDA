using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using B_BUS.Services;
using A_DAL.Models;

namespace C_PRL
{
    public partial class FormSanPham : Form
    {
        List<SanPham> sanphams; // Tạo ra List Sp
        SanPhamServices _services;

        public FormSanPham()
        {
            _services = new SanPhamServices();
            sanphams = _services.GetAll();
            InitializeComponent();
            LoadSPToPanel(1); // Ví dụ: Tải sản phẩm cho trang đầu tiên
        }

        public void LoadSPToPanel(int page)
        {
            tabSanPham.Controls.Clear();
            int numberOfPage = (int)Math.Ceiling((decimal)sanphams.Count / 4);

            if (page < 1 || page > numberOfPage) return;

            if (page * 4 - 4 < sanphams.Count)
            {
                Panel s1 = CreatePanelSp(sanphams[page * 4 - 4]);
                tabSanPham.Controls.Add(s1, 0, 0);
            }
            if (page * 4 - 3 < sanphams.Count)
            {
                Panel s2 = CreatePanelSp(sanphams[page * 4 - 3]);
                tabSanPham.Controls.Add(s2, 0, 1);
            }
            if (page * 4 - 2 < sanphams.Count)
            {
                Panel s3 = CreatePanelSp(sanphams[page * 4 - 2]);
                tabSanPham.Controls.Add(s3, 1, 0);
            }
            if (page * 4 - 1 < sanphams.Count)
            {
                Panel s4 = CreatePanelSp(sanphams[page * 4 - 1]);
                tabSanPham.Controls.Add(s4, 1, 1);
            }
        }

        public Panel CreatePanelSp(SanPham sp)
        {
            Panel p = new Panel();
            p.Size = new Size(555, 360);
            p.Name = sp.MaSanPham.ToString();

            PictureBox ptb = new PictureBox();
            ptb.Size = new Size(297, 287);
            ptb.Image = Image.FromFile(filename: sp.MoTa);
            ptb.Location = new Point(14, 12);
            ptb.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lbTen = new Label(); lbTen.Text = "Tên sản phẩm";
            lbTen.Location = new Point(322, 14);

            Label lbTenValue = new Label(); lbTenValue.Text = sp.TenSanPham;
            lbTenValue.Location = new Point(322, 42);

            Label lbGia = new Label(); lbGia.Text = "Giá sản phẩm";
            lbGia.Location = new Point(322, 76);

            Label lbGiaValue = new Label(); lbGiaValue.Text = sp.GiaNhap + "";
            lbGiaValue.Location = new Point(322, 114);

            Label lbSL = new Label(); lbSL.Text = "Số lượng sản phẩm";
            lbSL.Location = new Point(322, 152);

            Label lbSLValue = new Label(); lbSLValue.Text = sp.SoLuong + "";
            lbSLValue.Location = new Point(322, 190);

            Label lbMua = new Label(); lbMua.Text = "Số lượng mua";
            lbMua.Location = new Point(322, 235);

            Button btnMua = new Button();
            btnMua.Location = new Point(390, 264);
            btnMua.Size = new Size(75, 27);
            btnMua.Text = "Mua";
            btnMua.MouseClick += butMua_MouseClick;

            TextBox tbSoLuong = new TextBox();
            tbSoLuong.PlaceholderText = "Nhập";
            tbSoLuong.Location = new Point(322, 264);
            tbSoLuong.Size = new Size(62, 25);
            tbSoLuong.Name = "tbSoLuong";

            p.Controls.Add(ptb);
            p.Controls.Add(lbTen);
            p.Controls.Add(lbTenValue);
            p.Controls.Add(lbGia);
            p.Controls.Add(lbGiaValue);
            p.Controls.Add(lbSL);
            p.Controls.Add(lbSLValue);
            p.Controls.Add(lbMua);
            p.Controls.Add(btnMua);
            p.Controls.Add(tbSoLuong);

            return p;
        }

        private void butMua_MouseClick(object sender, MouseEventArgs e)
        {
            Button? btnMua = sender as Button;
            if (btnMua != null)
            {
                Panel? parentPanel = btnMua.Parent as Panel;
                if (parentPanel != null)
                {
                    TextBox? tbSoLuong = parentPanel.Controls.Find("tbSoLuong", true).FirstOrDefault() as TextBox;
                    if (tbSoLuong != null)
                    {
                        int soLuong;
                        if (int.TryParse(tbSoLuong.Text, out soLuong))
                        {
                            MessageBox.Show($"Mua {soLuong} sản phẩm có ID: {parentPanel.Name}");
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                        }
                    }
                }
            }
        }

        private void butShowSp_Click(object sender, EventArgs e)
        {
            LoadSPToPanel(1);
        }

        private void labBack_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labPage.Text) > 1)
            { //Nếu trang hiện tại vẫn nhở hơn tổng số trang có thể thì ta mới cho next trnag
                labPage.Text = Convert.ToInt32(labPage.Text) - 1 + "";
                LoadSPToPanel(Convert.ToInt32(labPage.Text));
            }
        }

        private void labNext_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labPage.Text) < (int)Math.Ceiling((decimal)sanphams.Count / 4))
            { //Nếu trang hiện tại vẫn nhở hơn tổng số trang có thể thì ta mới cho next trnag
                labPage.Text = Convert.ToInt32(labPage.Text) + 1 + "";
                LoadSPToPanel(Convert.ToInt32(labPage.Text));
            }
        }
    }
}
