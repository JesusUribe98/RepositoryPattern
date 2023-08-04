using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DAL
{
    public class AppConfiguration
    {
        public AppConfiguration()
        {
            IConfigurationBuilder _configBuilder = new ConfigurationBuilder();
            var _path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            _configBuilder.AddJsonFile(_path, optional: true, reloadOnChange: true);
            var _root = _configBuilder.Build();
            var _appSetting = _root.GetSection("DatabaseConnection");

            Server = _appSetting.GetSection("sql_server").Value;
            Database = _appSetting.GetSection("database").Value;
            Password = _appSetting.GetSection("database_password").Value;
            User = _appSetting.GetSection("database_user").Value;
        }


        public string Server { get; set; }
        public string Database { get; set; }
        public string Password { get; set; }
        public string User { get; set; }
    }
}
