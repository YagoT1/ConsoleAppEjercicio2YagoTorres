using System;

namespace ConsoleAppEjercicio2YagoTorres
{
    class Program
    {
		static void Main(string[] args)
		{
			double area;
			double ladoa;
			double ladob;
			double ladoc;
			double p;
			double perimetro;
			double superficie;
			Console.Write("Ingrese lado A: ");
			ladoa = Double.Parse(Console.ReadLine());
			Console.Write("Ingrese lado B: ");
			ladob = Double.Parse(Console.ReadLine());
			Console.Write("Ingrese lado C: ");
			ladoc = Double.Parse(Console.ReadLine());
			perimetro = ladoa + ladob + ladoc;
			p = ((ladoa + ladob + ladoc) / 2);
            //Area=raiz(p*(p-LadoA)*(p-LadoB)*(p-LadoC));
            if (validarLados(ladoa, ladob, ladoc))
            {



                if ((validarrectangulo(ladoa, ladob, ladoc)))
                {
                    Console.WriteLine("Es un Triángulo Rectángulo");
                    Console.WriteLine($"Su perimetro es: {perimetro}");
                }
                else
                {
                    if ((validarobtusangulo(ladoa, ladob, ladoc)))
                    {
                        Console.WriteLine("Es un Triángulo Obtusángulo");
                        Console.WriteLine($"Su perimetro es: {perimetro}");
                    }
                    else
                    {
                        if ((validaracutangulo(ladoa, ladob, ladoc)))
                        {
                            Console.WriteLine("Es un Triángulo Acutángulo");
                            Console.WriteLine($"Su perimetro es: {perimetro}");
                        }
                        else
                        {
                            Console.WriteLine("Los valores ingresados no pertenecen a ningún triángulo...");
                        }
                    }
                }
            }
			else
            {
				Console.WriteLine("Ingrese valores dintintos a cero");
            }
            static bool validaracutangulo(double ladoa, double ladob, double ladoc)
			{
				if (Math.Pow(ladoa, 2) < Math.Pow(ladob, 2) + Math.Pow(ladoc, 2))
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			static bool validarobtusangulo(double ladoa, double ladob, double ladoc)
			{
				if (Math.Pow(ladoa, 2) > Math.Pow(ladob, 2) + Math.Pow(ladoc, 2))
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			static bool validarrectangulo(double ladoa, double ladob, double ladoc)
			{
				if (Math.Pow(ladoa, 2) == Math.Pow(ladob, 2) + Math.Pow(ladoc, 2))
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			static bool validarLados(double ladoa, double ladob, double ladoc)
			{
				
				      return ladoa > 0 && ladob > 0 && ladoc > 0;
			}
		}
		
	}
}
