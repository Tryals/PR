using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplePracWork13.Classes
{
    internal class ClassWorker
    {
       
        //поля класса
        string fullname;
        string work;
        string years;
        string titleBook;
        DateTime dateIssue;
        DateTime dateReturn;

        //свойства для доступа к полям
       public string FullName
        { get { return fullname;} set { fullname = value; } }
        public string Work
        { get { return work; } set { work = value; } }
        public string Year
        { get { return years; }  set { years = value; } }

        //конструкторы
        public ClassWorker() 
        {
            FullName = string.Empty;
            Work = string.Empty;
            Year= string.Empty;
        }
        public ClassWorker(string fname, string wk, 
            string yea)
        {
            FullName = fname;
            Work = wk;
            Year = yea;
            
        }
    }
}
