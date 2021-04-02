using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using OOP_tutorial.Classes;
using System.Windows;

namespace OOP_tutorial.Modules
{
    public class StoreModule : ObservableObject
    {
        public ObservableCollection<Thing> Things { get; } = new ObservableCollection<Thing>();

        public StoreModule()
        {
            AddThings();
        }

        public string[] ThingTypes => Enum.GetNames(typeof(ThingType));
        public string[] SMaterialTypes => Enum.GetNames(typeof(Souvenir.MaterialType));
        public string[] Rarities => Enum.GetNames(typeof(Jewelry.Rarity));
        public string[] JMaterialTypes => Enum.GetNames(typeof(Jewelry.MaterialType));

        private string _selectedThingType;
        private string _selectedSMaterialTypes;
        private string _selectedRarities;
        private string _selectedJMaterialTypes;
        private string _name;
        private string _title;
        private string _author;
        private int _numberOfPages;
        private string _model;
        private string _originCountry;

        public string SelectedThingType
        {
            get { return _selectedThingType; }
            set
            {
                _selectedThingType = value;
                RaisePropertyChanged(nameof(SelectedThingType));
            }
        }

        public string SelectedSMaterialTypes
        {
            get { return _selectedSMaterialTypes; }
            set
            {
                _selectedSMaterialTypes = value;
                RaisePropertyChanged(nameof(SelectedSMaterialTypes));
            }
        }

        public string SelectedRarities
        {
            get { return _selectedRarities; }
            set
            {
                _selectedRarities = value;
                RaisePropertyChanged(nameof(SelectedRarities));
            }
        }

        public string SelectedJMaterialTypes
        {
            get { return _selectedJMaterialTypes; }
            set
            {
                _selectedJMaterialTypes = value;
                RaisePropertyChanged(nameof(SelectedJMaterialTypes));
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(nameof(Name));
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged(nameof(Title));
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                RaisePropertyChanged(nameof(Author));
            }
        }

        public int NumberOfPages
        {
            get { return _numberOfPages; }
            set
            {
                _numberOfPages = value;
                RaisePropertyChanged(nameof(NumberOfPages));
            }
        }

        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
                RaisePropertyChanged(nameof(Model));
            }
        }

        public string OriginCountry
        {
            get { return _originCountry; }
            set
            {
                _originCountry = value;
                RaisePropertyChanged(nameof(OriginCountry));
            }
        }

        private enum ThingType
        {
            Book,
            Souvenir,
            Jewelry
        }

        private string GetThingsCountString()
        {
            return Things.Count.ToString();
        }

        public void AddThing()
        {
            if (SelectedThingType == "Book")
            { 
                if (Name!= null && Title != null && Author != null && NumberOfPages != 0)
                {
                    AddBook(Name, Title, Author, NumberOfPages);
                    ClearProperties();
                    MessageBox.Show("Succesfully added Book.");
                }
                else
                {
                    MessageBox.Show("There are some missing values. Please check if your values.");
                }
            }
            else if (SelectedThingType == "Souvenir")
            {
                if (Name != null && Model != null && SelectedSMaterialTypes != null && OriginCountry != null)
                {
                    AddSouvenir(Name, Model, SelectedSMaterialTypes, OriginCountry);
                    ClearProperties();
                    MessageBox.Show("Succesfully added Book.");
                }
                else
                {
                    MessageBox.Show("There are some missing values. Please check if your values.");
                }
            }
            else if (SelectedThingType == "Jewelry")
            { }
        }

        private void AddBook(string name, string title, string author, int numberOfPages)
        {

            Book newBook = new Book(name, GetThingsCountString(), title, author, numberOfPages);
            Things.Add(newBook);
            RaisePropertyChanged(nameof(Things));
        }

        private void AddSouvenir(string name, string model, string materialType, string originCountry)
        {
            Souvenir newSouvenir = new Souvenir(name, GetThingsCountString(), model, materialType, originCountry);
            Things.Add(newSouvenir);
            RaisePropertyChanged(nameof(Things));
        }

        private void AddJewelry(string name, string rarity, string materialType)
        {
            Jewelry newJewelry = new Jewelry(name, GetThingsCountString(), rarity, materialType);
            Things.Add(newJewelry);
            RaisePropertyChanged(nameof(Things));
        }

        private void ClearProperties()
        {
            Name = null;
            Title = null;
            Author = null;
            NumberOfPages = 0;
            Model = null;
            OriginCountry = null;
            SelectedSMaterialTypes = null;
            SelectedRarities = null;
            SelectedJMaterialTypes = null;
            SelectedThingType = null;
        }

        private void AddThings()
        {
            for (int i = 0; i < 10; i++)
            {
                Things.Add(new Book("Book-"+i.ToString(), i.ToString(), "ASTRO Things", "Carmela Manalo", 200));
                Things.Add(new Souvenir("Souvenir-"+i.ToString(), i.ToString(), "Model "+i.ToString(), Souvenir.MaterialType.Plastic.ToString(), "Philippines"));
                Things.Add(new Jewelry("Jewelry-"+i.ToString(), i.ToString(), Jewelry.Rarity.Common.ToString(), Jewelry.MaterialType.Bronze.ToString()));
            }
        }
    }
}
