using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public int Legs { get; set; }
        public int Type { get; set; }
        public bool HasScales { get; set; }
        public bool IsColdBlooded { get; set; }
        public string ShootsFire { get; set; }



        public Reptile()
        {

        }


        public Reptile(int legs, int type, bool hasScales, bool isColdBlooded, int age, string name, bool hasTwoEyes, string shootsFire)
        {
            Name = name;
            Age = age;
            Legs = legs;
            Type = type;
            HasScales = hasScales;
            IsColdBlooded = isColdBlooded;
            HasTwoEyes = hasTwoEyes;
            ShootsFire = shootsFire;
        }
    }
}
