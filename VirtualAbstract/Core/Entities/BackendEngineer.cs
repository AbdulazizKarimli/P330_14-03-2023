using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public sealed class BackendEngineer : Engineer
    {
        public int Experience { get; set; }

        public BackendEngineer(string name, byte age, int salary, int experience) : base(name, age, salary)
        {
            Experience = experience;
        }

        //public override void GetInfo()
        //{
        //    Console.WriteLine($"{Name} {Age} {Salary} {Experience}");
        //}
    }
}
