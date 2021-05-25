 public class Window
    {
        Button _btn = new Button();
        TextBox _text = new TextBox();
        public void CaptureButtonClick()
        {
            _btn.OnClick();
        }

    }
    public class Button
    {
        public void OnClick()
        {
          
        }
    }

    public class TextBox
    {

        public void Clear()
        {
            Console.WriteLine("Text Box Content Cleared");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Window _window = new Window();
            while(true)
            {
                Console.WriteLine("Press Any Key To Press Button");
                Console.ReadKey();
                _window.CaptureButtonClick();

            }
        }
    }
}
