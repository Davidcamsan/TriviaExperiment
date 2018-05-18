using System;
using System.Globalization;
using Xamarin.Forms;

namespace TriviaExperiment.ViewModels.Converters
{
	public class AnswersToColorConverter : IValueConverter
	{
        
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            if ((bool)value == true)
                return "Green";
            else
                return "Red";

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
