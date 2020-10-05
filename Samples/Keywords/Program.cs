using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keywords
{
	class Browser
    {
		string name;
		public Browser(string name)
        {
			this.name = name;
        }

		public void Open()
        {
			System.Console.WriteLine($"{name} browser open");

        }

    }
	class Selinium
    {
		public void Launch(params Browser[] browsers)
        {
			for(int i = 0; i < browsers.Length; i++)
            {
				browsers[i].Open();
            }
        }
	
    }

	
    class Program
    {


		public static void Main()
		{
			//Sum(1);
			//Sum(1, 2);
			//Sum(1, 2, 3);
			//Sum(1, 2, 3, 4, 5);
			Selinium _sel = new Selinium();
			Browser _chrome = new Browser("Chrome");
			Browser _ie = new Browser("IE");
			Browser _fx = new Browser("Fire");

			_sel.Launch(_chrome,_ie,_fx);
		}

		static int Sum(params int[] numbers)
		{
			int result = default(int);
			for (int i = 0; i < numbers.Length; i++)
			{
				result += numbers[i];
			}

			return result;
		}
		
	}
}
