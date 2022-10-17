using System;

DateModifier dateModifier = new DateModifier();

dateModifier.Print();

class DateModifier
{
    public DateTime d1 = new DateTime(2016, 05, 31);
    public DateTime d2 = new DateTime(2016, 04, 19);

    public DateModifier() { }

    public void Print()
    {
        Console.Write("Date Modifier: ");
        Console.WriteLine((d1.Date - d2.Date).TotalDays);
    }

}