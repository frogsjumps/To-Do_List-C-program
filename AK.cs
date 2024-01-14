using System.Security.Cryptography;

int userTaskInput;
string tasks; 
int taskErase;
int number01 = 1;
int number02 = 1;
int userInput;

Console.WriteLine("Press 1 if you would like to access the to do list!");
userInput = Convert.ToInt32(Console.ReadLine());

if (userInput == 1)
{
    Console.WriteLine("How many tasks would you like to complete?");
userTaskInput = Convert.ToInt32(Console.ReadLine());

Console.Clear();

List<string> taskName = new List<string>();

for (int i = 0; i < userTaskInput; i++)
{
    Console.Write("Enter Task:");
    tasks = Console.ReadLine();
    taskName.Add(tasks);
}
Console.Clear();

for (int i = 0; i < taskName.Count; i++)
{
    Console.WriteLine(number01 + "." + taskName[i]);
    number01++;
}

while (taskName.Count != 0)
{
    Console.WriteLine("\nPlease enter the number of the task you are done with to erase it off the board.");
    taskErase = Convert.ToInt32(Console.ReadLine())-1;
    taskName.RemoveAt(taskErase);
    Console.Clear();
    for (int i = 0; i < taskName.Count; i++)
{
    Console.WriteLine(number02 + "." + taskName[i]);
    number02++;
}
}

if (taskName.Count <= 0)
{
    Console.Clear();
    Console.WriteLine("Congrats you finished all your work!");
}

} else 
{
    Console.WriteLine("Come back when you have more tasks! Enjoy the rest of your day.");
}



Console.ReadKey();
