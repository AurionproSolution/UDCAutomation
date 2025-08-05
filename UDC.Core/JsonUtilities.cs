using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDC.UDC.Core
{
    public class JsonUtilities
    {
        public static T ReadJson<T>(string filePath)
        {
            string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "StepDefinitions", filePath);
            string json = File.ReadAllText(fullPath);
            return JsonConvert.DeserializeObject<T>(json);
        }
    }

}
