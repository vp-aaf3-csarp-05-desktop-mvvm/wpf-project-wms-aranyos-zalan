using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Media;

namespace WMSProject
{
    public partial class EmployeeViewModel : ObservableObject
    {
        private static int VacationDay = 45;

        public string Name { get; } = "Nagy Anna";
        public string Adoszam { get; } = "1234567-09-01";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(RemainingDays))]
        private int szabadnapokSzama = 8;

        public int RemainingDays => VacationDay - SzabadnapokSzama;
    }
}
