using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev1gorsel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1(); // Giriş ekranını aç
            loginForm.Show();
            this.Hide(); // Ana menüyü gizle
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(); // Kayıt ol ekranını aç
            registerForm.Show();
            this.Hide(); // Ana menüyü gizle
        }

    }
}
