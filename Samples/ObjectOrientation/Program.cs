using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientation
{
    public class Control
    {
        public int Height { get; set; }
        public int Width { get; set; }
    }
    public class Button:Control
    {
        
        //Auto Property
        public string Caption { get; set; }

    }
    public class TextBox:Control
    {
     
        public string Text { get; set; }
        public string Color { get; set; }
        public string FontSize { get; set; }
    }

    public class ComboBox:Control
    {
      
        public string Caption { get; set; }

        public List<object> Items { get; set; }
    }
    public class Package
    {
        public int Height { get; set; }
        public int Width { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
