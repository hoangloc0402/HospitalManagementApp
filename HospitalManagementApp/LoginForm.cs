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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }
        
        void login()
        {
            try
            {
                string oradb = "DATA SOURCE=127.0.0.1:1521/hospital;PERSIST SECURITY INFO=True;USER ID=" + textEditorName.Text + "; PASSWORD=" + textEditorPassword.Text + ";";
                OracleConnection conn = new OracleConnection(oradb);  // C
                conn.Open();
                this.Hide();
                MainForm m = new MainForm(conn);
                m.Show();
            }
            catch (OracleException)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu","Oops!...");
            }
        }

        private void textEditorName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) login();
        }

        private void textEditorPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) login();
        }
    }
}
