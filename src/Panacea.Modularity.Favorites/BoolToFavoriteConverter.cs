using Panacea.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace Panacea.Modularity.Favorites
{
    public class BoolToFavoriteConverter : IMultiValueConverter
    {
        public object Convert(object[] value, Type targetType, object parameter, CultureInfo culture)
        {
            var command = value[0] as ICommand;
            if (command == null) throw new ArgumentException("First argument is not a command");
            var item = value[1] as ServerItem;
            if(item == null) throw new ArgumentException("Second argument is not a ServerItem");
            return command.CanExecute(item) == true ? Brushes.Red : Brushes.DodgerBlue;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}