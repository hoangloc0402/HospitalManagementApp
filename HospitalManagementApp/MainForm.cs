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
            comboLoai.ValueList = v;

            List<Panel> panels = new List<Panel>();
            panels.Add(panelBenhNhan);
            panels.Add(panelDD);
            panels.Add(panelBaoCao);
            panelManager = new PanelManager(panels);

            panelBenhNhan.Dock = DockStyle.Fill;
           

        }

        private void labelTen_Click(object sender, EventArgs e)
        {

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
                        ClearSelection();
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
                    else loaibn = "NOITRU";
                    String manv = ((TextBoxTool)this.ultraToolbarsManager1.Tools["textboxmanv"]).Text;
                    try
                    {
                        dbHelper.ThemBN(mabn,tenbn,diachi,loaibn,manv);
                        MessageBox.Show("Đã thêm bệnh nhân thành công", "Thành công");
                    }
                    catch (Exception) {
                        MessageBox.Show("Có lỗi xảy ra.\nVui lòng kiểm tra lại thông tin đã nhập.", "Lỗi");
                    }
                    break;
                case "buttontimmadd":    // Button Tim danh sach thuoc
                    panelManager.ShowPanel(1);                     // Place code here
                    break;

            }


        }
        void ClearSelection()
        {
            dataGridViewDotDieuTri.ClearSelection();
            dataGridViewSDT.ClearSelection();
            dataGridViewLanKhamBenh.ClearSelection();
        }
    }
}
