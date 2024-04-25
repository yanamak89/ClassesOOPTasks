namespace Task3;

/*
 * Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
   
   Потрібно: Створити клас Book. 
   Створити класи Title, Author та Content, 
   кожен з яких повинен містити одне рядкове поле та метод void Show(). 
   Реалізуйте можливість додавання до книги назви книги, імені автора та змісту.
   Виведіть на екран різними кольорами за допомогою методу Show() назву книги, ім'я автора та зміст.
 */
public class Book
{
    private Title title;
    private Author author;
    private Content content;

    public Book()
    {
        title = new Title();
        author = new Author();
        content = new Content();
       
    }

    public void SetTitle(string text)
    {
        title.Text = text;
    }
    
    
    public void SetAuthor(string text)
    {
        author.Text = text;
    }
    
    public void SetContent(string text)
    {
        content.Text = text;
    }

    public void Show()
    {
        title.Show();
        author.Show();
        content.Show();
    }


}