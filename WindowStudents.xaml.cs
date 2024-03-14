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
using Microsoft.EntityFrameworkCore;

namespace Manage_student
{
    /// <summary>
    /// Interaction logic for WindowStudents.xaml
    /// </summary>
    public partial class WindowStudents : Window
    {
        private readonly Manage_studentContext _context;
        public WindowStudents()
        {
            InitializeComponent();
            _context = new Manage_studentContext();
            LoadDepartments();
            LoadClasses();
            LoadData();
        }

        private void LoadDepartments()
        {
            cmbDepartment.ItemsSource = _context.Departments.ToList();
            cmbDepartment.DisplayMemberPath = "DepartmentName";
        }

        private void LoadClasses()
        {
            cmbClass.ItemsSource = _context.Classes.ToList();
            cmbClass.DisplayMemberPath = "ClassName";
        }

        private void LoadData()
        {
            var studentsWithInfo = _context.Students
                .Include(student => student.Department) // Load thông tin từ bảng Department
                .Include(student => student.Class)      // Load thông tin từ bảng Class
                .ToList();

            DGView.ItemsSource = studentsWithInfo;
        }

        private Student GetInfo()
        {
            // Tạo một đối tượng Student mới với dữ liệu từ TextBoxes và ComboBoxes
            var newStudent = new Student
            {
                FullName = txtFullName.Text,
                Email = txtEmail.Text,
                DepartmentId = ((Department)cmbDepartment.SelectedItem).DepartmentId,
                ClassId = ((Class)cmbClass.SelectedItem).ClassId
            };

            return newStudent;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var newStudent = GetInfo();
            _context.Students.Add(newStudent);
            _context.SaveChanges();
            LoadData();
        }

        private void DGView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedStudent = (Student)DGView.SelectedItem;
            if (selectedStudent != null)
            {
                txtStudentID.Text = selectedStudent.StudentId.ToString();
                txtFullName.Text = selectedStudent.FullName;
                txtEmail.Text = selectedStudent.Email;
                cmbDepartment.SelectedItem = selectedStudent.Department;
                cmbClass.SelectedItem = selectedStudent.Class;
            }
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = (Student)DGView.SelectedItem;
            if (selectedStudent != null)
            {
                var updatedStudent = GetInfo();
                selectedStudent.FullName = updatedStudent.FullName;
                selectedStudent.Email = updatedStudent.Email;
                selectedStudent.DepartmentId = updatedStudent.DepartmentId;
                selectedStudent.ClassId = updatedStudent.ClassId;

                _context.SaveChanges();
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = (Student)DGView.SelectedItem;
            if (selectedStudent != null)
            {
                _context.Students.Remove(selectedStudent);
                _context.SaveChanges();
                LoadData();
            }
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}