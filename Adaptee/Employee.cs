using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace AdaperPattern
{
    public class Employee
    {
        Employee()
        {
                
        }
        public Employee(int id, string name)
        {
                
        }
        [XmlAnyAttribute]
        public int ID { get; set; }
        [XmlAnyAttribute]
        public string Name { get; set; }

    }

    public class EmployeeManager
    {
        public List<Employee> employees;
        public EmployeeManager()
        {
            employees = new List<Employee>();
            this.employees.Add(new Employee(1, "shiv"));
            this.employees.Add(new Employee(2, "prasad"));
            this.employees.Add(new Employee(3, "indewar"));
            this.employees.Add(new Employee(4, "shivprasad"));
            this.employees.Add(new Employee(5, "shivindewar"));

        }

        public virtual string GetAllEmployees()
        {
            var emptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(employees.GetType());
            var xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;  
            xmlSettings.OmitXmlDeclaration  = true;

            using (var stream = new StringWriter())
            using (var writter = XmlWriter.Create(stream, xmlSettings))
            {
                serializer.Serialize(writter, employees, emptyNamespaces);
                return stream.ToString();
            }

        }

    }
}
