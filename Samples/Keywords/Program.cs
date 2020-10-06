using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keywords
{
	class Browser
    {
        #region private data members
        private string name;
		private string version;
		#endregion
		#region Mutators
		public void Set_name(string value)
		{
			this.name = value;
		}
		public string Get_name()
		{
			return this.name;

		}
        #endregion

        #region Properties
		//Grammer/ MSIL Constrcut
		// Generate Mutators in MSIL
		public string Version
        {
			// public string get_Version(){} 
            get {

				/* Function Body */
				return this.version;
			}
			//public void set_Version(string value)
			set {
				/*Function Body */
				this.version = value;
			}
        }
        #endregion 

        #region Initializers/Constructors
        public Browser(string name)
        {
			this.name = name;
        }
        #endregion

        #region public methods
        public void Open()
        {
			System.Console.WriteLine($"{name} browser open");

        }
        #endregion

       
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


	    static void Main_old()
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

		static void Main_udated()
        {
			Browser _browserObj = new Browser("Chrome");
			// _browerObj.name="Chrome Lt";
			_browserObj.Set_name("Chrome Lt");
			string name = _browserObj.Get_name();
			_browserObj.Version = "1.0.0.0"; //MSIL -> _browserObj.set_Version("1.0.0.0");
			string version=_browserObj.Version; //MSIL -> _browserObj.get_Version();

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
		
		static void Main()
        {
			//System.Array numbers=new System.Array(10);
			int[] numbers = new int[10];
			numbers[0] = 10;

			CalculatorWindow _window = new CalculatorWindow();
			//_window.AddButton(0, new Button());
			//_window[0] =new button();
			//	_window.GetButton(0);
			//Button instance=_window[0]

			Table _matrix = new Table();

			_matrix.SetCellValue(2, 0, 10);

			_matrix[2, 0] = 10;// _matrix.set_Item(2,0,10);
			_matrix[1, 1] = 20;// _matrix.set_Item(1,1,20);
			int value = _matrix[2, 0];//_matrix.get_Item(2,0);

		}
	}

	class CalculatorWindow
    {

		Button[] _buttons;
		public CalculatorWindow()
        {
			this._buttons = new Button[10];

        }
		public Button GetButton(int index)
        {
			return this._buttons[index];
        }
		public void AddButton(int index, Button btn)
        {
			this._buttons[index] = btn;
        }

    }

	class Button
    {

    }

	class Table
	{

		public int this[int row,int column]
        {
			//public int get_Item(int row,int column){}
            get {
				return 0;
			}
			//public void set_Item(int row,int column,int value){}
            set { }
        }
		public void SetCellValue(int row,int column,int value)
        {

        }
		public int GetCellValue(int row,int column)
        {
			return 0;
        }


	}




}
