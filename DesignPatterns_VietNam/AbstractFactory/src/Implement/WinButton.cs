using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Implement
{
    public class WinButton : IButton_
    {
        public string Pain()
        {
            return "Chỗ này để vẽ cái nút cho Win";
        }
    }
}
