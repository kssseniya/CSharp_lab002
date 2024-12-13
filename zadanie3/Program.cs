public class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
    }
}

// Профессиональная версия DocumentWorker
public class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
    }
}

// Экспертная версия DocumentWorker
public class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите ключ доступа (pro/exp): ");
        string key = Console.ReadLine();

        DocumentWorker documentWorker;

        if (key == "pro") documentWorker = new ProDocumentWorker();
        else if (key == "exp") documentWorker = new ExpertDocumentWorker();
        else documentWorker = new DocumentWorker();

        documentWorker.OpenDocument();
        documentWorker.EditDocument();
        documentWorker.SaveDocument();
    }
}