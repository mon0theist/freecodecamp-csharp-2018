namespace Giraffe
{
    static class UsefulTools // adding static means you can't create an object instance
    {
        // Static Class Method
        public static void SayHi(string name)
        {
            Console.WriteLine($"Hi {name}");
        }
    }
}