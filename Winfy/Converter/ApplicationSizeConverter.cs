using System;
using System.Globalization;
using System.Windows.Data;
using Winfy.Core;

namespace Winfy.Converter {
	public sealed class ApplicationSizeConverter : IValueConverter {
		private const int LargeApplicationSizeInPixel = 300;
		private const int MediumApplicationSizeInPixel = 174;
		private const int SmallApplicationSizeInPixel = 100;
        private const int MiniApplicationSizeInPixel = 20;

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
			if (!(value is ApplicationSize)) return MediumApplicationSizeInPixel;
			
			var appSize = (ApplicationSize) value;
			switch (appSize) {
				case ApplicationSize.Large:
					return LargeApplicationSizeInPixel;
				case ApplicationSize.Medium:
					return MediumApplicationSizeInPixel;
				case ApplicationSize.Small:
					return SmallApplicationSizeInPixel;
                case ApplicationSize.Mini:
                    return MiniApplicationSizeInPixel;
			}
			return MediumApplicationSizeInPixel;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
			return value;
		}
	}
    public sealed class ApplicationSizeConverterWidth : IValueConverter
    {
        private const int LargeWidthApplicationSizeInPixel = 300;
        private const int MediumWidthApplicationSizeInPixel = 174;
        private const int SmallWidthApplicationSizeInPixel = 100;
        private const int MiniWidthApplicationSizeInPixel = 300;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is ApplicationSize)) return MediumWidthApplicationSizeInPixel;

            var appSize = (ApplicationSize)value;
            switch (appSize)
            {
                case ApplicationSize.Large:
                    return LargeWidthApplicationSizeInPixel;
                case ApplicationSize.Medium:
                    return MediumWidthApplicationSizeInPixel;
                case ApplicationSize.Small:
                    return SmallWidthApplicationSizeInPixel;
                case ApplicationSize.Mini:
                    return MiniWidthApplicationSizeInPixel;
            }
            return MediumWidthApplicationSizeInPixel;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
