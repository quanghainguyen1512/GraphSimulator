﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace GraphSimulator.Converter
{
    public class RouteCostConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int cost)
            {
                if (cost == int.MaxValue)
                    return '∞';
                return cost;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
