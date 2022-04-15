using DemoHrManagerWpf.ViewModel;
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

namespace DemoHrManagerWpf
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    // Bonne pratique de mettre les ViewModel dans la MainWindow car elles peuvent ainsi être accédées
    private MainViewModel viewModel;
    public MainWindow()
    {
      InitializeComponent();
      DataContext = viewModel = new MainViewModel();
      this.Loaded += MainWindow_Loaded;
    }

    private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
      // Bonne pratique de faire le chargement des données asynchrones
      // dans une callback qui elle peut etre asynchrone contrairement au constructeur
      await viewModel.LoadData();
    }
  }
}
