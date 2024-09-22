using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using WpfApplication1.Model;

namespace WpfApplication1.Vm
{
    public class Vm : INotifyPropertyChanged
    {
        private M _m = new M();

        public Vm()
        {
        }

        public string Name
        {
            get => _m.Name;
            set
            {
                if (_m.Name != value)
                {
                    _m.Name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get => _m.Password;
            set
            {
                if (_m.Password != value)
                {
                    _m.Password = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ExecuteSubmit(object obj)
        {
            // 这里是按钮点击时执行的逻辑                                                                                                                                                
            Console.WriteLine(Name);
            Console.WriteLine(Password);
        }
        public ICommand ExecuteSubmitAction
        {
           get
           {
               return new RelayCommand(ExecuteSubmit, o => true);
           }
        }
    }

}