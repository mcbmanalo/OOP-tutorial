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

            Things.Add(new Souvenir("Souvenir-1", "0001", "Model 1", Souvenir.MaterialType.Plastic, "Philippines"));
            Things.Add(new Souvenir("Souvenir-2", "0002", "Model 2", Souvenir.MaterialType.Wood, "Singapore"));
            Things.Add(new Souvenir("Souvenir-3", "0003", "Model 3", Souvenir.MaterialType.Wood, "Thailand"));
            Things.Add(new Souvenir("Souvenir-4", "0004", "Model 4", Souvenir.MaterialType.Steel, "Philippines"));
            Things.Add(new Souvenir("Souvenir-5", "0005", "Model 5", Souvenir.MaterialType.Steel, "Japan"));
            Things.Add(new Souvenir("Souvenir-6", "0006", "Model 6", Souvenir.MaterialType.Plastic, "North Korea"));
            Things.Add(new Souvenir("Souvenir-7", "0007", "Model 7", Souvenir.MaterialType.Plastic, "South Korea"));
            Things.Add(new Souvenir("Souvenir-8", "0008", "Model 8", Souvenir.MaterialType.Wood, "Philippines"));
            Things.Add(new Souvenir("Souvenir-9", "0009", "Model 9", Souvenir.MaterialType.Steel, "USA"));
            Things.Add(new Souvenir("Souvenir-10", "00010", "Model 10", Souvenir.MaterialType.Plastic, "Philippines"));

            Things.Add(new Jewelry("Jewelry-1", "0001", Jewelry.Rarity.Common, Jewelry.MaterialType.Bronze));
            Things.Add(new Jewelry("Jewelry-2", "0002", Jewelry.Rarity.Rare, Jewelry.MaterialType.Bronze));
            Things.Add(new Jewelry("Jewelry-3", "0003", Jewelry.Rarity.Unique, Jewelry.MaterialType.Bronze));
            Things.Add(new Jewelry("Jewelry-4", "0004", Jewelry.Rarity.Rare, Jewelry.MaterialType.Silver));
            Things.Add(new Jewelry("Jewelry-5", "0005", Jewelry.Rarity.Unique, Jewelry.MaterialType.Gold));
            Things.Add(new Jewelry("Jewelry-6", "0006", Jewelry.Rarity.Common, Jewelry.MaterialType.Silver));
            Things.Add(new Jewelry("Jewelry-7", "0007", Jewelry.Rarity.Common, Jewelry.MaterialType.Bronze));
            Things.Add(new Jewelry("Jewelry-8", "0008", Jewelry.Rarity.Unique, Jewelry.MaterialType.Gold));
            Things.Add(new Jewelry("Jewelry-9", "0009", Jewelry.Rarity.Rare, Jewelry.MaterialType.Bronze));
            Things.Add(new Jewelry("Jewelry-10", "00010", Jewelry.Rarity.Common, Jewelry.MaterialType.Bronze));
        }
    }
}
