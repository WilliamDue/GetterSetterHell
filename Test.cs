namespace GetterSetterHell;

public class Test {
    
    private string firstThing;

    // This property behaves identically to a public field.
    public string SecondThing { get; set; }

    // This behaves like a public field but one is only able to set its value inside the class.
    public string PrivateSetter { get; private set; }

    // This makes the property readonly.
    public string OnlyGettable { get; }

    // This does not work a getter must be present.
    // public string OnlySettable { set; }

    // This property behaves the same as the the functions GetFirstThing and SetFirstThing.
    // The only difference is the syntax.
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

    // This property behaves the same as the FirstThing property, the difference is it does not 
    // print to console. It works if the setter/getter is a one-liner (It can also be used for 
    // methods). This syntax might be confusing but if you meet it when researching you can see it 
    // here.
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

    // The methods GetFirstThing/SetFirstThing behaves the same as the FirstThing property.
    public string GetFirstThing() {
        Console.WriteLine("You are getting first thing.");
        return firstThing;
    }

    public void SetFirstThing(string firstThing) {
        Console.WriteLine("You are setting first thing.");
        this.firstThing = firstThing;
    }
}