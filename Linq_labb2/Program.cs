using Linq_labb2.Data;
using Linq_labb2.Models;
using System;
using System.Linq;

namespace Linq_labb2
{
    class Program
    {
        static void Main(string[] args)
        {
            using SkolanEFDBContext Context = new SkolanEFDBContext();

            bool go = true;
            while (go)
            {
                Console.WriteLine("Välj från menyn:");
                Console.WriteLine("\n\t[1] Hämta läraren som undervisar matte\n" +
                   "\t[2] Hämta elever med sina lärare\n" +
                   "\t[3] Se om subjects innehåller Programmering 2\n" +
                   "\t[4] Ändra subject från Programmering 2 till OOP\n" +
                   "\t[5] Uppdatera en student med lärare Anas och Reidar\n" +
                   "\t[6] Avsluta");
                Console.Write("Menyval: ");
                int choices;
                int.TryParse(Console.ReadLine(), out choices);
                switch (choices)
                {
                    case 1:
                        var QJoin = (from tsb in Context.TeacherSubjects
                                     join te in Context.teachers
                                     on tsb.TeacherID equals te.TeacherID
                                     join sub in Context.subjects
                                     on tsb.SubjectID equals sub.SubjectID
                                     where tsb.SubjectID == 6
                                     select new
                                     {
                                         Teach = te.TeacherName
                                     }).ToList();

                        Console.WriteLine("Lärare med matte som ämne:");
                        foreach (var t in QJoin)
                        {
                            Console.WriteLine(t.Teach);
                        }
                        break;

                    case 2:
                        var TS = (from ts in Context.TeacherStudents
                                  join te in Context.teachers
                                  on ts.TeacherID equals te.TeacherID
                                  join stud in Context.students
                                  on ts.StudentID equals stud.StudentID
                                  select new
                                  {
                                      Tea = te.TeacherName,
                                      Stud = stud.StudentName
                                  }).ToList();

                        Console.WriteLine("Lärare och deras studenter:");
                        foreach (var item in TS)
                        {
                            Console.WriteLine(item.Stud + " - " + item.Tea);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Skriv om Programmering 1 finns:");
                        string prog = Console.ReadLine();
                        if (prog == "Programmering 1")
                        {
                            var subj = from subjects in Context.subjects
                                       where subjects.SubjectName == prog
                                       select subjects;

                            Console.WriteLine(prog + " existerar.");
                        }
                        else if (prog != "Programmering 1")
                        {
                            Console.WriteLine("Existerar ej.");
                        }
                        break;

                    case 4:
                        Console.Write("Lägg till ny kurs istället för Programmering 2: ");
                        string course = Console.ReadLine();
                        var prog2 = Context.subjects
                            .Where(s => s.SubjectID == 2)
                            .FirstOrDefault();
                        if (prog2 is Subject)
                        {
                            prog2.SubjectName = course;
                        }
                        Context.SaveChanges();
                        Console.WriteLine("Klart, vänligen se databasen.");
                        break;

                    case 5:
                        var anas = Context.TeacherStudents
                            .Where(a => a.TeacherID == 1)
                            .FirstOrDefault();
                        if (anas is TeacherStudent)
                        {
                            anas.TeacherID = 3;
                        }
                        Context.SaveChanges();
                        Console.WriteLine("Uppdaterar Cruella de Vil med lärare från Anas till Reidar...");
                        break;
                    case 6:
                        Console.WriteLine("Hejdå!");
                        go = false;
                        break;
                    default:
                        Console.WriteLine("Vänligen välj mellan menyvalen 1-6.");
                        break;
                }
            }
        }
    }
}
