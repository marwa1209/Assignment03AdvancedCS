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
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate Example 1
            ///Delegate Is Class
            ///Delegate is c# language feature 
            ///has 2 usages
            ///1.Pointer to Function (functinal programming)
            ///2.Even driven programming
            ///

           int x= StringFunction.GetCountOfUpperCharacters("MarWa");
           //int y = StringFunction.GetCountOfUpperCharacters;//invalid
            


            //Step 01: Declare Reference From Delegate
            StringFuncDelegate stringFuncDelegate;
            //Step 02: Initialize Reference From Delegate[Pointer To Function]
            stringFuncDelegate = new StringFuncDelegate(StringFunction.GetCountOfUpperCharacters);
            //stringFuncDelegate = StringFunction.GetCountOfUpperCharacters; //syntax sugar
            //Step 03: Use Delegate Reference [Call Method] 
            int y =stringFuncDelegate.Invoke("MatUPOPOj");
            Console.WriteLine(y);


            stringFuncDelegate+= new StringFuncDelegate(StringFunction.GetCountOfLowerCharacters);



            #endregion
        }
    }
}
