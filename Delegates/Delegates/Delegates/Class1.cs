namespace Delegates.Delegates
{
    internal class Class1
    {
        public Action<bool> forShow;

        public void Show(bool status)
        {
            Console.WriteLine(status);
        }

        public int Pow(int a, int b)
        {
            return a * b;
        }
    }
}
