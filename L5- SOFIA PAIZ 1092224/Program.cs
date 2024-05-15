using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[]args)
    {

    String nombre;

        Console.WriteLine("Ingrese su nombre");
        nombre = Console.ReadLine();
        Console.WriteLine("Hola" + nombre);

        Console.WriteLine("Parte 2: Ej 1");
        int num1, num2;
        int suma, resta, mult, división, mod;

        Console.WriteLine("Ingrese el primer número");
        num1= Int32.Parse(Console.ReadLine());
        Console.WriteLine(num1);

        Console.WriteLine("Ingrese el segundo número");
        num2 = Int32.Parse(Console.ReadLine());
        Console.WriteLine(num2);

        suma= num1 + num2;
        resta = num1-num2;
        mult= num1* num2;
        división= num1/num2;
        mod= num1 % num2;
        

       Console.WriteLine ("El resultado de la suma:"+ num1 + "+"+ num2 + "="+ suma );
       Console.WriteLine ("El resultado de la resta:"+ num1 + "-"+ num2+ "="+ resta );
       Console.WriteLine ("El resultado de la multiplicación:"+ num1 + "*"+ num2+ "="+ mult );
       Console.WriteLine ("El resultado de la división:"+ num1 + "/"+ num2+ "="+ división );
       Console.WriteLine ("El resultado del mod:"+ num1 + "%"+num2+ "="+ mod);


       Console.WriteLine("Ejercicio 2: operaciones booleanas");
       Console.WriteLine (num1 + "<"+num2 + "="+(num1<num2) );
       Console.WriteLine (num1 + ">"+num2 + "="+(num1>num2) );
       Console.WriteLine (num1 + "=="+num2 + "="+(num1==num2) );
    



    Console.WriteLine("Ejercicio 3: Jerarquía de operaciones");
    int a, b, c, resultado, resultado2, resultado3, resultado4;

    Console.WriteLine("Ingrese un número");
        a = Int32.Parse(Console.ReadLine());
        Console.WriteLine(a);

     Console.WriteLine("Ingrese otro número");
        b = Int32.Parse(Console.ReadLine());
        Console.WriteLine(b);
    
    Console.WriteLine("Ingrese otro número");
        c = Int32.Parse(Console.ReadLine());
        Console.WriteLine(c);

resultado = a*b+c; 
resultado2 = a*(b+c); 
resultado3= ((a)/(b*c));
resultado4= ((3*a)+(2*b)/(c*c));

Console.WriteLine ("El resultado es:"+ resultado );
Console.WriteLine ("El resultado es:"+ resultado2 );
Console.WriteLine ("El resultado es:"+ resultado3 );
Console.WriteLine ("El resultado es:" + resultado4 );


Console.WriteLine("Parte 4: ej 1");
 double parta, partb, partc;

        Console.WriteLine("Ingrese el valor de a:");
        parta = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de b:");
        partb = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de c:");
        partc = Convert.ToDouble(Console.ReadLine());

        if (parta != 0 && Math.Pow(partb, 2) - 4 * parta * partc >= 0)
        {
            double x1 = (-partb + Math.Sqrt(Math.Pow(partb, 2) - 4 * a * c)) / (2 * a);
            double x2 = (-partb - Math.Sqrt(Math.Pow(partb, 2) - 4 * a * c)) / (2 * a);

        
            Console.WriteLine("La respuestas pueden ser:");
            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
        else
        {
            Console.WriteLine("La operación no se puede realizar.");
        }
    }
}







