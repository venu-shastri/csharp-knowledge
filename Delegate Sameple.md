#### Delegate Sameple



```C#



    public delegate bool PredicateHandler<T>(T item);
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "philips", "pic", "siemens", "sap" };
            PredicateHandler<string> _handler = new PredicateHandler<string>(Program.CheckStringStartWithp);
            List<string> _resultList = Iterator(names,_handler);
            _handler = new PredicateHandler<string>(Program.CheckStringLengthGreaterThan3);
            _resultList = Iterator(names, _handler);
            int[] numbers = { 23, 4, 5, 6, 77, 88 };
            PredicateHandler<int> _intHandler = new PredicateHandler<int>(Program.CheckForEvenNumbers);
          List<int> intResult=  Iterator<int>(numbers, _intHandler);
        }

        static bool CheckForEvenNumbers(int item)
        {
            return item % 2 == 0;
        }
        static bool CheckStringStartWithp(string item)
        {
            return item.StartsWith("p");
        }
        static bool CheckStringLengthGreaterThan3(string item)
        {
            return item.Length > 3;
        }
        public static List<T> Iterator<T>(T[] input, PredicateHandler<T> predicate )
        {
            List<T> result = new List<T>();

            for (int i = 0; i < input.Length; i++)
            {
                if (predicate.Invoke(input[i]))
                {
                    result.Add(input[i]);
                }
            }

            return result;
        }
    }
```

### Built in Func Delegate usge

```C#
  class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "philips", "pic", "siemens", "sap" };
            Func<string,bool> _handler = new Func<string, bool>(Program.CheckStringStartWithp);
            List<string> _resultList = Iterator(names,_handler);
            _handler = new Func<string, bool>(Program.CheckStringLengthGreaterThan3);
            _resultList = Iterator(names, _handler);
            int[] numbers = { 23, 4, 5, 6, 77, 88 };
            Func<int,bool> _intHandler = new Func<int,bool>(Program.CheckForEvenNumbers);
          List<int> intResult=  Iterator<int>(numbers, _intHandler);
        }

        static bool CheckForEvenNumbers(int item)
        {
            return item % 2 == 0;
        }
        static bool CheckStringStartWithp(string item)
        {
            return item.StartsWith("p");
        }
        static bool CheckStringLengthGreaterThan3(string item)
        {
            return item.Length > 3;
        }
        public static List<T> Iterator<T>(T[] input, Func<T,bool> predicate )
        {
            List<T> result = new List<T>();

            for (int i = 0; i < input.Length; i++)
            {
                if (predicate.Invoke(input[i]))
                {
                    result.Add(input[i]);
                }
            }

            return result;
        }
    }
```

#### MulticastDelegate Demo

```C#
 class MultiCastDelegateDemo
    {

        static void Main()
        {
            Action funRef = new Action(MultiCastDelegateDemo.Fun);

            Action fooRef = new Action(MultiCastDelegateDemo.Foo);

            Action moreFunRef = new Action(MultiCastDelegateDemo.MoreFun);
            funRef += fooRef + moreFunRef;

            // Action _newDelegateRef=System.Delegate.Combine(funRef, fooRef, moreFunRef) as Action;
            Action _newDelegateRef = funRef + fooRef + moreFunRef;

            if (_newDelegateRef != null)
            {
                _newDelegateRef.Invoke(); // Fun,Foo,MoreFun.....
            }

        }

        static void Fun() { }
        static void Foo() { }

        static void MoreFun() { }


    }
```

