using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Implement
{
    public class MacFactory : IGUIFactory
    {
        public IButton_ CreateButton()
        {
            return new MacButton();
        }

        public ICheckBox_ CreateCheckBox()
        {
            return new MacCheckBox();
        }
    }
}
