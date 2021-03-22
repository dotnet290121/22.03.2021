using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WaitHandlers2203
{
    public class PageLoader
    {

        private ManualResetEvent gate = new ManualResetEvent(false);

        public void MakeWindowAnimation()
        {
            Console.WriteLine("MakeWindowAnimation reached gate");
            // wait for page to be loaded
            gate.WaitOne();
            Console.WriteLine("Drawing page animation ...");

        }
        public void ShowAmazingScrollBarsAnimation()
        {
            Console.WriteLine("ShowAmazingScrollBarsAnimation reached gate");
            // wait for page to be loaded
            gate.WaitOne();
            Console.WriteLine("ShowAmazingScrollBarsanimation ...");

        }
        public void FireRequestToWebSite()
        {
            Console.WriteLine("FireRequestToWebSite reached gate");
            // wait for page to be loaded
            gate.WaitOne();
            Console.WriteLine("FireRequestTo WebSite ...");

        }
        public void LoadPage()
        {
            Console.WriteLine("Loading page...");
            Thread.Sleep(5 * 1000);
            Console.WriteLine("Page finished loading");

            gate.Set();
        }
    }
}
