/*
Задание 5. Реализация собственного перечислителя с использованием IEnumerable 
Создайте класс Team, содержащий коллекцию игроков в виде списка строк (List<string>).
Реализуйте интерфейс IEnumerable<string>, чтобы можно было итерировать по игрокам в команде.
Напишите цикл, который будет выводить имена всех игроков с использованием foreach. 
*/


using System.Collections;

public class Team : IEnumerable<string>
{
    List<string> players = new List<string>();

    public void AddPlayer(string player)
    {
        players.Add(player);
    }

    public IEnumerator<string> GetEnumerator()
    {
        return players.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Team team = new Team();
        team.AddPlayer("Marcelo");
        team.AddPlayer("Ronaldo");
        team.AddPlayer("Messi");

        foreach (var player in team)
        {
            Console.WriteLine($"Name: {player}");
        }
    }
}