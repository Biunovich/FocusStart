using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusStartDylgyrzhapovBuin
{
    class StringLines : Base
    {
        private List<string> arr = new List<string>();
        public override void Sort(string Flag)
        {
            string key;
            int i;
            if (arr.Count < 2)
                return;
            for (int j = 1; j < arr.Count; j++)
            {
                key = arr[j];
                i = j - 1;
                while (i > -1 && String.Compare(arr[i], key) > 0)
                {
                    arr[i + 1] = arr[i];
                    i = i - 1;
                }
                arr[i + 1] = key;
            }
            if (Flag == "-d")
                arr.Reverse();
        }
        public override void Add(string set)
        {
            arr.Add(set);
        }
        public override void Write(string outFile)
        {
            using (StreamWriter sw = new StreamWriter(File.Open(outFile, FileMode.Create)))
            {
                foreach (string word in this.arr)
                {
                    sw.WriteLine(word);
                }
            }
        }
    }
}