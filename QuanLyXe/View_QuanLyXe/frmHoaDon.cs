using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QuanLyXe;
using DTO_QuanLyXe;
using DAO_QuanLyXe;

namespace BaiTapLon
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        BUS_HoaDon BusHd;
        BUS_ChiTietHoaDon BusChitietHD;
        TreeNode nGoc;
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            btnHD_Sua.Enabled = false;
            btnHD_Xoa.Enabled = false;

            lvwHD.LargeImageList = imgLon;
            lvwHD.SmallImageList = imgNho;
            TaoTieuDeCot();
            nGoc = new TreeNode("Loại Hóa Đơn");
            BusHd = new BUS_HoaDon();
            BusChitietHD = new BUS_ChiTietHoaDon();
            treHD_LoaiHD.ImageList = imgTree;
            IEnumerable<HoaDon> dshd = BusHd.getAllHoadon();
            loadHoaDonToTree(treHD_LoaiHD,dshd);
        }

        private void loadHoaDonToTree(TreeView tre,IEnumerable<HoaDon> dshd)
        {
            tre.Nodes.Clear();
            nGoc.Nodes.Clear();//xoa cac con
            TreeNode nCon;
            foreach (HoaDon p in dshd)
            {
                nCon = new TreeNode();
                nCon.Text = p.LoaiHD;
                nCon.Tag = p.MaHD;
                nGoc.Nodes.Add(nCon);
            }
            tre.Nodes.Add(nGoc);
            tre.ExpandAll();
        }
        void TaoTieuDeCot()
        {
            lvwHD.Columns.Add("Mã HD", 135);
            lvwHD.Columns.Add("Mã Xe", 135);
            lvwHD.Columns.Add("Số Lượng", 200);
            lvwHD.Columns.Add("Đơn giá", 200);
            lvwHD.Columns.Add("Thành Tiền", 218);
            
            lvwHD.View = View.Details;
            lvwHD.GridLines = true;
            lvwHD.FullRowSelect = true;
        }

        private void dtgvHD_Show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treHD_LoaiHD_AfterSelect(object sender, TreeViewEventArgs e)
        {
            IEnumerable<ChiTietHD> cthd;
            BUS_HonLoan BusHl;
            string StrMaHD = "";
            if(treHD_LoaiHD.SelectedNode != null)
            {
                if (treHD_LoaiHD.SelectedNode.Level == 0)
                {
                    StrMaHD = "";
                }
                else
                {
                    StrMaHD = treHD_LoaiHD.SelectedNode.Tag.ToString();
                }
                cthd = BusChitietHD.getAllChiTietHD(StrMaHD);
                BusHl = new BUS_HonLoan();
                MessageBox.Show("hello: ", "Thong báo" + BusHl.getHonLoan());
                loadChiTietHDToListView(lvwHD, cthd);
            }    
        }

        private void loadChiTietHDToListView(ListView lvwHD, IEnumerable<ChiTietHD> cthd)
        {
            lvwHD.Items.Clear();
            ListViewItem itemCTHoaDon;
            foreach(ChiTietHD ct in cthd)
            {
                itemCTHoaDon = GreateItem(ct);
                lvwHD.Items.Add(itemCTHoaDon);
            }    
        }

        private ListViewItem GreateItem(ChiTietHD ct)
        {
            ListViewItem lvwItem;
            lvwItem = new ListViewItem(ct.MaHD);
            lvwItem.SubItems.Add(ct.MaHD);
            lvwItem.SubItems.Add(ct.MaXe);
            lvwItem.SubItems.Add(Convert.ToString(ct.Soluong));
            lvwItem.SubItems.Add(Convert.ToString(ct.DonGia));
            lvwItem.SubItems.Add(Convert.ToString(ct.ThanhTien));
            lvwItem.Tag = ct;
            lvwItem.ImageIndex = 0;
            return lvwItem;
        }
    }
}
