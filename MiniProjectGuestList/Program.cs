using MiniProjectGuestList;

/* Build a Console Guest Book. Ask the user for their name and how many are in their party. 
 * Keep track of how many people are at the party. 
 * At the end, print out the guest list and the total number of guest.
 */

Dictionary<string, int> guestList = new Dictionary<string, int>();
bool running = true;

do
{
    Console.WriteLine("Welcome to the Party!");

    // Gets the name and amount of people in guest's party
    (string name, int people) = Party.GetNameAndAmount();

    // Added the guest and people amount to Guest List
    guestList.Add(name, people);

    // Asks if there are anymore Guest and exit loop if there aren't any
    running = Party.CheckForGuest();

} while (running);

Party.PrintGuestList(guestList);