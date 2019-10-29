using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Zork.Common;
using System.Runtime.CompilerServices;

namespace Zork.Builder.ViewModels
{
    class GameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Filename { get; set; }

        public BindingList<Room> Rooms { get; set; }

        public Game Game 
        {
            set
            {
                if (mGame != value)
                {
                    mGame = value;
                    if (mGame != null && mGame.World != null && mGame.World.Rooms != null)
                    {
                        Rooms = new BindingList<Room>(mGame.World.Rooms.ToList());
                    }
                    else
                    {
                        Rooms = new BindingList<Room>(Array.Empty<Room>());
                    }
                }
            }
        }

        private Game mGame;
    }
}
