using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DataAcess;
using WebApplication1.Models;
using WebApplication1.Models.ViewModel;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DapperAcess _DapperAcess;
        private readonly Data_manipulation _data_manipulation;
        public HomeController(ILogger<HomeController> logger, DapperAcess DapperAcess, Data_manipulation data_manipulation)
        {
            _logger = logger;
            _DapperAcess = DapperAcess;
             _data_manipulation= data_manipulation;
        }

        public IActionResult Index()
        {
            
            return View(_data_manipulation.LoadDataFromDataBase());//從資料庫下載資料
           
        }
        [HttpPost]
        public IActionResult Index(string game_name)
        {
            if (game_name != null)
            {
                var data= _data_manipulation.queryDatabase(game_name);
                if(data.Count()==0)
                {
                    ViewBag.str = "查無此資料";
                }
                else if(data.Count()!=0)
                {
                    

                        ViewBag.game = data;
                                   
                }
            }
            else if(game_name == null)
            {               
                return View(_data_manipulation.LoadDataFromDataBase());
            }
            return View(_data_manipulation.LoadDataFromDataBase());
        }

        public IActionResult cart(int game_number)
        {
            return View(_data_manipulation.CreateCart(game_number));//加入購物車資料
        }
        public IActionResult deletcart(int shoppingid)
        {
            _data_manipulation.deleteCart(shoppingid);
            return RedirectToAction("cart");
        }
        public IActionResult management()
        {
            Game_mall game_ = new Game_mall();
            game_ .game= _data_manipulation.LoadDataFromDataBase();

            return View(game_);
        }
        [HttpPost]
        public IActionResult management(Game_mall games)
        {
            _data_manipulation.UpdateDatabase(games);
                   
            return RedirectToAction("index");
        }
        public IActionResult Privacy()
        {


            return View();
        }
        public IActionResult query()
        {


            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
