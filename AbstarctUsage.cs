namespace ConsoleApp16.WhyAbstract
{
    //Common Code
    //Variation Code

    
    public class Program
    {
        static void Main()
        {
    
            SearchWindow _searchWindow = new SearchWindow();
            _searchWindow.Draw();
        }
    }


    public abstract class Control
    {
        public string ControlId, ToolTip;
        public double Height, Width;
    }

    public class TextBox:Control
    {
        
        public string Text;
        public void Draw()
        {

            Console.WriteLine("TextBox Draw");
        }
        
    }
    public class Button:Control
    {
        
        public string Caption;
        public void Draw()
        {
            Console.WriteLine("Button Draw");
        }
    }
    public class Window:Control
    {
        
        public string Title;
        public void Draw()
        {
            // Window Draw Code
            Console.WriteLine("Window Draw");
        }
    }

    public class SearchWindow : Window
    {
        TextBox _textBox = new TextBox();
        Button _button = new Button();
    }







}
