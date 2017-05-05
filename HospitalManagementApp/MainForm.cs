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
        String name;
        String password;
        OracleConnection conn;
        public MainForm(OracleConnection conn)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.conn = conn;
        }

        private void ultraToolbarsManager1_ToolClick(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            switch (e.Tool.Key)
            {
                case "textEditorMaBN":    // TextBoxTool
                                          // Place code here
                    break;

                case "buttonTim":    // ButtonTool
                    MessageBox.Show(((TextBoxTool)this.ultraToolbarsManager1.Tools["textEditorMaBN"]).Text,"Warning");
                    break;

                case " ":    // LabelTool
                             // Place code here
                    break;

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper(conn);
            String ten;
            DataTableCollection tables = dbHelper.TimBN("1", out ten);
            labelTen.Text = ten;
            dataGridViewSDT.DataSource = tables[0];
            dataGridViewDotDieuTri.DataSource = tables[1];
            dataGridViewLanKhamBenh.DataSource = tables[2];

        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
