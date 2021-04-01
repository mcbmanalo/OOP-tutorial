using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_tutorial
{
    public abstract class Thing
    {
        private string _name;
        private string _itemId;
        private double _value;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string ItemId
        {
            get
            {
                return _itemId;
            }
            set
            {
                _itemId = value;
            }
        }

        public double Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }
    }
}
