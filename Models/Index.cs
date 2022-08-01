using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;

namespace WPF_Password_Generator.Models
{
    public class Index : ObservableObject
    {
        private string _textContent = string.Empty;

        public string TextContent
        {
            get {  return _textContent; }
            set { SetProperty(ref _textContent, value); }
        }
    }

}
