using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_tutorial.Classes
{
    public class Souvenir : Thing
    {
        public Souvenir(string name, string itemId, string model, MaterialType materialType, string countryOfOrigin) 
        {
            Name = name;
            ItemId = "S-" + itemId;
            Model = model;
            SMaterialType = materialType;
            CountryOfOrigin = countryOfOrigin;
            Value = getMaterialValue(materialType);
        }

        private string _model;
        private MaterialType _materialType;
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

        public MaterialType SMaterialType
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

        private double getMaterialValue (MaterialType materialType)
        {
            if (materialType == MaterialType.Plastic)
                return (double)MaterialType.Plastic;
            else if (materialType == MaterialType.Wood)
                return (double)MaterialType.Wood;
            else if (materialType == MaterialType.Steel)
                return (double)MaterialType.Steel;
            return 0;
        }
    }
}
