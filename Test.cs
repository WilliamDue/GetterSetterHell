namespace GetterSetterHell;

public class Test {
    
    private string firstThing;
    public string SecondThing { get; set; }
    public string PrivateSetter { get; private set; }
    public string OnlyGettable { get; }
    public string FirstThing {

        get {
            Console.WriteLine("You are getting first thing.");
            return firstThing;
        }
        
        set {
            Console.WriteLine("You are setting first thing.");
            firstThing = value;
        }

    }
    public string FirstThingLambdaExpression {
        get => firstThing;
        set => firstThing = value;
    }

    public Test(string thing) {
        firstThing = thing;
        FirstThingLambdaExpression = thing;
        SecondThing = thing;
        PrivateSetter = thing;
        OnlyGettable = thing;
    }

    public string GetFirstThing() {
        Console.WriteLine("You are getting first thing.");
        return firstThing;
    }

    public void SetFirstThing(string firstThing) {
        Console.WriteLine("You are setting first thing.");
        this.firstThing = firstThing;
    }
}