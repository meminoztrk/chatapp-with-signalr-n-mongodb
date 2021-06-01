using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using chatApp.Models;
using Microsoft.AspNetCore.Http;
using MongoDB.Driver;
using MongoDB.Bson;

namespace chatApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IMongoCollection<Yorum> _admincol;
        private IMongoCollection<User> _user;
        private IMongoCollection<ChatName> _chatname;

        public HomeController(ILogger<HomeController> logger,IMongoClient client)
        {
            _logger = logger;
            var database = client.GetDatabase("test");
            _admincol = database.GetCollection<Models.Yorum>("chaticerik");
            _user = database.GetCollection<Models.User>("user");
            _chatname = database.GetCollection<Models.ChatName>("chatname");

        }

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

        public JsonResult Veriler()
        {
            var bul = _admincol.Find(new BsonDocument()).ToList();
            var test = new List<Yorum>();
            foreach (var data in bul)
            {
                test.Add(new Yorum() { yorumid = data._id.ToString(), yorums = data.yorums });
            }
           

            return Json(test);
        }

        public JsonResult ChatList()
        {
            var chatlist = _chatname.Find(new BsonDocument()).ToList();
            var chatlists = new List<ChatName>();
            foreach (var item in chatlist)
            {
                chatlists.Add(new ChatName(){chatid = item._id.ToString(),chatismi = item.chatismi});
            }

            return Json(chatlists);
        }

        public JsonResult YorumList(string id)
        {
            var yorumList = _admincol.Find(x => x.chatid == id).ToList();
            return Json(yorumList);
        }
        

        public JsonResult EkleJson(Yorum yorum)
        {

            _admincol.InsertOne(yorum);
            return Json(null);
        }
        

        public JsonResult SilJson(string id)
        {
            var docId = new ObjectId(id);
            if (docId != null)
            {
                _admincol.DeleteOne(m => m._id == docId);
                return Json(null);
            }
            return Json(null);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var login = _user.Find(x => x.username == user.username && x.password == user.password).SingleOrDefault();
            if (login != null)
            {
                var userno = login.userid.ToString();
                HttpContext.Session.SetString("userid",userno);
                HttpContext.Session.SetString("username",login.username);
                HttpContext.Session.SetString("adsoyad",login.ad + " " + login.soyad);
                return RedirectToAction("Chat", "Home");
            }
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(User user)
        {
            if (ModelState.IsValid)
            {
                _user.InsertOne(user);
                return RedirectToAction("Login", "Home");
            }
            
            return View();
        }

        public IActionResult Chat()
        {
            return View();
        }
    
    
    }
}