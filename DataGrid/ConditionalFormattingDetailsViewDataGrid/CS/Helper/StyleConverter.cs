#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace ConditionalFormattingDetailsViewDataGrid
{    
    
    internal class StyleConverterforQuantity : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {    
            double _value;
            if (!String.IsNullOrEmpty(value.ToString()))
            {
                _value = double.Parse(value.ToString(), NumberStyles.Currency, culture);                                                    
                if(_value<6)
                    return App.Current.Resources["Brush1"];                    
            }
            return new SolidColorBrush();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    internal class StyleConverterforUnitPrice : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            double _value;
            if (!String.IsNullOrEmpty(value.ToString()))
            {
                _value = double.Parse(value.ToString(), NumberStyles.Currency, culture);                
                    
                if (_value >50)
                    return App.Current.Resources["Brush2"];                
            }            
            return new SolidColorBrush();
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
