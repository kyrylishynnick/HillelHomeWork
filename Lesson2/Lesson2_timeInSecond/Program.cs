int hour = 11;
int minutes = 45;
int seconds = 51;

int hourInSecond = hour * 3600;
int minsInSecond = minutes * 60;

int result = seconds + hourInSecond + minsInSecond;

Console.WriteLine(result + " seconds");