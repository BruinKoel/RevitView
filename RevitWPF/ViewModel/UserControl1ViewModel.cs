using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RevitWPF.ViewModel
{
    public class UserControl1ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int Id { get; set; }
        private string name;
        public string Name
        {
            get 
            { 
                return name; 
            }
            set
            { 
                name = value;
                OnPropertyChanged(nameof(name)); 
            }
        }
        public string Description { get; set; }
        public string Context { get; set; }

        public UserControl1ViewModel() 
        { 
            Name = "topkek";
        }

        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
