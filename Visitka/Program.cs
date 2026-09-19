//Визитка студента
Console.WriteLine("  ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА");
string name = "Пономарева Анастасия Андреевна";
string group = "ИСП252";
int course = 2;
string speciality = "09.02.07";
double middlemark = 4.5;
int weekafter = 3; // недель после каникул
const int weeks = 17; // принимаем количество недель за константу, потому что оно не меняется
bool bigger = middlemark >= 4;
Console.WriteLine($"ФИО: {name}");
Console.WriteLine($"Группа: {group}");
Console.WriteLine($"Курс: {course}");
Console.WriteLine($"Специальность: {speciality}");
Console.WriteLine("\n");
Console.WriteLine($"Средний балл >= 4: {bigger}");
Console.WriteLine($"Учебных недель осталось в семестре: {weeks - weekafter}"); // вычисляем количество оставшихся недель