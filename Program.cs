//Задание 1. 
//Создайте класс Пьеса. Класс должен хранить такую информацию:
//- название пьесы;
//- ФИО автора;
//- жанр;
//- год выпуска.
//Реализуйте в классе методы и свойства, необходымые для функционирования класса.
//Добавьте в классе деструктор. Напишите код для тестирования функциональности класса.
//Напишите код для вызова деструктора.
//Добавьте реализацию интерфейса IDisposable

Info();
GC.Collect();
Console.Read();
void Info()
{
    Piece piece1 = new Piece("Наталка Полтавка", "Котляревский Иван Петрович", "социально-бытовая драма", 1819);
    Piece piece2 = new Piece("Мазепа", "Байрон Джордж Гордон ", "поэма", 1818);
    Piece piece3 = new Piece("Батерфляй", "Беласко Дэвид ", "драма", 1904);
    Piece piece = new Piece("За двумя зайцами", "Старицкий Михаил Петрович", "поэма", 1883);

    DoAction1(piece1);
    DoAction2(piece2);
    DoAction3(piece3);
    DoAction4(piece);
    DoAction5(piece1);
    DoAction6(piece2);
    DoAction7(piece3);

    void DoAction1(IDisposable disposable) => disposable.Start();
    void DoAction2(IDisposable disposable) => disposable.End();
    void DoAction3(IDisposable disposable) => disposable.Stop();
    Console.WriteLine();
    void DoAction4(IPieceInfo piece) => Console.WriteLine(piece.GetInfo());
    void DoAction5(IPieceInfo piece1) => Console.WriteLine(piece1.GetInfo());
    void DoAction6(IPieceInfo piece2) => Console.WriteLine(piece2.GetInfo());
    void DoAction7(IPieceInfo piece3) => Console.WriteLine(piece3.GetInfo());

}


