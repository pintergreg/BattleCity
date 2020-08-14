using System;
using System.Collections.Generic;
using System.Text;
using BattleCity.Models;

namespace BattleCity.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Hello World!";

        public GameField Field {get; set;}

        public MainWindowViewModel(GameField field) {
            Field = field;
        }
         
    }
}
