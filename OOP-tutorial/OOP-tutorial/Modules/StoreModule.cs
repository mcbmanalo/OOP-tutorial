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
            AddThings();
        }

        private void AddBook(string name, string title, string author, int numberOfPages)
        {
            
            Book newBook = new Book(name, GetThingsCountString(), title, author, numberOfPages);
            Things.Add(newBook);
            RaisePropertyChanged(nameof(Things));
        }

        private void AddSouvenir(string name, string model, Souvenir.MaterialType materialType, string originCountry)
        {
            Souvenir newSouvenir = new Souvenir(name, GetThingsCountString(), model, materialType, originCountry);
            Things.Add(newSouvenir);
            RaisePropertyChanged(nameof(Things));
        }

        private void AddJewelry(string name, Jewelry.Rarity rarity, Jewelry.MaterialType materialType)
        {
            Jewelry newJewelry = new Jewelry(name, GetThingsCountString(), rarity, materialType);
            Things.Add(newJewelry);
            RaisePropertyChanged(nameof(Things));
        }

        private string GetThingsCountString()
        {
            return Things.Count.ToString();
        }

        private void AddThings()
        {
            for (int i = 0; i < 10; i++)
            {
                Things.Add(new Book("Book-"+i.ToString(), i.ToString(), "ASTRO Things", "Carmela Manalo", 200));
                Things.Add(new Souvenir("Souvenir-"+i.ToString(), i.ToString(), "Model "+i.ToString(), Souvenir.MaterialType.Plastic, "Philippines"));
                Things.Add(new Jewelry("Jewelry-"+i.ToString(), i.ToString(), Jewelry.Rarity.Common, Jewelry.MaterialType.Bronze));
            }
        }
    }
}
