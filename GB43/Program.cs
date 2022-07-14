
Console.Clear();

double b1 = Input ("Введите значение b1: ");
double k1 = Input ("Введите значение k1: ");
double b2 = Input ("Введите значение b2: ");
double k2 = Input ("Введите значение k2: ");

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

if(k1==k2)
{
    Console.WriteLine("Прямые параллельны, точек пересечения нет.\n");
    return;
}
else
{
    Console.WriteLine($"y = {x}, x = {x} \n");
}
    
int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}

