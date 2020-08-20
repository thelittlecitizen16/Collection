using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    public class ManageCollection
    {
        public List<string> ListOperations(List<string> strList)
        {
            if (strList.Count % 2 != 0)
            {
                strList.RemoveAt(strList.Count / 2);
            }

            if (strList.Contains("mamas"))
            {
                strList.Add("6");
            }

            if ((strList.IndexOf("aram") + 1) % 2 != 0)
            {
                strList.Reverse();
            }

            if (strList.GroupBy(a => a).Count() == 3)
            {
                List<string> newList = new List<string>();

                newList.AddRange(strList.Take(2));
                newList.AddRange(new List<string> { "2", "3", "4" });

                newList.AddRange(strList.Skip(2));

                strList = newList;
            }

            return strList;
        }

        public Dictionary<string, int> DictionaryOperations(Dictionary<string, int> coursesValue)
        {
            if (coursesValue.ContainsKey("scuba"))
            {
                if (coursesValue["scuba"] == 6 && !coursesValue.ContainsKey("Empire"))
                {
                    coursesValue["Empire"] = 6;

                }
            }

            return coursesValue;
        }

        public Stack<DateTime> StackOperations(Stack<DateTime> dates)
        {
            if (dates.Count > 0)
            {
                DateTime dateNow = DateTime.Now;

                if (dates.First() < dateNow)
                {
                    dates.Pop();
                    dates.Push(dateNow);
                }
            }

            return dates;
        }
    }
}
