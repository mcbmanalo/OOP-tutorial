using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OOP_tutorial.Classes;

namespace OOP_tutorial.Modules
{
    public class StoreModule : ObservableObject
    {
        public ObservableCollection<Thing> Things { get; } = new ObservableCollection<Thing>();

        public StoreModule()
        {
            
        }

        private void AddThings()
        {
            Things.Add(new Book("Book-1", "001", "ASTRO Things", "Carmela Manalo", 200));
            Things.Add(new Book("Book-2", "002", "ASTRO Things", "Carmela Manalo", 200));
            Things.Add(new Book("Book-3", "003", "ASTRO Things", "Carmela Manalo", 200));
            Things.Add(new Book("Book-4", "004", "ASTRO Things", "Carmela Manalo", 200));
            Things.Add(new Book("Book-5", "005", "ASTRO Things", "Carmela Manalo", 200));
            Things.Add(new Book("Book-6", "006", "ASTRO Things", "Carmela Manalo", 200));
            Things.Add(new Book("Book-7", "007", "ASTRO Things", "Carmela Manalo", 200));
            Things.Add(new Book("Book-8", "008", "ASTRO Things", "Carmela Manalo", 200));
            Things.Add(new Book("Book-9", "009", "ASTRO Things", "Carmela Manalo", 200));
            Things.Add(new Book("Book-10", "0010", "ASTRO Things", "Carmela Manalo", 200));

        }
    }
}
