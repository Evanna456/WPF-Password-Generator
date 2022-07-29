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
    public class IndexViewModel : INotifyPropertyChanged
    {
       Models.Index index = new Models.Index();
        public string TextContent
        {
            get
            {
                return index.textContent;
            }
            set
            {
                index.textContent = value;
                OnPropertyChanged("TextContent");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ICommand generateCommand;
        public ICommand GenerateCommand
        {
            get
            {
                if (generateCommand == null)
                {
                    generateCommand = new Generate();
                    return generateCommand;
                }
                else
                {
                    return generateCommand;
                }
            }
        }
     
    }
   public class Generate: ICommand
    {
        IndexViewModel indexViewModel = new IndexViewModel();
        public void Execute(object parameter)
        {
            indexViewModel.TextContent = "asdasdadasd";
            MessageBox.Show(indexViewModel.TextContent);
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
