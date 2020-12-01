using System;

namespace Primeiro_POO
{
    class Program
    {
        static void Main(string[] args)
        {
        // Instancianando objeto

        Personagem player1 = new Personagem();
        player1.nome = "Matheus";
        player1.idade = 22;
        player1.armadura = "Mark 42";
        player1.iA = "Jarvis";

        Personagem player2 = new Personagem();
        player2.nome = "James Rhodes";
        player2.idade = 40;
        player2.armadura= "War Machine";

        // Características do Personagem 1
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Veja características do PL1: ");
        Console.WriteLine($"Nome do player 1: {player1.nome} ");
        Console.WriteLine($"Idade do player 1: {player1.idade} ");
        Console.WriteLine($"Armadura do player 1: {player1.armadura} ");
        Console.WriteLine($"Inteligência Artificial do player 1: {player1.iA} ");
        Console.WriteLine("-------------------------------------------");
        Console.ResetColor();

        // Características do Personagem 2
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Veja características do PL 2: ");
        Console.WriteLine($"Nome do player 2: {player2.nome}");
        Console.WriteLine($"Idade do player 2: {player2.idade}");
        Console.WriteLine($"Armadura do player 2: {player2.armadura}");
        Console.ResetColor();
        
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Partida: {player1.nome} VS {player2.nome} ");
        Console.WriteLine($"Armadura do PL1: {player1.armadura} || Armadura do PL 2: {player2.armadura} ");
        Console.WriteLine($"IA do PL 1: {player1.iA} || IA do PL 2: {player2.iA} ");
        Console.ResetColor();

        // Iniciando combate entre os players
        Console.ForegroundColor = ConsoleColor.Blue;
        int lifeOfPlayer2 = player2.Defender(player2.Atacar1());

        if (lifeOfPlayer2 <= 0){
            Console.WriteLine($"Infelizmente o Player 2 morreu!");
        }else{
            Console.WriteLine($"O player 2 após ataque, ficou com {player2.life}");
        }
        Console.ResetColor();
        } // fim de Main
    }
}
