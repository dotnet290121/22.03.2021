using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitHandlers2203
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            PageLoader page = new PageLoader();
            Task t1 = Task.Run(() => { page.MakeWindowAnimation(); });
            Task t2 = Task.Run(() => { page.ShowAmazingScrollBarsAnimation(); });
            Task t3 = Task.Run(() => { page.FireRequestToWebSite(); });
            Task t4 = Task.Run(() => { page.LoadPage(); });

            Task.WaitAll(new Task[] { t1, t2, t3, t4 });
            Console.ReadLine();
        }
    }
}
