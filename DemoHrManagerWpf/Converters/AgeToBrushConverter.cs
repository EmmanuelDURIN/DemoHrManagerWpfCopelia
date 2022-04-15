using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace DemoHrManagerWpf.Converters
{
  public class AgeToBrushConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      //Brush brush = Brushes.Green;
      Brush brush = new SolidColorBrush(Color.FromArgb(255, 0, 128, 0));
      if (value != null)
      {
        int age = int.Parse(value.ToString());
        if (age < 18)
          brush = new SolidColorBrush(Color.FromArgb(255, 128, 0, 0));
      }
      return brush;
    }
    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
      return null;
    }
  }
}
