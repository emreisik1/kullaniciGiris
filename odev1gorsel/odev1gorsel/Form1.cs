using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace odev1gorsel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantı dizesi
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=KullaniciDB;Integrated Security=True";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bağlantı Dizesi: " + connectionString, "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Kullanıcı adı ve şifre boş bırakılamaz!";
                lblMessage.Visible = true;
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT Role FROM Users WHERE Username=@username AND Password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                object? result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string role = result.ToString()?.Trim().ToLower() ?? ""; // Küçük harf ve boşlukları temizledik
                    Console.WriteLine("Kullanıcının Rolü: " + role); // Debug için ekledik

                    MessageBox.Show("Giriş başarılı! Rol: " + role, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Kullanıcıyı ilgili forma yönlendir
                    if (role == "admin")
                    {
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                        this.Hide(); // Giriş ekranını gizle
                    }
                    else if (role == "user")
                    {
                        UserForm userForm = new UserForm();
                        userForm.Show();
                        this.Hide(); // Giriş ekranını gizle
                    }
                    else
                    {
                        MessageBox.Show("Bilinmeyen bir rol algılandı: " + role, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    lblMessage.Text = "Kullanıcı adı veya şifre yanlış!";
                    lblMessage.Visible = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde çalışacak kod (Şimdilik boş bırakabiliriz)
        }

    }
}
