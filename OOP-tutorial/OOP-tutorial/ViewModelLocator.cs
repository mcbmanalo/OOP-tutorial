using System;
using System.Collections.Generic;
using System.Text;
using OOP_tutorial.Modules;

namespace OOP_tutorial
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            StoreModule = new StoreModule();
        }

        public StoreModule StoreModule { get; }
    }
}
