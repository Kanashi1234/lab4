using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        Dictionary<string, int> players = new Dictionary<string, int>();


        Console.WriteLine("Введiть iм'я гравця та його бали через пробiл (наприклад, 'Гравець1 100'):");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Гравець {i + 1}: ");
            string[] input = Console.ReadLine().Split(' ');
            if (input.Length == 2 && int.TryParse(input[1], out int score))
            {
                players[input[0]] = score;
            }
            else
            {
                Console.WriteLine("Неправильний формат вводу. Спробуйте ще раз.");
                i--;
            }
        }


        var topPlayers = players.OrderByDescending(pair => pair.Value).Take(3);


        Console.WriteLine("\nТоп 3 гравцi за сумою балiв:");
        foreach (var player in topPlayers)
        {
            Console.WriteLine($"{player.Key}: {player.Value} балiв");
        }
    }
}
