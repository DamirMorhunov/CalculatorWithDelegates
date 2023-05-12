int choice = 4;
Operation operation = null;
switch(choice)
{
    case 1: operation = Add; break;
    case 2: operation = Sub; break;
    case 3: operation = Mult; break;
    case 4: operation = Div; break;
}
double? result = operation?.Invoke(12, 0);
Console.WriteLine(result);






double Add(double x, double y) => x + y;
double Sub(double x, double y) => x - y;
double Mult(double x, double y) => x * y;
double Div(double x, double y) => x / y;
delegate double Operation(double x, double y);
