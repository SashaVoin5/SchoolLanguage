using Language.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddClient.xaml
    /// </summary>
    public partial class EditClient : Page
    {
        public string PathImage = "";
        Client cl;
        int IdClient = 0;
        public EditClient(Client client)
        {
            InitializeComponent();
            cl =  client;


            Gender.ItemsSource = GenderMass;
            var tag = schoollanguageEntities.GetContext().Tag;
            foreach (var item in tag)
            {
                Tag.Items.Add(item.Title);
            }

            cl = client;
            IdClient = cl.ID;
            ID.Text = cl.ID.ToString();
            FirstName.Text = cl.FirstName.ToString();
            LastName.Text = cl.LastName.ToString();
            Patronymic.Text = cl.Patronymic.ToString();
            Email.Text = cl.Email.ToString();
            Phone.Text = cl.Phone.ToString();
            Birthday.Text = cl.Birthday.ToString();
            RegistrationDate.Text = cl.RegistrationDate.ToString();
            string genCode = cl.GenderCode;
            var Gen = schoollanguageEntities.GetContext().Gender.Where(GENDER => GENDER.Code == genCode);
            foreach (var item in Gen)
            {
                Gender.Text = item.Name;
            }
            if (cl.PhotoPath != null)
            {
                string imagePath = "C:\\Users\\sasha\\source\\repos\\Language\\Language\\Клиенты\\" + cl.PhotoPath.Trim();
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri(imagePath);
                bitmapImage.DecodePixelWidth = 100; // Установите желаемую ширину миниатюры (в пикселях)
                bitmapImage.EndInit();

                // Установите BitmapImage в элемент Image на вашей форме (назовем его MyImage)
                AgentImage.Source = bitmapImage;
            }
            TagGrid.ItemsSource = schoollanguageEntities.GetContext().TagOfClient.Where(ProductSale => ProductSale.ClientID == cl.ID).ToList();
        }
        private void AddImage_click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Файлы изображений: (*.png, *.jpg,*.jpeg)|*png; *jpg; *jpeg";
            OFD.InitialDirectory = "C:\\Users\\sasha\\source\\repos\\Language\\Language\\Клиенты\\"; //Сюда будут сохраняться все фотографии
            if (OFD.ShowDialog() == true)
            {
                string imagePath = OFD.FileName; //АБСОЛЮТНЫЙ ПУТЬ К ФАЙЛУ

                // Создайте BitmapImage из выбранной фотографии
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri(imagePath);
                bitmapImage.DecodePixelWidth = 100; // Установите желаемую ширину миниатюры (в пикселях)
                bitmapImage.EndInit();

                // Установите BitmapImage в элемент Image на вашей форме (назовем его MyImage)
                AgentImage.Source = bitmapImage;

                // Сохраните путь к выбранной фотографии, если это необходимо
                PathImage = OFD.SafeFileName; //ОТНОСИТЕЛЬНЫЙ ПУТЬ К ФАЙЛУ
            }
        }
        public string[] GenderMass { get; set; } =
        {
            "Мужчина",
            "Женщина"

        };
        private void AddClient_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (FirstName.Text.Length > 50)
                {
                    MessageBox.Show("Имя не может быть длиннее 50 символов!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                if (LastName.Text.Length > 50)
                {
                    MessageBox.Show("Фамилия не может быть длиннее 50 символов!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                if (Patronymic.Text.Length > 50)
                {
                    MessageBox.Show("Отчество не может быть длиннее 50 символов!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                if (FirstName.Text == "")
                {
                    MessageBox.Show("Введите имя!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                if (LastName.Text == "")
                {
                    MessageBox.Show("Введите фамилию!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                if (Patronymic.Text == "")
                {
                    MessageBox.Show("Введите отчество!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                if (new Regex(@"^[a-zA-Z\s\-]+$").IsMatch(FirstName.Text))
                {
                    MessageBox.Show("Введите имя!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                if (new Regex(@"^[a-zA-Z\s\-]+$").IsMatch(LastName.Text))
                {
                    MessageBox.Show("Введите фамилию!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                if (new Regex(@"^[a-zA-Z\s\-]+$").IsMatch(Patronymic.Text)) //знак ! это тип не должно быть
                {
                    MessageBox.Show("Введите отчество!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                if ((Email.Text != "") && (!(new Regex(@"(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)")).IsMatch(Email.Text)))
                {
                    MessageBox.Show("Введите электронную почту!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                };

                if (!new Regex(@"^[0-9+\-\(\)\s]+$").IsMatch(Phone.Text)) //\s это любой пробел.Здесь валидация на + и - и на скобки Короче валидация огонь!!! и знак ! это тип не должно быть, короче так надо)))
                {
                    MessageBox.Show("Введите телефон!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                int gen = Gender.SelectedIndex + 1;
                Client newClient = new Client()
                {
                    LastName = LastName.Text.ToString(),
                    FirstName = FirstName.Text.ToString(),
                    Patronymic = Patronymic.Text.ToString(),
                    Birthday = (DateTime)Birthday.SelectedDate,
                    RegistrationDate = (DateTime)RegistrationDate.SelectedDate,
                    Email = Email.Text.ToString(),
                    Phone = Phone.Text.ToString(),
                    GenderCode = gen.ToString(),
                    PhotoPath = PathImage

                };
                schoollanguageEntities.GetContext().Client.Add(newClient);
                schoollanguageEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные успешно сохранены!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка ", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void AddTag_Click(object sender, RoutedEventArgs e)
        {
            if (Tag.SelectedItem == null)
            {
                MessageBox.Show("Выберите тэг!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            string TagName = Tag.SelectedItem.ToString();
            var SelectedTagID = schoollanguageEntities.GetContext().Tag.Where(p => p.Title == TagName).FirstOrDefault();



            try
            {


                TagOfClient newTag = new TagOfClient
                {
                    ClientID = IdClient,
                    TagID = SelectedTagID.ID,

                };
                schoollanguageEntities.GetContext().TagOfClient.Add(newTag);
                schoollanguageEntities.GetContext().SaveChanges();
                TagGrid.ItemsSource = schoollanguageEntities.GetContext().TagOfClient.Where(p => p.ClientID == cl.ID).ToList();
            }
            catch { }


        }

        private void DeleteTag_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < TagGrid.SelectedItems.Count; i++)
            {
                TagOfClient prs = TagGrid.SelectedItem as TagOfClient;
                if (prs != null)
                {
                    schoollanguageEntities.GetContext().TagOfClient.Remove(prs);
                }
            }
            try
            {
                schoollanguageEntities.GetContext().SaveChanges();
                TagGrid.ItemsSource = schoollanguageEntities.GetContext().TagOfClient.Where(ProductSale => ProductSale.ClientID == cl.ID).ToList();

            }
            catch { return; };
        }
    }
}
