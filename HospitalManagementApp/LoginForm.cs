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
        private bool nameEdited;
        private bool passEdited;
        private void defaultText()
        {
            textEditorName.Text = "Tên đăng nhập";
            textEditorPassword.Text = "mật khẩu";
            nameEdited = false;
            passEdited = false;
        }
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            defaultText();
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
            defaultText();
        }

        private void textEditorName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) login();
        }

        private void textEditorPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) login();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textEditorName_AfterEnterEditMode(object sender, EventArgs e)
        {
            if (!nameEdited)
                textEditorName.Text = String.Empty;
        }

        private void textEditorName_AfterExitEditMode(object sender, EventArgs e)
        {
            if (textEditorName.Text == String.Empty)
            {
                textEditorName.Text = "Tên đăng nhập";
                nameEdited = false;
            }
            else
                nameEdited = true;
        }

        private void textEditorPassword_AfterEnterEditMode(object sender, EventArgs e)
        {
            if (!passEdited)
                textEditorPassword.Text = String.Empty;
        }

        private void textEditorPassword_AfterExitEditMode(object sender, EventArgs e)
        {
            if (textEditorPassword.Text == String.Empty)
            {
                textEditorPassword.Text = "mật khẩu";
                passEdited = false;
            }
            else
                passEdited = true;
        }
    }
}
