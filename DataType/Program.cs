

//Console.WriteLine("Zmienne i typy danych");
//byte byteVariable = 50;
//int integralVariable = 300;
//long longVariable = 100000000;
//char charVariable1 = (char)87;
//char charVariable2 = 'a';
//double doubleVariable = 50.0005;
//float doubleVariable1 = 50e10F;
//string stringVariable = "How you doing?";


// tutaj wpisz rozwiązanie 
//Console.WriteLine(byteVariable);
//Console.WriteLine(integralVariable);
//Console.WriteLine(longVariable);
//Console.WriteLine(charVariable1);
//Console.WriteLine(charVariable2);
//Console.WriteLine(doubleVariable);
//Console.WriteLine(doubleVariable1);
//Console.WriteLine(stringVariable);




/* koniec zadania 1 */





/* zadanie 2 */

//int num = 2147483647;
//long bigNum = 88888888888;
//string stringNum = "1024";

// zadeklaruj zmienną typu long i przypisz do niej zmienną num
//long longValue = num;
//Console.WriteLine(bigNum);
// zadeklaruj zmienną typu int i przypisz do niej zmienną bigNum
//int integerValue = (int)bigNum;
//Console.WriteLine(bigNum);
//Console.WriteLine(integerValue);
// zadeklaruj zmienną typu int i przypisz do niej zmienną stringNum (zastosuj Parse)
//int intFromString = int.Parse(stringNum);
//Console.WriteLine(intFromString);
// zbadaj zachowanie programu


/*koniec zdania 2*/


/* zadanie 3 */

//using System.ComponentModel.DataAnnotations;
//using System.Data;

//int a = 18;
//int b = 6;
//decimal price = 10.56m;
//double doubleVal = 10.56;
//double radius = 5.0;
//double time = 1234.45;
//int c;
//int d;
//int e;
//int f;
//int g;
// wypisz na ekran c,d,e,f,g
//Console.WriteLine(c);
//Console.WriteLine(d);
//Console.WriteLine(e);
//Console.WriteLine(f);
//Console.WriteLine(g);
//int h = (int)price;
//int i = (int)doubleVal;
// zadeklaruj zmienną c, do której przypisz wynik dodawania a i b 
//c = a + b;
// zadeklaruj zmienną d, do której przypisz wynik odejmowania a i b 
//d = a - b;
//zadeklaruj zmienną e, do której przypisz wynik mnożenia a i b 
//e = a * b;
// zadeklaruj zmienną f, do której przypisz wynik dzielenia a i b 
//f = a / b;
// zadeklaruj zmienną g, do której przypisz wynik reszty z dzielenia a i b 
//g = a % b;
// wypisz na ekran wynik zmiennej price pomnożonej przez samą siebie
//price = h * h;
// wypisz na ekran wynik zmiennej doubleVal pomnożonej przez samą siebie
//doubleVal = i * i;
// zastanów się skąd się bieże różnica
//Console.WriteLine(price * price);
//Console.WriteLine(doubleVal* doubleVal);
// wypisz na ekran wynik pola koła o promieniu równym radius
//Console.WriteLine(radius * radius);
// W zmiennej time znajduje się czas w minutach. Oblicz wartości zmiennych hours, minutes i seconds na postawie zmiennej time
//Console.WriteLine("czas w min : " + time);
//Console.WriteLine("czas w hours :" + time * 60);
//Console.WriteLine("czas w sekundach: " + time * 3600);

/* koniec zadania 3 */




/* zadanie 4 */


//int toIncrement = 3;
//int toDivide = 5;

// wstaw do zmiennej toIncrement jej obecną wartość powiększoną o jeden (nie używając żadnej cyfry)
//toIncrement++;
//Console.WriteLine(toIncrement);
// wstaw do zmiennej toDivide jej obecną wartość podzieloną o nią samą (nie używając żadnej cyfry)
//toDivide /= toIncrement;
//Console.WriteLine(toDivide);


/* koniec zadania 4 */

/* zadanie 5 */
//double degree = 45;
//double sinValue;
// do zmiennej sinValue przypisz wartość funkcji sinus dla zmiennej degree wyrażonej w stopniach
//sinValue = Math.Sin(degree);



/* koniec zadania 5 */

/* zadanie 6 */
int year = 2024;
int month = 5;
int day = 3;
int hour = 23;
int minute = 30;
// stwórz zmienną typu DateTime jako wartość złożoną z powyższych składowych
DateTime dt = new DateTime(year, month, day, hour, minute, 0);
// następnie dodaj do niej 3 miesiące, odejmij 1 godzinę

// wypisz na ekran nazwę dnia tygodnia jaki przypada tego dnia

/* koniec zadania 6 */