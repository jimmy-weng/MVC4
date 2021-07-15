using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DataAcess;
using WebApplication1.Models.ViewModel;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly Data_manipulation _data_manipulation;
        public ApiController(Data_manipulation data_manipulation)
        {

            _data_manipulation = data_manipulation;

        }
        [Route("api/index")]
       
        public List<Game_mall> index()
        {



            return _data_manipulation.LoadDataFromDataBase();
        }
        [Route("api/index")]
        [HttpPost]
        public List<Game_mall> index(Json1 request)
        {

            

            return _data_manipulation.queryDatabase(request.name); ;
        }
        [Route("api/query")]
        public string query()
        {
            return "a";
        }
        [Route("api/query")]
        [HttpPost]
        public List<Game_mall> query(Json1 request)
        {

            return _data_manipulation.LoadDataFromDataBasebyid(request.identity);
        }
    }
}
