using CounterProgramWithConditionalRendringWPF_using_core.MVVM.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CounterProgramWithConditionalRendringWPF_using_core.MVVM.ViewModel
{
    public class MainWindowViewModel:INotifyPropertyChanged
    {
        public ICommand IncrementCommand { get; set; }
        public ICommand ApearingBtn { get; set; }


        private bool myVar3;

        public bool IsbtnEnabled
        {
            get { return myVar3; }
            set { myVar3 = value;
                OnPropertyChanged("IsbtnEnabled");
            }
        }

        private string myVar4;

        public string IsCollapsed
        {
            get { return myVar4; }
            set { myVar4 = value;
                OnPropertyChanged("IsCollapsed");
            }
        }


        private int myVar;

        public int IncrementTextBlk
        {
            get { return myVar; }
            set { myVar = value;
                OnPropertyChanged("IncrementTextBlk");
            }
        }

        private string myVar2;

        

        public string EvenOddTextBlk
        {
            get { return myVar2; }
            set { myVar2 = value;
                OnPropertyChanged("EvenOddTextBlk");
            }
        }


        public MainWindowViewModel() {

            IncrementCommand = new GenricCommand(Increment, canIncrement);
            ApearingBtn = new GenricCommand(Apear, canApear);
            IncrementTextBlk = 0;
            EvenOddTextBlk = "";
            IsbtnEnabled = true;
            IsCollapsed = "Visible";
        }

        public void Increment(object parameter) 
        {
            IncrementTextBlk += 1;
            if(IncrementTextBlk % 2 != 0)
            {
                EvenOddTextBlk = "This is an Odd number " + IncrementTextBlk;
                IsCollapsed = "Collapsed";
            }
            else
            {
                EvenOddTextBlk = "This is an Even number " + IncrementTextBlk;
                IsbtnEnabled = true;
                IsCollapsed = "Visible";
            }


        }
        public void Apear(object parameter)
        {
            
        }
        public bool canApear(object parameter)
        {
            return true;
        }
        public bool canIncrement(object parameter)
        {
            return true;
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }
    }
}
