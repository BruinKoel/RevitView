using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RevitView.ViewModel
{
    public class UserControl1ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ClickCommand { get; set; }// property, with databind/contextbind

        public int Id { get; set; }
        private string name;// storage
        public string Name// property
        {
            get 
            { 
                return name; 
            }
            set
            { 
                name = value;
                OnPropertyChanged(nameof(name)); // two-way binding 
            }
        }
        public string Description { get; set; }
        public string Context { get; set; }

        public UserControl1ViewModel() 
        { 
            Name = "kek";
            ClickCommand = new Models.RelayCommand(_ => Click());
        }

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private string randomString(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, length)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }

        public void Click()
        {
            Name = randomString(10);
           
        }

    }
}
