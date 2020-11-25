using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIteratorsDemo
{
    class ErbiumRoster : IEnumerable
    {
        private string[] classMembers;
        private string[] classStatus;

        public ErbiumRoster()
        {
            classMembers = new string[] { "Denis", "Greg", "Joe", "Pa", "Zack B", "Zach I" };
            classStatus = new string[] { "Amazing", "Awesome", "Fantastic" };
        }

        public IEnumerator GetEnumerator()
        {
            for(int index = 0; index < classMembers.Length; index++)
            {

                if (index <= 2)
                {
                    yield return classMembers[index];
                    yield return classStatus[index];

                }
                else if (index > 2)
                {
                    int statusIndex = index - 3;
                    yield return classMembers[index];
                    yield return classStatus[statusIndex];

                }
            }

            yield return "That's all folks!";

        }

    }
}
