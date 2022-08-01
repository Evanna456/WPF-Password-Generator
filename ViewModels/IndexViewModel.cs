using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPF_Password_Generator.Models;

namespace WPF_Password_Generator.ViewModels
{
    public class IndexViewModel : ObservableObject
    {
        public IndexViewModel()
        {
            IndexModel = new Models.Index();
            GenerateCommand = new RelayCommand(OnGenerateCommand);
        }
        public Models.Index IndexModel { get; set; }

        public ICommand GenerateCommand { get; set; }

        private void OnGenerateCommand()
        {
            IndexModel.TextContent = "asdasdadasd";
        }
    }
}
