using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KipAzz
{
    class Password //Model
    {
        string value;
        string iconPath; //wszystkie ikony będą trafiały do folderu icons
        string name;
        string? URL;
        string? appName;
        
        DateTime expirationDate;
        DateTime created;
        DateTime lastModified;
        public Password(string value, string iconPath, string name, DateTime expirationDate)
        {
            this.value = value;
            this.iconPath = iconPath;
            this.name = name;
            this.expirationDate = expirationDate;
            created = DateTime.Now;
            lastModified = DateTime.Now;
        }
        public Password(string value, string iconPath, string name, string? uRL, string? appName, DateTime expirationDate)
        {
            this.value = value;
            this.iconPath = iconPath;
            this.name = name;
            URL = uRL;
            this.appName = appName;
            this.expirationDate = expirationDate;
            created = DateTime.Now;
            lastModified = DateTime.Now;
        }
    }
}
