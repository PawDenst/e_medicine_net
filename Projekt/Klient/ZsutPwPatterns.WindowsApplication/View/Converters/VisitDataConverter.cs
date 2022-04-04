namespace ZsutPw.Patterns.WindowsApplication.View
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using Windows.UI.Xaml.Data;

    using ZsutPw.Patterns.WindowsApplication.Model;
    using ZsutPwPatterns.WindowsApplication.Logic.Model.Data;

    public class VisitDataConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            VisitData visitData = (VisitData)value;

            return String.Format("{0} {1} has visit with {2} {3} at {4} in Room {5}", visitData.patientName, visitData.patientSurname, visitData.doctorName, visitData.doctorSurname, visitData.visitDate, visitData.roomNumber);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}