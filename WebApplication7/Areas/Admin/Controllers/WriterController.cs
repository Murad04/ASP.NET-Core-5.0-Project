using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication7.Areas.Admin.Models;

namespace WebApplication7.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonWriter = JsonConvert.SerializeObject(writer);
            return Json(jsonWriter);
        }

        public IActionResult GetWriterById(int writerid)
        {
            var findw = writer.FirstOrDefault(x => x.writerid == writerid);
            var jsonwriters = JsonConvert.SerializeObject(findw);
            return Json(jsonwriters);
        }
        public IActionResult GetWriterByName(string name)
        {
            var findwn = writer.FirstOrDefault(x => x.writername == name);
            var jsonwrt = JsonConvert.SerializeObject(findwn);
            return Json(jsonwrt);
        }
        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writer.Add(w);
            var jsonw = JsonConvert.SerializeObject(w);
            return Json(jsonw);
        }
        public IActionResult DeleteWriter(int id)
        {
            var writerr = writer.FirstOrDefault(x => x.writerid == id);
            writer.Remove(writerr);
            return Json(writer);
        }
        public IActionResult UpdateWriter(WriterClass ww)
        {
            var writerr = writer.FirstOrDefault(x => x.writerid == ww.writerid);
            writerr.writername = ww.writername;
            var jsonw = JsonConvert.SerializeObject(ww);
            return Json(jsonw);
        }
        public static List<WriterClass> writer = new List<WriterClass>
        {
            new WriterClass
            {
                writerid=1,
                writername="Frank Herbert"
            },
            new WriterClass
            {
                writerid=2,
                writername="Rovsen Abdullaoglu"
            },
        };
    }
}
