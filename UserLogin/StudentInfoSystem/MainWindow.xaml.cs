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

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Student mockStudent = StudentData.testStudentsData().ElementAt(0);
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            name.IsEnabled = false;
            midleName.IsEnabled = false;
            lastName.IsEnabled = false;
            faculty.IsEnabled = false;
            speciality.IsEnabled = false;
            oks.IsEnabled = false;
            status.IsEnabled = false;
            facultyNumber.IsEnabled = false;
            course.IsEnabled = false;
            stream.IsEnabled = false;
            group.IsEnabled = false;

            MessageBox.Show("ALL TABS ARE DISABLED");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            name.IsEnabled = true;
            midleName.IsEnabled = true;
            lastName.IsEnabled = true;
            faculty.IsEnabled = true;
            speciality.IsEnabled = true;
            oks.IsEnabled = true;
            status.IsEnabled = true;
            facultyNumber.IsEnabled = true;
            course.IsEnabled = true;
            stream.IsEnabled = true;
            group.IsEnabled = true;

            MessageBox.Show("ALL TABS ARE ENABLED");
        }

        private void TextBox_TextChanged_faculty(object sender, TextChangedEventArgs e)
        {
            faculty.Text = mockStudent.faculty;
        }

        private void TextBox_TextChanged_speciality(object sender, TextChangedEventArgs e)
        {
            speciality.Text = mockStudent.specialty;
        }

        private void TextBox_TextChanged_oks(object sender, TextChangedEventArgs e)
        {
            oks.Text = "Dori ne znam kakvo e tova";
        }

        private void TextBox_TextChanged_status(object sender, TextChangedEventArgs e)
        {
            status.Text = mockStudent.status;
        }

        private void TextBox_TextChanged_facultyNumber(object sender, TextChangedEventArgs e)
        {
            facultyNumber.Text = mockStudent.facultyNumber.ToString();
        }

        private void TextBox_TextChanged_course(object sender, TextChangedEventArgs e)
        {
            course.Text = mockStudent.course;
        }

        private void TextBox_TextChanged_stream(object sender, TextChangedEventArgs e)
        {
            stream.Text = mockStudent.stream;
        }

        private void TextBox_TextChanged_name(object sender, TextChangedEventArgs e)
        {
            name.Text = mockStudent.name;
        }

        private void TextBox_TextChanged_midleName(object sender, TextChangedEventArgs e)
        {
            midleName.Text = mockStudent.middleName;
        }

        private void TextBox_TextChanged_lastName(object sender, TextChangedEventArgs e)
        {
            lastName.Text = mockStudent.lastName;
        }

        private void TextBox_TextChanged_group(object sender, TextChangedEventArgs e)
        {
            group.Text = mockStudent.group;
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            name.Clear();
            midleName.Clear();
            lastName.Clear();
            faculty.Clear();
            speciality.Clear();
            oks.Clear();
            status.Clear();
            facultyNumber.Clear();
            course.Clear();
            stream.Clear();
            group.Clear();

            MessageBox.Show("ALL TABS ARE CLEARED!");
        }
    }
}