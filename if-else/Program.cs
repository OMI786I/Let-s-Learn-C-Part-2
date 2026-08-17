Random dice = new ();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"initial total: {total} \n,{roll1}, {roll2}, {roll3}");





//"If any two dice you roll result in the same value, you get two bonus points for rolling doubles"


if (roll1 == roll2 || roll2 == roll3 || roll3 == roll1)
{   
   
    Console.WriteLine("you rolled double +2 bonus to total");
    total += 2;

}



//"If all three dice you roll result in the same value, you get six bonus points for rolling triples."


if (roll1 == roll2 && roll2 == roll3)
{
    total +=6;
    Console.WriteLine("You just hit the jackpot bro +6 to total");

}

Console.WriteLine($"total final:{total}");


if (total >= 18)
{
    Console.WriteLine("You win bro");
}

if (total < 18)
{
    Console.WriteLine("You are a minor bro");
}