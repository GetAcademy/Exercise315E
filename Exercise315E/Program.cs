using Exercise315E;

//TheExercise.Run();

var startValue = MyConsole.Ask("startverdi: ");
var endValue = MyConsole.Ask("sluttverdi: ");
var change = MyConsole.Ask("endring: ");

var numberGenerator = new NumberGenerator(startValue, endValue, change);
while (true)
{
    Console.WriteLine(numberGenerator.GetNumber());
    Console.WriteLine("+ = neste tall    - = forrige tall");
    var key = Console.ReadKey(true);
    if (key.KeyChar == '+') numberGenerator.Next();
    else if (key.KeyChar == '-') numberGenerator.Previous();
}