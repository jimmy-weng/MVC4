using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.ViewModel;

namespace WebApplication1.DataAcess
{
    public class Data_manipulation
    {
        private readonly DapperAcess _DapperAcess;
        public Data_manipulation(DapperAcess DapperAcess)
        {
            _DapperAcess = DapperAcess;
        }
        public List<Game_mall> LoadDataFromDataBasebyid(int id)
        {


            string sql_data = "select*from Game_mall where Game_number="+id;
            var data = _DapperAcess.LoadData<Game_mall>(sql_data);
            return data;
        }
        public List<Game_mall> LoadDataFromDataBase()
        {


            string sql_data = "select*from Game_mall";
            var data = _DapperAcess.LoadData<Game_mall>(sql_data);
            return data;
        }
        public List<shopping> CreateCart(int game_number)
        {
            string sql_data = "select*from Game_mall where game_number=" + game_number;
            var data = _DapperAcess.LoadData<Game_mall>(sql_data);
            shopping Shopping = new shopping();
            foreach (var row in data)
            {

                Shopping.Game_name = row.Game_name;
                Shopping.Game_category = row.Game_category;
                Shopping.Unit_price = row.Unit_price;

                string sql_insert = "insert into shopping(Game_name,Game_category,Unit_price)values(@Game_name,@Game_category,@Unit_price)";
                _DapperAcess.SaveData<shopping>(sql_insert, Shopping);
            }

            string sql_data1 = "select*from shopping";

            var data1 = _DapperAcess.LoadData<shopping>(sql_data1);


            return data1;

        }
        public void deleteCart(int shoppingid)
        {
            shopping Shopping = new shopping();
            Shopping.shoppingid = shoppingid;

            string sql_data = "Delete from shopping where shoppingid=" + shoppingid;
            _DapperAcess.SaveData<shopping>(sql_data, Shopping);
        }
        public List<Game_mall> queryDatabase(string game_name)
        {

            Game_mall game_Mall = new Game_mall();
            
                string sql_data = "select*from Game_mall where Game_name LIKE N'%" + game_name + "%'";
                var data1 = _DapperAcess.LoadData<Game_mall>(sql_data);


            return data1;

        }
        public void UpdateDatabase(Game_mall games)
        {
            foreach (var row in games.game)
            {

                Game_mall game_Mall = new Game_mall();
                game_Mall.Unit_price = row.Unit_price;
                string sql_data = "Update Game_mall Set Unit_price=@Unit_price where Game_number = '" + row.Game_number + "' ";
                _DapperAcess.SaveData<Game_mall>(sql_data, game_Mall);
            }


        }
    }
}
