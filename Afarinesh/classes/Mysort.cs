using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Tamrin.classes
{
    public  class MySort
    {
        public void bubllesort(List<int> mylist,int n)
        {
            for (int i = 2; i < n; i++)
            {
                for (int j = 0; j < n-i+1; j++)
                {
                    if (mylist[j] > mylist[j + 1])
                    {
                        int temp =mylist[j];
                        mylist[j] = mylist[j + 1];
                        mylist[j + 1] = temp;
                    }
                    
                }
            }
        }

        

    }
}
