using System;
using System.Globalization;
using Xamarin.Forms;

namespace TriviaExperiment.ViewModels.Converters
{
	public class SelectedToColorConverter : IValueConverter
    {
        
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
		
			if((bool)value == true)         
				return "Yellow";
			else
				return "White";



		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
