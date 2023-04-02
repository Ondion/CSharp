// namespace POO;

public class Rocket
{
  public string Type { get; set; }
}

var rocket1 = new Rocket();
var rocket2 = rocket1;

rocket1.Type = "Apollo 11";
rocket2.Type = "Falcon 9";

Console.WriteLine(rocket1.Type);

// Console: "Falcon 9"

var number1 = 1;
var number2 = number1;

number2 = 2;

Console.WriteLine(number1);
// Console: # 1
