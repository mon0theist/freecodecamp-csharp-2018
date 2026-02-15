namespace Giraffe
{
    class Chef
    {
        // METHODS
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes chicken.");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes salad.")
        }
        
        // virtual means this can be overridden in inherited subclasses
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes BBQ ribs.");
        }
    }
}