using HomeworkMethods;

/* Create a welcome method, a method to ask for the user's name, and another to tell that user "Hello <name>".
 * Call these methods from Program.cs.*/

Messages.Welcome();
string username = Messages.GetUsername();

Messages.GreetUser(username);
