﻿using System;
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

namespace UP_3._1
{
	/// <summary>
	/// Логика взаимодействия для pageForFullGrid.xaml
	/// </summary>
	public partial class pageForFullGrid : Page
	{
		private MagazineEntities context = new MagazineEntities();

		public pageForFullGrid()
		{
			InitializeComponent();
			fullDataGrid.ItemsSource = context.Orders.ToList();
		}
	}
}
