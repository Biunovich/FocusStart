using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusStartDylgyrzhapovBuin
{
    class Base
    {
        virtual public void Sort(string Flag)
        {
            throw new Exception("Wrong method");
        }
        virtual public void Add(string str)
        {
            throw new Exception("Wrong input type");
        }
        virtual public void Write(string str)
        {
            throw new Exception("Wrong method");
        }
    }
}
