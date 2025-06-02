using EspacioCalculadora;

Calculadora calc = new Calculadora();
string comando = "";

Console.WriteLine("Comandos: sumar, restar, multiplicar, dividir, limpiar, salir");

while (comando != "salir")
{
    Console.WriteLine($"\nResultado actual: {calc.Resultado}");
    Console.Write("Ingrese una operación: ");
    comando = Console.ReadLine().ToLower();
    if (comando == "salir") break;
    if (comando == "limpiar")
        {
            calc.Limpiar();
            Console.WriteLine("Resultado reiniciado a 0.");
        }
        else if (comando == "sumar" || comando == "restar" ||
            comando == "multiplicar" || comando == "dividir")
        {
            Console.Write("Ingrese un número: ");
            string entrada = Console.ReadLine();
            if (double.TryParse(entrada, out double valor))
            {
                switch (comando)
                {
                    case "sumar":
                        calc.Sumar(valor);
                    break;
                    case "restar":
                        calc.Restar(valor);
                    break;
                    case "multiplicar":
                        calc.Multiplicar(valor);
                    break;
                    case "dividir":
                        calc.Dividir(valor);
                    break;
                }
            }else
                {
                    Console.WriteLine("Entrada inválida");
                }
            }else
                {
                    Console.WriteLine("Comando desconocido.");
                }
        }

Console.WriteLine($"Resultado final: {calc.Resultado}");
Console.WriteLine("Fin");