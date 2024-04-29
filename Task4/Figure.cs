namespace Task4;
using System;


/*
 * Клас Figure повинен містити конструктори, які приймають від 3 до 5 аргументів типу Point.

   Створити два методи:
   double LengthSide(Point A, Point B), що розраховує довжину сторони багатокутника;
   void PerimeterCalculator(), що розраховує периметр багатокутника.
 */
public class Figure
{
    private Point[] points;
    

    public Figure(Point A, Point B, Point C)
    {
        points = new Point[] { A, B, C };
    }

    public Figure(Point A, Point B, Point C, Point D)
    {
        pionts = new Point[]{A, B, C, D};
    }
	public Figure(Point A, Point B, Point C, Point D, Point F)
    {
        pionts = new Point[]{A, B, C, D, F};
    }

    // Метод розрахунку довжини сторони
	public double LengthSide(Point A, Point B)
	{
		return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y -A.Y), 2));
	}

    // Метод розрахунку периметру
	public  void PerimeterCalculator()
	{ 
		doublie perimeter = 0;
		for (int i = 0; i < points.Length - 1; i++)
		{
			perimeter += LengthSide(points[i], points[i + 1]);
		}

		perimeter += LengthSide(points[points.Length - 1], points[0]);// Додаємо останню сторону
		Console.WriteLine($"Perimeter of the figure: {perimeter}");
	}
	
}