using ExamplePracWork13.Classes;
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

namespace ExamplePracWork13
{
    /// <summary>
    /// Логика взаимодействия для WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        public WindowAdd()
        {
            InitializeComponent();
            CmbYear.ItemsSource = ClassHelp.year;
        }

        private void BtnAddWorker_Click(object sender, RoutedEventArgs e)
        {
            ClassWorker library = new ClassWorker()
            {
                FullName = TxbFullName.Text,
                Work = TxbWork.Text,
                Year = CmbYear.Text

            };
            ClassHelp.worker.Add(library);
        }
    }
}
