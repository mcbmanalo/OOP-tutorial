using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_tutorial.Classes
{
    public class Jewelry : Thing
    {
        public Jewelry(string name, string itemId, double value, Rarity rarity, MaterialType materialType) 
            : base(name, itemId, value)
        {
            ItemId = "J-" + value;
            JRarity = rarity;
            JMaterialType = materialType;
            Value = getMaterialValue(materialType) * getRarityValue(rarity);
        }

        private Rarity _rarity;
        private MaterialType _jMaterialType;

        public Rarity JRarity
        {
            get
            {
                return _rarity;
            }
            set
            {
                _rarity = value;
            }
        }

        public MaterialType JMaterialType
        {
            get
            {
                return _jMaterialType;
            }
            set
            {
                _jMaterialType = value;
            }
        }

        public enum Rarity
        {
            Common,
            Rare,
            Unique
        }

        public enum MaterialType
        {
            Bronze = 1000,
            Silver = 3000,
            Gold = 5000
        }

        private double getRarityValue(Rarity rarity)
        {
            if (rarity == Rarity.Common)
                return 1.5;
            else if (rarity == Rarity.Rare)
                return 2.0;
            else if (rarity == Rarity.Unique)
                return 3.5;
            return 0;
        }

        private double getMaterialValue(MaterialType materialType)
        {
            if (materialType == MaterialType.Bronze)
                return (double)MaterialType.Bronze;
            else if (materialType == MaterialType.Silver)
                return (double)MaterialType.Silver;
            else if (materialType == MaterialType.Gold)
                return (double)MaterialType.Gold;
            return 0;
        }
    }
}
