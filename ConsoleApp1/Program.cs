//List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, };

//Console.WriteLine(numbers[^1]);


//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}

//numbers.ForEach(number => Console.WriteLine(number));

//int numberOfItemsLessThanFour = numbers.Count(n=>n<4);
//List<int> numbersLessThanFour = numbers.Where(n=>n<4).ToList();
//int sumOfAllNumbers = numbers.Sum();
//Console.ReadLine();


Baseball baseball = new Baseball();
baseball.stitches = 100;
baseball.radius = 3.5;
baseball.weight = 1.0;

SoccerBall newBall = new SoccerBall();
newBall.stitches = 5;


//this doesn't compile, Ball is abstract so you can't create an instance of it by itself.
//Ball basicBall = new Ball();

public abstract class Ball
{
    public double radius { get; set; }
    public double weight { get; set; }

    public abstract void Roll();
}

/*
    By putting `: Ball` after the definition of
    Baseball, any object created from this class
    would automatically have the two properties of
    radius and weight.
*/

//Baseball is considered the "derived" or "child" class
//Ball is considered the "inherited" or "parent" class
class Baseball : Ball
{
    // Stitches is not common to every kind of ball
    public int stitches { get; set; }

    
    public void DoSomething()
    {
        Roll();
    }

    public override void Roll()
    {
        throw new NotImplementedException();
    }
}



// All soccer balls will also have radius and weight
class SoccerBall : Baseball
{
    // Panels is not common to every kind of ball
    public int panels { get; set; }
}

class Football : Ball
{
    public double AirPressure { get; set; }
    public override void Roll()
    {
        Console.WriteLine("The football is wobbling around in a weird circle because it's an egg shape.");
    }
}