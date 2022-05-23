using Lab6.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Lab6.ViewModels
{
    class MyViewModel : INotifyPropertyChanged
    {
        private int result;    //Результат умножения. Обратите внимание, что все поля приватные
        private int result1;    //Результат умножения. Обратите внимание, что все поля приватные
        private int selectedValue; 

       
        public int Result
        {
            get
            {
                return result;
            }

            set
            {
                result = value;
                RaisePropertyChanged("Result");
            }
        }
        public int Result1
        {
            get
            {
                return result1;
            }

            set
            {
                result1 = value;
                RaisePropertyChanged("Result");
            }
        }

        public int ValueScroll
        {

            get
            {
                return selectedValue;
            }

            set
            {
                selectedValue = value;
                RaisePropertyChanged("ValueScroll");
            }
        }

        

        private RelayCommand clickCommand;
        public RelayCommand ClickCommand
        {
            get
            {
                return clickCommand ??
                  (clickCommand = new RelayCommand(obj =>
                  {  //при нажатии на кнопку производится расчет результата умножения
                      Numbers numbers = new Numbers();  //создадим объект класса модели
                      Result = numbers.returnResult(ValueScroll); //вызовем функцию расчета результата и присвоим ее значение
                      //соответствующему полю Result
                  }));
            }
        }


        private RelayCommand resetCommand;
        public RelayCommand ResetCommand
        {
            get
            {
                return resetCommand ??
                  (resetCommand = new RelayCommand(obj =>
                  {
                      Result = 0;
                      ValueScroll = 0;
                  }));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string p)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }


        public MyViewModel() //пустой конструктор
        {
        }
    }
}
