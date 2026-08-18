/*string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
*/

/*

string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

*/


string[] name = ["Tahid", "Tariq", "Tarique"];

foreach (string n in name)

{
    Console.WriteLine(n);
}



int[] inventory = [1,4,5,6,9,10,8,7,6,5,4];
int total = 0;
int bin = 0;
foreach (int i in inventory)

{
    total += i;
    bin++;
}

Console.WriteLine($"Total: {total} and Bin: {bin}");