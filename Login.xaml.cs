using Manage_student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Manage_student
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly Manage_studentContext _context;
        public Login()
        {
            InitializeComponent();
            _context = new Manage_studentContext();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Kiểm tra xem có tài khoản trong cơ sở dữ liệu không
            Account user = _context.Accounts.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                MessageBox.Show("Đăng nhập thành công!");

                // Tạo một thể hiện của cửa sổ chính
                MainWindow mainWindow = new MainWindow();

                // Hiển thị cửa sổ chính
                mainWindow.Show();

                // Đóng cửa sổ đăng nhập
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công. Vui lòng thử lại!");
            }
        }
    }
}

