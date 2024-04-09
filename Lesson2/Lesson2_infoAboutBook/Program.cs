string nameOfBook = "Dune";
string author = "Frank Herbert";
int dateOfpublished = 1965;
int price = 350;

string message = string.Format("The name of book = {3}, author of book = {2}, was published = {1}, price of book = {0}", price, dateOfpublished,author,nameOfBook);
Console.WriteLine(message);