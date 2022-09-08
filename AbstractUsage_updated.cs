
    public abstract class Control
    {
        public string ControlId, ToolTip;
        public double Height, Width;
        public abstract void Draw();
      
    }

    public class TextBox:Control
    {
        
        public string Text;
        public override void Draw()
        {

            Console.WriteLine("TextBox Draw");
        }
        
    }
    public class Button:Control
    {
        
        public string Caption;
        public override void Draw()
        {
            Console.WriteLine("Button Draw");
        }
    }
    public class Window:Control
    {

        List<Control> controls = new List<Control>();
        public string Title;
        public override void Draw()
        {
            // Window Draw Code
            Console.WriteLine("Window Draw");
            foreach(Control ctrl in controls)
            {
                ctrl.Draw();
            }
        }
        public void AddControl(Control ctrl)
        {
            this.controls.Add(ctrl);
        }
        public void RemoveControl(Control ctrl)
        {
            this.controls.Remove(ctrl);
        }
    }

    public class SearchWindow : Window
    {
        TextBox _textBox = new TextBox();
        Button _button = new Button();
        public SearchWindow()
        {
            this.AddControl(_textBox);
            this.AddControl(_button);
        }
    }

