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

    public class PrescriptionDataConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            PrescriptionData presriptionData = (PrescriptionData)value;
            var drugs = "";
            foreach (var drug in presriptionData.drugs){
                drugs += drug+ ", ";
            }


            return String.Format("{0} {1} has prescription from {2} {3} expiring {5} for {4}", presriptionData.patientName, presriptionData.patientSurname, presriptionData.doctorName, presriptionData.doctorSurname,  drugs, presriptionData.expirationDate);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}