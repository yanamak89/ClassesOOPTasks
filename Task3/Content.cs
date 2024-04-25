namespace Task3;

/*
 * Потрібно: Створити клас Book. 
   Створити класи Title, Author та Content, 
   кожен з яких повинен містити одне рядкове поле та метод void Show(). 
   Реалізуйте можливість додавання до книги назви книги, імені автора та змісту.
   Виведіть на екран різними кольорами за допомогою методу Show() назву книги, ім'я автора та зміст.
 */
public class Content
{
    public string Text { get; set; }
    
    public void Show()
    {
        Console.WriteLine($"Content {Text}");
    }
}
