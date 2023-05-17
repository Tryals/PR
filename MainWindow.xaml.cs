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
using ExamplePracWork13.Classes;

namespace ExamplePracWork13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CmbFiltr.ItemsSource = ClassHelp.year;

            //один объект класса ClassLibrary
            ClassWorker worker = new ClassWorker()
            {
                FullName = "Иванов Иван Иванович",
                Work = "Сантехник",
                Year = "2005",

            };
            ClassHelp.worker.Add(worker);

            //источник данных таблицы - список объектов
            DtgListWorkers.ItemsSource = ClassHelp.worker;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {//переход на форму добавления
            WindowAdd windowAdd = new WindowAdd();
            windowAdd.ShowDialog();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {//Поиск по ФИО
            DtgListWorkers.ItemsSource = ClassHelp.worker.Where(x=>x.FullName.Contains(TxtSearch.Text)).ToList();
        }

        private void CmbFiltr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //фильтр по годам
            string city = ClassHelp.year[CmbFiltr.SelectedIndex];
            if (CmbFiltr.SelectedIndex != 0)
                DtgListWorkers.ItemsSource = ClassHelp.worker.Where(x => x.Year == year).ToList();
            else
                DtgListWorkers.ItemsSource = ClassHelp.worker;
        }

        private void RbUp_Checked(object sender, RoutedEventArgs e)
        {
            DtgListWorkers.ItemsSource = ClassHelp.worker.OrderBy(x=>x.FullName).ToList();
        }

        private void RbDown_Checked(object sender, RoutedEventArgs e)
        {
            DtgListWorkers.ItemsSource = ClassHelp.worker.OrderByDescending(x => x.FullName).ToList();
        }
    }
}
