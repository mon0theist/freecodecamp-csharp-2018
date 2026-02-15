// Inherits from Chef.cs

namespace Giraffe
{
    class ItalianChef : Chef // inherit from Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Italian Chef makes a Gabbagool....fuhgeddaboudit!");
        }

        // overrides the virtual
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes BBQ ribs.");
        }
    }
}