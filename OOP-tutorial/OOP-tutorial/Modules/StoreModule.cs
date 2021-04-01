using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace OOP_tutorial.Modules
{
    public class StoreModule : ObservableObject
    {
        public ObservableCollection<Thing> Things { get; } = new ObservableCollection<Thing>();
    }
}
