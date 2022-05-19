using AutoServiceApp.Model;
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

namespace AutoServiceApp.MyWindows.Employee
{
    /// <summary>
    /// Логика взаимодействия для AddEditWindow.xaml
    /// </summary>
    public partial class AddEditWindow : Window
    {
        auto_service_dbEntities auto_Service = new auto_service_dbEntities();

        Model.Client _client = new Model.Client();
        Model.User user = new Model.User();

        public AddEditWindow()
        {
            InitializeComponent();
        }

        public AddEditWindow(Model.Client client)
        {
            InitializeComponent();

            _client.client_id = client.client_id;
            surname_box.Text = client.surname;
            name_box.Text = client.name;
            lastname_box.Text = client.lastname;
            telephone_box.Text = client.telephone;

            var currentClient = auto_Service.User.Where(item => item.client_id == client.client_id).ToList();

            login_box.Text = currentClient.Last().login;
            password_box.Password = currentClient.Last().password;

        }

        private void Button_Click(object sender, RoutedEventArgs e) //сохранить
        {
            if (isChecked())
            {
                try
                {
                    Model.Client client = new Model.Client();
                    Model.User user = new Model.User();

                    client.lastname = lastname_box.Text;
                    client.name = name_box.Text;
                    client.surname = surname_box.Text;
                    client.telephone = telephone_box.Text;

                    auto_Service.Client.Add(client);
                    auto_Service.SaveChanges();

                    user.login = login_box.Text;
                    user.password = password_box.Password;
                    user.role_id = 1;

                    var currentClient = auto_Service.Client.ToList();
                    user.client_id = currentClient.Last().client_id;

                    auto_Service.User.Add(user);
                    auto_Service.SaveChanges();

                    MessageBox.Show("Клиент добавлен в систему", "Ура!");

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
            if (string.IsNullOrEmpty(surname_box.Text))
            {
                error.AppendLine("Введите фамилию");
            }
            if (string.IsNullOrEmpty(name_box.Text))
            {
                error.AppendLine("Введите имя");
            }
            if (string.IsNullOrEmpty(lastname_box.Text))
            {
                error.AppendLine("Введите отчество");
            }
            if (string.IsNullOrEmpty(telephone_box.Text))
            {
                error.AppendLine("Введите телефон");
            }
            if (string.IsNullOrEmpty(login_box.Text))
            {
                error.AppendLine("Введите логин");
            }
            if (string.IsNullOrEmpty(password_box.Password))
            {
                error.AppendLine("Введите пароль");
            }
            if (error.Length > 0)
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
