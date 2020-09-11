using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Interface
{
    public interface IGUIFactory
    {
        IButton_ CreateButton();
        ICheckBox_ CreateCheckBox();
    }
}
