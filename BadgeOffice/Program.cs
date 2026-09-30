Console.Write("What is your first and last name? ");
string rawname = Console.ReadLine();
rawname = rawname.Trim();
rawname = rawname.ToUpper();
int spacePosition = rawname.IndexOf(" ");
string firstName = rawname.Substring(0, spacePosition);
string lastName = rawname.Substring(spacePosition + 1);

string username = firstName.Substring(0, 1) + lastName ;
string lowername = username.ToLower();

string Letters = firstName.Substring(0, 1);
string Letter = lastName.Substring(0, 1);

int lastlamelength = lastName.Length;
Console.WriteLine($"Name On Badge : {rawname}");
Console.WriteLine($"Username: {lowername} ");
Console.WriteLine($"Initials : {Letters}.{Letter}.");
Console.WriteLine($"Letters In Last Name : {lastlamelength}");