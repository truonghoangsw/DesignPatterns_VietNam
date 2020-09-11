using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Implement
{
    public class WinFactory : IGUIFactory
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
