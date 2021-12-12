using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildFrameworkCraft.Service
{
    public class ConfigService
    {
        public static string GetValueInConfig(string key)
        {
          var value = ConfigurationManager.AppSettings[key] is null ? null: ConfigurationManager.AppSettings[key].ToString();
            return value;
        }
    }
}
