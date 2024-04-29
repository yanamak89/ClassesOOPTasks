namespace Task4;
using System;


/*
 * Клас Point повинен містити два цілих поля і одне рядкове поле.
 * Створити три властивості одним методом доступу get.
 *
 * Створити власний конструктор, у тілі якого проініціалізуйте поля значеннями аргументів. 
 */

public class Point
{
    private int x;
    private int y;
    private string name;

    public int X { get; set; }
    public int Y { get; set; }
    public string Name { get { return name } }



    public Point(int x, int y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }
}