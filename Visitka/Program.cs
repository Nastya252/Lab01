//Визитка студента
Console.WriteLine("  ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА");
Console.Write("Введите ваше ФИО: ");
string name = Console.ReadLine();
Console.Write("Введите вашу группу: ");
string group = Console.ReadLine();
Console.Write("Введите ваш курс: ");
string course = Console.ReadLine();
int coursse = int.Parse(course);
Console.Write("Введите вашу специальность: ");
string speciality = Console.ReadLine();
Console.Write("Введите ваш средний балл: ");
string middlemark = Console.ReadLine();
bool bigger = double.TryParse(middlemark, out double middle);
Console.Write("Сколько недель прошло с начала учебы: ");
string weekafter = Console.ReadLine();
int weeksafter = int.Parse(weekafter);
const int weeks = 17;

Console.WriteLine($"ФИО: {name}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Курс: {coursse}");
Console.WriteLine($"Специальность: {speciality}");
Console.WriteLine("\n");
Console.WriteLine($"Средний балл >= 4: {bigger}");
Console.WriteLine($"Учебных недель осталось в семестре: {weeks - weeksafter}");