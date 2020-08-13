using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection
{
    public class ManageCollection
    {
        public List<string> ListOperations(List<string> allData)
        {
            if (allData.Count % 2 != 0)
            {
                allData.RemoveAt(allData.Count / 2);
            }

            if (allData.Contains("mamas"))
            {
                allData.Add("6");
            }

            if ((allData.IndexOf("aram") + 1) % 2 != 0)
            {
                allData.Reverse();
            }

            if (allData.GroupBy(a => a).Count() == 3)
            {
                List<string> newList = new List<string>();

                newList.AddRange(allData.Take(2));
                newList.AddRange(new List<string> { "2", "3", "4" });

                newList.AddRange(allData.Skip(2));

                allData = newList;
            }

            return allData;
        }

        public Dictionary<string, int> DictionaryOperations(Dictionary<string, int> allData)
        {
            if (allData.ContainsKey("scuba"))
            {
                if (allData["scuba"] == 6 && !allData.ContainsKey("Empire"))
                {
                    allData["Empire"] = 6;

                }
            }

            return allData;
        }

        public Stack<DateTime> StackOperations(Stack<DateTime> allDats)
        {
            if (allDats.Count > 0)
            {
                DateTime dateNow = DateTime.Now;

                if (allDats.First() < dateNow)
                {
                    allDats.Pop();
                    allDats.Push(dateNow);
                }
            }

            return allDats;
        }
    }
}
