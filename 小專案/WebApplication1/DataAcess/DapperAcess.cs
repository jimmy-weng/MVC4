using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.DataAcess
{
    public class DapperAcess 
    {


        public string connectionStr { get; set; }
      
        public IConfiguration _configuration { get; }

        public DapperAcess(IConfiguration configuration)
        {
            _configuration = configuration;

            string path = Directory.GetCurrentDirectory(); // 在這個資料裡下
            connectionStr = _configuration.GetConnectionString("GameVIewContext")
                                .Replace("[DataDirectory]", path);
           
        }

        public List<T> LoadData<T>(string sql)
        {

            using (IDbConnection cnn = new SqlConnection(connectionStr))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        public int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(connectionStr))
            {
                return cnn.Execute(sql, data);
            }

        }

        
    }
}
