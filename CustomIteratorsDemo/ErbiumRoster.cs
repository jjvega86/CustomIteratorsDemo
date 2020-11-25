using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIteratorsDemo
{
    public class ErbiumRoster : IEnumerable
    {
        private string[] classMembers;
        private string[] classMemberStatus;

        public string[] ClassMembers { get => classMembers; set => classMembers = value; } // public read/write property for classMembers

        public ErbiumRoster()
        {
            classMemberStatus = new string[] { "Amazing", "Awesome", "Fantastic" };
        }

        public IEnumerator GetEnumerator() //the only thing our IEnumerable contract requires to implement. Returns type IEnumerator 
        {
            int statusIndex = 0;
            for(int index = 0; index < classMembers.Length; index++) // our customer iterator that utilizes yield return to send values back to foreach loop
            {
                
                if (index % 3 == 0)
                {
                    statusIndex = 0;
                    yield return classMembers[index];
                    yield return classMemberStatus[statusIndex];
                    statusIndex++;

                }
                else
                {
                    yield return classMembers[index];
                    yield return classMemberStatus[statusIndex];
                    statusIndex++;
                }
            }

            yield return "That's all folks!";

        }

    }
}
