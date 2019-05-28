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

namespace TestingWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppDomain newDomain;
        AppDomain currentDomain;
        string assemblyForNewDomain;
        public MainWindow()
        {
            InitializeComponent();
            currentDomain = AppDomain.CurrentDomain;
            newDomain = AppDomain.CreateDomain("DomainForTest");
        }

        private void DownladButtonClick(object sender, RoutedEventArgs e)
        {
            assemblyForNewDomain = currentDomain.BaseDirectory + "ExeForTestingDownload.exe";
            newDomain.ExecuteAssembly(assemblyForNewDomain);
        }

        private void LoopButtonClick(object sender, RoutedEventArgs e)
        {
            assemblyForNewDomain = currentDomain.BaseDirectory + "ExeForTestingLoop.exe";
            newDomain.ExecuteAssembly(assemblyForNewDomain);
        }
    }
}
