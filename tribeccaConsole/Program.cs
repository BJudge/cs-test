// See https://aka.ms/new-console-template for more information
using tribeca;

Console.WriteLine("What is your first name?");
var firstName = Console.ReadLine();

Console.WriteLine("What is your surname?");
var lastName = Console.ReadLine();

Console.WriteLine("What is your date of birth: yyyy-mm-dd?");
var dateOfBirth = Console.ReadLine();


var person = new tribeca.Person();
person.Name = firstName;
person.Surname = lastName;
person.DateOfBirth = Convert.ToDateTime(dateOfBirth);

Console.WriteLine($"You are {person.Age} years old.");
Console.WriteLine($"You are {person.GetStarSign()}");
Console.WriteLine($"Using reflection, your name is {Utilities.GetPersonName(person)}");


