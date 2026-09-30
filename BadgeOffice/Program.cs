// Part 1
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
Console.WriteLine($"Initials: {Letters}.{Letter}.");
Console.WriteLine($"Letters In Last Name: {lastlamelength}");
System.Console.WriteLine("");
// Part 2
Random rng = new Random();
int studentid = rng.Next(100000, 1000000);
int Locker = rng.Next(1,500);

Console.WriteLine($"Student ID: {studentid}");
Console.WriteLine($"Locker: {Locker}");
System.Console.WriteLine("");
// part 3
Console.Write("The Dorm's X coridnate: ");
double dormx = Convert.ToDouble(Console.ReadLine());
Console.Write("The Dorm's Y coridnate: ");
double dormy = Convert.ToDouble(Console.ReadLine());
Console.Write("The Classrooms X coridnates: ");
double classx = Convert.ToDouble(Console.ReadLine());
Console.Write("The Classrooms Y coridnate: ");
double classy = Convert.ToDouble(Console.ReadLine());
Console.Write("Walking Speed In Feet Per Second: ");
double walkspeed = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("");
Math.Sqrt(Math.Pow(dormx - classx,2) + Math.Pow(dormy - classy, 2));
double distance = Math.Sqrt(Math.Pow(dormx - classx,2) + Math.Pow(dormy - classy, 2));
System.Console.WriteLine($"Distance: {distance:F1} Feet");
int totalseconds = (int)Math.Round(distance / walkspeed);
int minitues = totalseconds / 60;
int seconds = totalseconds % 60;
System.Console.WriteLine($"Estimated walking time {minitues} Minutes and {seconds} seconds");
System.Console.WriteLine("");

Console.WriteLine("WALK: {minitues} min {seconds} sec".PadLeft(10));
// The Badge
Console.WriteLine("==================================");
Console.WriteLine("        ETSU STUDENT BADGE        ");
Console.WriteLine("==================================");
Console.WriteLine("NAME" + rawname.ToString().PadLeft(6));
Console.WriteLine("USERNAME"+ lowername.ToString().PadLeft(2));
Console.WriteLine("ID" + studentid.ToString().PadLeft(8));
double id = studentid / 9;
Console.WriteLine("LOCKER" + Locker.ToString().PadLeft(4));
Console.WriteLine($"WALK" {minitues} "min" {seconds} "sec".PadLeft(10));
Console.WriteLine("==================================");