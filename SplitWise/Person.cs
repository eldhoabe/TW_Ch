using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWise
{
    public class Person
    {
        public double Amount { get; set; }

        public string Name { get; set; }

        public string ShowOutStanding()
        {
            if (Amount < 0)
            {
                return string.Format("{0} Has to give {1}", Name, -Amount);
            }
            else
            {
                return string.Format("{0} Gets {1}", Name, Amount);
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            var person = obj as Person;

            return person.Name.Equals(this.Name, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
