
double num1, num2, suma, resta, mult, divis, res;
Console.WriteLine("Ingrese un número: ");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
num2 = int.Parse(Console.ReadLine());

suma = num1 + num2;
resta = num1 - num2;
mult = num1 * num2;
divis = num1 / num2;

Console.WriteLine("La suma de los números es: " + suma);
Console.WriteLine("La resta de los números  es : " + resta);
Console.WriteLine("La multiplicación de los números es: " + mult);
Console.WriteLine("La división de los números es:" + divis);
res = (suma * resta) * mult / (divis);
Console.WriteLine("La suma x la resta x la mult dividida es: " + res);

Console.ReadKey();
