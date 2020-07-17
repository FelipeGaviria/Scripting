using System;
using System.ComponentModel.Design;

namespace Cálculo_de_deducciones_salariales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario: ");
            double sal = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su tipo de contrato (escriba 1 si es dependiente, 2 si es independiente): ");
            int Contrato = int.Parse(Console.ReadLine());

            int smmlv = 877803;

            double Cot = sal * 0.4; //La base de cotización es el 40% del salario



            if (Contrato == 1)
            { 
                if (Cot < smmlv)
                {
                    Cot = smmlv;
                    double pension = Cot * 0.04;
                    double eps = Cot * 0.04;
                    double deduc = pension + eps;

                    double salReal = sal - deduc;
                    Console.WriteLine("Su salario real es: " + salReal);

                    double salAnual = (salReal * 12) + sal;
                    Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                }

                else
                {
                    double pension = Cot * 0.04;
                    double eps = Cot * 0.04;
                    double deduc = pension + eps;

                    double salReal = sal - deduc;
                    Console.WriteLine("Su salario real es: " + salReal);

                    double salAnual = (salReal * 12) + sal;
                    Console.WriteLine("Sus ingresos anuales son: " + salAnual);   
                }
            }

            else if (Contrato == 2)
            { //(Si es independiente)
                Console.WriteLine("Ingrese un número de 1 a 5 equivalente a la clase del riesgo que le corresponde: ");
                double riesg = double.Parse(Console.ReadLine());

                if (riesg == 1)
                {
                    if (Cot < smmlv)
                    {
                        Cot = smmlv;
                        double pension = Cot * 0.16;
                        double eps = Cot * 0.125;
                        double arl = Cot * 0.00522;
                        double deduc = pension + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);

                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }
                    else
                    {                        
                        double pension = Cot * 0.16;
                        double eps = Cot * 0.125;
                        double arl = Cot * 0.00522;
                        double deduc = pension + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }                   
                }

                if (riesg == 2)
                {
                    if (Cot < smmlv)
                    {
                        Cot = smmlv;
                        double pension = Cot * 0.16;
                        double eps = Cot * 0.125;
                        double arl = Cot * 0.01044;
                        double deduc = pension + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }
                    else
                    {
                        double pension =  Cot * 0.16;
                        double eps = Cot * 0.125;
                        double arl = Cot * 0.01044;
                        double deduc = pension + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }
                }

                if (riesg == 3)
                {
                    if (Cot < smmlv)
                    {
                        Cot = smmlv;
                        double pension = Cot * 0.16;
                        double eps = Cot * 0.125;
                        double arl = Cot * 0.02436;
                        double deduc = pension + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }
                    else
                    {
                        double pension = Cot * 0.16;
                        double eps = Cot * 0.125;
                        double arl = Cot * 0.02436;
                        double deduc = pension + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }
                }

                if (riesg == 4)
                {
                    if (Cot < smmlv)
                    {
                        Cot = smmlv;
                        double pension = Cot * 0.16;
                        double eps = Cot * 0.125;
                        double arl = Cot * 0.04350;
                        double deduc = pension + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }
                    else
                    {
                        double pension = Cot * 0.16;
                        double eps = Cot * 0.125;
                        double arl = Cot * 0.04350;
                        double deduc = pension + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }
                }
                if (riesg == 5)
                {
                    if (Cot < smmlv)
                    {
                        Cot = smmlv;
                        double pension = Cot * 0.16;
                        double eps = Cot * 0.125;
                        double arl = Cot * 0.06960;
                        double deduc = pension + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }

                    else
                    {

                        double pension = Cot * 0.16;
                        double eps = Cot * 0.125;
                        double arl = Cot * 0.06960;
                        double deduc = pension + eps + arl;

                        double salReal = sal - deduc;
                        Console.WriteLine("Su salario real es: " + salReal);
                        double salAnual = salReal * 12;
                        Console.WriteLine("Sus ingresos anuales son: " + salAnual);
                    }
                }
            }
        }
    }
}