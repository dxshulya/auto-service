using AutoServiceApp.Model;
using AutoServiceApp.MyWindows.Admin;
using AutoServiceApp.MyWindows.Client;
using AutoServiceApp.MyWindows.Employee;
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

namespace AutoServiceApp.MyWindows.Auth
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        auto_service_dbEntities auto_Service = new auto_service_dbEntities();

        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Reg_btn_Click(object sender, RoutedEventArgs e)
        {
            if (isChecked())
            {
                try
                {
                    Model.User user = auto_Service.User.FirstOrDefault(u => u.password == password_box.Password && u.login == login_box.Text);

                    if (user != null)
                    {
                        if (user.role_id == 1)
                        {
                            ClientWindow clientWindow = new ClientWindow(user);
                            clientWindow.Show();
                            this.Close();
                        }

                        if (user.role_id == 2)
                        {
                            EmployeeWindow employeeWindow = new EmployeeWindow(user);
                            employeeWindow.Show();
                            this.Close();
                        }

                        if (user.role_id == 3)
                        {
                            AdminWindow adminWindow = new AdminWindow();
                            adminWindow.Show();
                            this.Close();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Упс!");
                }
            }
        }

        private bool isChecked()
        {
            StringBuilder error = new StringBuilder();
            if (string.IsNullOrEmpty(login_box.Text))
            {
                error.AppendLine("Введите логин");
            }

            if (string.IsNullOrEmpty(password_box.Password))
            {
                error.AppendLine("Введите пароль");
            }

            if(error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Ошибка!");
                return false;
            }

            else
            {
                return true;
            }
        }
    }
}
