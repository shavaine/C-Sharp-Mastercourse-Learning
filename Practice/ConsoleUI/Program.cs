// Capture the information about each guest (assumption is at least one guest and unknow maximum)
// Info to capture: First name, last name, message to the host
// Once done, loop through each guest and print their info

using ConsoleUI;
using GuessBookLibrary.Models;

List<GuestModel> guests = new();

RequestData.GetGuestInformation(guests);

ConsoleMessages.PrintGuestInformation(guests);

Console.ReadLine();