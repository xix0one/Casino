using Casino;

Random random = new Random();
double odds = 0.75;
Player player = new Player() { Name = "The player", Cash = 100 };

Console.WriteLine($"Welcome to the casino. The odds are {odds}");


while (player.Cash > 0)
{
    player.WriteMyInfo();

    Console.Write("How much do you want to bet: ");
    string howMuch = Console.ReadLine();

    if (int.TryParse(howMuch, out int amount))
    {
        if (amount > player.Cash)
            Console.WriteLine("nope");
        else
        { 
            int pot = amount * 2;
            if (random.Next(0, 2) > odds)
            {
                player.ReceiveCash(pot);
                Console.WriteLine("You win " + pot);
            }
            else
            {
                player.GiveCash(amount);
                Console.WriteLine("Bad luck, you lose");
            }
        }
    }
    else Console.WriteLine("nope!");
}
Console.WriteLine("The house always win.");