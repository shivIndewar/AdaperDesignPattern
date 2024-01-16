using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdaperPattern.Adapter
{
    public class EmployeeAdapter : EmployeeManager, IEmployee
    {
        public override string GetAllEmployees()
        {
           string   returnXml = base.GetAllEmployees();
            XmlDocument document = new XmlDocument();
            document.LoadXml(returnXml);
            return JsonConvert.SerializeObject(document, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
