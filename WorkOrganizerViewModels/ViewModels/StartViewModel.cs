using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOrganizerViewModels.ViewModels
{
    public partial class StartViewModel : ObservableObject, INotifyPropertyChanged
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }
        public StartViewModel() 
        {
        }
        [RelayCommand]
        public void TestStart()
        {
            Console.WriteLine("TEST");
        }
    }
}
