using Language.Model;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace Language.Pages
{
    /// <summary>
    /// Логика взаимодействия для VisitingPage.xaml
    /// </summary>
    public partial class VisitingPage : Page
    {
        Client client;
        public VisitingPage(Client cl)
        {
            InitializeComponent();
            client = cl;
            try
            {
                Load();
                if (client.PhotoPath != null)
                {
                    string imagePath = "C:\\Users\\sasha\\source\\repos\\Language\\Language\\Клиенты\\" + client.PhotoPath.Trim();
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.UriSource = new Uri(imagePath);
                    bitmapImage.DecodePixelWidth = 100; // Установите желаемую ширину миниатюры (в пикселях)
                    bitmapImage.EndInit();

                    // Установите BitmapImage в элемент Image на вашей форме (назовем его MyImage)
                    AgentImage.Source = bitmapImage;
                }
                FirstName.Text = "Имя " + client.FirstName;
                LastName.Text = "Фамилия " + client.LastName;
                if (client.Patronymic != "" || (client.Patronymic != null))
                {
                    MiddleName.Text = "Отчество " + client.Patronymic;
                }
                else
                {
                    MiddleName.Text = "Отчество отсутствует";
                }


            }
            catch
            {

            }


        }
        public void Load()
        {
            DataView.ItemsSource = schoollanguageEntities.GetContext().ClientService.Where(Client => Client.ClientID == client.ID).ToList();
            CountVisit.Text = "Кол-во посещений " + schoollanguageEntities.GetContext().ClientService.Where(Client => Client.ClientID == client.ID).Count().ToString();
        }

       

        private void EditService_Click(object sender, RoutedEventArgs e)
        {
            Load();
        }
    }
 }

