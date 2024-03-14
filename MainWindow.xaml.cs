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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Manage_student
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded; // Gắn sự kiện Loaded của cửa sổ với phương thức MainWindow_Loaded
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnDepartment_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnStudent_Click(object sender, RoutedEventArgs e)
        {
            WindowStudents windowStudents = new WindowStudents();
            windowStudents.Show();
            this.Close();
        }

        private void btnCourse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTeacher_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAssignment_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}



