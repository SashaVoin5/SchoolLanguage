using Language.Model;
using System;
using System.Collections;
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

namespace Language.Pages
{
    /// <summary>
    /// Логика взаимодействия для ClientView.xaml
    /// </summary>
    public partial class ClientView : Page
    {

        public int fullcount = 0;
        public int IndexFilter = 0;
        public int start = 0;
        int ViewPages = 10;
        public string SearchText = "";
        public ClientView(Frame frame)
        {
            InitializeComponent();
            ComboBoxSorting.ItemsSource = SortingList;
            ComboBoxSorting.Text = "Без сортировки";
            ComboBoxFilter.ItemsSource = FilterList;
            ComboBoxFilter.Text = "Без фильтрации";
            Load();
        }

        public void Load()
        {

            if (ComboBoxSorting.SelectedIndex == 0)
            {
                var Data = schoollanguageEntities.GetContext().Client.OrderBy(p => p.ID).ToList();
                if (ViewPages == 10)
                {
                    DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                    fullcount = Data.Count();

                    Load10();
                }
                if (ViewPages == 50)
                {
                    DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                    fullcount = Data.Count();

                    Load50();
                }
                if (ViewPages == 200)
                {
                    DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                    fullcount = Data.Count();

                    Load200();
                }
                if (ViewPages == 555)
                {
                    DataView.ItemsSource = Data;
                    fullcount = Data.Count();

                    LoadAll();
                }

            }
            if (ComboBoxSorting.SelectedIndex == 1)
            {
                var Data = schoollanguageEntities.GetContext().Client.OrderBy(p => p.LastName).ToList();
                if (ViewPages == 10)
                {
                    DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                    fullcount = Data.Count();
                    Load10();
                }
                if (ViewPages == 50)
                {
                    DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                    fullcount = Data.Count();
                    Load50();
                }
                if (ViewPages == 200)
                {
                    DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                    fullcount = Data.Count();
                    Load200();
                }
                if (ViewPages == 555)
                {
                    DataView.ItemsSource = Data;
                    fullcount = Data.Count();
                    LoadAll();
                }
            }
            if (ComboBoxSorting.SelectedIndex == 2)
            {
                var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.DataVisitint).ToList();
                if (ViewPages == 10)
                {
                    DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                    fullcount = Data.Count();
                    Load10();
                }
                if (ViewPages == 50)
                {
                    DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                    fullcount = Data.Count();
                    Load50();
                }
                if (ViewPages == 200)
                {
                    DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                    fullcount = Data.Count();
                    Load200();
                }
                if (ViewPages == 555)
                {
                    DataView.ItemsSource = Data;
                    fullcount = Data.Count();
                    LoadAll();
                }
            }
            if (ComboBoxSorting.SelectedIndex == 3)
            {
                var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.DataVisitint).ToList();
                if (ViewPages == 10)
                {
                    DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                    fullcount = Data.Count();
                    Load10();
                }
                if (ViewPages == 50)
                {
                    DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                    fullcount = Data.Count();
                    Load50();
                }
                if (ViewPages == 200)
                {
                    DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                    fullcount = Data.Count();
                    Load200();
                }
                if (ViewPages == 555)
                {
                    DataView.ItemsSource = Data;
                    fullcount = Data.Count();
                    LoadAll();
                }
            }
            if (ComboBoxSorting.SelectedIndex == 4)
            {
                var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.CountVisitint).ToList();
                if (ViewPages == 10)
                {
                    DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                    fullcount = Data.Count();
                    Load10();
                }
                if (ViewPages == 50)
                {
                    DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                    fullcount = Data.Count();
                    Load50();
                }
                if (ViewPages == 200)
                {
                    DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                    fullcount = Data.Count();
                    Load200();
                }
                if (ViewPages == 555)
                {
                    DataView.ItemsSource = Data;
                    fullcount = Data.Count();
                    LoadAll();
                }
            }
            if (ComboBoxSorting.SelectedIndex == 5)
            {
                var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.CountVisitint).ToList();
                if (ViewPages == 10)
                {
                    DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                    fullcount = Data.Count();
                    Load10();
                }
                if (ViewPages == 50)
                {
                    DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                    fullcount = Data.Count();
                    Load50();
                }
                if (ViewPages == 200)
                {
                    DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                    fullcount = Data.Count();
                    Load200();
                }
                if (ViewPages == 555)
                {
                    DataView.ItemsSource = Data;
                    fullcount = Data.Count();
                    LoadAll();
                }
            }

            if (IndexFilter != 0)
            {
                string filter = IndexFilter.ToString();
                var Data = schoollanguageEntities.GetContext().Client.OrderBy(Client => Client.ID).Where(p => p.GenderCode == filter).ToList();
                if (ViewPages == 10)
                {
                    DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                    fullcount = Data.Count();
                    Load10();
                }
                if (ViewPages == 50)
                {
                    DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                    fullcount = Data.Count();
                    Load50();
                }
                if (ViewPages == 200)
                {
                    DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                    fullcount = Data.Count();
                    Load200();
                }
                if (ViewPages == 555)
                {
                    DataView.ItemsSource = Data;
                    fullcount = Data.Count();
                    LoadAll();
                }
            }
            if (ComboBoxSorting.SelectedIndex != 0 && IndexFilter != 0)
            {
                if (ComboBoxSorting.SelectedIndex == 0)
                {
                    string filter = IndexFilter.ToString();
                    var Data = schoollanguageEntities.GetContext().Client.OrderBy(Client => Client.ID).Where(Client => Client.GenderCode == filter).ToList();
                    if (ViewPages == 10)
                    {
                        DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                        fullcount = Data.Count();

                        Load10();
                    }
                    if (ViewPages == 50)
                    {
                        DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                        fullcount = Data.Count();

                        Load50();
                    }
                    if (ViewPages == 200)
                    {
                        DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                        fullcount = Data.Count();

                        Load200();
                    }
                    if (ViewPages == 555)
                    {
                        DataView.ItemsSource = Data;
                        fullcount = Data.Count();

                        LoadAll();
                    }

                }
                if (ComboBoxSorting.SelectedIndex == 1)
                {
                    string filter = IndexFilter.ToString();
                    var Data = schoollanguageEntities.GetContext().Client.OrderBy(p => p.LastName).Where(Client => Client.GenderCode == filter).ToList();
                    if (ViewPages == 10)
                    {
                        DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                        fullcount = Data.Count();
                        Load10();
                    }
                    if (ViewPages == 50)
                    {
                        DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                        fullcount = Data.Count();
                        Load50();
                    }
                    if (ViewPages == 200)
                    {
                        DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                        fullcount = Data.Count();
                        Load200();
                    }
                    if (ViewPages == 555)
                    {
                        DataView.ItemsSource = Data;
                        fullcount = Data.Count();
                        LoadAll();
                    }
                }
                if (ComboBoxSorting.SelectedIndex == 2)
                {
                    string filter = IndexFilter.ToString();
                    var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.DataVisitint).Where(Client => Client.GenderCode == filter).ToList();
                    if (ViewPages == 10)
                    {
                        DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                        fullcount = Data.Count();
                        Load10();
                    }
                    if (ViewPages == 50)
                    {
                        DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                        fullcount = Data.Count();
                        Load50();
                    }
                    if (ViewPages == 200)
                    {
                        DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                        fullcount = Data.Count();
                        Load200();
                    }
                    if (ViewPages == 555)
                    {
                        DataView.ItemsSource = Data;
                        fullcount = Data.Count();
                        LoadAll();
                    }
                }
                if (ComboBoxSorting.SelectedIndex == 3)
                {
                    string filter = IndexFilter.ToString();
                    var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.DataVisitint).Where(Client => Client.GenderCode == filter).ToList();
                    if (ViewPages == 10)
                    {
                        DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                        fullcount = Data.Count();
                        Load10();
                    }
                    if (ViewPages == 50)
                    {
                        DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                        fullcount = Data.Count();
                        Load50();
                    }
                    if (ViewPages == 200)
                    {
                        DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                        fullcount = Data.Count();
                        Load200();
                    }
                    if (ViewPages == 555)
                    {
                        DataView.ItemsSource = Data;
                        fullcount = Data.Count();
                        LoadAll();
                    }
                }
                if (ComboBoxSorting.SelectedIndex == 4)
                {
                    string filter = IndexFilter.ToString();
                    var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.CountVisitint).Where(Client => Client.GenderCode == filter).ToList();
                    if (ViewPages == 10)
                    {
                        DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                        fullcount = Data.Count();
                        Load10();
                    }
                    if (ViewPages == 50)
                    {
                        DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                        fullcount = Data.Count();
                        Load50();
                    }
                    if (ViewPages == 200)
                    {
                        DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                        fullcount = Data.Count();
                        Load200();
                    }
                    if (ViewPages == 555)
                    {
                        DataView.ItemsSource = Data;
                        fullcount = Data.Count();
                        LoadAll();
                    }
                }
                if (ComboBoxSorting.SelectedIndex == 5)
                {
                    string filter = IndexFilter.ToString();
                    var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.CountVisitint).Where(Client => Client.GenderCode == filter).ToList();
                    if (ViewPages == 10)
                    {
                        DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                        fullcount = Data.Count();
                        Load10();
                    }
                    if (ViewPages == 50)
                    {
                        DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                        fullcount = Data.Count();
                        Load50();
                    }
                    if (ViewPages == 200)
                    {
                        DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                        fullcount = Data.Count();
                        Load200();
                    }
                    if (ViewPages == 555)
                    {
                        DataView.ItemsSource = Data;
                        fullcount = Data.Count();
                        LoadAll();
                    }
                }
            }

                if (SearchText != "")
                {
                if (IndexFilter != 0)
                {
                    string filter = IndexFilter.ToString();
                    var Data = schoollanguageEntities.GetContext().Client.OrderBy(Client => Client.ID).Where(Client => Client.LastName.Contains(SearchText) && Client.GenderCode == filter || Client.Phone.Contains(SearchText) && Client.GenderCode == filter || Client.FirstName.Contains(SearchText) && Client.GenderCode == filter || Client.Patronymic.Contains(SearchText) && Client.GenderCode == filter || Client.Email.Contains(SearchText) && Client.GenderCode == filter).ToList();
                    if (ViewPages == 10)
                    {
                        DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                        fullcount = Data.Count();
                        Load10();
                    }
                    if (ViewPages == 50)
                    {
                        DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                        fullcount = Data.Count();
                        Load50();
                    }
                    if (ViewPages == 200)
                    {
                        DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                        fullcount = Data.Count();
                        Load200();
                    }
                    if (ViewPages == 555)
                    {
                        DataView.ItemsSource = Data;
                        fullcount = Data.Count();
                        LoadAll();
                    }

                }
                else
                {
                    var Data = schoollanguageEntities.GetContext().Client.OrderBy(Client => Client.ID).Where(Client => Client.LastName.Contains(SearchText) || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) || Client.Patronymic.Contains(SearchText) || Client.Email.Contains(SearchText)).ToList();
                    if (ViewPages == 10)
                    {
                        DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                        fullcount = Data.Count();
                        Load10();
                    }
                    if (ViewPages == 50)
                    {
                        DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                        fullcount = Data.Count();
                        Load50();
                    }
                    if (ViewPages == 200)
                    {
                        DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                        fullcount = Data.Count();
                        Load200();
                    }
                    if (ViewPages == 555)
                    {
                        DataView.ItemsSource = Data;
                        fullcount = Data.Count();
                        LoadAll();
                    }
                }
                if (ComboBoxSorting.SelectedIndex != 0 && IndexFilter == 0)
                {
                    if (ComboBoxSorting.SelectedIndex == 0)
                    {
                        var Data = schoollanguageEntities.GetContext().Client.OrderBy(p => p.ID).Where(Client => Client.LastName.Contains(SearchText) || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) || Client.Patronymic.Contains(SearchText) || Client.Email.Contains(SearchText)).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();

                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();

                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();

                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();

                            LoadAll();
                        }

                    }
                    if (ComboBoxSorting.SelectedIndex == 1)
                    {
                        var Data = schoollanguageEntities.GetContext().Client.OrderBy(p => p.LastName).Where(Client => Client.LastName.Contains(SearchText) || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) || Client.Patronymic.Contains(SearchText) || Client.Email.Contains(SearchText)).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();
                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();
                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();
                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();
                            LoadAll();
                        }
                    }
                    if (ComboBoxSorting.SelectedIndex == 2)
                    {
                        var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.DataVisitint).Where(Client => Client.LastName.Contains(SearchText) || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) || Client.Patronymic.Contains(SearchText) || Client.Email.Contains(SearchText)).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();
                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();
                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();
                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();
                            LoadAll();
                        }
                    }
                    if (ComboBoxSorting.SelectedIndex == 3)
                    {
                        var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.DataVisitint).Where(Client => Client.LastName.Contains(SearchText) || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) || Client.Patronymic.Contains(SearchText) || Client.Email.Contains(SearchText)).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();
                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();
                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();
                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();
                            LoadAll();
                        }
                    }
                    if (ComboBoxSorting.SelectedIndex == 4)
                    {
                        var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.CountVisitint).Where(Client => Client.LastName.Contains(SearchText) || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) || Client.Patronymic.Contains(SearchText) || Client.Email.Contains(SearchText)).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();
                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();
                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();
                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();
                            LoadAll();
                        }
                    }
                    if (ComboBoxSorting.SelectedIndex == 5)
                    {
                        var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.CountVisitint).Where(Client => Client.LastName.Contains(SearchText) || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) || Client.Patronymic.Contains(SearchText) || Client.Email.Contains(SearchText)).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();
                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();
                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();
                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();
                            LoadAll();
                        }
                    }
                }
                if (ComboBoxSorting.SelectedIndex != 0 && IndexFilter != 0)
                {
                    if (ComboBoxSorting.SelectedIndex == 0)
                    {
                        string filter = IndexFilter.ToString();
                        var Data = schoollanguageEntities.GetContext().Client.OrderBy(Client => Client.ID).Where(Client => Client.LastName.Contains(SearchText) && Client.GenderCode == filter || Client.Phone.Contains(SearchText) && Client.GenderCode == filter || Client.FirstName.Contains(SearchText) && Client.GenderCode == filter || Client.Patronymic.Contains(SearchText) && Client.GenderCode == filter || Client.Email.Contains(SearchText) && Client.GenderCode == filter).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();

                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();

                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();

                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();

                            LoadAll();
                        }

                    }
                    if (ComboBoxSorting.SelectedIndex == 1)
                    {
                        string filter = IndexFilter.ToString();
                        var Data = schoollanguageEntities.GetContext().Client.OrderBy(p => p.LastName).Where(Client => Client.LastName.Contains(SearchText) && Client.GenderCode == filter || Client.Phone.Contains(SearchText) && Client.GenderCode == filter  || Client.FirstName.Contains(SearchText) && Client.GenderCode == filter || Client.Patronymic.Contains(SearchText) && Client.GenderCode == filter || Client.Email.Contains(SearchText)).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();
                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();
                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();
                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();
                            LoadAll();
                        }
                    }
                    if (ComboBoxSorting.SelectedIndex == 2)
                    {
                        string filter = IndexFilter.ToString();
                        var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.DataVisitint).Where(Client => Client.LastName.Contains(SearchText) && Client.GenderCode == filter  || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) && Client.GenderCode == filter  || Client.Patronymic.Contains(SearchText) && Client.GenderCode == filter || Client.Email.Contains(SearchText)).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();
                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();
                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();
                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();
                            LoadAll();
                        }
                    }
                    if (ComboBoxSorting.SelectedIndex == 3)
                    {
                        string filter = IndexFilter.ToString();
                        var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.DataVisitint).Where(Client => Client.LastName.Contains(SearchText) && Client.GenderCode == filter  || Client.Phone.Contains(SearchText) && Client.GenderCode == filter  || Client.FirstName.Contains(SearchText) && Client.GenderCode == filter || Client.Patronymic.Contains(SearchText) && Client.GenderCode == filter  || Client.Email.Contains(SearchText)).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();
                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();
                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();
                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();
                            LoadAll();
                        }
                    }
                    if (ComboBoxSorting.SelectedIndex == 4)
                    {
                        string filter = IndexFilter.ToString();
                        var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.CountVisitint).Where(Client => Client.LastName.Contains(SearchText) && Client.GenderCode == filter || Client.Phone.Contains(SearchText) && Client.GenderCode == filter || Client.FirstName.Contains(SearchText) && Client.GenderCode == filter || Client.Patronymic.Contains(SearchText) && Client.GenderCode == filter  || Client.Email.Contains(SearchText)).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();
                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();
                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();
                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();
                            LoadAll();
                        }
                    }
                    if (ComboBoxSorting.SelectedIndex == 5)
                    {
                        string filter = IndexFilter.ToString();
                        var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.CountVisitint).Where(Client => Client.LastName.Contains(SearchText) && Client.GenderCode == filter || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) && Client.GenderCode == filter  || Client.Patronymic.Contains(SearchText) && Client.GenderCode == filter || Client.Email.Contains(SearchText)).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();
                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();
                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();
                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();
                            LoadAll();
                        }
                    }
                }
            }

            if (Birthday.IsChecked == true)
            {
                int seeCount = 0;
                var serach = schoollanguageEntities.GetContext().Client.Where(Client => Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month).ToList();
                DataView.ItemsSource = serach;
                var countData = serach.Count();
                fullcount = countData;
                int ost = countData % 10;
                int pag = 0;
                pag = (countData - ost) / 100;
                if (ost > 0) pag++;
                if (pag == 0)
                {
                    pag++;
                }
                pagin.Children.Clear();
                for (int i = 0; i < pag; i++)
                {
                    Button myButton = new Button();
                    myButton.Height = 30;
                    myButton.Content = i + 1;
                    myButton.Width = 20;
                    myButton.HorizontalAlignment = HorizontalAlignment.Center;
                    myButton.Tag = i;
                    myButton.Click += new RoutedEventHandler(pagButton_Click);
                    pagin.Children.Add(myButton);
                }
                turnButton50();


                CountItem.Text = "Показано " + fullcount.ToString() + " записей  ";
                if (SearchText != "")
                {
                    if (IndexFilter != 0)
                    {
                        string filter = IndexFilter.ToString();
                        var Data = schoollanguageEntities.GetContext().Client.OrderBy(Client => Client.ID).Where(Client => Client.LastName.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Phone.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.FirstName.Contains(SearchText) && Client.GenderCode == filter || Client.Patronymic.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Email.Contains(SearchText) && Client.GenderCode == filter).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();
                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();
                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();
                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();
                            LoadAll();
                        }

                    }
                    else
                    {
                        var Data = schoollanguageEntities.GetContext().Client.OrderBy(Client => Client.ID).Where(Client => Client.LastName.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month  || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month  || Client.Patronymic.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Email.Contains(SearchText)).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();
                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();
                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();
                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();
                            LoadAll();
                        }
                    }
                    if (ComboBoxSorting.SelectedIndex != 0 && IndexFilter == 0)
                    {
                        if (ComboBoxSorting.SelectedIndex == 0)
                        {
                            var Data = schoollanguageEntities.GetContext().Client.OrderBy(p => p.ID).Where(Client => Client.LastName.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Phone.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.FirstName.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Patronymic.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Email.Contains(SearchText)).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();

                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();

                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();

                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();

                                LoadAll();
                            }

                        }
                        if (ComboBoxSorting.SelectedIndex == 1)
                        {
                            var Data = schoollanguageEntities.GetContext().Client.OrderBy(p => p.LastName).Where(Client => Client.LastName.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Patronymic.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Email.Contains(SearchText)).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 2)
                        {
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.DataVisitint).Where(Client => Client.LastName.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Patronymic.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Email.Contains(SearchText)).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 3)
                        {
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.DataVisitint).Where(Client => Client.LastName.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Patronymic.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Email.Contains(SearchText)).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 4)
                        {
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.CountVisitint).Where(Client => Client.LastName.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Patronymic.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Email.Contains(SearchText)).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 5)
                        {
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.CountVisitint).Where(Client => Client.LastName.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Patronymic.Contains(SearchText) && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Email.Contains(SearchText)).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                    }
                    if (ComboBoxSorting.SelectedIndex != 0 && IndexFilter != 0)
                    {
                        if (ComboBoxSorting.SelectedIndex == 0)
                        {
                            string filter = IndexFilter.ToString();
                            var Data = schoollanguageEntities.GetContext().Client.OrderBy(Client => Client.ID).Where(Client => Client.LastName.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Phone.Contains(SearchText) && Client.GenderCode == filter || Client.FirstName.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Patronymic.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Email.Contains(SearchText) && Client.GenderCode == filter).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();

                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();

                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();

                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();

                                LoadAll();
                            }

                        }
                        if (ComboBoxSorting.SelectedIndex == 1)
                        {
                            string filter = IndexFilter.ToString();
                            var Data = schoollanguageEntities.GetContext().Client.OrderBy(p => p.LastName).Where(Client => Client.LastName.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Phone.Contains(SearchText) && Client.GenderCode == filter || Client.FirstName.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Patronymic.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Email.Contains(SearchText)).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 2)
                        {
                            string filter = IndexFilter.ToString();
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.DataVisitint).Where(Client => Client.LastName.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month || Client.Patronymic.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month  || Client.Email.Contains(SearchText)).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 3)
                        {
                            string filter = IndexFilter.ToString();
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.DataVisitint).Where(Client => Client.LastName.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month  || Client.Phone.Contains(SearchText) && Client.GenderCode == filter || Client.FirstName.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month  || Client.Patronymic.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month  || Client.Email.Contains(SearchText)).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 4)
                        {
                            string filter = IndexFilter.ToString();
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.CountVisitint).Where(Client => Client.LastName.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month  || Client.Phone.Contains(SearchText) && Client.GenderCode == filter || Client.FirstName.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month  || Client.Patronymic.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month  || Client.Email.Contains(SearchText)).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 5)
                        {
                            string filter = IndexFilter.ToString();
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.CountVisitint).Where(Client => Client.LastName.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month  || Client.Phone.Contains(SearchText) || Client.FirstName.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month  || Client.Patronymic.Contains(SearchText) && Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month  || Client.Email.Contains(SearchText)).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                    }


                }
                else
                {
                    if (IndexFilter != 0)
                    {
                        string filter = IndexFilter.ToString();
                        var Data = schoollanguageEntities.GetContext().Client.OrderBy(Client => Client.ID).Where(Client =>  Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month).ToList();
                        if (ViewPages == 10)
                        {
                            DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                            fullcount = Data.Count();
                            Load10();
                        }
                        if (ViewPages == 50)
                        {
                            DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                            fullcount = Data.Count();
                            Load50();
                        }
                        if (ViewPages == 200)
                        {
                            DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                            fullcount = Data.Count();
                            Load200();
                        }
                        if (ViewPages == 555)
                        {
                            DataView.ItemsSource = Data;
                            fullcount = Data.Count();
                            LoadAll();
                        }

                    }
                   
                    if (ComboBoxSorting.SelectedIndex != 0 && IndexFilter == 0)
                    {
                        if (ComboBoxSorting.SelectedIndex == 0)
                        {
                            var Data = schoollanguageEntities.GetContext().Client.OrderBy(p => p.ID).Where(Client =>  Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();

                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();

                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();

                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();

                                LoadAll();
                            }

                        }
                        if (ComboBoxSorting.SelectedIndex == 1)
                        {
                            var Data = schoollanguageEntities.GetContext().Client.OrderBy(p => p.LastName).Where(Client => Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 2)
                        {
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.DataVisitint).Where(Client => Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 3)
                        {
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.DataVisitint).Where(Client => Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 4)
                        {
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.CountVisitint).Where(Client => Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 5)
                        {
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.CountVisitint).Where(Client => Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                    }
                    if (ComboBoxSorting.SelectedIndex != 0 && IndexFilter != 0)
                    {
                        if (ComboBoxSorting.SelectedIndex == 0)
                        {
                            string filter = IndexFilter.ToString();
                            var Data = schoollanguageEntities.GetContext().Client.OrderBy(Client => Client.ID).Where(Client =>  Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();

                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();

                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();

                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();

                                LoadAll();
                            }

                        }
                        if (ComboBoxSorting.SelectedIndex == 1)
                        {
                            string filter = IndexFilter.ToString();
                            var Data = schoollanguageEntities.GetContext().Client.OrderBy(p => p.LastName).Where(Client => Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 2)
                        {
                            string filter = IndexFilter.ToString();
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.DataVisitint).Where(Client => Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 3)
                        {
                            string filter = IndexFilter.ToString();
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.DataVisitint).Where(Client => Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 4)
                        {
                            string filter = IndexFilter.ToString();
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderByDescending(c => c.CountVisitint).Where(Client => Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                        if (ComboBoxSorting.SelectedIndex == 5)
                        {
                            string filter = IndexFilter.ToString();
                            var Data = schoollanguageEntities.GetContext().Client.ToList().OrderBy(c => c.CountVisitint).Where(Client => Client.GenderCode == filter && Client.Birthday.HasValue && Client.Birthday.Value.Month == DateTime.Now.Month).ToList();
                            if (ViewPages == 10)
                            {
                                DataView.ItemsSource = Data.Skip(start * 10).Take(10);
                                fullcount = Data.Count();
                                Load10();
                            }
                            if (ViewPages == 50)
                            {
                                DataView.ItemsSource = Data.Skip(start * 50).Take(50);
                                fullcount = Data.Count();
                                Load50();
                            }
                            if (ViewPages == 200)
                            {
                                DataView.ItemsSource = Data.Skip(start * 200).Take(200);
                                fullcount = Data.Count();
                                Load200();
                            }
                            if (ViewPages == 555)
                            {
                                DataView.ItemsSource = Data;
                                fullcount = Data.Count();
                                LoadAll();
                            }
                        }
                    }

                }
            }
        }

        public void LoadAll()
        {

            int pages = 1;
            pagin.Children.Clear();
            for (int i = 0; i < pages; i++)
            {
                Button myButton = new Button();
                myButton.Height = 30;
                myButton.Width = 20;
                myButton.HorizontalAlignment = HorizontalAlignment.Center;
                myButton.Content = i + 1;
                myButton.Tag = i;
                myButton.Click += new RoutedEventHandler(pagButton_Click);
                pagin.Children.Add(myButton);
            }
            CountItem.Text = "Показано " + fullcount.ToString() + " записей";
            Forward.IsEnabled = false;
            Back.IsEnabled = false;

        }

        public void Load200()
        {
            int ost = fullcount % 10;
            int pages = 0;
            if (fullcount < 200)
            {
                pages = 1;
            }
            else
            {
                pages = (fullcount - ost) / 200;
                if (ost > 0)
                {
                    pages++;
                }
            }


            pagin.Children.Clear();
            for (int i = 0; i < pages; i++)
            {
                Button myButton = new Button();
                myButton.Height = 30;
                myButton.Width = 20;
                myButton.HorizontalAlignment = HorizontalAlignment.Center;
                myButton.Content = i + 1;
                myButton.Tag = i;
                myButton.Click += new RoutedEventHandler(pagButton_Click);
                pagin.Children.Add(myButton);
            }
            int SeeCount = start * 200 + 200;
            if (SeeCount > fullcount)
            {
                SeeCount = fullcount;
            }
            CountItem.Text = "Показано " + SeeCount.ToString() + " из " + fullcount.ToString() + " записей";
            turnButton200();
        }
        public void turnButton200()
        {
            if (start == 0)
            {
                Back.IsEnabled = false;

            }
            else
            {
                Back.IsEnabled = true;
            }
            if ((start + 1) * 200 >= fullcount)
            {
                Forward.IsEnabled = false;

            }
            else
            {
                Forward.IsEnabled = true;
            }
        }

        public void Load50()
        {
            int ost = fullcount % 10;
            int pages = (fullcount - ost) / 50;
            if (ost > 0)
            {
                pages++;
            }
            pagin.Children.Clear();
            for (int i = 0; i < pages; i++)
            {
                Button myButton = new Button();
                myButton.Height = 30;
                myButton.Width = 20;
                myButton.HorizontalAlignment = HorizontalAlignment.Center;
                myButton.Content = i + 1;
                myButton.Tag = i;
                myButton.Click += new RoutedEventHandler(pagButton_Click);
                pagin.Children.Add(myButton);
            }
            int SeeCount = start * 50 + 50;
            if (SeeCount > fullcount)
            {
                SeeCount = fullcount;
            }
            CountItem.Text = "Показано " + SeeCount.ToString() + " из " + fullcount.ToString() + " записей";
            turnButton50();
        }
        public void turnButton50()
        {
            if (start == 0)
            {
                Back.IsEnabled = false;

            }
            else
            {
                Back.IsEnabled = true;
            }
            if ((start + 1) * 50 >= fullcount)
            {
                Forward.IsEnabled = false;

            }
            else
            {
                Forward.IsEnabled = true;
            }

        }
        public void Load10()
        {
            int ost = fullcount % 10;
            int pages = (fullcount - ost) / 10;
            if (ost > 0)
            {
                pages++;
            }
            pagin.Children.Clear();
            for (int i = 0; i < pages; i++)
            {
                Button myButton = new Button();
                myButton.Height = 30;
                myButton.Width = 20;
                myButton.HorizontalAlignment = HorizontalAlignment.Center;
                myButton.Content = i + 1;
                myButton.Tag = i;
                myButton.Click += new RoutedEventHandler(pagButton_Click);
                pagin.Children.Add(myButton);
            }
            int SeeCount = start * 10 + 10;
            if (SeeCount > fullcount)
            {
                SeeCount = fullcount;
            }
            CountItem.Text = "Показано " + SeeCount.ToString() + " из " + fullcount.ToString() + " записей";
            turnButton10();
        }
        public void turnButton10()
        {
            if (start == 0)
            {
                Back.IsEnabled = false;

            }
            else
            {
                Back.IsEnabled = true;
            }
            if ((start + 1) * 10 >= fullcount)
            {
                Forward.IsEnabled = false;

            }
            else
            {
                Forward.IsEnabled = true;
            }
        }
        public void pagButton_Click(object sender, RoutedEventArgs e)
        {
            start = Convert.ToInt32(((Button)sender).Tag.ToString());
            Load();
        }
        public string[] SortingList { get; set; } =
      {
            "Без сортировки",
            "Сортировка по фамилии",
            "Сортирока по убыванию даты посещения",
            "Сортирока по возрастанию даты посещения",
            "Сортирока по убыванию кол-ву посещений",
            "Сортирока по возрастанию кол-ву посещений",
        };
        public string[] FilterList { get; set; } =
       {
            "Без фильтрации",
            "Мужчина",
            "Женщина",

        };


        private void ComboBoxSorting_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Load();
        }

        private void ComboBoxFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IndexFilter = ComboBoxFilter.SelectedIndex;
            Load();
        }

        private void check_birthday(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void BtnDeleteClient_Click(object sender, RoutedEventArgs e)
        {
            if (DataView.SelectedIndex == -1)
            {
                MessageBox.Show("Выделите строку для удаления", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            if ((DataView.SelectedIndex != -1))
            {
                try
                {
                    if (MessageBox.Show("Вы точно хотите удалить эту запись?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    {

                        var idi = (DataView.SelectedItem as Client).ID;
                        var CountService = schoollanguageEntities.GetContext().ClientService.Where(Client => Client.ClientID == idi).Count();
                        if (CountService > 0)
                        {
                            MessageBox.Show("Удаление невозможно, у агента есть информация о посещении ", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                            return;
                        }
                        else
                        {
                            var TagDelete = schoollanguageEntities.GetContext().TagOfClient.Where(p => p.ClientID == idi);
                            var ClientDelete = schoollanguageEntities.GetContext().Client.Where(p => p.ID == idi).FirstOrDefault();
                            foreach (var item in TagDelete)
                            {
                                schoollanguageEntities.GetContext().TagOfClient.Remove(item);
                            }

                            schoollanguageEntities.GetContext().Client.Remove(ClientDelete);
                            schoollanguageEntities.GetContext().SaveChanges();
                            MessageBox.Show("Клиент удален", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Information);
                            Load();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка удаления", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }


        private void BtnEditClient_Click(object sender, RoutedEventArgs e)
        {
            if (DataView.SelectedItems.Count > 0)
            {
                Client client = DataView.SelectedItem as Client;

                if (client != null)
                {
                    NavigationService.Navigate(new EditClient(client));
                }
            }
            else
            {
                MessageBox.Show("Выберите клиента для редактирования", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnAddClient_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddNewClient());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataView.SelectedItems.Count > 0)
            {
                Client client = DataView.SelectedItem as Client;

                if (client != null)
                {
                    NavigationService.Navigate(new VisitingPage(client));
                }
            }
            else
            {
                MessageBox.Show("Выберите клиента для редактирования", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
           
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            start--;
            Load();
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            start++;
            Load();
        }

        private void TenItems_Click(object sender, RoutedEventArgs e)
        {
            ViewPages = 10;
            Load();
        }

        private void FiftyItems_Click(object sender, RoutedEventArgs e)
        {
            ViewPages = 50;
            Load();
        }

        private void TwoHundredItems_Click(object sender, RoutedEventArgs e)
        {
            ViewPages = 200;
            Load();
        }

        private void AllItems_Click(object sender, RoutedEventArgs e)
        {
            ViewPages = 555;
            Load();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            SearchText = Search.Text.ToString();
            Load();
        }

        private void Birthday_Unchecked(object sender, RoutedEventArgs e)
        {
            Load();
        }
    }
}
