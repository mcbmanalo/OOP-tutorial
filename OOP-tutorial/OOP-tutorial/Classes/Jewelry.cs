using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_tutorial.Classes
{
    public class Jewelry : Thing
    {
        public Jewelry(string name, string itemId, string rarity, string materialType) 
        {
            Name = name;
            ItemId = "J-" + itemId;
            JRarity = rarity;
            JMaterialType = materialType;
            Value = getMaterialValue(materialType) * getRarityValue(rarity);
        }

        private string _rarity;
        private string _jMaterialType;

        public string JRarity
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

        public string JMaterialType
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

        private double getRarityValue(string rarity)
        {
            if (rarity == Rarity.Common.ToString())
                return 1.5;
            else if (rarity == Rarity.Rare.ToString())
                return 2.0;
            else if (rarity == Rarity.Unique.ToString())
                return 3.5;
            return 0;
        }

        private double getMaterialValue(string materialType)
        {
            if (materialType == MaterialType.Bronze.ToString())
                return (double)MaterialType.Bronze;
            else if (materialType == MaterialType.Silver.ToString())
                return (double)MaterialType.Silver;
            else if (materialType == MaterialType.Gold.ToString())
                return (double)MaterialType.Gold;
            return 0;
        }
    }
}
