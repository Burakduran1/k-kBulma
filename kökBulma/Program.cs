// See https://aka.ms/new-console-template for more information
int a, b, c;
double delta, x1, x2;
Console.WriteLine("a değerini giriniz:");
a =int.Parse(Console.ReadLine());
Console.WriteLine("b değerini giriniz:");
b = int.Parse(Console.ReadLine());
Console.WriteLine("c değerini giriniz:");
c = int.Parse(Console.ReadLine());

delta = b * b - 4 * a * c;

if (delta == 0)
{
    Console.WriteLine("Kökler eşit");

}
else if (delta < 0)
{

    Console.WriteLine("Reel Kökler Bulunmamaktadır.");


}
else
{
    x1 = ((-1) * b - delta * delta / 2 * a);
    x2 = ((-1) * b - delta * delta / 2 * a);

    Console.WriteLine("1.kök: " + x1 + "2. kök: " + x2);



}