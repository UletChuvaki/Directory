using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    
    
    class People
    {
        protected string ffio;

        public People()
        {

        }

        public People(string fio, string tel)
        {
            ffio = fio;
            telephone = tel;
            
        }

        public People(string fio, string tel, string email)
        {
            ffio = fio;
            telephone = tel;
            mail = email;

        }


        public string fio {
            get
            {
                return ffio;
            }
            set
            {
                ffio = value.ToUpper();
            }
        }
        public string telephone;
        public string mail;
        public virtual void Display()
        {
            Console.WriteLine(fio + telephone + mail );
            
        }
    }
    class Peoples
    {
        public List<People> peoples;
        public Peoples()
        {
            peoples = new List<People>();
        }

        public void Display()
        {
            foreach (var item in peoples)
            {
                item.Display();

            }

        }

        public People this[int index]
        {
            get
            {
                return peoples[index];
            }
            set
            {
                peoples[index] = value;
            }
        }

    }

    class WorkerPeople : People
    {
        public string place { get; set; }
        public string position { get; set; }
        public WorkerPeople(string fio, string tel, string email, string place, string position) : base()
        {
            ffio = fio;
            telephone = tel;
            mail = email;
            this.place = place;
            this.position = position;

        }

        public WorkerPeople()
        {

        }
        public override void Display()
        {
            Console.WriteLine(fio  + telephone +" mail: "+ mail +" place:" +place + " "+ position);
        }
    }

}


