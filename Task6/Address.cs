namespace Task6;

/*
 * У тілі класу потрібно створити поля: index, country, city, street, house, apartment.
   Для кожного поля створити властивість з двома методами доступу. 
   Створити екземпляр класу Address. 
   У поля екземпляра записати інформацію про поштову адресу. 
   Виведіть на екран значення полів, що описують адресу.
 */
public class Address
{
    private string index { get; set; }
    private string country{ get; set; }
    private string city { get; set; }
    private string street { get; set; }
    private string house { get; set; }
    private string appartment{ get; set; }

    public Address(string index, string country, string city, string street, string house, string appartment)
    {
        this.index = index;
        this.country = country;
        this.city = city;
        this.street = street;
        this.house = house;
        this.appartment = appartment;
    }

    public void ShowAdress()
    {
        Console.WriteLine($"\nYour address is: \n{index}, {country}, \n{city}, \n{street}, {house} / {appartment}");
    }


}