using MiniProjectGuestList;

/* Build a Console Guest Book. Ask the user for their name and how many are in their party. 
 * Keep track of how many people are at the party. 
 * At the end, print out the guest list and the total number of guest.
 */

Console.WriteLine("Welcome to the Party!");
 
var guestList = Party.GetTotalGuests();

Party.PrintGuestList(guestList);