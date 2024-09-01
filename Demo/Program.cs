using Demo.Example02_Delegate;
using Demo.Example04;

namespace Demo
{
    //step 0 :declare Delegate
    public delegate int StringFuncDelegate(string Str);

    //will be translated to New Class [Delegate]
    // Any Reference From This Delegate Can Refer To 
    // Function Or More [Pointer To Function]
    // This Function May be Static Function [Class Member Function]
    // This Function May be Non Static Function [Object Member Function]
    // But These Functions Must be with the Same Signature of The Delegate 
    // Regardless Function Name & Access Modifier
    #region Built-In Delegates[predicate ,Func,Action]
    /// Predicate 
    /// can refer to function that take one parameter[of any data type] only and retuen bool 

    /// Func    
    /// can refer to function that take [zero to 16] parameter And Must Be Return

    /// Action
    /// can refer to function that take [zero to 16] parameter And Must Be Void
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate Example 1
            // ///Delegate Is Class
            // ///Delegate is c# language feature 
            // ///has 2 usages
            // ///1.Pointer to Function (functinal programming)
            // ///2.Even driven programming
            // ///

            //int x= StringFunction.GetCountOfUpperCharacters("MarWa");
            ////int y = StringFunction.GetCountOfUpperCharacters;//invalid



            // //Step 01: Declare Reference From Delegate
            // StringFuncDelegate stringFuncDelegate;
            // //Step 02: Initialize Reference From Delegate[Pointer To Function]
            // stringFuncDelegate = new StringFuncDelegate(StringFunction.GetCountOfUpperCharacters);
            // //stringFuncDelegate = StringFunction.GetCountOfUpperCharacters; //syntax sugar
            // //Step 03: Use Delegate Reference [Call Method] 
            // int y =stringFuncDelegate.Invoke("MatUPOPOj");
            // Console.WriteLine(y);


            // stringFuncDelegate+= new StringFuncDelegate(StringFunction.GetCountOfLowerCharacters);



            #endregion
            #region Delegate Example 2
            //int[] Numbers = { 10, 2, 3, 4, 15, 1, 78 };
            //CompareFuncDelegate compareFunc = new CompareFuncDelegate(ComareFunction.LessThan);
            //foreach (var item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("after sorting");
            //SotingAlgorithm.BubbleSort(Numbers, compareFunc);
            //foreach (var item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //CompareFuncDelegate compareFunc2 = new CompareFuncDelegate(ComareFunction.GreaterThan);

            //Console.WriteLine("after desc sorting");
            //SotingAlgorithm.BubbleSort(Numbers ,compareFunc2);
            //foreach (var item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Delegate Example 3 [generics]
            string[] Names = { "Marwa", "Marwan", "Marwaaaaa", "Marwaaaaann" };
            SotingAlgorithm<string>.BubbleSort(Names, ComareFunction.SortStringAsc);
            foreach (var item in Names)
            {
                Console.WriteLine(item);
            }
            #endregion
            #region Delegate Example 4
            List<int> Numbers = Enumerable.Range(0, 100).ToList();
            List<int> Result = Helper<int>.Elemsnts(Numbers, FilterFunctions.OdddFilter);
            //foreach (var item in Result) { Console.WriteLine( item); }

            List<int> ResultBySeven = Helper<int>.Elemsnts(Numbers, FilterFunctions.BySevenFilter);

            #region generics
            foreach (var item in ResultBySeven) { Console.WriteLine(item); }
            Console.WriteLine("string Filter");
            List<string> Names02 = new List<string>() { "Marwaa", "reem", "ra", "jfjf", "marwan" };
            List<string> Result02 = Helper<string>.Elemsnts(Names02, FilterFunctions.FilterString);

            foreach (var item in Result02) { Console.WriteLine(item); }
            #endregion
            #endregion
            #region Built-In Delegates[predicate ,Func,Action] && Anonymous Method and Lambda Expression[functional programming]
            #region predicate
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Predicate<int> isEven = IsEvenNumber;

            List<int> evenNumbers = numbers.FindAll(isEven);

            Console.WriteLine("Even numbers in the list:");
            //foreach (int number in evenNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
            #region Func
            Func<int> getRandomNumber = () => new Random().Next(1, 100);
            Console.WriteLine($"Random number: {getRandomNumber()}");

            Func<int, int> square = x => x * x;
            int number = 5;
            Console.WriteLine($"Square of {number}: {square(number)}");

            Func<int, int, string> concatenateNumbers = (a, b) => (a.ToString() + b.ToString());
            int num1 = 3, num2 = 4;
            Console.WriteLine($"Concatenation of {num1} and {num2}: {concatenateNumbers(num1, num2)}");

            Func<int, int, int, bool> isSumGreaterThanTen = (a, b, c) => (a + b + c) > 10;
            int x = 2, y = 3, z = 6;
            Console.WriteLine($"Is the sum of {x}, {y}, and {z} greater than 10? {isSumGreaterThanTen(x, y, z)}");
            #endregion
            #region Action
            Action greet = () => Console.WriteLine("Hello, world!");
            greet();

            Action<string> printMessage = message => Console.WriteLine($"Message: {message}");
            printMessage("Welcome to C# programming!");

            Action<int, int> addNumbers = (a, b) => Console.WriteLine($"Sum: {a + b}");
            addNumbers(5, 7);

            Action<int, int, int> multiplyNumbers = (x, y, z) => Console.WriteLine($"Product: {x * y * z}");
            multiplyNumbers(2, 3, 4);
            #endregion
            #endregion
            #region Var new c# feature
            var Predicate = (int x) => x == 2; 
            #endregion

        }
        #region predicate
        static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        } 
        #endregion
    }
}
