using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment__1
{
    internal class Book
    {
        public int Pages;
        public string Title;


        public override string ToString()
        {
            return $"Title = {Title} , Pages = {Pages}";
        }



    }
}
