using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Implement
{
    public class WinCheckBox : ICheckBox_
    {
        public string Pain()
        {
            return "Check Box này cho WIn nhá";
        }
    }
}
