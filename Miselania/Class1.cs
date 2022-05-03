using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miselania
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double num3;
            double opcion;

            Console.WriteLine("Bienvenido");
            Console.WriteLine("-----------------");

            Console.WriteLine("Elije una opcion   " +
                "\n1 - Operadores" +
                "\n2 - condicionales" +
                "\n3 - Ciclos" +              
                "\n9 - salir");
            Console.WriteLine("-----------------");
            opcion = Convert.ToDouble(Console.ReadLine());



            switch (opcion)
            {
                case 1:
                    Console.WriteLine("-----------------");
                    Console.WriteLine("\n1 - Calcular area del triangulo");
                    Console.WriteLine("\n2 - Ingresar dos números por teclado y sumarlos.");
                    Console.WriteLine("\n3 - Ingresar un número y visualizar el número elevado al cuadrado. ");
                    Console.WriteLine("\n4 - Escribir un algoritmo que convierta de euros a dólares. ");
                    Console.WriteLine("\n5 - Escribir un algoritmo que pida el lado de un cuadrado y muestre el valor del área y del perímetro. ");
                    Console.WriteLine("\n6 - Escribir un algoritmo que determine el área y el volúmen de un cilindro.");
                    Console.WriteLine("\n7 - Realizar un algoritmo que lea el radio de una circunferencia y escriba la longitud de la misma y el área (pi*r)^2 del círculo inscrito. ");
                    Console.WriteLine("\n8 - Calcular el promedio de tres (3) números ingresados por teclado");
                    Console.WriteLine("\n9 - salir");
                    Console.WriteLine("-----------------");

                   
                    double opcion_1;

                    opcion_1 = Convert.ToDouble(Console.ReadLine());

                    switch (opcion_1)
                    {
                        case 1:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("lado 1:");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("lado 2: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("El area del triangulo es es:");
                            Console.WriteLine(num1 * num2/2);
                            Console.WriteLine("-----------------");
                            break; 


                        case 2:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("primer valor:");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("segundo valor: ");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("la suma es:");
                            Console.WriteLine(num1 + num2 );
                            Console.WriteLine("-----------------");
                            break;

                        case 3:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Ingrese el primer entero a multiplicar:");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("El resultado es:");
                            Console.WriteLine(  Math.Pow(num1,2) );
                            Console.WriteLine("-----------------");
                            break;

                        case 4:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Ingrese el valor en  euros:");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("El valor en dolares es:");
                            Console.WriteLine(num1 * 1.06);
                            Console.WriteLine("-----------------");
                            break;

                        case 5:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Ingrese el lado de un cuadrado:");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("El area del cuadrado es : ");
                            Console.WriteLine(num1 * num1);
                            Console.WriteLine("El perimetro del cuadrado es");
                            Console.WriteLine(num1 +  num1 + num1 + num1);
                            Console.WriteLine("-----------------");
                            break;

                        case 6:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Ingrese el radio del cilindro:");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese la altura del cilindro:");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("El area del cilindro es  : ");
                            Console.WriteLine( 2 * Math.PI *  num1 * num2 );
                            Console.WriteLine("El volumen del cilindro es");
                            Console.WriteLine(  Math.PI * num1 * num1 * num2);
                            Console.WriteLine("-----------------");
                            break;

                        case 7:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Ingrese el valor del diametro de la circunferencia:");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("El radio es : ");
                            Console.WriteLine();
                            Console.WriteLine("El area del cilindro es  : ");
                            Console.WriteLine();
                            Console.WriteLine("la longitud de la circunferencia es");
                            Console.WriteLine(Math.PI * 2  );
                            Console.WriteLine("-----------------");
                            break;

                        case 8:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Ingrese el primer valor:");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo valor:");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el tercer valor:");
                            num3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("El promedio de los datos es  : ");
                            Console.WriteLine( num1 + num2 + num3 / 3);
                            break;

                        case 9:

                            Console.WriteLine("saliendo del programa");
                            break ;

                        default:
                            Console.WriteLine("dato incorrecto saliendo del programa");
                            break;


                    }

                    break;
                case 2:
                    Console.WriteLine("-----------------");
                    Console.WriteLine("\n1 - Escribir un algoritmo para saber si el número ingresado por teclado es positivo o negativo.");
                    Console.WriteLine("\n2 - Escribir un algoritmo que reciba dos números por teclado y diga cuál es el mayor y cuál el menor. ");
                    Console.WriteLine("\n3 - Escriba un programa que lea tres números enteros positivos y que calcule e imprima en pantalla el menor y el mayor de ellos. ");
                    Console.WriteLine("\n4 - Dados dos números A y B, sumarlos si A es menor que B o sino restarlos.");
                    Console.WriteLine("\n5 - Dados dos números A y B encontrar el cociente entre A y B. Recordar que la división por cero no está definida, en ese caso debe aparecer una leyenda anunciando que la división no es posible. ");
                    Console.WriteLine("\n6 - Dados dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos. ");
                    Console.WriteLine("\n7 - Escribir un algoritmo que determine si un año es bisiesto o no.");
                    Console.WriteLine("-----------------");

                   
                    double opcion_2;
                    opcion_2 = Convert.ToDouble(Console.ReadLine());

                    switch (opcion_2)
                    {
                        case 1:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Ingrese un numero");
                            num1= Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("-----------------");
                            if (num1 > 0)
                            {
                                Console.WriteLine("El numero es " + num1 + " positivo");
                            }
                            else
                            {
                                Console.WriteLine("El numero es " + num1 + " negativo");
                            }
                            break;

                        case 2:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Ingrese el primer numero");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo numero");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("-----------------");
                            if (num1 > num2)
                            {
                                Console.WriteLine("El numero  " + num1 + "  es mayor que " + num2);
                            }
                            else 
                            {
                                Console.WriteLine("El numero  " + num1 + " es  menor que " + num2);
                                
                            }
                            break;

                        case 3:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Ingrese el primer numero");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo numero");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el tercer numero");
                            num3 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("-----------------");

                            if (num1 > num2)                            
                            {
                                Console.WriteLine("El numero mayor es " + num1 );
                            }
                            else if (num2 > num3)
                            {
                                Console.WriteLine("El numero mmayor es " + num2);
                            }
                            else 
                            {
                                Console.WriteLine("El numero mayor es " + num3);
                            }
                            if (num1 < num2)
                            {
                                Console.WriteLine("El numero menor es " + num1);
                            }
                            else if (num2 < num3)
                            {
                                Console.WriteLine("El numero menor es " + num2);
                            }
                            else 
                            {
                                Console.WriteLine("El numero menor es " + num3);
                            }

                            break;

                        case 4:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Ingrese el primer numero");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo numero");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("-----------------");

                            if (num1 > num2)
                            {
                                Console.WriteLine(" la suma es ");
                                Console.WriteLine( num1 + num2);
                            }
                            else 
                            {
                                Console.WriteLine(" la resta es ");
                                Console.WriteLine( num1 - num2 );
                            }

                            break;

                        case 5:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Ingrese el primer numero");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo numero");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("-----------------");


                            if (num1 == 0)
                            {
                                Console.WriteLine("la division no es posible");
                            }
                            else if (num2 == 0)
                            {
                                Console.WriteLine("la division no es posible");
                            }
                            else
                            {
                                Console.WriteLine("el resultado es ");
                                Console.WriteLine(num1 / num2);
                            }
                            
                            break;

                        case 6:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Ingrese el primer numero");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo numero");
                            num2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("-----------------");

                            if (num1 < 0)
                            {
                                Console.WriteLine(" la suma es ");
                                Console.WriteLine(num1 + num2);
                            }
                            else if (num2 < 0)
                            {
                                Console.WriteLine(" la suma es ");
                                Console.WriteLine(num1 + num2);
                            }
                            else
                            {
                                Console.WriteLine(" la multiplicacion es  ");
                                Console.WriteLine(num1 * num2);
                            }

                            break;

                        case 7:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Calcular bisiestos");                          
                            Console.WriteLine("Año a calcular");
                            num1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("-----------------");

                            if(num1 % 4 == 0 && (num1) % 100 !=0 || (num1) % 400 ==0)
                            {
                                Console.WriteLine("Es bisiesto {0}", num1);
                            }
                            else
                            {
                                Console.WriteLine("no es bisiesto {0}", num1);
                            }
                            break;
                    }
                    break;



                case 3:
                    Console.WriteLine("-----------------");
                    Console.WriteLine("\n1 - Imprimir todos los múltiplos de 3 que hay entre 1 y 100.");
                    Console.WriteLine("\n2 - Imprimir los números impares entre 0 y 100. ");
                    Console.WriteLine("\n3 - Imprimir los números pares del 1 al 100");
                    Console.WriteLine("\n4 - Escribir un programa que imprima por pantalla los cuadrados de los números del 1 al 30.");
                    Console.WriteLine("\n5 - Escribir un programa que sume los cuadrados de los cien primeros números naturales, mostrando el resultado en pantalla.");
                    Console.WriteLine("\n6 - Dados dos números naturales, el primero menor que el segundo, generar y mostrar todos los números comprendidos entre ellos en secuencia ascendente.");
                    Console.WriteLine("\n7 - Sumar todos los números que se digitan por teclado mientras no sea cero.");
                    Console.WriteLine("-----------------");

                  
                    double opcion_3;

                    opcion_3 = Convert.ToDouble(Console.ReadLine());

                    switch(opcion_3)
                    {
                        case 1:
                            
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Los multiplos de 3 del numero 1 al 100 son");
                            Console.WriteLine("-----------------");

                            for(num1 = 3; num1 <= 100; num1+=3)
                            {
                                Console.WriteLine("-" + num1);
                            }
                            break ;

                        case 2:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Los numeros impares del numero 0 al 100 son");
                            Console.WriteLine("-----------------");

                            for (num1 = 1; num1 <= 100; num1 += 2)
                            {
                                Console.WriteLine("-" + num1);
                            }

                            break ;

                        case 3:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Los numeros pares del numero 0 al 100 son");
                            Console.WriteLine("-----------------");

                            for (num1 = 2; num1 <= 100; num1 += 2)
                            {
                                Console.WriteLine("-" + num1);
                            }

                            break;

                        case 4:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Los cuadrados del numero 1 al 30 son");
                            Console.WriteLine("-----------------");

                            for (num1 = 1; num1 <= 30; num1 ++)
                            {
                                Console.WriteLine(" El numero " + num1 + " al cuadrado es = " + Math.Pow(num1,2));
                            }

                            break;

                        case 5:
                            Console.WriteLine("-----------------");
                            Console.WriteLine("Los cuadrados del numero 1 al 30 son");
                            Console.WriteLine("-----------------");

                            for (num1 = 1; num1 <= 30; num1++)
                            {
                                Console.WriteLine(" El numero " + num1 + " al cuadrado es = " + Math.Pow(num1, 2));
                            }

                            break;

                    }


                    break;
                case 9:
                    Console.WriteLine("salir");
                    break;

            


            }



        }
    }

}
 
    

