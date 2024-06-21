using DemoAndLabs.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoAndLabs.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult SyncDemo()
        {
            var sw = new Stopwatch();
            sw.Start();
            MyDemo.FuncA();
            MyDemo.FuncB();
            MyDemo.FuncC();
            sw.Stop();

            return Content($"Chạy hết {sw.ElapsedMilliseconds} ms");
        }

        public async Task<IActionResult> AsyncDemo()
        {
            var sw = new Stopwatch();
            sw.Start();
            var x = MyDemo.FuncAAsync();
            var y = MyDemo.FuncBAsync();
            var z = MyDemo.FuncCAsync();
            await x; await y; await z;
            sw.Stop();

            return Content($"Chạy hết {sw.ElapsedMilliseconds} ms");
        }
    }
}
