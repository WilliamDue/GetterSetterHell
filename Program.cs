namespace GetterSetterHell;

public class Program {
    static void Main(string[] args) {
        var test = new Test("Test");
        Console.WriteLine(test.FirstThing);
        
        test.FirstThing = "Something new 0";
        Console.WriteLine(test.FirstThing);

        test.FirstThingLambdaExpression = "Something new 1";
        Console.WriteLine(test.FirstThingLambdaExpression);

        test.SetFirstThing("Something new 2");
        Console.WriteLine(test.GetFirstThing());

        test.SecondThing = "Something new 3";
        Console.WriteLine(test.SecondThing);

        // test.PrivateSetter = "This will fail"; // <- This will give an build error.
        Console.WriteLine(test.PrivateSetter);

        // test.OnlyGettable = "This will fail"; // <- This will give an build error.
        Console.WriteLine(test.OnlyGettable);
    }
}