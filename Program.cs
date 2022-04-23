using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Peoples peoples = new Peoples();                      
            People people = new People();
            people.fio = "Ivanov Ivan";
            people.telephone = "795107869";
            
            peoples.peoples.Add(people);
           
            People people2 = new People("Ivanov Ivan 2", "895480274");
            //people2.fio = ;
            //people2.telephone = "795107869";
            peoples.peoples.Add(people2);
            


            people = new People("Petrov Petr", "7964920", "petrov@mail.ru");
            //people.fio = "Petrov Petr";
            //people.telephone = "7964920";
            peoples.peoples.Add(people);
            //people.Display();

            People wrkt = new WorkerPeople();
            wrkt.fio = "Sergeev Sergey";
            wrkt.telephone = "795372910";



            WorkerPeople wrk = new WorkerPeople ( "Sergeev Sergey", "795372910",  "sergeev@mail.ru", "police",  "policeman"); //восходящее преобразование
            
            (wrk as WorkerPeople).position = "1123";

            People Wrk = new WorkerPeople { 
                             fio = "Alexandrov Alexandr", 
                             telephone = "796840863", 
                             mail = "alexandrovv@mail.ru", place = "restaurant", position = "cook" };
            string Place = ((WorkerPeople)Wrk).place; //нисходящее преобразование от People к PlaceOfWork

            peoples.peoples.Add(wrk);

            if (peoples[1] is  WorkerPeople)
            {
                (peoples[1] as WorkerPeople).place = "3123";

            }

            peoples.Display();
            Console.ReadKey();

            
        }
    }
}
