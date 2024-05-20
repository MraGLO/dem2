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

namespace dem2
{
	/// <summary>
	/// Логика взаимодействия для AutorixationPage.xaml
	/// </summary>
	public partial class AutorixationPage : Page
	{
		public AutorixationPage()
		{
			InitializeComponent();
		}

		private void EntryButton_Click(object sender, RoutedEventArgs e)
		{
			Manager.MainFrame.Navigate(new ZajavkiPage());
        }

		private void ReginButton_Click(object sender, RoutedEventArgs e)
		{
			Manager.MainFrame.Navigate(new RegistrationPage());
        }
    }
}
