namespace Delegates
{
    class Program
    {
        public static void Main()
        {
            Delegates.Class1 class1 = new Delegates.Class1();
            Delegates.Class2 class2 = new Delegates.Class2();


            class1.forShow = class1.Show;
            var result = class2.Calc(class2.forPow, 7, 3);
            class1.forShow(result(4));
          
        }
    }
}