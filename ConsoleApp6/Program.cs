using ConsoleApp6;


Teacher teacher1 = new Teacher(Guid.NewGuid(), "Cinare", "Gulizade", new DateOnly(1987, 11, 2), 5000, "Ingilis dili");
Teacher teacher2 = new Teacher(Guid.NewGuid(), "Huseyn", "Victor", new DateOnly(1982, 10, 5), 3000, "Rus dili");


Security security1 = new Security(Guid.NewGuid(), "Ekber", "Ekberli", new DateOnly(1800, 10, 1), 300, "Makar");
Security security2 = new Security(Guid.NewGuid(), "Cingiz", "Xan", new DateOnly(1500, 10, 1), 110, "Nize");


Police police1 = new Police(Guid.NewGuid(), "Elnur", "Memmedov", new DateOnly(1200, 11, 1), 200, Rank.Kapitan);
Police police2 = new Police(Guid.NewGuid(), "Kifayet", "Qelenderli", new DateOnly(1400, 11, 1), 200, Rank.Leytnant);






List<Worker> workers = new List<Worker>();
workers.Add(teacher1);
workers.Add(teacher2);
workers.Add(security1);
workers.Add(security2);
workers.Add(police1);
workers.Add(police2);



//foreach (Worker worker in workers)
//{
//    Console.WriteLine();
//    Console.WriteLine(worker);
//}



foreach (Worker worker in workers)
{
    worker.Work();
}