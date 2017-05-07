using Infragistics.Win;
using Infragistics.Win.UltraWinToolbars;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementApp
{
    public partial class MainForm : Form
    {
        OracleConnection conn;
        DatabaseHelper dbHelper;
        ComboBoxTool comboLoai;
        PanelManager panelManager;
        List<DataGridView> gribBN = new List<DataGridView>();
        List<DataGridView> gribBC = new List<DataGridView>();
        public MainForm(OracleConnection conn)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.conn = conn;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            dbHelper = new DatabaseHelper(conn);
            comboLoai = ((ComboBoxTool)this.ultraToolbarsManager1.Tools["comboboxLoaiBN"]);//tao comboBox Loai
            ValueList v = new ValueList();
            v.ValueListItems.Add("Ngoại trú");
            v.ValueListItems.Add("Nội trú");
            v.ValueListItems.Add("Cả hai");
            comboLoai.ValueList = v;
            comboLoai.SelectedIndex = 0;

            List<Panel> panels = new List<Panel>();
            panels.Add(panelBenhNhan);
            panels.Add(panelDD);
            panels.Add(panelBaoCao);
            panelManager = new PanelManager(panels);

            gribBN.Add(dataGridViewSDT);
            gribBN.Add(dataGridViewDotDieuTri);
            gribBN.Add(dataGridViewLanKhamBenh);

            gribBC.Add(dataGridViewBenhAn);
            gribBC.Add(dataGridViewPhauThuat);
            gribBC.Add(dataGridViewDotDT);
            gribBC.Add(dataGridViewThuoc);
            gribBC.Add(dataGridViewDungCu);
            
            panelBenhNhan.Dock = DockStyle.Fill;
           

        }
        

        private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
        {
            switch (e.Tool.Key)
            {
                case "buttonTimMa":    // Button Tim benh nhan
                    String maBN = ((TextBoxTool)this.ultraToolbarsManager1.Tools["textboxMaBN"]).Text;
                    
                    String ten;
                    try
                    {
                        DataTableCollection tables = dbHelper.TimBN(maBN, out ten);
                        labelTen.Text = ten;
                        dataGridViewSDT.DataSource = tables[0];
                        dataGridViewDotDieuTri.DataSource = tables[1];
                        dataGridViewLanKhamBenh.DataSource = tables[2];
                        panelManager.ShowPanel(0);
                        ClearSelection(gribBN);
                    }
                    catch (Exception) {
                        MessageBox.Show("Không tìm thấy bệnh nhân","Không tìm thấy");
                        panelManager.HideAllPanel();
                    }
                    
                    break;
                case "buttonThem":    // Button Them
                    String mabn=((TextBoxTool)this.ultraToolbarsManager1.Tools["textboxMaBNthem"]).Text;
                    String tenbn = ((TextBoxTool)this.ultraToolbarsManager1.Tools["textboxTen"]).Text;
                    String diachi = ((TextBoxTool)this.ultraToolbarsManager1.Tools["textboxDiaChi"]).Text;
                    String loaibn;
                    if (comboLoai.SelectedIndex == 0) loaibn = "NGOAITRU";
                    else if (comboLoai.SelectedIndex == 0) loaibn = "NOITRU";
                    else loaibn = "CAHAI";
                    //String manv = ((TextBoxTool)this.ultraToolbarsManager1.Tools["textboxmanv"]).Text;
                    try
                    {
                        dbHelper.ThemBN(mabn,tenbn,diachi,loaibn);
                        MessageBox.Show("Đã thêm bệnh nhân thành công", "Thành công");
                    }
                    catch (OracleException ex) {
                        if (ex.Number == 00001)
                        {
                            MessageBox.Show("Mã bệnh nhân đã tồn tại", "Lỗi");
                        }
                        else if(ex.Number == 01400)
                        {
                            MessageBox.Show("Không được để trống bất cứ thông tin nào", "Lỗi");
                        }
                        else MessageBox.Show(ex.Message);
                    }
                    break;
                case "buttontimDSThuoc":    // Button dieu duong
                    String maphong = ((TextBoxTool)this.ultraToolbarsManager1.Tools["textboxMaPhong"]).Text;
                    String makhu = ((TextBoxTool)this.ultraToolbarsManager1.Tools["textboxMaKhu"]).Text;
                    try { 
                        DataTableCollection tablesDS = dbHelper.DanhSachThuoc(maphong,makhu);
                        dataGridViewDSThuoc.DataSource = tablesDS[0];
                        panelManager.ShowPanel(1);
                        dataGridViewDSThuoc.ClearSelection();
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case "buttonTaoBaoCao": //button tao bao cao
                    String mabnbaocao = ((TextBoxTool)this.ultraToolbarsManager1.Tools["mabnBaoCao"]).Text;
                    String tenBC;
                    String tongtienBC;
                    try {
                        DataTableCollection tablesBC = dbHelper.TaoBaoCao(mabnbaocao,out tenBC,out tongtienBC);
                        labelTenBaoCao.Text = tenBC;
                        labelTongTien.Text = tongtienBC+" Đồng";
                        dataGridViewBenhAn.DataSource = tablesBC[0];
                        dataGridViewPhauThuat.DataSource = tablesBC[1];
                        dataGridViewDotDT.DataSource = tablesBC[2];
                        dataGridViewThuoc.DataSource = tablesBC[3];
                        dataGridViewDungCu.DataSource = tablesBC[4];
                        panelManager.ShowPanel(2);
                        ClearSelection(gribBC);
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("Không tìm thấy bệnh nhân", "Không tìm thấy");
                        panelManager.HideAllPanel();
                    }
                    
                    
                    break;
                case "buttonThoat":    // ButtonTool
                    Application.Exit();                   // Place code here
                    break;

                case "buttonDangXuat":    // ButtonTool
                    this.Hide();
                    LoginForm m = new LoginForm();
                    m.Show();                      // Place code here
                    break;

            }


        }
        void ClearSelection(List<DataGridView> l)
        {
            foreach (var g in l)
            {
                g.ClearSelection();
            }
        }
        private void ultraToolbarsManager1_AfterRibbonTabSelected(object sender, RibbonTabEventArgs e)
        {
            panelManager.HideAllPanel();
        }
    }
}
