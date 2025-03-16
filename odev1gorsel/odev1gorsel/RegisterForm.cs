using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace odev1gorsel
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantı dizesi
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=KullaniciDB;Integrated Security=True";

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Ol butonuna tıklandı!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string newUsername = txtNewUsername.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string selectedRole = cmbRole.SelectedItem?.ToString() ?? "";
            // Kullanıcı rolünü al

            // Girdi Kontrolleri
            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(selectedRole))
            {
                lblRegisterMessage.Text = "Tüm alanları doldurmalısınız!";
                lblRegisterMessage.Visible = true;
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Aynı kullanıcı adında biri var mı kontrol et
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@username";
                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@username", newUsername);
                int userExists = (int)checkCmd.ExecuteScalar();

                if (userExists > 0)
                {
                    lblRegisterMessage.Text = "Bu kullanıcı adı zaten alınmış!";
                    lblRegisterMessage.Visible = true;
                    return;
                }

                // Yeni kullanıcıyı ekle
                string insertQuery = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@username", newUsername);
                cmd.Parameters.AddWithValue("@password", newPassword);
                cmd.Parameters.AddWithValue("@role", selectedRole);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı başarıyla eklendi! Veritabanını kontrol edin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Kayıt başarılı olursa formu kapat
            }
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde çalışacak kod (Şimdilik boş bırakıyoruz)
        }

    }
}
