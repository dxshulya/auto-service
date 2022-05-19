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

namespace AutoServiceApp.MyWindows.Client
{
    /// <summary>
    /// Логика взаимодействия для ClientWindow.xaml
    /// </summary>
    public partial class ClientWindow : Window
    {
        auto_service_dbEntities auto_Service = new auto_service_dbEntities();
        User _user = new User();

        public ClientWindow(User user)
        {
            InitializeComponent();

            _user = user;

            servicesGrid.ItemsSource = auto_Service.Service.ToList();
            bookingServicesGrid.ItemsSource = auto_Service.Client_Service.Where(item => item.client_id == user.client_id).ToList();
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {
            if (servicesGrid.SelectedItems.Count == 1)
            {
                Service service = (Service)servicesGrid.SelectedItems[0];
                if (MessageBox.Show("Заказать?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    try
                    {
                        Client_Service client_Service = new Client_Service();

                        client_Service.client_id = _user.client_id;
                        client_Service.employee_id = 1;
                        client_Service.service_id = service.service_id;

                        auto_Service.Client_Service.Add(client_Service);
                        auto_Service.SaveChanges();

                        bookingServicesGrid.ItemsSource = auto_Service.Client_Service.ToList();
                        MessageBox.Show("Успешно добавлено", "Ура!");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Упс!");
                    }

                }
            }
        }

        private void Delete_btn_Click(object sender, RoutedEventArgs e)
        {
            if (bookingServicesGrid.SelectedItems.Count == 1)
            {
                Client_Service client_Service = (Client_Service)bookingServicesGrid.SelectedItems[0];
                if (MessageBox.Show("Удалить?", "Внимание!", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    try
                    {                       
                        auto_Service.Client_Service.Remove(client_Service);
                        auto_Service.SaveChanges();

                        bookingServicesGrid.ItemsSource = auto_Service.Client_Service.ToList();
                        MessageBox.Show("Успешно удалено", "Ура!");
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Упс!");
                    }

                }
            }
        }
    }
}
