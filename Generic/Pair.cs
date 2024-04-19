using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public  class Pair<S, T>
    {
        public S Name { get; set; }

        public T Age {  get; set; }

        public Pair( S name , T age) 
        {
            // TODO: проверить входные параметры
            Name = name;
            Age = age;
            Console.WriteLine($"Name: {name} , age: {age}");
        }

    }






}
