// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bienvenido al juego de cartaas");
int totalJugadro = 0;
int totoalDealer = 0;
int num = 0;
string message = "";
string switchControl = "menu";
string controlOtraCarta = "";
int platziCoint = 0;
while (true)
{
    Console.WriteLine("Welcome to Casino");
    Console.WriteLine("¿Cuantos platzi conits deseas \n ingresa un entero \n recuerda que necesitas una por ronda.\n");
    platziCoint = int.Parse(Console.ReadLine());
    for (int i = 0; i < platziCoint; i++)
    {
        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("Welcome al casino ");
                Console.WriteLine("Escriba 21 para jugar al 21 ");
                switchControl = Console.ReadLine();
                i = i - 1;
                break;
            case "21":
                totalJugadro = 0; totoalDealer = 0; num = 0;
                do
                {
                    //instancia de random
                    System.Random random = new System.Random();
                    num = random.Next(1, 12);
                    totalJugadro = totalJugadro + num;
                    Console.WriteLine("Toma tu carta; jugador");
                    Console.WriteLine($"Te salió el numero = {num} \n Estas acumulando {totalJugadro} \n Deseas una carta?");
                    controlOtraCarta = Console.ReadLine();
                } while (controlOtraCarta == "Si" || controlOtraCarta == "si");
                System.Random random1 = new System.Random();
                totoalDealer = random1.Next(14, 23);
                if (totalJugadro > totoalDealer && totalJugadro < 22)
                {
                    message = $"venciste al dealer, Felicidades {totoalDealer} ";
                }
                else if (totalJugadro > 21)
                {
                    message = $"Perdiste vs el dealer, lo siento te pasaste de 21 {totoalDealer}";
                }
                else if (totalJugadro <= totoalDealer)
                {
                    message = $"Perdiste vs el dealer, lo siento {totoalDealer}";
                }
                else
                {
                    message = "condición no válida";
                }
                Console.WriteLine(message);
                switchControl = "menu";
                break;
            default:
                Console.WriteLine("no existe esta opcion");
                switchControl = Console.ReadLine();
                break;
        }


    }
    Console.WriteLine("no tienes mas platzi coint");
    
}

