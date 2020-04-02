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

namespace DNA_RNA_Converter
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void ToRNA_Click(object sender, RoutedEventArgs e)
		{
			Converter convert = new Converter();

			string inputText = Input.Text;

			string result = convert.ConvertToRNA(inputText);

			if (result == "202")
			{
				Output.Text = "Error. Try to look into your length of you protein.";
			}
			else if (result == "203")
			{
				Output.Text = "Error. You typed in a characters that is not allowed there.";
			}
			else
			{
				Output.Text = result;
			}
		}

		private void ToDNA_Click(object sender, RoutedEventArgs e)
		{
			Converter convert = new Converter();

			string inputText = Input.Text;

			string result = convert.ConvertToDNA(inputText);

			if (result == "202")
			{
				Output.Text = "Error. Try to look into your length of you protein.";
			}
			else if (result == "203")
			{
				Output.Text = "Error. You typed in a characters that is not allowed there.";
			}
			else
			{
				Output.Text = result;
			}
		}

		private void Clear_Click(object sender, RoutedEventArgs e)
		{
			Output.Text = "";
			Input.Text = "Enter your RNA or DNA here...";
		}
	}
}
