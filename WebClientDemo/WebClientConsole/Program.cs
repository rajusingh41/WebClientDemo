using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebClientModel;

namespace WebClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var apiUrl = "http://localhost:56907/";



            using (var client = new WebClient())
            {
                try
                {
                    Employee employee = new Employee();
                    employee.EmpId = 1;
                    employee.EmpName = "Raju Singh";
                    employee.EmpAddress = "TKK";
                    string json = JsonConvert.SerializeObject(employee);
                    client.UseDefaultCredentials = true;
                    client.Headers.Add("Content-Type:application/json");
                    client.Headers.Add("Accept:application/json");
                  //  client.Headers.Add("Custom", "Raju");
                    var uri = new Uri(new Uri(apiUrl), "api/Default/SaveEmployee");
                    var response = client.UploadString(uri, "POST", json);
                    Console.WriteLine(response);
                }
                catch (WebException ex)
                {
                    if (ex.Status == WebExceptionStatus.ProtocolError)
                    {
                        HttpWebResponse wrsp = (HttpWebResponse)ex.Response;
                        var statusCode = (int)wrsp.StatusCode;
                        var msg = wrsp.StatusDescription;
                        throw new HttpException(statusCode, msg);
                    }
                    else
                    {
                        throw new HttpException(500, ex.Message);
                    }
                }

            }

            using (var client = new WebClient())
            {
                try
                {

                    EmployeeList employeeList = new EmployeeList();

                    List<Employee> emp = new List<Employee>();
                    emp.Add(new Employee() { EmpId = 1, EmpName = "raju Singh", EmpAddress = "TKK" });
                    emp.Add(new Employee() { EmpId = 2, EmpName = "raju Singh2", EmpAddress = "TKK2" });
                    emp.Add(new Employee() { EmpId = 3, EmpName = "raju Singh3", EmpAddress = "TKK3" });
                    emp.Add(new Employee() { EmpId = 4, EmpName = "raju Singh4", EmpAddress = "TKK4" });
                    employeeList.empList = emp;

                    string json = JsonConvert.SerializeObject(employeeList);
                    client.UseDefaultCredentials = true;
                    client.Headers.Add("Content-Type:application/json");
                    client.Headers.Add("Accept:application/json");
                    var uri = new Uri(new Uri(apiUrl), "api/Default/SaveMultipleEmployee");
                    var response = client.UploadString(uri, "POST", json);
                    Console.WriteLine(response);
                }
                catch (WebException ex)
                {
                    // Http Error
                    if (ex.Status == WebExceptionStatus.ProtocolError)
                    {
                        HttpWebResponse wrsp = (HttpWebResponse)ex.Response;
                        var statusCode = (int)wrsp.StatusCode;
                        var msg = wrsp.StatusDescription;
                        throw new HttpException(statusCode, msg);
                    }
                    else
                    {
                        throw new HttpException(500, ex.Message);
                    }
                }

            }

            using (var client = new WebClient())
            {
                try
                {
                    int id = 10;
                    client.QueryString.Add("id", "10");
                    client.QueryString.Add("name", "raju singh");
                    client.UseDefaultCredentials = true;
                    client.Headers.Add("Content-Type:application/x-www-form-urlencoded");
                    client.Headers.Add("Accept:application/json");
                    var uri = new Uri(new Uri(apiUrl), "api/Default/SaveTest");
                    // var uri = new Uri(apiUrl, "api/Default/SaveEmployee");
                    var response = client.DownloadString(uri);
                    Console.WriteLine(response);
                }
                catch (WebException ex)
                {
                    // Http Error
                    if (ex.Status == WebExceptionStatus.ProtocolError)
                    {
                        HttpWebResponse wrsp = (HttpWebResponse)ex.Response;
                        var statusCode = (int)wrsp.StatusCode;
                        var msg = wrsp.StatusDescription;
                        throw new HttpException(statusCode, msg);
                    }
                    else
                    {
                        throw new HttpException(500, ex.Message);
                    }
                }

            }

            Console.ReadLine();
        }
    }
    
}
