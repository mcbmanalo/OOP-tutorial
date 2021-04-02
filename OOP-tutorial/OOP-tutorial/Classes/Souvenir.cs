using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_tutorial.Classes
{
    public class Souvenir : Thing
    {
        public Souvenir(string name, string itemId, string model, string materialType, string countryOfOrigin) 
        {
            Name = name;
            ItemId = "S-" + itemId;
            Model = model;
            SMaterialType = materialType;
            CountryOfOrigin = countryOfOrigin;
            Value = getMaterialValue(materialType);
        }

        private string _model;
        private string _materialType;
        private string _countryOfOrigin;
        
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }

        public string SMaterialType
        {
            get
            {
                return _materialType;
            }
            set
            {
                _materialType = value;
            }
        }

        public string CountryOfOrigin
        {
            get
            {
                return _countryOfOrigin;
            }
            set
            {
                _countryOfOrigin = value;
            }
        }

        public enum MaterialType
        {
            Plastic = 100,
            Wood = 150,
            Steel = 300
        }

        private double getMaterialValue (string materialType)
        {
            if (materialType == MaterialType.Plastic.ToString())
                return (double)MaterialType.Plastic;
            else if (materialType == MaterialType.Wood.ToString())
                return (double)MaterialType.Wood;
            else if (materialType == MaterialType.Steel.ToString())
                return (double)MaterialType.Steel;
            return 0;
        }
    }
}
