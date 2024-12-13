public class ClassRoom //Класс учебного класса
{
    private Pupil[] pupils;
    public ClassRoom(params Pupil[] pupils) //Конструктор с использованием params для произвольного количества учеников
    { 
        this.pupils = pupils;
    }

    //Вывод информации об учениках
    public void ShowPupils()
    {
        Console.WriteLine("Информация об учениках: ");
        for (int i = 0; i < pupils.Length; i++)
        {
            Console.WriteLine($"Ученик {i+1}:");
            pupils[i].Study();
            pupils[i].Read();
            pupils[i].Write();
            pupils[i].Relax();
        }
    }
}

//Базовый класс ученика
public class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Ученик учится ");
    }

    public virtual void Read()
    {
        Console.WriteLine("Ученик читает ");
    }

    public virtual void Write()
    {
        Console.WriteLine("Ученик пишет ");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Ученик отдыхает ");
    }
}

public class ExcelentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Отличник учится отлично");
    }

    public override void Read()
    {
        Console.WriteLine("Отличник читает отлично");
    }

    public override void Write()
    {
        Console.WriteLine("Отличник пишет отлично");
    }

    public override void Relax()
    {
        Console.WriteLine("Отличник отдыхает отлично");
    }
}

public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Хороший ученик учится хорошо");
    }

    public override void Read()
    {
        Console.WriteLine("Хороший ученик читает хорошо");
    }

    public override void Write()
    {
        Console.WriteLine("Хороший ученик пишет хорошо");
    }

    public override void Relax()
    {
        Console.WriteLine("Хороший ученик отдыхает хорошо");
    }
}

public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Плохой ученик учится плохо");
    }

    public override void Read()
    {
        Console.WriteLine("Плохой ученик читает плохо");
    }

    public override void Write()
    {
        Console.WriteLine("Плохой ученик пишет плохо");
    }

    public override void Relax()
    {
        Console.WriteLine("Плохой ученик отдыхает очень хорошо");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pupil pupil1 = new Pupil();
        Pupil pupil2 = new ExcelentPupil();
        Pupil pupil3 = new GoodPupil();
        Pupil pupil4 = new BadPupil();

        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classRoom.ShowPupils();
    }
}