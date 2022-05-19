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
    /// Логика взаимодействия для EmployeeWindow.xaml
    /// </summary>
    public partial class EmployeeWindow : Window
    {

        auto_service_dbEntities auto_Service = new auto_service_dbEntities();
        User _user = new User();

        public EmployeeWindow(User user)
        {
            InitializeComponent();

            _user = user;
            clientsGrid.ItemsSource = auto_Service.Client.ToList();
            bookingServicesGrid.ItemsSource = auto_Service.Client_Service.ToList();
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e) //добавить клиента
        {
            AddEditWindow addEditWindow = new AddEditWindow();
            addEditWindow.Show();
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e) //удалить клиента
        {
            if (clientsGrid.SelectedItems.Count == 1)
            {
                Model.Client client = (Model.Client)clientsGrid.SelectedItems[0];
                auto_Service.Client.Remove(client);

                User currentUser = auto_Service.User.FirstOrDefault(item => item.client_id == client.client_id);
                auto_Service.User.Remove(currentUser);

                var currentService = auto_Service.Client_Service.Where(item => item.client_id == client.client_id);
                
                auto_Service.Client_Service.RemoveRange(currentService);

                auto_Service.SaveChanges();

                clientsGrid.ItemsSource = auto_Service.Client.ToList();

            }
        }

        private void Change_btn_Click(object sender, RoutedEventArgs e) //изменить клиента
        {
            if (clientsGrid.SelectedItems.Count == 1)
            {
                AddEditWindow addEditWindow = new AddEditWindow((Model.Client)clientsGrid.SelectedItems[0]);
                addEditWindow.Show();
            }
        }

        private void Update_btn_Click(object sender, RoutedEventArgs e) //завершить заказ
        {
            if (bookingServicesGrid.SelectedItems.Count == 1)
            {
                Client_Service client = (Client_Service)bookingServicesGrid.SelectedItems[0];

                try
                {
                    auto_Service.Client_Service.Remove(client);
                    auto_Service.SaveChanges();

                    bookingServicesGrid.ItemsSource = auto_Service.Client_Service.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Упс!");
                }
            }
        }

        private void Update_table_btn_Click(object sender, RoutedEventArgs e) //обновить данные после добавления
        {
            auto_Service.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            clientsGrid.ItemsSource = auto_Service.Client.ToList();
        }
    }
}
