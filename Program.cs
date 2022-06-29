int randomNumber = new Random().Next(100, 999);
int firstDigit = randomNumber / 100;
int secondDigit = randomNumber / 10;
int needDigit = secondDigit - (firstDigit * 10);
Console.WriteLine($"{randomNumber} - {needDigit}");