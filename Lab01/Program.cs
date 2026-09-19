string myName = "Анастасия";
string groupName = "ИСП-252";
int courseNumber = 2;
double averageGrade = 4.5;
bool isBudget = false;
Console.WriteLine("Знакомство");
Console.WriteLine($"Студент: {myName}");
Console.WriteLine($"Группа: {groupName}");
Console.WriteLine($"Курс: {courseNumber}");
Console.WriteLine($"Средний балл: {averageGrade}");
Console.WriteLine($"Бюджетное место: {isBudget}");

// считаем размеры комнаты
Console.WriteLine();
Console.WriteLine("Ремонт: комната");
double roomWidth = 3.5;
double roomLength = 4.2;
double roomArea = roomWidth * roomLength;
double roomPerimeter = (roomWidth + roomLength) * 2;
Console.WriteLine($"Ширина: {roomWidth} м, длина: {roomLength} м");
Console.WriteLine($"Площадь: {roomArea} кв.м");
Console.WriteLine($"Периметр: {roomPerimeter} м");

//считаем стоимость покупки ноутбука
Console.WriteLine();
Console.WriteLine("Покупка ноутбука в рассрочку");
int laptopPrice = 6500;
int monthsCount = 12;
double interestRate = 0.08;
double totalWithInterest = laptopPrice * (1 + interestRate);
double monthlyPayment = totalWithInterest / monthsCount;
Console.WriteLine($"Цена ноутбука: {laptopPrice} py6.");
Console.WriteLine($"Итого с процентами: {totalWithInterest} руб.");
Console.WriteLine($"Платёж в месяц: {monthlyPayment} руб.");


Console.WriteLine();
Console.WriteLine("Внимание: деление int");
int totalStudents = 25;
int groupsCount = 4;
int studentsPerGroupWrong = totalStudents / groupsCount;
double studentsPerGroupCorrect = (double)totalStudents / groupsCount;
Console.WriteLine($"25 / 4 как int: {studentsPerGroupWrong}");
Console.WriteLine($"25 / 4 как double: {studentsPerGroupCorrect}");

//методы сбора строк
Console.WriteLine();
Console.WriteLine("Способы собрать строку");
string firstName = "Анастасия";
string lastName = "Пономарева";
// Способ 1: конкатенация через оператор +
string fullNameConcat = firstName + " " + lastName;
// Способ 2: интерполяция через $""
string fullNameInterp = $"{firstName} {lastName}";
// Способ 3: метод string.Concat
string fullNameConcatMethod = string.Concat(firstName, " ", lastName);
Console.WriteLine(fullNameConcat);
Console.WriteLine(fullNameInterp);
Console.WriteLine(fullNameConcatMethod);
Console.WriteLine($"Все три строки равны: {fullNameConcat == fullNameInterp && fullNameInterp == fullNameConcatMethod}");


/*
 Константы (const) в C# нужны, 
 чтобы хранить значения, 
 которые не должны меняться 
 в течение работы программы
*/
Console.WriteLine();
Console.WriteLine("Константы");
const double VatRate = 0.20;
const string CollegeName = "BФ ВолГУ";
double productPrice = 1000;
double priceWithVat = productPrice * (1 + VatRate);
Console.WriteLine($"Учебное заведение: {CollegeName}");
Console.WriteLine($"Цена без НДС: {productPrice}, c HДC ({VatRate:P0}):{priceWithVat}");


