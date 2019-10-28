using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zork.Common;
using System.Runtime.CompilerServices;

namespace Zork.Builder.GameViewModelFolder
{
    class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }

        public Game game { get; set; }

    }
}
