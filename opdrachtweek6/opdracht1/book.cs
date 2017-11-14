namespace week06{


public class Book
{
private string name;
private Author author;
private double price;
private int qtyInStock = 0;

public Book(string name, Author author, double price, int qtyInStock)
{
        this.name = name;
        this.author = author;
        this.price = price;
}


public void print()
{
        Console.WriteLine("Book: {0} - {1} - {2}", this.name, this.price, this.author)
}
public int getPrice()
{
        return this.price;
}
}
}