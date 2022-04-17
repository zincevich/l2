﻿using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NYSSLab2
{
	/// <summary>
	/// Логика взаимодействия для Report.xaml
	/// </summary>
	public partial class Report : Window
	{
		public Report()
		{
			InitializeComponent();
		}

        private void EditHistoryClick(object sender, RoutedEventArgs e)
        {
			EditHistory	edit = new EditHistory();
			edit.DataContext = MainWindow.changed2;
			edit.Show();
        }
    }
}
