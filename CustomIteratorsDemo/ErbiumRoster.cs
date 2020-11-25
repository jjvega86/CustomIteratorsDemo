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
        private string[] classStatus;

        public string[] ClassMembers 
        {
            get { return classMembers; } 
            
            set { classMembers = value; } 
        
        }

        public ErbiumRoster()
        {
            classStatus = new string[] { "Amazing", "Awesome", "Fantastic" };
        }

        public IEnumerator GetEnumerator()
        {
            int statusIndex = 0;
            for(int index = 0; index < classMembers.Length; index++)
            {
                
                if (index % 3 == 0)
                {
                    statusIndex = 0;
                    yield return classMembers[index];
                    yield return classStatus[statusIndex];
                    statusIndex++;

                }
                else
                {
                    yield return classMembers[index];
                    yield return classStatus[statusIndex];
                    statusIndex++;
                }
            }

            yield return "That's all folks!";

        }

    }
}
