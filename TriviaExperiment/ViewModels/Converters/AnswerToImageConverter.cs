using System;
using System.Globalization;
using Xamarin.Forms;

namespace TriviaExperiment.ViewModels.Converters
{
	public class AnswerToImageConverter : IValueConverter
    {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
			if ((bool)value == true)
				return "Check";
			else
				return "X";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
