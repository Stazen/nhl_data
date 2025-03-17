using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
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

namespace NHL_UI
{
    /// <summary>
    /// Logique d'interaction pour Matchs.xaml
    /// </summary>
    public partial class Matchs : UserControl
    {
        public Matchs()
        {
            InitializeComponent();
        }
    }

    public class BoolToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? new SolidColorBrush(Colors.AliceBlue) : new SolidColorBrush(Colors.Transparent);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class BoolToEllipseFillConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool)value ? new SolidColorBrush(Colors.Gray) : new SolidColorBrush(Colors.White);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }



    public class TimelineViewModel : INotifyPropertyChanged
    {
        private DateTime _currentDate = DateTime.Now;

        public ObservableCollection<int> Days { get; set; } = new ObservableCollection<int> { 15, 16, 17, 18, 19, 20, 21 };

        public event PropertyChangedEventHandler? PropertyChanged;

        public bool IsToday(int day)
        {
            return _currentDate.Day == day;
        }
    }

}
