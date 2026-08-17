Random dice = new ();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine(total);

if (total >= 18)
{
    Console.WriteLine("You win bro");
}

if (total < 18)
{
    Console.WriteLine("You are a minor bro");
}
