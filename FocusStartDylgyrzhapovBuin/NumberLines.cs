using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusStartDylgyrzhapovBuin
{
    class NumberLines : Base
    {
        private List<int> arr = new List<int>();
        public override void Sort(string Flag)
        {
            int key;
            int i;
            if (arr.Count < 2)
                return;
            for (int j = 1; j < arr.Count; j++)
            {
                key = arr[j];
                i = j - 1;
                while (i > -1 && arr[i] > key)
                {
                    arr[i + 1] = arr[i];
                    i = i - 1;
                }
                arr[i + 1] = key;
            }
            if (Flag == "-d")
                arr.Reverse();
        }
        public override void Add(string num)
        {
            arr.Add(Convert.ToInt32(num));
        }
        public override void Write(string outFile)
        {
            using (StreamWriter sw = new StreamWriter(File.Open(outFile, FileMode.Create)))
            {
                foreach (int num in this.arr)
                {
                    sw.WriteLine(num);
                }
            }
        }
    }
}
