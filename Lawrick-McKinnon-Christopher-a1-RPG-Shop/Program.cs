


// Get the player's Name

Console.WriteLine("Who be you, traveller?: ");
string playerName = Console.ReadLine();

// Get the player's Gold

Console.WriteLine("How much gold do you have traveller?: ");
int playerGold = int.Parse(Console.ReadLine());

int bronzeSwordCost = 15;


Console.WriteLine($"You, {playerName}, have reached a blacksmith's shop. You have the option to buy a Bronze Sword for {bronzeSwordCost} coins. Do you want to buy it? YES or NO? ");

// Check player's response
string playerResponse = Console.ReadLine().ToUpper();


// Check balance/purchase
if (playerResponse == "YES")
{
    if (playerGold >= bronzeSwordCost)
    {
        // Buy sword
        playerGold -= bronzeSwordCost;
        Console.WriteLine($"You, {playerName}, have bought a bronze sword for ${bronzeSwordCost} coins, leaving you at {playerGold} coins!");
    }
    else
    {
        // Player is broke
        Console.WriteLine($"You, {playerName}, do not have enough coins to buy a Bronze Sword. You need {bronzeSwordCost - playerGold} more coins!");
    }
} else if (playerResponse == "NO")
{
    Console.WriteLine($"You, {playerName}, avoid the shop and move on.");
} else {

    // Handle invalid input
    Console.WriteLine($"You, {playerName}, have put an invalid response!");
}

