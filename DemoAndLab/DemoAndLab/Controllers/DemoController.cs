using DemoAndLab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoAndLab.Controllers
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

            return Content($"Chạy hết {sw.ElapsedMilliseconds}ms");
        }

        public async Task<IActionResult> AsyncDemo()
        {
            var sw = new Stopwatch();
            sw.Start();
            var a = MyDemo.FuncAAsync();
            var b = MyDemo.FuncBAsync();
            var c = MyDemo.FuncCAsync();
            await a; await b; await c;
            sw.Stop();

            return Content($"Chạy hết {sw.ElapsedMilliseconds}ms");
        }
    }
}
