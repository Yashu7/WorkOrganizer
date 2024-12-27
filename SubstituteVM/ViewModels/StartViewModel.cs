using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstituteVM.ViewModels
{
    public partial class StartViewModel : ObservableObject
    {
        public StartViewModel()
        {
        }
        [RelayCommand]
        public void TestStart()
        {
            Console.WriteLine("TEST2");
        }
    }
}
