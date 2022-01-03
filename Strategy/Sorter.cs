using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // به کلاینت اجازه می دهد که هر نوع الگوریتم مرتب سازی را در زمان اجرا انتخاب کند و این کار بدون اینکه کلاس را تغییر دهیم
    public class Sorter
    {
        public ISortAlgorithm sortAlgorithm { get; set; }
        public long Sort(int [] arr)
        {
            long Start = System.DateTime.Now.Millisecond;
            if (sortAlgorithm != null)
                sortAlgorithm.Sort(arr);
            long End = System.DateTime.Now.Millisecond;
            long Duration = End - Start;
            return Duration;
        }
    }
}
