using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Implement
{
    public class MacButton : IButton_
    {
        public string Pain()
        {
            return "Tạo ra nút cho mac";
        }
    }
}
