namespace Delegates.Delegates
{
    internal class Class2
    {
        private Class1 class1 = new Class1();

        public Func<int, int, int> forPow;

        private Func<int, bool> forResult;

        private int _result;

        public Func<int, bool> Calc(Func<int, int, int> forPow1, int a, int b)
        {
            forPow1 = forPow;
            forPow1 = class1.Pow;
            _result = forPow1(a, b);
          
           return forResult = Result;    
        }

        public bool Result(int a)
        {
            int num = _result / a;
           
            if(num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
    }
}
