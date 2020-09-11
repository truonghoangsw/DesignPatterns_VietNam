using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Implement
{
    public class MacCheckBox : ICheckBox_
    {
        public string Pain()
        {
            return "Check box của mac";
        }
    }
}
