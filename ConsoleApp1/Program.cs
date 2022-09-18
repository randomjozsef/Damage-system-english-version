// See https://aka.ms/new-console-template for more information
Random r = new Random();
int hp = r.Next(1, 200);
while (true)
{
    Console.Write("The monster's HP " + hp + "\nHow much do you damage?: ");
    int damage = int.Parse(Console.ReadLine());
    hp -= damage;
    if (hp <= 0) break;
    else continue;
}
Console.WriteLine("You defeated the monster!");
Console.ReadKey(); ;
