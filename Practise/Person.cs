
using AESEncrypt;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
//http://www.c-sharpcorner.com/UploadFile/1492b1/diving-into-oop-day-5-all-about-access-modifiers-in-C-Sharp/
//Classes allow you to create objects that contained members with attributes or behavior. 
//Interfaces allow you to declare a set of attributes and behavior that all objects implementing them would publicly expose. 
#region extension
//namespace Extension
//{
//    public class Main
//    {
//        public string Display()
//        {
//            Console.WriteLine("Main Display!");
//    urn "Display this!";
//        }
//        public string Print()
//        {
//            Console.WriteLine("Main Print!");
//    urn "Print This";
//        }
//    }
//}
#endregion

namespace Practise
{

    public class NumWays
    {
        static void Main()
        {
            NumWays n = new NumWays();
            //int[] array = new int[5] { 1, 2, 3, 4, 5};
            int[,] array = new int[5, 5] { 
            { 1, 2, 3, 4, 5 }, 
            { 6, 2, 8, 4, 5 }, 
            { 6, 11, 9, 4, 6 }, 
            { 5, 13, 3, 4, 8 }, 
            { 2, 2, 3, 14, 5 } 
            };
            n.DisplayOddEven(array);
            //int x = n.findSum2d(array);
            //Console.WriteLine(x);
            Console.ReadLine();
        }
        public void DisplayOddEven(int[,] array)
        {
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int n = 0; n < 5; n++)
                {
                    if (i == 0 && n == 0)
                    {
                        Console.WriteLine("First Row: ");
                    }
                    if (i == 1 && n == 0)
                    {
                        Console.WriteLine("Second Row: ");
                    }
                    if (i == 2 && n == 0)
                    {
                        Console.WriteLine("Third Row: ");
                    }
                    if (i == 3 && n == 0)
                    {
                        Console.WriteLine("Fourth Row: ");
                    }
                    if (i == 4 && n == 0)
                    {
                        Console.WriteLine("Fifth Row: ");
                    }
                    if (array[i,n] % 2 == 0 )
                    {
                        Console.WriteLine("Even: {0}", array[i, n]);
                    }
                    else
                    {
                        Console.WriteLine("Odd: {0}", array[i, n]);
                    }
                  
                }
            }
        }
        //public int findSum2d(int[,] array)
        //{
        //    int total = 0;
        //    for (int i = 0; i < 5; i++)
        //    {
        //        for (int x = 0; x <5; x++)
        //        {
        //            total += array[i, x];
        //            Console.WriteLine(array[i, x]);
        //        }
        //    }

        //    return total;
        //}
        //public int findSum(int[] array)
        //{
        //    int total = 0;
        //    foreach (var item in array)
        //    {
        //        total += item;
        //    }
        //    return total;
        //}
        //public int numWays(int n) 
        //{
        //    if (n == 0 || n == 1)
        //    {
        //        return 1;
        //    }
        //    else 
        //    {
        //        return numWays(n - 1) + numWays(n - 2);
        //    }
        //}
    }
    #region Google Coordinates
    //class x {
    //public string GetLongitudeAndLatitude(string address, string sensor)
    //{
    //    string urlAddress = "http://maps.googleapis.com/maps/api/geocode/xml?address=" + HttpUtility.UrlEncode(address) + "&sensor=" + sensor;
    //    string returnValue = "";
    //    try
    //    {
    //        XmlDocument objXmlDocument = new XmlDocument();
    //        objXmlDocument.Load(urlAddress);
    //        XmlNodeList objXmlNodeList = objXmlDocument.SelectNodes("/GeocodeResponse/result/geometry/location");
    //        foreach (XmlNode objXmlNode in objXmlNodeList)
    //        {
    //            // GET LONGITUDE 
    //            returnValue = objXmlNode.ChildNodes.Item(0).InnerText;

    //            // GET LATITUDE 
    //            returnValue += "," + objXmlNode.ChildNodes.Item(1).InnerText;
    //        }
    //    }
    //    catch
    //    {
    //        // Process an error action here if needed  
    //    }
    //    return returnValue;
    //}
    //static void Main() 
    //{
    //    string longi, lat = string.Empty;
    //    Adress adrs = new Adress();
    //    adrs.Address = "ML EXTENSION, B. BENEDICTO ST. NRA";
    //    adrs.GeoCode();
    //    lat = adrs.Latitude;
    //    longi = adrs.Longitude;

    //}
    //public class Adress
    //{
    //    public Adress()
    //    {
    //    }
    //    //Properties
    //    public string Latitude { get; set; }
    //    public string Longitude { get; set; }
    //    public string Address { get; set; }

    //    //The Geocoding here i.e getting the latt/long of address
    //    public void GeoCode()
    //    {
    //        //to Read the Stream
    //        StreamReader sr = null;

    //        //The Google Maps API Either return JSON or XML. We are using XML Here
    //        //Saving the url of the Google API 
    //        string url = String.Format("https://maps.googleapis.com/maps/api/geocode/xml?address=" +
    //        this.Address + "&sensor=false&key=" + "AIzaSyB121lw5hxWkCwyhzFIBspWZEeIAfamBX4");

    //        //to Send the request to Web Client 
    //        WebClient wc = new WebClient();
    //        try
    //        {
    //            sr = new StreamReader(wc.OpenRead(url));
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("The Error Occured" + ex.Message);
    //        }

    //        try
    //        {
    //            XmlTextReader xmlReader = new XmlTextReader(sr);
    //            bool latread = false;
    //            bool longread = false;

    //            while (xmlReader.Read())
    //            {
    //                xmlReader.MoveToElement();
    //                switch (xmlReader.Name)
    //                {
    //                    case "lat":

    //                        if (!latread)
    //                        {
    //                            xmlReader.Read();
    //                            this.Latitude = xmlReader.Value.ToString();
    //                            latread = true;

    //                        }
    //                        break;
    //                    case "lng":
    //                        if (!longread)
    //                        {
    //                            xmlReader.Read();
    //                            this.Longitude = xmlReader.Value.ToString();
    //                            longread = true;
    //                        }

    //                        break;
    //                }
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception("An Error Occured" + ex.Message);
    //        }
    //    }
    //}
    //}
    //class Coordinates
    //{

    //    static void Main()
    //    {

    //    //    try
    //    //    {
    //    //        string address = "ML EXTENSION, B. BENEDICTO ST. NRA";
    //    //        string requestURI = string.Format("http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false&key={1}", Uri.EscapeDataString(address),"");
    //    //        WebRequest request = WebRequest.Create(requestURI);
    //    //        WebResponse response = request.GetResponse();
    //    //        XDocument xdoc = XDocument.Load(response.GetResponseStream());

    //    //        XElement result = xdoc.Element("GeocodeResponse").Element("result");
    //    //        XElement locationElement = result.Element("geometry").Element("location");
    //    //        XElement lat = locationElement.Element("lat");
    //    //        XElement lng = locationElement.Element("lng");
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        Console.WriteLine(ex.ToString());
    //    //    }
    //    //    Console.ReadLine();
    //    //    //IGeocoder geo = new GoogleGeocoder() { };
    //    //    //Address[] addressess = geo.Geocode(address).ToArray();
    //    //    //foreach (Address add in addressess)
    //    //    //{
    //    //    //    Console.WriteLine(add.Coordinates);
    //    //    //}
    //    //    //Console.ReadLine();
    //    }
    //}
    #endregion
    #region Fix Upload
    //public class Search
    //{
    //    public List<t> searchData { get; set; }
    //    public List<re> Reportsdata { get; set; }
    //}
    //public class re
    //{
    //    public string transdate;
    //    public string operatorName;
    //    public string walletname;
    //    public string walletno;
    //    public string kptn;
    //    public int nooftxn;
    //    public double amount;
    //    public decimal charge;
    //    public int commission;
    //    public string batchnumber;
    //    public string status;
    //    public string receiptNo;
    //}
    //public class t
    //{
    //    public string filename;
    //    public string batchnumber;
    //    public string walletno;
    //    public string walletname;
    //    public double amount;
    //    public string kptn;
    //    public string operatorName;
    //    public DateTime transdate;
    //    public decimal charge;
    //    public string branchCode;
    //    public int zonecode;
    //    public string station;
    //    public string fullname;
    //    public string firstname;
    //    public string middlename;
    //    public string lastname;
    //    public string status;
    //    public string receiptNo;
    //    public int executed;
    //}
    //public class X
    //{
    //    public static void Main()
    //    {
    //        X xx = new X();
    //        Search yy = new Search();
    //        yy.searchData = new List<t>();
    //        string z = xx.HttpGetRequest();
    //        string r = xx.GetReports();
    //        Search y = JsonConvert.DeserializeObject<Search>(z);

    //        Search report = JsonConvert.DeserializeObject<Search>(r);
    //        foreach (var item in y.searchData)
    //        {

    //            if (item.batchnumber == "2019081612312700552")
    //            {

    //                yy.searchData.Add(new t
    //                {
    //                    batchnumber = item.batchnumber,
    //                    walletname = item.walletname,
    //                    walletno = item.walletno
    //                });
    //            }
    //        }

    //        var activewallet = from a in yy.searchData
    //                           select a.walletno;

    //        var inactivewallet = from ia in report.Reportsdata
    //                             select ia.walletno;

    //        var difference = activewallet.Except(inactivewallet).ToList();
    //        string inactive = string.Empty;
    //        foreach (var item in difference)
    //        {
    //            Console.WriteLine("Inactive Wallet: " + item);
    //            inactive += item + ",";
    //        }
    //        inactive = inactive.Substring(0, inactive.Length - 1);
    //        string[] inactivelist = inactive.Split(',');

    //        string final = string.Empty;
    //        foreach (var con in inactivelist)
    //        {
    //            final += con + "\n";
    //        }
    //        Console.WriteLine(final);
    //        //foreach (var item in yy.searchData)
    //        //{

    //        //    if (item.walletno != report.Reportsdata[counter].walletno)
    //        //    {
    //        //        Console.WriteLine(item.walletno);

    //        //    }
    //        //    counter++;

    //        //}

    //        Console.ReadLine();

    //    }
    //    public virtual string GetReports()
    //    {
    //        int attempt = 0;
    //        do
    //        {
    //            try
    //            {
    //                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
    //                if (attempt > 0)
    //                {

    //                    if (attempt == 1)
    //                    {
    //                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
    //                    }
    //                    else
    //                    {
    //                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
    //                    }
    //                }
    //                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://mlexpress.mlhuillier1.com/Walletbatchupload/Service.svc/ReportsData/?batchnumber=2019081612312700552") as HttpWebRequest;
    //                request.Method = "GET";
    //                request.ContentType = "application/json";
    //                request.Credentials = CredentialCache.DefaultCredentials;
    //                //request.Timeout = Timeout.Infinite;
    //                WebResponse webresponse = request.GetResponse();
    //                String res = null;
    //                using (Stream response = webresponse.GetResponseStream())
    //                {
    //                    if (webresponse != null)
    //                    {
    //                        using (StreamReader reader = new StreamReader(response))
    //                        {
    //                            res = reader.ReadToEnd();
    //                            reader.Close();
    //                            webresponse.Close();
    //                        }
    //                    }
    //                }
    //                return res;
    //            }
    //            catch (WebException ex)
    //            {

    //                if (ex.ToString().ToLower().Contains("underlying") || ex.ToString().ToLower().Contains("ssl"))
    //                {
    //                    if (attempt < 2)
    //                    {
    //                        attempt++;
    //                        Thread.Sleep(attempt * 2000);
    //                    }
    //                    else
    //                    {
    //                        try
    //                        {
    //                            using (WebResponse response = ex.Response)
    //                            {
    //                                HttpWebResponse httpResponse = (HttpWebResponse)response;

    //                                using (Stream data = response.GetResponseStream())
    //                                using (var reader = new StreamReader(data))
    //                                {
    //                                    string text = reader.ReadToEnd();
    //                                    String respcode = httpResponse.StatusCode.ToString();
    //                                    if (respcode == "422")
    //                                    {

    //                                        return "ERROR" + "|" + text;
    //                                    }

    //                                    return "ERROR" + "|" + text;
    //                                }
    //                            }
    //                        }
    //                        catch (Exception tex)
    //                        {
    //                            return "ERROR" + "|" + tex.ToString();
    //                        }
    //                    }
    //                }
    //                else
    //                {
    //                    return "ERROR" + "|" + ex.ToString();
    //                }
    //            }
    //        } while (true);
    //    }
    //    public virtual string HttpGetRequest()
    //    {
    //        int attempt = 0;
    //        do
    //        {
    //            try
    //            {
    //                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
    //                if (attempt > 0)
    //                {

    //                    if (attempt == 1)
    //                    {
    //                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
    //                    }
    //                    else
    //                    {
    //                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
    //                    }
    //                }
    //                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://mlexpress.mlhuillier1.com/Walletbatchupload/Service.svc/LoadedTransactions/?date=2019-08-16&limitFrom=0&limitTo=10000&type=0") as HttpWebRequest;
    //                request.Method = "GET";
    //                request.ContentType = "application/json";
    //                request.Credentials = CredentialCache.DefaultCredentials;
    //                //request.Timeout = Timeout.Infinite;
    //                WebResponse webresponse = request.GetResponse();
    //                String res = null;
    //                using (Stream response = webresponse.GetResponseStream())
    //                {
    //                    if (webresponse != null)
    //                    {
    //                        using (StreamReader reader = new StreamReader(response))
    //                        {
    //                            res = reader.ReadToEnd();
    //                            reader.Close();
    //                            webresponse.Close();
    //                        }
    //                    }
    //                }
    //                return res;
    //            }
    //            catch (WebException ex)
    //            {

    //                if (ex.ToString().ToLower().Contains("underlying") || ex.ToString().ToLower().Contains("ssl"))
    //                {
    //                    if (attempt < 2)
    //                    {
    //                        attempt++;
    //                        Thread.Sleep(attempt * 2000);
    //                    }
    //                    else
    //                    {
    //                        try
    //                        {
    //                            using (WebResponse response = ex.Response)
    //                            {
    //                                HttpWebResponse httpResponse = (HttpWebResponse)response;

    //                                using (Stream data = response.GetResponseStream())
    //                                using (var reader = new StreamReader(data))
    //                                {
    //                                    string text = reader.ReadToEnd();
    //                                    String respcode = httpResponse.StatusCode.ToString();
    //                                    if (respcode == "422")
    //                                    {

    //                                        return "ERROR" + "|" + text;
    //                                    }

    //                                    return "ERROR" + "|" + text;
    //                                }
    //                            }
    //                        }
    //                        catch (Exception tex)
    //                        {
    //                            return "ERROR" + "|" + tex.ToString();
    //                        }
    //                    }
    //                }
    //                else
    //                {
    //                    return "ERROR" + "|" + ex.ToString();
    //                }
    //            }
    //        } while (true);
    //    }
    //}
    #endregion
    //class returntype 
    //{
    //    static void Main() 
    //    {
    //        Console.WriteLine("\nReflection.MethodInfo");

    //        // Get the Type and MethodInfo.
    //     ype MyType = Type.GetType("System.Reflection.FieldInfo");
    //   thodInfo Mymethodinfo = MyType.GetMethod("GetValue");
    //        Console.Write("\n" + MyType.FullName + "." + Mymethodinfo.Name);

    //        // Get and display the ReturnType.
    //        Console.Write("\nReturnType = {0}", Mymethodinfo.ReturnType);
    //        Console.ReadLine();
    //    }
    //}
    //static class Extesion
    //{
    //    internal static T ParseValue<T>(this object value, Format format)
    //    {

    //        Console.WriteLine("\nReflection.MethodInfo");

    //        // Get the Type and MethodInfo.
    //     ype MyType = Type.GetType("Practise.Extesion");
    //   thodInfo Mymethodinfo = MyType.GetMethod("ParseValue<T>");
    //        Console.Write("\n" + MyType.FullName + "." + Mymethodinfo.Name);

    //        // Get and display the ReturnType.
    //        Console.Write("\nReturnType = {0}", Mymethodinfo.ReturnType);

    //        int i;
    //     ouble dbl;
    //   cimal dc;
    //        switch (format)
    //        {
    //            case Format.INTEGER:
    //                Int32.TryParse(value.ToString(), out i);
    //        urn (T)Convert.ChangeType(i, typeof(T));
    //            case Format.DOUBLE:
    //             ouble.TryParse(value.ToString(), out dbl);
    //        urn (T)Convert.ChangeType(dbl, typeof(T));
    //            case Format.DECIMAL:
    //           cimal.TryParse(value.ToString(), out dc);
    //        urn (T)Convert.ChangeType(dc, typeof(T));
    //       fault:
    //        urn (T)Convert.ChangeType(0, typeof(T));
    //        }
    //    }
    //}
    //public enum Format
    //{
    //    INTEGER,
    // OUBLE,
    //    FLOAT,
    // ECIMAL
    //}
    //class x
    //{

    //    static void Main()
    //    {
    //        string x = "2.6";
    //        Console.WriteLine(x.ParseValue<double>(Format.DOUBLE));
    //        Console.ReadLine();
    //    }
    //}
    //class Program
    //{
    //    //My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\script\posProcessOnlineSales.txt")

    //    static void Main()
    //    {
    //        string date = "20180517";
    //        //string text = File.ReadAllText(@"\\192.168.17.8\c$\kpwslogs\WalletBatchUpload\6.0\BatchUpload_" + date + ".log.2");
    //        string text = File.ReadAllText(@"C:\\kpwslogs\ECommerce\2.0\Ecommerce_" + date + ".log");
    //        Console.WriteLine(text);
    //        Console.ReadLine();
    //    }
    //}
    //SOLID PRINCIPLES
    //Single Responsibility Principle (SRP) - SRP says "Every software module should have only one reason to change".
    //public class UserService
    //{
    // mailService _emailService;
    //    //DbContext _dbContext;
    //    //, DbContext aDbContext
    //    public UserService(EmailService aEmailService)
    //    {
    //        _emailService = aEmailService;
    //        //_dbContext = aDbContext;
    //    }
    //    public void Register(string email, string password)
    //    {
    //        //if (!_emailService.ValidateEmail(email))
    //        // hrow new ValidationException("Email is not an email");
    //        //var user = new User(email, password);
    //        //_dbContext.Save(user);
    //        _emailService.SendEmail(new MailMessage("myname@mydomain.com", email) { Subject = "Hi. How are you!" });
    //        //

    //    }

    //}
    //public class EmailService
    //{
    //    SmtpClient _smtpClient;
    //    public EmailService(SmtpClient aSmtpClient)
    //    {
    //        _smtpClient = aSmtpClient;
    //    }
    //    public virtual bool ValidateEmail(string email)
    //    {
    //   turn email.Contains("@");
    //    }
    //    public void SendEmail(MailMessage message)
    //    {
    //        _smtpClient.Send(message);
    //    }
    //}
    //O: Open/Closed Principle -The Open/closed Principle says "A software module/class is open for extension and closed for modification".
    //public abstract class Shape
    //{
    //    public abstract double Area();
    //}
    //public class Rectangle : Shape
    //{
    //    public double Height { get; set; }
    //    public double Width { get; set; }
    //    public override double Area()
    //    {
    //   turn Height * Width;
    //    }
    //}
    //public class Circle : Shape
    //{
    //    public double Radius { get; set; }
    //    public override double Area()
    //    {
    //   turn Radius * Radius * Math.PI;
    //    }
    //}
    //public class AreaCalculator
    //{
    //    public double TotalArea(Shape[] arrShapes)
    //    {
    //     ouble area = 0;
    //        foreach (var obj in arrShapes)
    //        {
    //    a += obj.Area();
    //        }
    //   turn area;
    //    }
    //}
    //public class Test
    //{
    //    public static void Main()
    //    {
    //   ctangle r = new Rectangle();
    //     .Height = 2.5;
    //     .Width = 3.6;
    //        Console.WriteLine(r.Area());
    //        Circle c = new Circle();
    //        c.Radius = 3.8;
    //        Console.WriteLine(c.Area());
    //        Shape[] obj = new Shape[] { r, c };
    //   eaCalculator area = new AreaCalculator();
    //     ouble total = area.TotalArea(obj);
    //        Console.WriteLine(total);
    //        Console.ReadLine();
    //    }
    //}
    //Liskov Substitution Principle - "you should be able to use any derived class instead of a parent class and have it behave in the same manner without modification". 
    //public class SqlFile
    //{
    //    public string FilePath { get; set; }
    //    public string FileText { get; set; }
    //    public string LoadText()
    //    {
    //   turn "";
    //        /* Code to read text from sql file */
    //    }
    //    public string SaveText()
    //    {
    //   turn "";
    //        /* Code to save text into sql file */
    //    }
    //}
    //public class ReadOnlySqlFile : SqlFile
    //{       
    //    public string LoadText()
    //    {
    //   turn "";
    //        /* Code to read text from sql file */
    //    }
    //    public void SaveText()
    //    {
    //        /* Throw an exception when app flow tries to do save. */
    //     hrow new IOException("Can't Save");
    //    }
    //}   
    //public class SqlFileManager
    //{
    //    public List<SqlFile> lstSqlFiles { get; set; }
    //    public string GetTextFromFiles()
    //    {
    //        StringBuilder sb = new StringBuilder();
    //        foreach (var objFile  in lstSqlFiles)
    //        {
    //            sb.Append(objFile .LoadText());
    //        }
    //   turn sb.ToString();
    //    }
    //    public void SaveTextIntoFiles()
    //    {
    //        foreach (var objFile in lstSqlFiles)
    //        {
    //            objFile.SaveText();
    //        }
    //    }   
    //}
    //public class Test 
    //{
    //    public static void Main() 
    //    {
    //        List<SqlFile> sql = new List<SqlFile>();
    //        sql[0].FilePath = "path";
    //        sql[0].FileText = "test";

    //        SqlFileManager sm = new SqlFileManager();
    //        sm.lstSqlFiles = sql;
    //        sm.GetTextFromFiles();
    //        sm.SaveTextIntoFiles();

    //        List<ReadOnlySqlFile> rfile = new List<ReadOnlySqlFile>();
    //     file[0].FilePath = "path";
    //     file[0].FileText = "test";
    //        sm.lstSqlFiles = rfile;

    //    }
    //}
    #region Reflection
    //Reflection objects are used for obtaining type information at runtime. 
    //The classes that give access to the metadata of a running program are in the System.Reflection namespace.
    //The System.Reflection namespace contains classes that allow you to obtain information about the application and 
    //to dynamically add types, values, and objects to the application.
    //a custom attribute BugFix to be assigned to a class and its members
    //[AttributeUsage(
    //ttributeTargets.Class |
    //ttributeTargets.Constructor |
    //ttributeTargets.Field |
    //ttributeTargets.Method |
    //ttributeTargets.Property,
    //llowMultiple = true)]

    //public class DeBugInfo : System.Attribute
    //{
    //    private int bugNo;
    //    private string developer;
    //    private string lastReview;
    //    public string message;

    //    public DeBugInfo(int bg, string dev, string d)
    //    {
    //     his.bugNo = bg;
    //     his.developer = dev;
    //     his.lastReview = d;
    //    }
    //    public int BugNo
    //    {
    //        get
    //        {
    //    urn bugNo;
    //        }
    //    }
    //    public string Developer
    //    {
    //        get
    //        {
    //    urn developer;
    //        }
    //    }
    //    public string LastReview
    //    {
    //        get
    //        {
    //    urn lastReview;
    //        }
    //    }
    //    public string Message
    //    {
    //        get
    //        {
    //    urn message;
    //        }
    //        set
    //        {
    //       ssage = value;
    //        }
    //    }
    //}
    //[DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
    //[DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]

    //class Rectangle
    //{
    //    //member variables
    //    protected double length;
    //    protected double width;

    //    public Rectangle(double l, double w)
    //    {
    //        length = l;
    //        width = w;
    //    }
    //    [DeBugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]
    //    public double GetArea()
    //    {
    //   turn length * width;
    //    }
    //    [DeBugInfo(56, "Zara Ali", "19/10/2012")]
    //    public void Display()
    //    {
    //        Console.WriteLine("Length: {0}", length);
    //        Console.WriteLine("Width: {0}", width);
    //        Console.WriteLine("Area: {0}", GetArea());
    //    }
    //}//end class Rectangle

    //class ExecuteRectangle
    //{
    //    static void Main(string[] args)
    //    {
    //   ctangle r = new Rectangle(4.5, 7.5);
    //     .Display();
    //     ype type = typeof(Rectangle);

    //        //iterating through the attribtues of the Rectangle class
    //        foreach (Object attributes in type.GetCustomAttributes(false))
    //        {
    //    ugInfo dbi = (DeBugInfo)attributes;

    //            if (null != dbi)
    //            {
    //                Console.WriteLine("Bug no: {0}", dbi.BugNo);
    //                Console.WriteLine("Developer: {0}", dbi.Developer);
    //                Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
    //                Console.WriteLine("Remarks: {0}", dbi.Message);
    //            }
    //        }

    //        //iterating through the method attribtues
    //        foreach (MethodInfo m in type.GetMethods())
    //        {

    //            foreach (Attribute a in m.GetCustomAttributes(true))
    //            {
    //        ugInfo dbi = (DeBugInfo)a;

    //                if (null != dbi)
    //                {
    //                    Console.WriteLine("Bug no: {0}, for Method: {1}", dbi.BugNo, m.Name);
    //                    Console.WriteLine("Developer: {0}", dbi.Developer);
    //                    Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
    //                    Console.WriteLine("Remarks: {0}", dbi.Message);
    //                }
    //            }
    //        }
    //        Console.ReadLine();
    //    }
    //}
    //public class HelpAttribute : System.Attribute
    //{
    //    public readonly string Url;
    //    private string topic;
    //    // Topic is a named parameter
    //    public string Topic
    //    {
    //        get
    //        {
    //    urn topic;
    //        }
    //        set
    //        {
    //         opic = value;
    //        }
    //    }
    //    // url is a positional parameter 
    //    public HelpAttribute(string url)
    //    {
    //     his.Url = url;
    //    }
    //}
    //[HelpAttribute("Information on the class MyClass")]
    //class MyClass
    //{

    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        System.Reflection.MemberInfo info = typeof(MyClass);
    //        object[] attributes = info.GetCustomAttributes(true);

    //        for (int i = 0; i < attributes.Length; i++)
    //        {
    //            System.Console.WriteLine(attributes[i]);
    //        }
    //        Console.ReadKey();
    //    }
    //}
    #endregion
    #region Attributes
    //An attribute is a declarative tag that is used to convey information to runtime about the behaviors of various elements like classes,
    //methods, structures, enumerators, assemblies etc. in your program.
    //You can add declarative information to a program by using an attribute. 
    //A declarative tag is depicted by square ([ ]) brackets placed above the element it is used for.
    //Attributes are used for adding metadata, such as compiler instruction and other information such as comments,
    //description, methods and classes to a program. 
    //The .Net Framework provides two types of attributes: the pre-defined attributes and custom built attributes.
    //  [AttributeUsage(
    //AttributeTargets.Class |
    //AttributeTargets.Constructor |
    //AttributeTargets.Field |
    //AttributeTargets.Method |
    //AttributeTargets.Property,
    //AllowMultiple = true)]
    //class x : DeBugInfo
    //{
    //    public x(int x, string z, string d) : base(x, z, d) 
    //    {

    //    }
    //}
    //public class DeBugInfo : System.Attribute
    //{
    //    private int bugNo;
    //    private string developer;
    //    private string lastReview;
    //    public string message;

    //    public DeBugInfo(int bg, string dev, string d)
    //    {
    //     his.bugNo = bg;
    //     his.developer = dev;
    //     his.lastReview = d;
    //    }
    //    public int BugNo
    //    {
    //        get
    //        {
    //    urn bugNo;
    //        }
    //    }
    //    public string Developer
    //    {
    //        get
    //        {
    //    urn developer;
    //        }
    //    }
    //    public string LastReview
    //    {
    //        get
    //        {
    //    urn lastReview;
    //        }
    //    }
    //    public string Message
    //    {
    //        get
    //        {
    //    urn message;
    //        }
    //        set
    //        {
    //       ssage = value;
    //        }
    //    }
    //}
    //[DeBugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
    //[DeBugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
    //class Rectangle
    //{
    //    //member variables
    //    protected double length;
    //    protected double width;
    //    public Rectangle(double l, double w)
    //    {
    //        length = l;
    //        width = w;
    //    }
    //    [DeBugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]

    //    public double GetArea()
    //    {
    //   turn length * width;
    //    }
    //    [DeBugInfo(56, "Zara Ali", "19/10/2012")]

    //    public void Display()
    //    {
    //        Console.WriteLine("Length: {0}", length);
    //        Console.WriteLine("Width: {0}", width);
    //        Console.WriteLine("Area: {0}", GetArea());
    //    }
    //}
    //public class MyClass
    //{
    //    [Obsolete("Don't use OldMethod, use NewMethod instead", true)]

    //    static void OldMethod()
    //    {
    //        Console.WriteLine("It is the old method");
    //    }
    //    static void NewMethod()
    //    {
    //        Console.WriteLine("It is the new method");
    //    }
    //    public static void Main()
    //    {
    //        OldMethod();
    //    }
    //}
    #endregion
    #region RegEx
    //A regular expression is a pattern that could be matched against an input text. 
    //The .Net framework provides a regular expression engine that allows such matching. 
    //A pattern consists of one or more character literals, operators, or constructs.
    //class Program
    //{
    //    private static void showMatch(string text, string expr)
    //    {
    //        Console.WriteLine("The Expression: " + expr);
    //   tchCollection mc = Regex.Matches(text, expr);

    //        foreach (Match m in mc)
    //        {
    //            Console.WriteLine(m);
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        string str = "A Thousand Splendid Suns";

    //        Console.WriteLine("Matching words that start with 'S': ");
    //        showMatch(str, @"\bS\S*");
    //        Console.ReadKey();
    //    }
    //}
    #endregion
    #region Implementing the Operator Overloading
    //You can redefine or overload most of the built-in operators available in C#. 
    //Thus a programmer can use operators with user-defined types as well.
    //Overloaded operators are functions with special names the keyword operator followed by the symbol for the operator being defined. 
    //similar to any other function, an overloaded operator has a return type and a parameter list.
    //The above function implements the addition operator (+) for a user-defined class Box.
    //It adds the attributes of two Box objects and returns the resultant Box object.
    //class Box
    //{
    //    private double length;    // Length of a box
    //    private double breadth;   // Breadth of a box
    //    private double height;    // Height of a box

    //    public double getVolume()
    //    {
    //   turn length * breadth * height;
    //    }
    //    public void setLength(double len)
    //    {
    //        length = len;
    //    }
    //    public void setBreadth(double bre)
    //    {
    //   eadth = bre;
    //    }
    //    public void setHeight(double hei)
    //    {
    //        height = hei;
    //    }

    //    // Overload + operator to add two Box objects.
    //    public static Box operator +(Box b, Box c)
    //    {
    //     ox box = new Box();
    //     ox.length = b.length + c.length;
    //     ox.breadth = b.breadth + c.breadth;
    //     ox.height = b.height + c.height;
    //   turn box;
    //    }
    //    public static bool operator ==(Box lhs, Box rhs)
    //    {
    //     ool status = false;
    //        if (lhs.length == rhs.length && lhs.height == rhs.height
    //           && lhs.breadth == rhs.breadth)
    //        {

    //            status = true;
    //        }
    //   turn status;
    //    }
    //    public static bool operator !=(Box lhs, Box rhs)
    //    {
    //     ool status = false;

    //        if (lhs.length != rhs.length || lhs.height != rhs.height ||
    //           lhs.breadth != rhs.breadth)
    //        {

    //            status = true;
    //        }
    //   turn status;
    //    }
    //    public static bool operator <(Box lhs, Box rhs)
    //    {
    //     ool status = false;

    //        if (lhs.length < rhs.length && lhs.height < rhs.height
    //           && lhs.breadth < rhs.breadth)
    //        {

    //            status = true;
    //        }
    //   turn status;
    //    }
    //    public static bool operator >(Box lhs, Box rhs)
    //    {
    //     ool status = false;

    //        if (lhs.length > rhs.length && lhs.height >
    //        hs.height && lhs.breadth > rhs.breadth)
    //        {

    //            status = true;
    //        }
    //   turn status;
    //    }
    //    public static bool operator <=(Box lhs, Box rhs)
    //    {
    //     ool status = false;

    //        if (lhs.length <= rhs.length && lhs.height
    //           <= rhs.height && lhs.breadth <= rhs.breadth)
    //        {

    //            status = true;
    //        }
    //   turn status;
    //    }
    //    public static bool operator >=(Box lhs, Box rhs)
    //    {
    //     ool status = false;

    //        if (lhs.length >= rhs.length && lhs.height
    //           >= rhs.height && lhs.breadth >= rhs.breadth)
    //        {

    //            status = true;
    //        }
    //   turn status;
    //    }
    //    public override string ToString()
    //    {
    //   turn String.Format("({0}, {1}, {2})", length, breadth, height);
    //    }
    //}
    //class Tester
    //{
    //    static void Main(string[] args)
    //    {
    //     ox Box1 = new Box();   // Declare Box1 of type Box
    //     ox Box2 = new Box();   // Declare Box2 of type Box
    //     ox Box3 = new Box();   // Declare Box3 of type Box
    //     ox Box4 = new Box();
    //     ouble volume = 0.0;    // Store the volume of a box here

    //        // box 1 specification
    //     ox1.setLength(6.0);
    //     ox1.setBreadth(7.0);
    //     ox1.setHeight(5.0);

    //        // box 2 specification
    //     ox2.setLength(12.0);
    //     ox2.setBreadth(13.0);
    //     ox2.setHeight(10.0);

    //        //displaying the Boxes using the overloaded ToString():
    //        Console.WriteLine("Box 1: {0}", Box1.ToString());
    //        Console.WriteLine("Box 2: {0}", Box2.ToString());

    //        // volume of box 1
    //        volume = Box1.getVolume();
    //        Console.WriteLine("Volume of Box1 : {0}", volume);

    //        // volume of box 2
    //        volume = Box2.getVolume();
    //        Console.WriteLine("Volume of Box2 : {0}", volume);

    //        // Add two object as follows:
    //     ox3 = Box1 + Box2;
    //        Console.WriteLine("Box 3: {0}", Box3.ToString());

    //        // volume of box 3
    //        volume = Box3.getVolume();
    //        Console.WriteLine("Volume of Box3 : {0}", volume);

    //        //comparing the boxes
    //        if (Box1 > Box2)
    //            Console.WriteLine("Box1 is greater than Box2");
    //     lse
    //            Console.WriteLine("Box1 is not greater than Box2");

    //        if (Box1 < Box2)
    //            Console.WriteLine("Box1 is less than Box2");
    //     lse
    //            Console.WriteLine("Box1 is not less than Box2");

    //        if (Box1 >= Box2)
    //            Console.WriteLine("Box1 is greater or equal to Box2");
    //     lse
    //            Console.WriteLine("Box1 is not greater or equal to Box2");

    //        if (Box1 <= Box2)
    //            Console.WriteLine("Box1 is less or equal to Box2");
    //     lse
    //            Console.WriteLine("Box1 is not less or equal to Box2");

    //        if (Box1 != Box2)
    //            Console.WriteLine("Box1 is not equal to Box2");
    //     lse
    //            Console.WriteLine("Box1 is not greater or equal to Box2");
    //     ox4 = Box3;

    //        if (Box3 == Box4)
    //            Console.WriteLine("Box3 is equal to Box4");
    //     lse
    //            Console.WriteLine("Box3 is not equal to Box4");

    //        Console.ReadKey();
    //    }
    //}
    #endregion
    //polymorphism/late binding/dynamic/overiding and inheritance
    //class Shape
    //{
    //    protected int width, height;

    //    public Shape(int a = 0, int b = 0)
    //    {
    //        width = a;
    //        height = b;
    //    }
    //    public virtual int area()
    //    {
    //        Console.WriteLine("Parent class area :");
    //   turn 0;
    //    }
    //}
    //class Rectangle : Shape
    //{
    //    public Rectangle(int a = 0, int b = 0)
    //        : base(a, b)
    //    {

    //    }
    //    public override int area()
    //    {
    //        Console.WriteLine("Rectangle class area :");
    //   turn (width * height);
    //    }
    //}
    //class Triangle : Shape
    //{
    //    public Triangle(int a = 0, int b = 0)
    //        : base(a, b)
    //    {
    //    }
    //    public override int area()
    //    {
    //        Console.WriteLine("Triangle class area :");
    //   turn (width * height / 2);
    //    }
    //}
    //class Caller
    //{
    //    public void CallArea(Shape sh)
    //    {
    //        int a;
    //      = sh.area();
    //        Console.WriteLine("Area: {0}", a);
    //    }
    //}
    //class Tester
    //{
    //    static void Main(string[] args)
    //    {
    //        Caller c = new Caller();
    //   ctangle r = new Rectangle(10, 7);
    //   iangle t = new Triangle(10, 5);

    //        c.CallArea(r);
    //        c.CallArea(t);
    //        Console.ReadKey();
    //    }
    //}

    //class Program
    //{
    //    public enum DayofWeek
    //    {
    //        Sunday = 1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    //    }
    //    static void Main(string[] args)
    //    {
    //        string[] values = Enum.GetNames(typeof(DayofWeek));
    //        int total = 0;
    //        foreach (string s in values)
    //        {
    //            Console.WriteLine(s);
    //         otal++;
    //        }
    //        Console.WriteLine("Total values in enum type is : {0}", total);
    //        Console.WriteLine();
    //        int[] n = (int[])Enum.GetValues(typeof(DayofWeek));
    //        foreach (int x in n)
    //        {
    //            Console.WriteLine(x);
    //        }
    //        Console.ReadLine();
    //    }
    //}  
    #region Aggregation
    //Composition and Aggregation both are subset of Association. 
    //Aggregation differs from composition in that it does not enforce ownership and 
    //the aggregate (whole) object does not take responsibility for the creation and destruction of components.
    //Aggregation
    //class Network
    //{
    //    private readonly List<Router> _routers = new List<Router>();
    //    private readonly List<NetworkSwitch> _networkSwitches = new List<NetworkSwitch>();
    //    private readonly List<NetworkAdpater> _networkAdapters = new List<NetworkAdpater>();
    //    public string NetworkName
    //    {
    //        get;
    //        set;
    //    }
    //    public void AddNetworkSwitch(NetworkSwitch networkSwitch)
    //    {
    //        _networkSwitches.Add(networkSwitch);
    //        Console.WriteLine("Switch {0} Added to the Network {1} ", networkSwitch.NetworkSwitchId, NetworkName);
    //    }
    //    public void RemoveNetworkSwitch(NetworkSwitch networkSwitch)
    //    {
    //        _networkSwitches.Remove(networkSwitch);
    //        Console.WriteLine("Switch {0} removed from the Network {1} ", networkSwitch.NetworkSwitchId, NetworkName);
    //    }
    //    public void AddNetworkAdapter(NetworkAdpater networkAdpater)
    //    {
    //        _networkAdapters.Add(networkAdpater);
    //        Console.WriteLine("Switch {0} Added to the Network {1} ", networkAdpater.NetworkAdpaterId, NetworkName);
    //    }
    //    public void RemoveNetworkAdpater(NetworkAdpater networkAdpater)
    //    {
    //        _networkAdapters.Remove(networkAdpater);
    //        Console.WriteLine("Switch {0} removed from the Network {1}", networkAdpater.NetworkAdpaterId, NetworkName);
    //    }
    //    public void AddRouter(Router router)
    //    {
    //        _routers.Add(router);
    //        Console.WriteLine("Router {0} Added to the Network {1} ", router.RouterId, NetworkName);
    //    }
    //    public void RemoveRouter(Router router)
    //    {
    //        _routers.Remove(router);
    //        Console.WriteLine("Router {0} removed from the Network {1}", router.RouterId, NetworkName);
    //    }
    //    public void PrintNetworkInformation()
    //    {
    //        foreach (var networkAdpater in _networkAdapters)
    //        {
    //            Console.WriteLine("{0} has a adapter {1}", NetworkName, networkAdpater.NetworkAdpaterId, NetworkName);
    //        }
    //        foreach (var networkSwitch in _networkSwitches)
    //        {
    //            Console.WriteLine("{0} has a switch {1}", NetworkName, networkSwitch.NetworkSwitchId, NetworkName);
    //        }
    //        foreach (var router in _routers)
    //        {
    //            Console.WriteLine("{0} has a router {1}", NetworkName, router.RouterId, NetworkName);
    //        }
    //    }
    //}
    //class NetworkSwitch
    //{
    //    public string NetworkSwitchId
    //    {
    //        get;
    //        set;
    //    }
    //    public string Description
    //    {
    //        get;
    //        set;
    //    }
    //}
    //class NetworkAdpater
    //{
    //    public string NetworkAdpaterId
    //    {
    //        get;
    //        set;
    //    }
    //    public string Description
    //    {
    //        get;
    //        set;
    //    }
    //}
    //class Router
    //{
    //    public string RouterId
    //    {
    //        get;
    //        set;
    //    }
    //    public string Description
    //    {
    //        get;
    //        set;
    //    }
    //}
    #endregion
    #region composite
    //Composite/ Composition
    //    public class Article {  
    //    private readonly List < Section > _sections = new List < Section > ();  
    //    public Article() {  
    //        _sections.Add(new Section() {  
    //            Heading = "Heading 1", Paragraph = "Text Goes Here......."  
    //        });  
    //        Console.WriteLine("Article Created Successfully with one default section.");  
    //    }  
    //    public void AddSection() {  
    //        Section section = new Section() {  
    //            Heading = "Heading 1", Paragraph = "Text Goes Here......."  
    //        };  
    //        _sections.Add(section);  
    //        Console.WriteLine("Section Added Successfully. {0} Section Added in an Article ", _sections.Count);  
    //    }  
    //    class Section {  
    //        public string Heading {  
    //            get;  
    //            set;  
    //        }  
    //        public string Paragraph {  
    //            get;  
    //            set;  
    //        }  
    //    }  
    //}  

    //class Program
    //{
    //    static string CollapseSpaces(string value)
    //    {
    //        //Regex.Replace(rootObject.products[x].body_html, "<.*?>", string.Empty);
    //   turn Regex.Replace(value, @"\s+", " ").Replace("<.*?>", string.Empty);
    //    }

    //    static void Main()
    //    {
    //        string value = "Dot     Net     Perls <strong><p font=></strong>";
    //        string removeTags = Regex.Replace(value,"<.*?>", string.Empty);
    //        string removeSpaces = Regex.Replace(removeTags, @"\s+", " ");
    //        Console.WriteLine(removeSpaces);

    //    }
    //}
    //public delegate string MyDel(string str);
    //class EventProgram 
    //{
    // vent MyDel MyEvent;
    //    public EventProgram() 
    //    {
    //     his.MyEvent += new MyDel(this.WelcomeUser);
    //    }
    //    public string WelcomeUser(string username)
    //    {
    //   turn "Hello " + username;
    //    }
    //    static void Main() 
    //    {
    //     ventProgram ep = new EventProgram();
    //        string result = ep.MyEvent("Stephen");
    //        Console.WriteLine(result);
    //    }
    //}
    #endregion
    #region class vs struct
    //Structures are value types and the classes are reference types. Before proceeding to the next point, let explain the difference between the two types. Imagine this is the memory within the machine,
    //Classes are usually used for large amounts of data, whereas structs are usually used for smaller amounts of data.
    //Classes can be inherited whereas structures not.
    //A structure couldn't be null like a class.
    //A structure couldn't have a destructor such as a class.
    //A structure can't be abstract, a class can.
    //You cannot override any methods within a structure except the following belonging to the type object
    //Equals() GetHashCode() GetType() ToString()
    //Declared events within a class are automatically locked and then they are thread safe, in contrast to the structure type where events can't be locked.
    //A structure must always have the default parameter less constructor defined as public but a class might have one, so you can't define a private parameter-less constructor as in the following,
    //A static constructor is triggered in the case of a class but not in the case of a structure as in the following,
    //Fields are automatically initialized with classes to 0/false/null wheatheras strucutres are not
    //Fields can't be directley instantiated within structures but classes allow such operations
    //1. The structures are value types and the classes are reference types.So object of structure store in stack exactly like any other value type like an Integer, a double but object of class store in heap
    //.Your can assigned null to class variable but you can't assigned null value to structure variable
    //2. Class support Inheritance but struct does not support so access modifier of a member of a struct cannot be protected or protected internal
    //3. You can use Destructor in a class but You can't use it in a structure 
    //4. When passing a class to a method, it is passed by reference. When passing a struct to a method, it's passed by value instead of as a reference.

    #endregion
    #region singleton
    //The singleton pattern is one of the best-known patterns in software engineering.
    //Essentially, a singleton is a class which only allows a single instance of itself to be created, and usually gives simple access to that instance.
    //Most commonly, singletons don't allow any parameters to be specified when creating the instance - 
    //as otherwise a second request for an instance but with a different parameter could be problematic! 
    //(If the same instance should be accessed for all requests with the same parameter, the factory pattern is more appropriate.) 
    //This article deals only with the situation where no parameters are required.
    //Typically a requirement of singletons is that they are created lazily - i.e. that the instance isn't created until it is first needed.
    //There are various different ways of implementing the singleton pattern in C#.
    //I shall present them here in reverse order of elegance, starting with the most commonly seen,
    //which is not thread-safe, and working up to a fully lazily-loaded, thread-safe, simple and highly performant version.
    //All these implementations share four common characteristics, however:
    //  single constructor, which is private and parameterless. 
    //This prevents other classes from instantiating it (which would be a violation of the pattern). 
    //Note that it also prevents subclassing - if a singleton can be subclassed once, it can be subclassed twice,
    //and if each of those subclasses can create an instance, the pattern is violated.
    //The factory pattern can be used if you need a single instance of a base type, but the exact type isn't known until runtime.
    // he class is sealed. This is unnecessary, strictly speaking, due to the above point, but may help the JIT to optimise things more.
    //  static variable which holds a reference to the single created instance, if any.
    //  public static means of getting the reference to the single created instance, creating one if necessary.
    //Note that all of these implementations also use a public static property Instance as the means of accessing the instance. 
    //In all cases, the property could easily be converted to a method, with no impact on thread-safety or performance. 

    //not quite as lazy, but thread-safe without using locks
    //sealed class Singleton
    //{
    //    private static Singleton instance = new Singleton();
    //    static Singleton() { }

    //    public static Singleton Instance
    //    {
    //        get { return instance; }
    //    }
    //}
    //class Program
    //{
    //private Object thisLock = new object();
    //int salary;
    //Random r = new Random();
    //public Program(int initial)
    //{
    //    salary = initial;
    //}
    //int Withraw(int amount)
    //{
    //    if (salary < 0)
    //    {
    //     hrow new Exception("Negative Balance");
    //    }
    //    lock (thisLock)
    //    {
    //        if (salary >= amount)
    //        {
    //            Console.WriteLine("Salaray before Withrawal: " + salary);
    //            Console.WriteLine("Amount to Withdraw: " + amount);
    //            salary = salary - amount;
    //            Console.WriteLine("Salary after withrawal: " + salary);
    //    urn amount;
    //        }
    //     lse
    //        {
    //    urn 0;
    //        }
    //    }
    //}
    //public void DoTransaction() 
    //{
    //    for (int i = 0; i < 100; i++)
    //    {
    //        Withraw(r.Next(1,100));
    //    }
    //}

    //static void Main() 
    //{
    // hread[] threads = new Thread[10];
    //    Program pr = new Program(1000);
    //    for (int i = 0; i < 10; i++)
    //    {
    //     hread t = new Thread(new ThreadStart(pr.DoTransaction));
    //     hreads[i] = t;
    //    }
    //    for (int i = 0; i < 10; i++)
    //    {
    //     hreads[i].Start();
    //    }
    //    Console.ReadLine();
    //}
    //static void Main()
    //{
    //    Calculate.Instance.ValueOne = 10.5;

    //    Calculate.Instance.ValueTwo = 5.5;

    //    Console.WriteLine("Addition : " + Calculate.Instance.Addition());

    //    Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());

    //    Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());

    //    Console.WriteLine("Division : " + Calculate.Instance.Division());



    //    Console.WriteLine("\n----------------------\n");



    //    Calculate.Instance.ValueTwo = 10.5;

    //    Console.WriteLine("Addition : " + Calculate.Instance.Addition());

    //    Console.WriteLine("Subtraction : " + Calculate.Instance.Subtraction());

    //    Console.WriteLine("Multiplication : " + Calculate.Instance.Multiplication());

    //    Console.WriteLine("Division : " + Calculate.Instance.Division());



    //    Console.ReadLine();
    //}
    //}
    //As hinted at before, the above is not thread-safe.
    //Two different threads could both have evaluated the test if (instance==null) and found it to be true,
    //then both create instances, which violates the singleton pattern.
    //Note that in fact the instance may already have been created before the expression is evaluated,
    //but the memory model doesn't guarantee that the new value of instance will be seen by other threads unless suitable memory barriers have been passed. 
    //Second version - simple thread-safety
    //sealed class Calculate
    //{
    //    private Calculate() { }
    //    private static readonly object padlock = new object();
    //    private static Calculate instance = null;
    //    public static Calculate Instance
    //    {
    //        get
    //        {
    //            lock (padlock)
    //            {
    //                if (instance == null)
    //                {
    //                    instance = new Calculate();
    //                }
    //        urn instance;
    //            }
    //        }
    //    }
    //    public double ValueOne { get; set; }

    //    public double ValueTwo { get; set; }



    //    public double Addition()
    //    {

    //   turn ValueOne + ValueTwo;

    //    }



    //    public double Subtraction()
    //    {

    //   turn ValueOne - ValueTwo;

    //    }



    //    public double Multiplication()
    //    {

    //   turn ValueOne * ValueTwo;

    //    }



    //    public double Division()
    //    {

    //   turn ValueOne / ValueTwo;

    //    }
    //}
    //public sealed class Prac
    //{
    //    public Prac()
    //    {

    //    }
    //    private static readonly object padlck = new object();

    //    private static Prac instance = null;
    //    public static Prac Instance
    //    {
    //        get
    //        {
    //            lock (padlck)
    //            {
    //                if (instance == null)
    //                {
    //                    instance = new Prac();
    //                }
    //        urn instance;
    //            }
    //        }
    //    }
    //}

    #endregion
    #region Pixsell Hashing
    //public class Covert
    //{
    //    #region hash code
    //    //static void DBL_INT_ADD(ref uint a, ref uint b, uint c)
    //    //{
    //    //    if (a > 0xffffffff - c) ++b; a += c;
    //    //}

    //    //static uint ROTLEFT(uint a, byte b)
    //    //{
    //    // eturn ((a << b) | (a >> (32 - b)));
    //    //}

    //    //static uint ROTRIGHT(uint a, byte b)
    //    //{
    //    // eturn (((a) >> (b)) | ((a) << (32 - (b))));
    //    //}

    //    //static uint CH(uint x, uint y, uint z)
    //    //{
    //    // eturn (((x) & (y)) ^ (~(x) & (z)));
    //    //}

    //    //static uint MAJ(uint x, uint y, uint z)
    //    //{
    //    // eturn (((x) & (y)) ^ ((x) & (z)) ^ ((y) & (z)));
    //    //}

    //    //static uint EP0(uint x)
    //    //{
    //    // eturn (ROTRIGHT(x, 2) ^ ROTRIGHT(x, 13) ^ ROTRIGHT(x, 22));
    //    //}

    //    //static uint EP1(uint x)
    //    //{
    //    // eturn (ROTRIGHT(x, 6) ^ ROTRIGHT(x, 11) ^ ROTRIGHT(x, 25));
    //    //}

    //    //static uint SIG0(uint x)
    //    //{
    //    // eturn (ROTRIGHT(x, 7) ^ ROTRIGHT(x, 18) ^ ((x) >> 3));
    //    //}

    //    //static uint SIG1(uint x)
    //    //{
    //    // eturn (ROTRIGHT(x, 17) ^ ROTRIGHT(x, 19) ^ ((x) >> 10));
    //    //}

    //    //struct SHA256_CTX
    //    //{
    //    //    public byte[] data;
    //    //    public uint datalen;
    //    //    public uint[] bitlen;
    //    //    public uint[] state;
    //    //}

    //    //static uint[] k = {
    //    //    0x428a2f98,0x71374491,0xb5c0fbcf,0xe9b5dba5,0x3956c25b,0x59f111f1,0x923f82a4,0xab1c5ed5,
    //    //    0xd807aa98,0x12835b01,0x243185be,0x550c7dc3,0x72be5d74,0x80deb1fe,0x9bdc06a7,0xc19bf174,
    //    //    0xe49b69c1,0xefbe4786,0x0fc19dc6,0x240ca1cc,0x2de92c6f,0x4a7484aa,0x5cb0a9dc,0x76f988da,
    //    //    0x983e5152,0xa831c66d,0xb00327c8,0xbf597fc7,0xc6e00bf3,0xd5a79147,0x06ca6351,0x14292967,
    //    //    0x27b70a85,0x2e1b2138,0x4d2c6dfc,0x53380d13,0x650a7354,0x766a0abb,0x81c2c92e,0x92722c85,
    //    //    0xa2bfe8a1,0xa81a664b,0xc24b8b70,0xc76c51a3,0xd192e819,0xd6990624,0xf40e3585,0x106aa070,
    //    //    0x19a4c116,0x1e376c08,0x2748774c,0x34b0bcb5,0x391c0cb3,0x4ed8aa4a,0x5b9cca4f,0x682e6ff3,
    //    //    0x748f82ee,0x78a5636f,0x84c87814,0x8cc70208,0x90befffa,0xa4506ceb,0xbef9a3f7,0xc67178f2
    //    //};

    //    //static void SHA256Transform(ref SHA256_CTX ctx, byte[] data)
    //    //{
    //    //    uint a, b, c, d, e, f, g, h, i, j, t1, t2;
    //    //    uint[] m = new uint[64];

    //    //    for (i = 0, j = 0; i < 16; ++i, j += 4)
    //    //     [i] = (uint)((data[j] << 24) | (data[j + 1] << 16) | (data[j + 2] << 8) | (data[j + 3]));

    //    //    for (; i < 64; ++i)
    //    //     [i] = SIG1(m[i - 2]) + m[i - 7] + SIG0(m[i - 15]) + m[i - 16];

    //    //  = ctx.state[0];
    //    //  = ctx.state[1];
    //    //    c = ctx.state[2];
    //    //  = ctx.state[3];
    //    //  = ctx.state[4];
    //    //    f = ctx.state[5];
    //    //    g = ctx.state[6];
    //    //    h = ctx.state[7];

    //    //    for (i = 0; i < 64; ++i)
    //    //    {
    //    //     1 = h + EP1(e) + CH(e, f, g) + k[i] + m[i];
    //    //     2 = EP0(a) + MAJ(a, b, c);
    //    //        h = g;
    //    //        g = f;
    //    //        f = e;
    //    //      = d + t1;
    //    //      = c;
    //    //        c = b;
    //    //      = a;
    //    //      = t1 + t2;
    //    //    }

    //    //    ctx.state[0] += a;
    //    //    ctx.state[1] += b;
    //    //    ctx.state[2] += c;
    //    //    ctx.state[3] += d;
    //    //    ctx.state[4] += e;
    //    //    ctx.state[5] += f;
    //    //    ctx.state[6] += g;
    //    //    ctx.state[7] += h;
    //    //}

    //    //static void SHA256Init(ref SHA256_CTX ctx)
    //    //{
    //    //    ctx.datalen = 0;
    //    //    ctx.bitlen[0] = 0;
    //    //    ctx.bitlen[1] = 0;
    //    //    ctx.state[0] = 0x6a09e667;
    //    //    ctx.state[1] = 0xbb67ae85;
    //    //    ctx.state[2] = 0x3c6ef372;
    //    //    ctx.state[3] = 0xa54ff53a;
    //    //    ctx.state[4] = 0x510e527f;
    //    //    ctx.state[5] = 0x9b05688c;
    //    //    ctx.state[6] = 0x1f83d9ab;
    //    //    ctx.state[7] = 0x5be0cd19;
    //    //}

    //    //static void SHA256Update(ref SHA256_CTX ctx, byte[] data, uint len)
    //    //{
    //    //    for (uint i = 0; i < len; ++i)
    //    //    {
    //    //        ctx.data[ctx.datalen] = data[i];
    //    //        ctx.datalen++;

    //    //        if (ctx.datalen == 64)
    //    //        {
    //    //            SHA256Transform(ref ctx, ctx.data);
    //    //       L_INT_ADD(ref ctx.bitlen[0], ref ctx.bitlen[1], 512);
    //    //            ctx.datalen = 0;
    //    //        }
    //    //    }
    //    //}

    //    //static void SHA256Final(ref SHA256_CTX ctx, byte[] hash)
    //    //{
    //    //    uint i = ctx.datalen;

    //    //    if (ctx.datalen < 56)
    //    //    {
    //    //        ctx.data[i++] = 0x80;

    //    //        while (i < 56)
    //    //            ctx.data[i++] = 0x00;
    //    //    }
    //    // lse
    //    //    {
    //    //        ctx.data[i++] = 0x80;

    //    //        while (i < 64)
    //    //            ctx.data[i++] = 0x00;

    //    //        SHA256Transform(ref ctx, ctx.data);
    //    //    }

    //    // BL_INT_ADD(ref ctx.bitlen[0], ref ctx.bitlen[1], ctx.datalen * 8);
    //    //    ctx.data[63] = (byte)(ctx.bitlen[0]);
    //    //    ctx.data[62] = (byte)(ctx.bitlen[0] >> 8);
    //    //    ctx.data[61] = (byte)(ctx.bitlen[0] >> 16);
    //    //    ctx.data[60] = (byte)(ctx.bitlen[0] >> 24);
    //    //    ctx.data[59] = (byte)(ctx.bitlen[1]);
    //    //    ctx.data[58] = (byte)(ctx.bitlen[1] >> 8);
    //    //    ctx.data[57] = (byte)(ctx.bitlen[1] >> 16);
    //    //    ctx.data[56] = (byte)(ctx.bitlen[1] >> 24);
    //    //    SHA256Transform(ref ctx, ctx.data);

    //    //    for (i = 0; i < 4; ++i)
    //    //    {
    //    //        hash[i] = (byte)(((ctx.state[0]) >> (int)(24 - i * 8)) & 0x000000ff);
    //    //        hash[i + 4] = (byte)(((ctx.state[1]) >> (int)(24 - i * 8)) & 0x000000ff);
    //    //        hash[i + 8] = (byte)(((ctx.state[2]) >> (int)(24 - i * 8)) & 0x000000ff);
    //    //        hash[i + 12] = (byte)((ctx.state[3] >> (int)(24 - i * 8)) & 0x000000ff);
    //    //        hash[i + 16] = (byte)((ctx.state[4] >> (int)(24 - i * 8)) & 0x000000ff);
    //    //        hash[i + 20] = (byte)((ctx.state[5] >> (int)(24 - i * 8)) & 0x000000ff);
    //    //        hash[i + 24] = (byte)((ctx.state[6] >> (int)(24 - i * 8)) & 0x000000ff);
    //    //        hash[i + 28] = (byte)((ctx.state[7] >> (int)(24 - i * 8)) & 0x000000ff);
    //    //    }
    //    //}

    //    //static string SHA256(string data)
    //    //{
    //    //    SHA256_CTX ctx = new SHA256_CTX();
    //    //    ctx.data = new byte[64];
    //    //    ctx.bitlen = new uint[2];
    //    //    ctx.state = new uint[8];

    //    // yte[] hash = new byte[32];
    //    //    string hashStr = string.Empty;

    //    //    SHA256Init(ref ctx);
    //    //    SHA256Update(ref ctx, Encoding.Default.GetBytes(data), (uint)data.Length);
    //    //    SHA256Final(ref ctx, hash);

    //    //    for (int i = 0; i < 32; i++)
    //    //    {
    //    //        hashStr += string.Format("{0:X2}", hash[i]);
    //    //    }

    //    // eturn hashStr;
    //    //}
    //    #endregion
    //    //        {
    //    //    "username":"PIXSELL_709!$T!$",
    //    //    "password":"Pi#$e77L09!STi($",
    //    //    "key":"XS472fngPQ9vtyrGerTbgKh1Ew0jajBvR3eFiYGH",
    //    //    "token":"P!X$#||4LadengSPQO9vtyZXSDgKhaseqajBvR3eFiYGH",
    //    //    "timestamp":"20190311132704",
    //    //    "data":{
    //    //        "pickupLocation":"ML",
    //    //        "contactPerson":"Steph",
    //    //        "phoneNo":"7778888",
    //    //        "pickupAddress":"ML NRA",
    //    //        "postCode":"CEB01",
    //    //        "ItemType":"LED TV",
    //    //        "merchantRefNo":"PX00001",
    //    //        "merchantRefNo2":"PX00002",
    //    //        "consigneeName":"Mark",
    //    //        "consigneeAddress1":"Toledo",
    //    //        "consigneeAddress2":"Lahug",
    //    //        "consigneeProvince":"Cebu",
    //    //        "consigneeCity":"Cebu",
    //    //        "consigneeCountry":"Philppines",
    //    //        "consigneeEmail":"stephen.asimudin@mlhuillier1.com",
    //    //        "consigneeContact":"09165904531",
    //    //        "handlingInstruction":"handle with care",
    //    //        "quantity":1,
    //    //        "length":1.0,
    //    //        "width":1.0,
    //    //        "height":1.0,
    //    //        "weight":1.0,
    //    //        "volumetricWeight":1.0,
    //    //        "price":1,
    //    //        "declaredValue":1,
    //    //        "paymenttype":"Wallet",
    //    //        "codamount":0,
    //    //        "currency":"Peso",
    //    //        "waybillDate":"03/11/2019 13:05"
    //    //    }

    //    //}
    //    //    #region hash Pixsell
    //    //public static void Main()
    //    //{
    //    //    //"20180522082427";
    //    // ateTime dt = DateTime.Now;

    //    //    string username = "PIXSELL_709!$T!$";
    //    //    string password = "Pi#$e77L09!STi($";
    //    //    string apikey = "XS472fngPQ9vtyrGerTbgKh1Ew0jajBvR3eFiYGH";

    //    //    string timestamp = dt.ToString("yyyyMMddHHmmss");
    //    //    string toHash = String.Format("{0}{1}{2}{3}", username, password, "20180525173919", apikey);


    //    //    //string sha256 = SHA256(toHash);
    //    //    //Console.WriteLine(sha256);
    //    //    //0. 
    //    //    //Create a SHA256   
    //    //    using (SHA256 sha256Hash = SHA256.Create())
    //    //    {
    //    //        // ComputeHash - returns byte array  
    //    //     yte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(toHash));

    //    //        // Convert byte array to a string   
    //    //        StringBuilder builder = new StringBuilder();
    //    //        for (int i = 0; i < bytes.Length; i++)
    //    //        {
    //    //         uilder.Append(bytes[i].ToString("x2"));
    //    //        }
    //    //        Console.WriteLine(builder.ToString());
    //    //    }
    //    //}

    //    //1. 648083F68E389A146B596CFC6C9B946AA77A0C50867E4BB65DDEE6752D288B44
    //    //SHA256 sha256 = SHA256Managed.Create();
    //    //byte[] bytes = Encoding.UTF8.GetBytes(toHash);
    //    //byte[] hash = sha256.ComputeHash(bytes);
    //    //string result =  GetStringFromHash(hash);

    //    //2. df8dbb7c17947e4186f0df6026173abff77b0e030031364cab6df89154c91678
    //    //var crypt = new System.Security.Cryptography.SHA256Managed();
    //    //var hash = new System.Text.StringBuilder();
    //    //byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(toHash));
    //    //foreach (byte theByte in crypto)
    //    //{
    //    //    hash.Append(theByte.ToString("x2"));
    //    //}


    //    //3. c091fe67717f004f3f7b4e57faf252c30f6c50b29937cb71eb863c0e5e4ab441
    //    //StringBuilder Sb = new StringBuilder();

    //    //using (SHA256 hash = SHA256Managed.Create())
    //    //{
    //    // ncoding enc = Encoding.UTF8;
    //    // yte[] result = hash.ComputeHash(enc.GetBytes(toHash));

    //    //    foreach (Byte b in result)
    //    //        Sb.Append(b.ToString("x2"));
    //    //}

    //    //4.
    //    //System.Security.Cryptography.SHA256 sha256 = new System.Security.Cryptography.SHA256Managed();
    //    //byte[] sha256Bytes = System.Text.Encoding.Default.GetBytes(toHash);
    //    //byte[] cryString = sha256.ComputeHash(sha256Bytes);
    //    //string sha256Str = string.Empty;
    //    //for (int i = 0; i < cryString.Length; i++)
    //    //{
    //    //    sha256Str += cryString[i].ToString("X");
    //    //}



    //    //DateTime date = Convert.ToDateTime("2018-05-11 09:33:20");
    //    //string year = date.ToString("yyyy");
    //    //string month = date.ToString("MM");
    //    //string day = date.ToString("dd");
    //    //string newdate = date.ToString("yyyy-MM-dd");
    //    //Console.WriteLine(date);
    //    //Console.WriteLine(year);
    //    //Console.WriteLine(month);
    //    //double count = Math.Ceiling(54.25);
    //    //Console.WriteLine(count);
    //    //Console.ReadLine();

    //    //}
    //    //    #endregion
    //    public static void Main() 
    //    {

    //        string key = sha256_hash("PIXSELL_709!$T!$" + "Pi#$e77L09!STi($" + "20190312141815" + "XS472fngPQ9vtyrGerTbgKh1Ew0jajBvR3eFiYGH");
    //        Console.WriteLine("");
    //        Console.ReadLine();
    //    }
    //    public static String sha256_hash(String value)
    //    {
    //        using (SHA256 sha256Hash = SHA256.Create())
    //        {
    //            // ComputeHash - returns byte array  
    //            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(value));

    //            // Convert byte array to a string   
    //            StringBuilder builder = new StringBuilder();
    //            for (int i = 0; i < bytes.Length; i++)
    //            {
    //                builder.Append(bytes[i].ToString("x2"));
    //            }
    //            return builder.ToString();
    //        }
    //    }


    //}
    #endregion
    #region crypto
    //internal class Cryptograph
    //{
    //    private AESEncryption Crypto;
    //    public Cryptograph()
    //    {

    //        Crypto = new AESEncryption();
    //    }
    //    protected internal string CryptoKey = "kWuYDGElyQDpGKM9";

    //    protected internal string Decrypt(string EncryptedText, string key)
    //    {
    //        string DecryptedText = Crypto.AESDecrypt(EncryptedText, key);
    //        return DecryptedText;
    //    }

    //}
    //public class Sample
    //{

    //    public static void Main()
    //    {
    //        Cryptograph crypt = new Cryptograph();
    //        string pass = "aZQe5BTGRl8JwehRN8Q60nOJoT0oe2sgWcLNwxTrdjY=";
    //        //string pass = "0aOue4utPxFq2tVDTyMnZ5w9nUoBEv4E3eag/yrMzPg=";

    //        String decryptedPassword = crypt.Decrypt(pass, crypt.CryptoKey);
    //        Console.WriteLine(decryptedPassword);
    //        Console.ReadLine();
    //    }

    //}
    #endregion
    #region linqwallet
    //public class Sample 
    //{
    //    public static void Main() 
    //    {
    //        string final = string.Empty;
    //        string lblOrderNo = "MLo-1783";
    //        string OrderDate = "04/16/2018 2:56 PM";
    //        string txtAddress = "COR. BORROMEO COLON STS., CEBU CITY";
    //        string lblFirstname = "Joenalyn Molina";
    //        string txtItemDescription = "BOSCH DRILL W/ BOX";
    //        string ItemQuantity = "1";
    //        string lblPayable = "1440.00";
    //        string txtAmount = "0";
    //        string lblChange = "0";

    //          string values  = "";
    //            values = values + "4" + "xx|xx";
    //            values = values + lblOrderNo.ToString() + "xx|xx";
    //            values = values + OrderDate + "xx|xx";
    //            values = values + txtAddress.ToString() + "xx|xx";
    //            values = values + lblFirstname.ToString() + "xx|xx";
    //            values = values + txtItemDescription.ToString() + "xx|xx";
    //            values = values + ItemQuantity + "xx|xx";
    //            values = values + lblPayable.ToString() + "xx|xx";
    //            values = values + txtAmount.ToString() + "xx|xx";
    //            values = values + lblChange.ToString() + "xx|xx";
    //            Console.WriteLine(values);
    //    }
    //}

    //public class active
    //{
    //    public string walletno = string.Empty;
    //}
    //public class inactive
    //{
    //    public string walletno = string.Empty;
    //}
    //public class x
    //{

    //    public static void Main()
    //    {

    //        List<active> act = new List<active>() 
    //        {
    //            new active(){walletno="1"},
    //            new active(){walletno="2"},
    //            new active(){walletno="3"},
    //            new active(){walletno="4"},
    //        };

    //        List<inactive> inact = new List<inactive>() 
    //        {
    //            new inactive(){walletno="0"},
    //            new inactive(){walletno="1"},
    //            new inactive(){walletno="2"},
    //            new inactive(){walletno="3"},
    //            new inactive(){walletno="4"},
    //            new inactive(){walletno="5"},
    //        };
    //        string msg = "Unable to Process request. Please check if the ff. wallet no's are registered in KP Mobile: ";
    //        var activewallet = from a in act
    //                           select a.walletno;

    //        var inactivewallet = from ia in inact
    //                             select ia.walletno;

    //        var difference = inactivewallet.Except(activewallet).ToList();
    //        string inactive = string.Empty;
    //        foreach (var item in difference)
    //        {
    //            inactive += item + ",";
    //            Console.WriteLine(item);
    //        }
    //        inactive = inactive.Substring(0, inactive.Length - 1);
    //        string final = String.Format("{0}{1}{2}", msg, "\n", inactive);

    //        Console.WriteLine(final);
    //        Console.ReadLine();


    //    }
    //}
    #endregion
    #region Dapper
    // apper.NET is an Open-Source, lightweight ORM developed by the developers of Stack Overflow.
    //They develop this ORM keeping performance in mind.
    //Dapper is authored by Sam Saffron of Stack Overlfow.
    //One of the common required by most applications is accessing data from a relational database.
    //If we are using a three-layered architecture with a Data Access Layer (DAL) for getting records from a database and doing various CRUD operations.
    //If we are using an Entity Framework (ORM) Object relationship and mapping then we are using Dbcontext for creating the connection and getting records from the database.
    //Now we will see a simpler way to access data from a database using an open source ORM called Dapper.
    //It is easy to use and write compared to Entity Framework.
    //And also in performance.
    //Hand coded (using a SqlDataReader) 47ms	
    //Dapper ExecuteMapperQuery	49ms	
    //ServiceStack.OrmLite (QueryById)	50ms	
    //PetaPoco	52ms	Can be faster
    //BLToolkit	80ms	
    //SubSonic CodingHorror	107ms	
    //NHibernate SQL	104ms	
    //Linq 2 SQL ExecuteQuery	181ms	
    //Entity framework ExecuteStoreQuery	631ms	


    #endregion
    #region ORM
    //    ORM (Object Relational Mapper) is a tool that creates layer between your application and data source and
    // eturns you the relational objects instead of (in terms of c# that you are using) ADO.NET objects. 
    // his is basic thing that every ORM does.
    //To do this, ORMs generally execute the query and map the returned DataReader to the POCO class. Dapper is limited up to here.
    //To extend this further, some ORMs (also called "full ORM") do much more things like generating query 
    //    for you to make your application database independent, cache your data for future calls,
    // anage unit of work for you and lot more. All these are good tools and adds value to ORM;
    // ut it comes with cost. Entity Framework falls in this class.
    #endregion
    #region get a 365 table
    //class program 
    //{
    //    static void Main() 
    //    {
    //        string walletno = "15110000000186";
    //        int wallet = Convert.ToInt32(walletno.Substring(4, 10));
    //        int temp = wallet % 100;
    //        int dBstart;
    //        int dBlast;
    //        if (temp == 0)
    //        {
    //       start = wallet - 99;
    //       last = wallet;
    //        }
    //     lse
    //        {
    //       start = (wallet - temp) + 1;
    //       last = dBstart + 99;
    //        }
    //        Console.WriteLine("wallet" + dBstart + "_" + dBlast + ".walletno" + wallet);
    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region sample date diff
    //public class Program 
    //{
    //    static void Main() 
    //    {
    //   teTime sample = DateTime.Now;
    //        Console.WriteLine(sample);
    //        string x = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    //        Console.WriteLine(x);
    //   teTime z = Convert.ToDateTime(x);
    //        Console.WriteLine(z);
    //   teTime n = z.AddMinutes(5);
    //        Console.WriteLine(n);
    //   teTime add = sample.AddMinutes(5);
    //        Console.WriteLine(add);
    //        if (add <= n)
    //        {
    //            Console.WriteLine("Expired.");
    //        }
    //     lse 
    //        {
    //            Console.WriteLine("Check");
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region Deadlock
    //public class SynchronizedCache
    //{
    //    private ReaderWriterLockSlim cacheLock = new ReaderWriterLockSlim();
    //    private Dictionary<int, string> innerCache = new Dictionary<int, string>();

    //    public int Count { get { return innerCache.Count; } }
    //    public string Read(int key) 
    //    {
    //        cacheLock.EnterReadLock();
    //   y
    //        {
    //    urn innerCache[key];
    //        }
    //        finally 
    //        {
    //            cacheLock.ExitReadLock();
    //        }
    //    }
    //    public void Add(int key, string value)
    //    {
    //        cacheLock.EnterWriteLock();
    //   y
    //        {
    //            innerCache.Add(key,value);
    //        }
    //        finally 
    //        {
    //            cacheLock.ExitWriteLock();
    //        }
    //    }
    //    public bool AddWithTimeout(int key,string value,int timeout)
    //    {
    //        if (cacheLock.TryEnterWriteLock(timeout))
    //        {
    //       y
    //            {
    //                innerCache.Add(key,value);
    //            }
    //            finally 
    //            {
    //                cacheLock.ExitWriteLock();
    //            }
    //    urn true;
    //        }
    //     lse 
    //        {
    //    urn false;
    //        }
    //    }
    //    public AddOrUpdateStatus AddOrUpdate(int key,string value) 
    //    {
    //        cacheLock.EnterUpgradeableReadLock();
    //   y
    //        {
    //            string result = null;
    //            if (innerCache.TryGetValue(key,out result))
    //            {
    //                if (result==value)
    //                {
    //            urn AddOrUpdateStatus.Unchanged;
    //                }
    //             lse
    //                {
    //                    cacheLock.EnterWriteLock();
    //               y
    //                    {
    //                        innerCache[key] = value;
    //                    }
    //                    finally 
    //                    {
    //                        cacheLock.ExitWriteLock();
    //                    }
    //            urn AddOrUpdateStatus.Updated;
    //                }
    //            }
    //         lse 
    //            {
    //                cacheLock.EnterWriteLock();
    //           y
    //                {
    //                    innerCache.Add(key,value);
    //                }
    //                finally 
    //                {
    //                    cacheLock.ExitWriteLock();
    //                }
    //        urn AddOrUpdateStatus.Added;
    //            }
    //        }
    //        finally 
    //        {
    //            cacheLock.ExitUpgradeableReadLock();
    //        }
    //    }
    //    public void Delete(int key)
    //    {
    //        cacheLock.EnterWriteLock();
    //   y
    //        {
    //            innerCache.Remove(key);
    //        }
    //        finally 
    //        {
    //            cacheLock.ExitWriteLock();
    //        }
    //    }
    //    public enum AddOrUpdateStatus
    //    {
    //   ded,Updated,Unchanged
    //    };

    //    public static void Main() 
    //    {
    //        SynchronizedCache sync = new SynchronizedCache();
    //        sync.Add(0,"Stephen");
    //        sync.AddWithTimeout(1,"Mark",10);
    //        sync.Read(1);
    //    }
    //    ~SynchronizedCache() 
    //    {
    //        if (cacheLock != null) cacheLock.Dispose();
    //    }
    //}    

    #endregion
    #region Asynchronous
    //Asynchronous operation means that the operation runs independent of main or other process flow.
    //In general c# program starts executing from the Main method and ends when the Main method returns.
    //In between all the operations runs sequentially one after another. 
    //One operation must wait until its previous operation finishes. 
    //If we use asynchronous programming pattern that .NET introduced in 4.5,
    //in most of the cases we need not to create manual thread by us.
    //The compiler does the difficult work that the developer used to do.
    //We will create our Task using Task.Run<T> method.
    //This method Queues the specified work to run on the ThreadPool and returns a task handle for that work. 
    //class Program
    //{
    //    static void Main()
    //    {
    //   sk task = new Task(CallMethod);
    //   sk.Start();
    //   sk.Wait();
    //        Console.ReadLine();
    //    }

    //    static async void CallMethod()
    //    {
    //        string filePath = "E:\\sampleFile.txt";
    //   sk<int> task = ReadFile(filePath);

    //        Console.WriteLine(" Other Work 1");
    //        Console.WriteLine(" Other Work 2");
    //        Console.WriteLine(" Other Work 3");

    //        int length = await task;
    //        Console.WriteLine(" Total length: " + length);

    //        Console.WriteLine(" After work 1");
    //        Console.WriteLine(" After work 2");
    //    }

    //    static async Task<int> ReadFile(string file)
    //    {
    //        int length = 0;

    //        Console.WriteLine(" File reading is stating");
    //        using (StreamReader reader = new StreamReader(file))
    //        {
    //            // Reads all characters from the current position to the end of the stream asynchronously  
    //            // and returns them as one string.  
    //            string s = await reader.ReadToEndAsync();

    //            length = s.Length;
    //        }
    //        Console.WriteLine(" File reading is completed");
    //   turn length;
    //    }
    //}   
    //class Program 
    //{
    //    public static void Main() 
    //    {
    //        Program p = new Program();
    //        p.Excute();            
    //    }
    //    private void Excute() 
    //    {
    //   sk<bool> task = ExecuteMultipleMethod();
    //   sk.Wait();
    //   sk.Dispose();
    //    }
    //    private async Task<bool> ExecuteMultipleMethod() 
    //    {
    //   sk<int> t1 = AddAsync(2);
    //   sk<int> t2 = MultiplyAsync(3);

    //     wait Task.WhenAll(t1,t2);
    //        int x = t1.Result;
    //        int y = t2.Result;
    //        int z = x + y;
    //        Console.WriteLine(String.Format("{0}{1}{2}{3}",x,y,"\nSum: ",z));
    //        Console.ReadLine();

    //   turn true;
    //    }
    //    static Task<int> AddAsync(int x) 
    //    {
    //   turn Task.Run<int>(() => {
    //    urn Sample(x);
    //        });
    //    }
    //    static Task<int> MultiplyAsync(int y)
    //    {
    //   turn Task.Run<int>(() =>
    //        {
    //    urn SampleMul(y);
    //        });
    //    }
    //    static int Sample(int number) 
    //    {
    //        int result = number;
    //        Console.WriteLine("number: " + result);
    //   turn result;
    //    }
    //    static int SampleMul(int number)
    //    {
    //        int result = number;
    //        Console.WriteLine("number: " + result);
    //   turn result;            
    //    }
    //}
    //=================================
    //private async Task<bool> ExecuteTask(String branchCode, String zone, String date, MsConnection _MsConn,
    //     sConnection _MsConn2, MyConnection _MyConn, MyConnection _MyConn2)
    //    {            
    //   sk<Decimal> PHPBalance = getBalancePHP(branchCode, zone, _MsConn);
    //   sk<Decimal> USDBalance = getBalanceUSD(branchCode, zone, _MsConn2);
    //   sk<Decimal> RequestPHP = getRequestAmountPHP(branchCode, date, _MyConn);
    //   sk<Decimal> RequestUSD = getRequestAmountUSD(branchCode, date, _MyConn2);
    //     wait Task.WhenAll(PHPBalance, USDBalance, RequestPHP, RequestUSD);
    //   turn true;

    //    }    

    //    /*<summary>
    // his method Queues the specified work to run on the ThreadPool and returns a task(CashBalancePeso) handle for that work
    //    </summary>*/
    //    private Task<Decimal> getBalancePHP(String branchCode, String zone, MsConnection _MsConn)
    //    {
    //   turn Task.Run<Decimal>(() =>
    //        {
    //    urn CashBalancePeso(branchCode, zone, _MsConn);
    //        });
    //    }

    //    /*<summary>
    // his method Queues the specified work to run on the ThreadPool and returns a task(CashBalanceUSD) handle for that work
    //    </summary>*/
    //    private Task<Decimal> getBalanceUSD(String branchCode, String zone, MsConnection _MsConn2)
    //    {
    //   turn Task.Run<Decimal>(() =>
    //        {
    //    urn CashBalanceUSD(branchCode, zone, _MsConn2);
    //        });
    //    }

    //    /*<summary>
    // his method Queues the specified work to run on the ThreadPool and returns a task(RequestAmountPHP) handle for that work
    //    </summary>*/
    //    private Task<Decimal> getRequestAmountPHP(String branchCode, String date, MyConnection _MyConn)
    //    {
    //   turn Task.Run<Decimal>(() =>
    //        {
    //    urn RequestAmountPHP(branchCode, date, _MyConn);
    //        });
    //    }

    //    /*<summary>
    // his method Queues the specified work to run on the ThreadPool and returns a task(RequestAmountUSD) handle for that work
    //    </summary>*/
    //    private Task<Decimal> getRequestAmountUSD(String branchCode, String date, MyConnection _MyConn2)
    //    {
    //   turn Task.Run<Decimal>(() =>
    //        {
    //    urn RequestAmountUSD(branchCode, date, _MyConn2);
    //        });
    //    }
    #endregion
    #region Cryptography
    //The translation of data into a secret code. Encryption is the most effective way to achieve data security. 
    //To read an encrypted file, you must have access to a secret key or password that enables you to decrypt it. 
    //Unencrypted data is called plain text ; encrypted data is referred to as cipher text.
    //public class Encryption
    //{
    //    static string str = "StephenMarkAsimudin123456789";
    //    public static void Main()
    //    {
    //        using (Aes Encrypter = Aes.Create())
    //        {
    //         yte[] encrypted = Encrypt(str, Encrypter.Key, Encrypter.IV);
    //            string decrypted = Decrypt(encrypted, Encrypter.Key, Encrypter.IV);
    //            Console.WriteLine(decrypted);
    //        }

    //    }
    //    static byte[] Encrypt(string text, byte[] key, byte[] IV)
    //    {
    //     yte[] encrypted;
    //        using (Aes aesAlg = Aes.Create())
    //        {
    //       sAlg.Key = key;
    //       sAlg.IV = IV;
    //            ICryptoTransform Encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
    //            using (MemoryStream msEncrypt = new MemoryStream())
    //            {
    //                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, Encryptor, CryptoStreamMode.Write))
    //                {
    //                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
    //                    {
    //                        swEncrypt.Write(text);
    //                    }
    //                 ncrypted = msEncrypt.ToArray();
    //                }
    //            }
    //        }
    //   turn encrypted;
    //    }
    //    static string Decrypt(byte[] cipherText, byte[] key, byte[] IV)
    //    {
    //        string text = string.Empty;
    //        using (Aes aesAlg = Aes.Create())
    //        {
    //       sAlg.Key = key;
    //       sAlg.IV = IV;

    //            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
    //            using (MemoryStream msDecrypt = new MemoryStream(cipherText))
    //            {
    //                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
    //                {
    //                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
    //                    {
    //                   xt = srDecrypt.ReadToEnd();
    //                    }
    //                }
    //            }
    //        }
    //   turn text;
    //    }
    //}
    #endregion
    #region Linked List
    //A linked list is a dynamically sized array. An array has a size and you have to deal with it you cant just resize an array.
    //Unlike an array a linked list has no absolute size. It can hold as many variables as you want it to.
    //In circumstances where you dont know how many variables you want to add. 
    //For example it could be just 1 or it could be 1000.
    //In such a situation its stupid to make an array of 10000 it would be a waist of memory.
    //public class Node
    //{
    //    protected Node nPrevious;
    //    protected Node nNext;
    //    protected object Object;

    //    public object Value
    //    {
    //        get { return Object; }
    //        set { Object = value; }
    //    }
    //    public Node Previous
    //    {
    //        get { return nPrevious; }
    //        set { nPrevious = value; }
    //    }
    //    public Node Next
    //    {
    //        get { return nNext; }
    //        set { nNext = value; }
    //    }
    //    public Node(Node PrevNode, Node NextNode, object obj)
    //    {
    //        nPrevious = PrevNode;
    //        nNext = NextNode;
    //        Object = obj;
    //    }
    //}
    //public class LinkedList
    //{
    //    int iCount = 1;
    //    int iCurrent = 0;
    //    Node nCurrent;
    //    public int Count
    //    {
    //        get { return iCount; }
    //    }
    //    public Node CurrentNode
    //    {
    //        get { return nCurrent; }
    //    }
    //    public int CurrentNodeIndex
    //    {
    //        get { return iCurrent; }
    //    }
    //    public LinkedList(object obj)
    //    {
    //        nCurrent = new Node(null, null, obj);
    //        nCurrent.Next = null;
    //        nCurrent.Previous = null;
    //    }
    //    public void AddNode(object obj)
    //    {
    //        if (nCurrent.Next == null)
    //        {
    //            nCurrent = nCurrent.Next = new Node(nCurrent, null, obj);
    //        }
    //     lse
    //        {
    //            nCurrent = nCurrent.Next = new Node(nCurrent, nCurrent.Next, obj);
    //        }
    //        iCount++;
    //        iCurrent++;
    //    }
    //    public void ToNext()
    //    {
    //        if (nCurrent.Next != null)
    //        {
    //            Console.WriteLine("Error Occured.");
    //         hrow new Exception("There is no next Node!");
    //        }
    //     lse
    //        {
    //            nCurrent = nCurrent.Next;
    //            iCurrent++;
    //            Console.WriteLine(nCurrent);
    //        }
    //    }
    //    public void ToPrevious()
    //    {
    //        if (nCurrent.Previous != null)
    //        {
    //            Console.WriteLine("Error Occured.");
    //         hrow new Exception("There is no previous Node!");
    //        }
    //     lse 
    //        {
    //            nCurrent = nCurrent.Previous;
    //            iCurrent--;
    //        }
    //    }
    //    public void GoTo(int index)
    //    {
    //        if (iCurrent<index)
    //        {
    //         oNext();
    //        }
    //     lse if(iCurrent>index)
    //        {
    //         oPrevious();
    //        }
    //    }
    //}
    //class Program
    //{        
    //    static void Main() 
    //    {  
    //        object name = "Steph";
    //        int x = 5;
    //        LinkedList list = new LinkedList(name);
    //        list.GoTo(0);
    //    }
    //}
    //=============================================
    //public class GenericList<T>
    //{
    //    private class Node
    //    {
    //        public Node Next;
    //        public T Data;
    //    }
    //    private Node head = null;
    //    public void AddNode(T t)
    //    {
    //        Node newNode = new Node();
    //        newNode.Next = head;
    //        newNode.Data = t;
    //        head = newNode;
    //    }
    //    public T GetFirstAdded()
    //    {
    // mp = default(T);
    //        Node current = head;
    //        while (current != null)
    //        {
    //    p = current.Data;
    //            current = current.Next;
    //        }
    //   turn temp;
    //    }
    //}
    //class Program 
    //{
    //    static void Main()
    //    {
    //        GenericList<int> gll = new GenericList<int>();
    //        gll.AddNode(5);
    //        gll.AddNode(4);
    //        gll.AddNode(3);
    //        int intVal = gll.GetFirstAdded();
    //        Console.WriteLine(intVal);
    //        Console.ReadLine();
    //    }
    //}
    //===================================
    //public class Node
    //{
    //    public Node Next;
    //    public Object Data;
    //}
    //public class LinkedList
    //{
    //    private Node head = null;
    //    public void printAllNodes()
    //    {
    //        Node Current = head;
    //        while (Current != null)
    //        {
    //            Console.WriteLine(Current.Data);
    //            Current = Current.Next;
    //        }
    //    }
    //    public void AddFirst(Object data)
    //    {
    //        Node toAdd = new Node();
    //     oAdd.Data = data;
    //     oAdd.Next = head;

    //        head = toAdd;
    //    }
    //    public void AddLast(Object data)
    //    {
    //        if (head == null)
    //        {
    //            head = new Node();

    //            head.Data = data;
    //            head.Next = null;
    //        }
    //     lse
    //        {
    //            Node toAdd = new Node();
    //         oAdd.Data = data;
    //            Node current = head;
    //            while (current.Next != null)
    //            {
    //                current = current.Next;
    //            }
    //            current.Next = toAdd;
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine("Add First: ");
    //        LinkedList myList = new LinkedList();
    //     yList.AddFirst("Hello");
    //     yList.AddFirst("Magical");
    //     yList.AddFirst("World");
    //     yList.printAllNodes();

    //        Console.WriteLine("Add Last: ");
    //        LinkedList myList2 = new LinkedList();
    //     yList2.AddLast("Hello2");
    //     yList2.AddLast("Magical2");
    //     yList2.AddLast("World2");
    //     yList2.printAllNodes();
    //        Console.ReadLine();
    //    }
    //}
    //=============================LinkedList<T> Generic class
    //class Program
    //{
    //    static void Main()
    //    {
    //        string[] words = { "the", "fox", "jumped", "over", "the", "dog" };
    //        LinkedList<string> sentence = new LinkedList<string>(words);
    //     isplay(sentence, "The Linked List values: ");
    //        Console.WriteLine("sentence.Contains(\"jumped\") = {0}", sentence.Contains("jumped"));
    //        sentence.AddFirst("today");
    //     isplay(sentence, "Test 1: Add 'today' to beginning of the list: ");
    //        LinkedListNode<string> mark1 = sentence.First;
    //        sentence.RemoveFirst();
    //        sentence.AddLast(mark1);
    //     isplay(sentence, "Test 2: Move First node to be last node: ");

    //        sentence.RemoveLast();
    //        sentence.AddLast("yesterday");
    //     isplay(sentence, "Test 3: Change the last node to 'yesterday': ");
    //   rk1 = sentence.Last;
    //        sentence.RemoveLast();
    //        sentence.AddFirst(mark1);
    //     isplay(sentence, "Test 4: Move last node to be first node: ");

    //        sentence.RemoveFirst();
    //        LinkedListNode<string> current = sentence.FindLast("the");
    //        IndicateNode(current, "Test 5: Indicate last occurence of 'the': ");

    //        sentence.AddAfter(current, "Old");
    //        sentence.AddAfter(current, "lazy");
    //        IndicateNode(current, "Test 6: Add 'lazy' and 'old' after 'the': ");

    //        current = sentence.Find("fox");
    //        IndicateNode(current, "Test 7: Indicate the 'fox' node: ");

    //        sentence.AddBefore(current, "quick");
    //        sentence.AddBefore(current, "brown");
    //        IndicateNode(current, "Test 8: Add 'quick' and 'brown' before 'fox': ");

    //   rk1 = current;
    //        LinkedListNode<string> mark2 = current.Previous;
    //        current = sentence.Find("dog");
    //        IndicateNode(current, "Test 9: Indicate the 'dog' node:");
    //        Console.WriteLine("Test 10: Throw exception by adding node (fox) already in the list: ");
    //   y
    //        {
    //            sentence.AddBefore(current, mark1);
    //        }
    //        catch (InvalidOperationException ex)
    //        {
    //            Console.WriteLine("Exception message: {0}", ex.Message);
    //        }

    //        sentence.Remove(mark1);
    //        sentence.AddBefore(current, mark1);
    //        IndicateNode(current, "Test 11: Move a referenced node (fox) before the current node (dog): ");
    //        sentence.Remove(current);

    //        IndicateNode(current, "Test 12: Remove Current node (dog) and attempt to indicate it: ");
    //        sentence.AddAfter(mark2, current);

    //        IndicateNode(current, "Test 13: Add node removed in test 11 after a reference node (brown):");
    //        sentence.Remove("old");
    //     isplay(sentence, "Test 14: Remove node that has the value 'old': ");
    //        sentence.RemoveLast();
    //        ICollection<string> icoll = sentence;
    //        icoll.Add("rhinoceros");
    //     isplay(sentence, "Test 15: Remove last node, cast to ICollection, and add 'rhinoceros':");
    //        Console.WriteLine("Test 16: Copy the list to an array:");
    //        string[] array = new string[sentence.Count];
    //        sentence.CopyTo(array, 0);
    //        foreach (string item in array)
    //        {
    //            Console.WriteLine(item);
    //        }
    //        sentence.Clear();

    //        Console.WriteLine("Test 17: Clear Linked List. Contains 'jumped' ={0}", sentence.Contains("jumped"));
    //        Console.ReadLine();



    //    }
    //    private static void Display(LinkedList<string> words, string test)
    //    {
    //        Console.WriteLine(test);
    //        foreach (var word in words)
    //        {
    //            Console.WriteLine(word + " ");
    //        }
    //    }
    //    private static void IndicateNode(LinkedListNode<string> node, string test)
    //    {
    //        Console.WriteLine(test);
    //        if (node.List == null)
    //        {
    //            Console.WriteLine("Node '{0}' is not in the list. \n", node.Value);
    //    urn;
    //        }
    //        StringBuilder result = new StringBuilder("(" + node.Value + ")");
    //        LinkedListNode<string> nodeP = node.Previous;
    //        while (nodeP != null)
    //        {
    //       sult.Insert(0, nodeP.Value + " ");
    //            nodeP = nodeP.Previous;
    //        }
    //        node = node.Next;
    //        while (node != null)
    //        {
    //       sult.Append(" " + node.Value);
    //            node = node.Next;
    //        }
    //        Console.WriteLine(result);
    //    }

    //}
    #endregion
    #region Destructor
    //The IDisposable interface contains only one public method with signature void Dispose(). 
    //We can implement this method to close or release unmanaged resources such as files, streams, 
    //and handles held by an instance of the class that implements this interface. 
    //This method is used for all tasks associated with freeing resources held by an object. 
    //When implementing this method, objects must seek to ensure that 
    //all held resources are freed by propagating the call through the containment hierarchy.
    //class MyClass : IDisposable
    //{
    //    public void Dispose()
    //    {
    //        //implementation
    //    }
    //}
    //    public class MyClass:IDisposable
    //{
    // private bool IsDisposed=false;
    // public void Dispose()
    // {
    //  Dispose(true);
    //  GC.SupressFinalize(this);
    // }
    // protected void Dispose(bool Diposing)
    // {
    //  if(!IsDisposed)
    //  {
    //  if(Disposing)
    //  {
    //   //Clean Up managed resources
    //  }
    //  //Clean up unmanaged resources
    // }
    // IsDisposed=true;
    // }
    // ~MyClass()
    // {
    //  Dispose(false);
    // }
    //}
    //Here the overload of Dispose(bool) does the cleaning up, and all the cleaning up code is written only in this method.
    //This method is called by both the destructor and the IDisposable.Dispose(). 
    //We should take care that the Dispose(bool) is not called from any where else except from the IDisposable.Dispose() and the destructor.
    //When a client calls IDisposable.Dispose(), then the client deliberately wants to clean up the managed and unmanaged resource,
    //and so the cleaning up is done. One thing you must have noticed is that 
    //we called GC.SupressFinalize(this) immediately after we cleaned up the resource.
    //This method tells the Garbage Collector that there is no need to call its destructor because we have already done the clean up.
    //Notice that in the above example, the destructor calls the Dispose with parameter as false.
    //Here, we are ensuring that the Garbage collector collects the managed resources. We only do the cleaning up of unmanaged resource.
    //public abstract class Base : IDisposable
    //{
    //    private bool disposed = false;
    //    private string instanceName;
    //    private List<object> trackingList;
    //    public Base(string instanceName, List<object> tracking)
    //    {
    //     his.instanceName = instanceName;
    //   ackingList = tracking;
    //   ackingList.Add(this);
    //    }
    //    public string InstanceName
    //    {
    //        get
    //        {
    //    urn instanceName;
    //        }
    //    }
    //    //Implement IDisposable.
    //    public void Dispose()
    //    {
    //        Console.WriteLine("\n[{0}].Base.Dispose()", instanceName);
    //     ispose(true);
    //        GC.SuppressFinalize(this);
    //    }
    //    protected virtual void Dispose(bool disposing)
    //    {
    //        if (!disposed)
    //        {
    //            if (disposing)
    //            {
    //                // Free other state (managed objects).
    //                Console.WriteLine("[{0}].Base.Dispose(true)", instanceName);
    //        ckingList.Remove(this);
    //                Console.WriteLine("[{0}] Removed from tracking list: {1:x16}",
    //                    instanceName, this.GetHashCode());
    //            }
    //         lse
    //            {
    //                Console.WriteLine("[{0}].Base.Dispose(false)", instanceName);
    //            }
    //         isposed = true;
    //        }
    //    }
    //    // Use C# destructor syntax for finalization code.
    //    ~Base()
    //    {
    //        // Simply call Dispose(false).
    //        Console.WriteLine("\n[{0}].Base.Finalize()", instanceName);
    //     ispose(false);
    //    }
    //}
    #endregion
    #region Loose Coupling
    //Tight Coupling
    //Tight coupling is when a group of classes are highly dependent on one another.
    //This scenario arises when a class assumes too many responsibilities,
    //or when one concern is spread over many classes rather than having its own class.

    //Loose coupling is achieved by means of a design that promotes single-responsibility and separation of concerns.
    //A loosely-coupled class can be consumed and tested independently of other (concrete) classes.

    //Interfaces are a powerful tool to use for decoupling.
    //Classes can communicate through interfaces rather than other concrete classes,
    //and any class can be on the other end of that communication simply by implementing the interface.

    //Notice how the OrderTotal method (and thus the Order class) depends on the implementation details of the CartContents 
    //and the CartEntry classes. If we were to try to change this logic to allow for discounts, 
    //we'd likely have to change all 3 classes. Also, if we change to using a List collection to keep track of 
    //the items we'd have to change the Order class as well. This is tight coupling that to the change in one class 
    //if it brings change in the other classes or objects, it is said to be tightly coupled and 
    //maintenance of such a code becomes too difficult to implement a slight change you need to change n number of places.
    //Loose Coupling Code :
    //The logic that is specific to the implementation of the cart line item or 
    //the cart collection or the order is restricted to just that class. 
    //So we could change the implementation of any of these classes without having to change the other classes.
    //We could take this decoupling yet further by improving the design, introducing interfaces, etc. 
    //Here the point is that we have made the implementations of the cart line item or the cart collection or 
    //the order so independent from one another that if you need to change the order class,
    //possibly nothing needs to be changed in the other classes.  This is what loose coupling means 
    //and is considered to be the most appropriate programming approach in Object Oriented Programming.
    //public class CartEntry
    //{
    //    public float Price;
    //    public int Quantity;
    //    public float GetLineItemTotal()
    //    {
    //   turn Price * Quantity;
    //    }        
    //}
    //public class CartContents
    //{
    //    public List<CartEntry> items = new List<CartEntry>();
    //    public float GetCartItemsTotal()
    //    {
    //        float cartTotal = 0;
    //        foreach (CartEntry item in items)
    //        {
    //            cartTotal += item.GetLineItemTotal();
    //        }
    //   turn cartTotal;
    //    }
    //}
    //public class Order
    //{
    //    private CartContents cart;
    //    private float salesTax;
    //    public Order(CartContents cart, float salesTax)
    //    {
    //     his.cart = cart;
    //     his.salesTax = salesTax;
    //    }
    //    public float OrderTotal()
    //    {
    //   turn cart.GetCartItemsTotal() * (1.0f + salesTax);
    //    }
    //}
    //class Program
    //{
    //    static void Main()
    //    {
    //        CartEntry ce = new CartEntry();
    //        ce.Price = 1000.00f;
    //        ce.Quantity = 5;
    //        CartContents cc = new CartContents();
    //        cc.items.Add(ce);
    //        float x = 3.28f;
    //        Order ordr = new Order(cc, x);
    //        float result = ordr.OrderTotal();
    //        Console.WriteLine(result);
    //        Console.ReadLine();
    //    }
    //}
    //======================================Example of tight coupling:
    //class CustomerRepository
    //{
    //    private readonly Database databases;

    //    public CustomerRepository(Database database)
    //    {
    //     his.databases = database;
    //    }

    //    public void Add(string CustomerName)
    //    {
    //   tabase.AddRow("Customer", CustomerName);
    //    }
    //}

    //class Database
    //{
    //    public void AddRow(string Table, string Value)
    //    {

    //    }
    //}
    //====================================Example of loose coupling:
    //class CustomerRepository
    //{
    //    private readonly IDatabase database;

    //    public CustomerRepository(IDatabase database)
    //    {
    //     his.database = database;
    //    }

    //    public void Add(string CustomerName)
    //    {
    //   tabase.AddRow("Customer", CustomerName);
    //    }
    //}

    //interface IDatabase
    //{
    //    void AddRow(string Table, string Value);
    //}

    //class Database : IDatabase
    //{
    //    public void AddRow(string Table, string Value)
    //    {
    //    }
    //}
    //loose
    //public interface Runnable
    //{
    //    public void run();
    //}

    //public class ABC implements Runnable
    //{
    //   public void run() {...}
    //}

    //public class XYZ implements Runnable
    //{
    //   public void run() {...}
    //}
    //    class Program
    //    {
    //     unnable obj = config.isNetwork() ? new XYZ() : new ABC();

    //obj.run();
    //    }
    #endregion
    #region Entity Framework
    //Entity framework (hereafter, EF) is the framework ORM (object-relational mapping) 
    //that Microsoft makes available as part of the .NET development (version 3.5 SP1 and later). 
    //Its purpose is to abstract the ties to a relational database, 
    //in such a way that the developer can relate to the database entity as to a set of objects 
    //and then to classes in addition to their properties. In essence, 
    //we speak about decoupling between our Applications and the logic of data access, which proves to be a major plus. 
    //For example: If we need to move - in the context of a single program - to different manufacturers database, 
    //it would be required to review the way and the instructions with which we interface the data manager on duty.
    // two types of approaches 
    // Database-First and Code-First
    //classes ==>Articoli & Famiglie
    //    using (TECHNETEntities db = new TECHNETEntities())  
    //{  
    //    var art = db.Articoli  
    //                .Join(db.Famiglie,  
    //              icolo => articolo.CodFamiglia,  
    //                      famiglia => famiglia.CodFamiglia,  
    //                      (articolo, famiglia) => new { Articoli = articolo, Famiglie = famiglia})  
    //                .Where((x) => x.Articoli.CodArt == "ART005")  
    //                .FirstOrDefault();  

    // essageBox.Show(art.Articoli.DesArt + " - " + art.Famiglie.DesFamiglia);  
    //}  
    #endregion
    #region Indexers
    //// indexers allow us to leverage the capability of accessing the class objects as an array.
    ////Properties can be static but indexers cannot be.
    ////Classes like ArrayList and List use indexers internally to provide functionality of arrays for fetching and using the elements.
    //class Indexers
    //{
    //    public int this[int indexValue]
    //    {
    //        set
    //        {
    //            Console.WriteLine("I am in set: value is: " + value + " and indexValie is: " + indexValue);
    //        }
    //    }
    //}
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        Indexers index = new Indexers();
    //        index[1] = 24;
    //    }
    //}
    ////Data-Types in Indexers
    //public class Indexer
    //{
    //    private int Index;
    //    public int this[string indexValue]
    //    {
    //        set
    //        {
    //            Console.WriteLine("This is set: Value is: " + value + " and indexValue is: " + indexValue);
    //            Index = value;
    //        }
    //        get
    //        {
    //            Console.WriteLine("This is get and indexValue is: " + indexValue);
    //    urn Index;
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Indexer indx = new Indexer();
    //        indx["Steph"] = 23;
    //        Console.WriteLine(indx["Steph"]);
    //        Console.ReadLine();
    //    }
    //}
    ////Indexers in interfaces
    //interface IIndexers
    //{
    //    string this[int indexValue] { get; set; }
    //}
    //class IndexerClass : IIndexers
    //{
    // eadonly string[] _nameList = { "Steph", "Mark", "Asi", "Dray" };
    //    public string this[int indexValue]
    //    {
    //        get
    //        {
    //    urn _nameList[indexValue];
    //        }
    //        set
    //        {
    //            Console.WriteLine("Set value is: " + value);
    //            _nameList[indexValue] = value;
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IIndexers iIndexers = new IndexerClass();
    //        iIndexers[0] = "lebron";
    //        Console.WriteLine(iIndexers[0]);
    //        Console.WriteLine(iIndexers[1]);
    //        Console.WriteLine(iIndexers[2]);
    //        Console.WriteLine(iIndexers[3]);
    //        Console.ReadLine();
    //    }
    //}
    ////Indexers in Abstract class
    //public abstract class BaseClass
    //{
    //    public abstract string this[int indxValue] { get; set; }
    //}
    //public class IndexerClass : BaseClass
    //{
    // eadonly string[] _nameList = { "Steph", "Mark", "Asi", "Lbj" };
    //    public override string this[int indxValue]
    //    {
    //        get
    //        {
    //    urn _nameList[indxValue];
    //        }
    //        set
    //        {
    //            _nameList[indxValue] = value;
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //   seClass absClass = new IndexerClass();
    //        Console.WriteLine(absClass[0]);
    //        Console.WriteLine(absClass[1]);
    //        Console.WriteLine(absClass[2]);
    //        Console.WriteLine(absClass[3]);
    //   sClass[3] = "Dray";
    //        Console.WriteLine(absClass[3]);
    //        Console.ReadLine();

    //    }
    //}
    ////Indexer Overloading
    //class Indexer
    //{
    //    public int this[int indexValue]
    //    {
    //        set { Console.WriteLine("Integer Value: " + indexValue + " value: " + value); }
    //    }
    //    public int this[string indexValue]
    //    {
    //        set { Console.WriteLine("String value: " + indexValue + " value: " + value); }
    //    }
    //    public int this[string indexValue, int indexIntValue]
    //    {
    //        set { Console.WriteLine("String value: " + indexValue + " Int Value: " + indexIntValue + " value: " + value); }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Indexer ind = new Indexer();
    //        ind[1] = 24;
    //        ind["Steph"] = 23;
    //        ind["Lebron", 23] = 32;
    //        Console.ReadLine();
    //    }
    //}
    ////Inheritance/Polymorphism in Indexers
    //class IndexBaseClass
    //{
    //    public virtual int this[int indexValue]
    //    {
    //        get
    //        {
    //            Console.WriteLine("Get of IndexerBaseClass; indexer value: " + indexValue);
    //    urn 100;
    //        }
    //        set
    //        {
    //            Console.WriteLine("Set of IndexerBaseClass; indexer value: " + indexValue + " set value " + value);
    //        }
    //    }
    //}
    //class IndexDerivedClass : IndexBaseClass
    //{
    //    public override int this[int indexValue]
    //    {
    //        get
    //        {
    //            int dValue = base[indexValue];
    //            Console.WriteLine("Get of IndexerDerivedClass; indexer value: " + indexValue + " dValue from base class indexer: " + dValue);
    //    urn 500;
    //        }
    //        set
    //        {
    //            Console.WriteLine("Set of IndexerDerivedClass; indexer value: " + indexValue + " set value " + value);
    //       se[indexValue] = value;
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IndexBaseClass index = new IndexDerivedClass();
    //        index[2] = 300;
    //        Console.WriteLine(index[2]);
    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region Properties
    //A property is a member that provides a flexible mechanism to read, write, or compute the value of a private field.
    //Properties can be used as if they are public data members, but they are actually special methods called accessors.
    //If we analyze the internals of properties, they are very different from normal variables. 
    //Internally, properties are methods that do not have their own memory like variables have.
    //We can leverage a property to write our custom code whenever we access a property. 
    //We can access the code when we call/execute properties or during of declaration too,
    //but this is not possible with variables. A property in easy language ,is a class member and is encapsulated and 
    //abstracted from the end developer who is accessing the property.
    //A property can contain lots of code that an end user does not know. 
    //An end user only cares to use that property like a variable. 
    //A property, as I explained, internally executes a function/method whereas a variable uses/initializes memory when used. 
    //At times properties are not slower than variables since the property code is internally rewritten to memory access.
    //If one does not mark a property defined in the derived class as override, it will by default be considered as new.
    //class Properties
    //{
    //    public string name
    //    {
    //        get
    //        {
    //    urn "I am a Name Property";
    //        }
    //    }
    //    public int age
    //    {
    //        get
    //        {
    //    eTime dateOfBirth = new DateTime(1993, 09, 20);
    //    eTime currentDate = DateTime.Now;
    //            int age = currentDate.Year - dateOfBirth.Year;
    //            Console.WriteLine("Get is Called.");
    //    urn age;
    //        }
    //        set
    //        {
    //            Console.WriteLine("Set is Called: " + value);
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Properties prop = new Properties();
    //        Console.WriteLine(prop.name);
    //        prop.age = 23;
    //        Console.WriteLine("My age is: " + prop.age);
    //        Console.ReadLine();
    //    }
    //}
    //The variable used for a property should be of the same data type as the data type of the property.
    //class Properties
    //{
    //    private string _name;
    //    private int _age;
    //    public string name
    //    {
    //        get { return _name; }
    //        set
    //        {
    //            Console.WriteLine("Set is called.");
    //            _name = value;
    //        }
    //    }
    //    public int age
    //    {
    //        get { return _age; }
    //        set
    //        {
    //            Console.WriteLine("Set is called.");
    //            _age = value;
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Properties pro = new Properties();
    //        pro.name = "Steph";
    //        Console.WriteLine(pro.name);
    //        pro.age = 23;
    //        Console.WriteLine("My age is: " + pro.age);
    //        Console.ReadLine();
    //    }
    //}
    //====================================
    //The following are automatic properties:
    //public string Name { get; set; }
    //public int Age { get; set; }
    //class Properties
    //{
    //    public static int Age
    //    {
    //        get
    //        {
    //            Console.WriteLine("This is get static value.");
    //    urn 23;
    //        }
    //        set 
    //        {
    //            Console.WriteLine("This is set static value: "+value);
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Properties.Age = 24;
    //        Console.WriteLine(Properties.Age);
    //        Console.ReadLine();
    //    }
    //}
    //===============================
    //Abstract Properties
    //public abstract class BaseClass
    //{
    //    public abstract int absProp { get; set; }
    //}
    //public class Properties : BaseClass
    //{
    //    public override int absProp
    //    {
    //        get
    //        {
    //            Console.WriteLine("Get is Called.");
    //    urn 23;
    //        }
    //        set
    //        {
    //            Console.WriteLine("Set is called. value: " + value);
    //        }
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Properties pro = new Properties();
    //        pro.absProp = 24;
    //        Console.WriteLine(pro.absProp);
    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region Enums
    //The enum keyword is used to declare an enumeration, a distinct type 
    //that consists of a set of named constants called the enumerator list.
    //An enum represents a constant number and an enum type is known as a distinct type having named constants.
    //We can't declare char as an underlying data type for enum objects because char stores Unicode characters, 
    //but enum objects data type can only be a number.
    // enum can't be derived from any other type except that of type byte, sbyte, short, ushort, int, uint, long, or ulong
    //By default an enum is a sealed class and therefore conforms to all the rules that a sealed class follows, 
    //so no class can derive from an enum, in other words a sealed type. 
    // an enum is also derived from the three interfaces IComparable, IFormattable and IConvertible.
    //    internal enum Color
    //    {
    //        Yellow,//0
    //     lue,//1
    //        Green//2
    //    }

    //    internal class Program
    //    {
    //        private static void Main(string[] args)
    //        {
    //            Console.WriteLine(Color.Yellow.CompareTo(Color.Blue));//0-1=-1
    //            Console.WriteLine(Color.Blue.CompareTo(Color.Green));//1-2=-1
    //            Console.WriteLine(Color.Blue.CompareTo(Color.Yellow));//1-0=1
    //            Console.WriteLine(Color.Green.CompareTo(Color.Green));//2-2=0
    //            Console.ReadLine();
    //            Output:
    //              -1
    //              -1
    //               1
    //               0
    //        }
    //}
    //==========================Cast enum======================
    //Since an enum acts as an individual data type so it cannot be directly compared to an int,
    //however, we can typecast the enum type to an int to do the comparison
    // num Color  
    //    {  
    //        Yellow,  
    //     lue,  
    //        Green  
    //    }  

    //    internal class Program  
    //    {  
    //        private static void Main(string[] args)  
    //        {  
    //            int myColor = 2;  
    //            if(myColor== (int)Color.Green)  
    //            {  
    //                Console.WriteLine("my color");  
    //            }  
    //           Console.ReadLine();  
    //        }  
    //    }  
    //}  
    //IFormattable
    //Format is the method derived from the IFormatter interface. 
    //It's a static method so can be used directly with the enum class defined as Color.
    //It's first parameter is the type of the enum class,
    //the second is the member that must be formatted and the third is the format,
    //in other words hexadecimal or decimal, like we used in the above example and we got a positive result output too.
    //internal enum Color
    //{
    //    Yellow, Blue, Green
    //}
    //internal class Test
    //{
    //    private static void Main(string[] args)
    //    {
    //        Console.WriteLine(Color.Format(typeof(Color), Color.Green, "X"));
    //        Console.WriteLine(Color.Format(typeof(Color), Color.Green, "d"));
    //        Console.ReadLine();
    //    }
    //}
    //IConvertible
    //internal enum Color
    //{
    //    Yellow, Blue, Green
    //}
    //internal class Program
    //{
    //    private static void Main(string[] args)
    //    {
    //        string[] names;
    //        names = Color.GetNames(typeof(Color));
    //        foreach (var name in names)
    //        {
    //            Console.WriteLine(name);
    //        }
    //        Console.ReadLine();
    //    }
    //}
    //We can always specify the default constant value to any enum member, here we see, 
    //we specified the value 2 for yellow, so as per the law of enum, the value of blue will be incremented by one
    //and gets the value 3. We again specified 9 as a default value to Brown 
    //and so its successor Green gets incremented by one and gets that value 10.
    //class Program 
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine((int)Color.yellow);
    //        Console.WriteLine((int)Color.blue);
    //        Console.WriteLine((int)Color.brown);
    //        Console.WriteLine((int)Color.green);
    //        Console.ReadLine();
    //    }
    //}
    //enum Color 
    //{
    //    yellow=2,blue,brown=9,green
    //}
    //output 2,3,9,10

    #endregion
    #region Interfaces
    //An interface looks like a class, but has no implementation. The only thing it contains are declarations of events, 
    //indexers, methods and/or properties. The reason interfaces only provide declarations is because they are inherited
    //by structs and classes, that must provide an implementation for each interface member declared.
    //So, what are interfaces good for if they don't implement functionality? 
    //They're great for putting together plug-n-play like architectures where components can be interchanged at will. 
    //Since all interchangeable components implement the same interface, they can be used without any extra programming.
    //The interface forces each component to expose specific public members that will be used in a certain way.
    //interface IMyInterface
    //{
    //    void MethodToImplement(); //Abstract Method signature.  
    //}
    //class InterfaceImplementer : IMyInterface
    //{
    //    static void Main()
    //    {
    //        InterfaceImplementer obj = new InterfaceImplementer();
    //        obj.MethodToImplement();
    //    }
    //    public void MethodToImplement()
    //    {
    //        //Abstract Method Implementation
    //    }
    //}
    //==========================
    //interface IOne
    //{
    //    string ONE();//Pure Abstract Method Signature  
    //}
    //interface ITwo
    //{
    //    string TWO();
    //}
    //interface IThree : IOne
    //{
    //    string THREE();
    //}
    //interface IFour
    //{
    //    string FOUR();
    //}
    //interface IFive : IThree
    //{
    //    string FIVE();
    //}
    //interface IEVEN : ITwo, IFour
    //{
    //    string EVEN();
    //}
    //class ODDEVEN : IEVEN, IFive////Must Implement all the abstract method, in Derived class.
    //{
    //    public string ONE() //Implementation of Abstract Method.  
    //    {
    //        var logic = new TEST();
    //   turn logic.ONE();
    //    }
    //    public string TWO()
    //    {
    //        var logic = new TEST();
    //   turn logic.TWO();
    //    }
    //    public string THREE()
    //    {
    //        var logic = new TEST();
    //   turn logic.THREE();
    //    }
    //    public string FOUR()
    //    {
    //        var logic = new TEST();
    //   turn logic.FOUR();            
    //    }
    //    public string FIVE()
    //    {
    //        var logic = new TEST();
    //   turn logic.FIVE();
    //    }
    //    public string EVEN()
    //    {
    //        var logic = new TEST();
    //   turn logic.EVEN();
    //    }
    //}
    //class TEST
    //{
    //    public string ONE()
    //    {
    //        Console.WriteLine("This is ONE");
    //   turn "This is ONE";
    //    }
    //    public string TWO()
    //    {
    //        Console.WriteLine("This is TWO");
    //   turn "This is TWO";
    //    }
    //    public string THREE()
    //    {
    //        Console.WriteLine("This is THREE");
    //   turn "This is THREE";
    //    }
    //    public string FOUR()
    //    {
    //        Console.WriteLine("This is FOUR");
    //   turn "This is FOUR";
    //    }
    //    public string FIVE()
    //    {
    //        Console.WriteLine("This is FIVE");
    //   turn "This is FIVE";
    //    }
    //    public string EVEN()
    //    {
    //        Console.WriteLine("This is EVEN method.");
    //   turn "This is EVEN";
    //    }
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("This is ODD.");
    //        IFive obj = new ODDEVEN();
    //        obj.ONE();
    //        obj.THREE();
    //        obj.FIVE();
    //        Console.WriteLine("This is EVEN.");
    //        IEVEN obj2 = new ODDEVEN();
    //        obj2.EVEN();
    //        obj2.TWO();
    //        obj2.FOUR();
    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region AccessModifiers
    //=======================Access Modifiers=========================//  
    //Access modifiers (or access specifiers) are keywords in object-oriented languages that set the accessibility of classes, 
    //methods, and other members. Access modifiers are a specific part of programming language syntax used to facilitate the
    //encapsulation of components.
    //The protected access specifier too cannot be applied to a class.
    //Public, Private, Protected at class level
    //The default access modifier is private for class members.
    //Elements defined in a namespace cannot be explicitly declared as private, protected, or protected internal
    //Protected internal means that the derived class and the class within the same source code file can have access.
    //between public and internal, public always allows greater access to its members. 
    //protected =>Access is limited to the containing class or types derived from the containing class.
    //internal => Access is limited to the current assembly.
    //protected  internal => Access is limited to the current assembly or types derived from the containing class.
    // Like classes const variables cannot be circular, in other words they cannot depend on each other.
    //A const variable cannot be marked as static.
    //A constant by default is static and we can't use the instance reference, in other words a name to reference a const. 
    //A const must be static since no one will be allowed to make any changes to a const variable.
    //C# always initializes static variables to their initial value after creating them.
    // A static readonly field cannot be assigned to (except in a static constructor or a variable initializer)
    //A readonly field cannot be ed ref or out (except in a constructor)
    //public class ClassA 
    //{ 
    //    protected internal void MethodA()
    //    {

    //    }
    //}
    //public class ClassB:ClassA 
    //{        
    //    protected internal void MethodB()
    //    {
    //   thodA();
    //    }
    //}
    //public class ClassC 
    //{
    //    protected internal void MethodC()
    //    {
    //        ClassA classA = new ClassA();
    //        classA.MethodA();
    //    }
    //}
    //public class MainClass 
    //{
    //    static void Main(string[] args)
    //    {
    //        ClassC classC = new ClassC();
    //        classC.MethodC();
    //    }
    //}
    //class Modifiers
    //{
    //    static void AAA()============default private
    //    {
    //        Console.WriteLine("Modifiers AAA");
    //    }

    //    public static void BBB()
    //    {
    //        Console.WriteLine("Modifiers BBB");
    //   A();
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //     odifiers.BBB();
    //    }
    //}    
    #endregion
    #region Abstract
    //==========================Abstract============================//
    //"The abstract keyword enables you to create classes and class members 
    //that are incomplete and must be implemented in a derived class. An abstract class cannot be instantiated. 
    //The purpose of an abstract class is to provide a common definition of a base class 
    //that multiple derived classes can share. For example, a class library may define an abstract class 
    //that is used as a parameter to many of its functions, and require programmers using that library to provide 
    //their own implementation of the class by creating a derived class.
    //Abstract classes may also define abstract methods. This is accomplished by adding 
    //the keyword abstract before the return type of the method.”
    //A class can be derived from an abstract class.
    // Abstract class cannot be sealed class.
    //Abstract class cannot be a static class.
    //public class ClassA
    //{
    //    public virtual void XXX()
    //    {
    //        Console.WriteLine("ClassA XXX");
    //    }
    //}
    //public abstract class ClassB : ClassA
    //{
    //    public new abstract void XXX();
    //}
    //public class ClassC : ClassB
    //{
    //    public override void XXX()
    //    {
    //        System.Console.WriteLine("ClassC XXX");
    //    }
    //}
    //public class Program
    //{
    //    private static void Main(string[] args)
    //    {
    //        ClassA classA = new ClassC();
    //        ClassB classB = new ClassC();
    //        classA.XXX();
    //        classB.XXX();
    //        Console.ReadLine();
    //    }
    //} 
    #endregion
    #region Polymorphism and inheritance and overloading
    //=============================Polymorphism and inheritance===================
    //it is a mechanism of deriving new class from an old class that is pre-defined.
    //the old class is called the super class. the new class is called the sub class.
    //inheritance is used for code reusability.
    //it allows sub class to inherit the variables and methods of their super class.
    //A reserved keyword named “base” can be used in a derived class to call the base class method.
    //It allows you to invoke methods of derived class through base class reference during runtime.
    //It has the ability for classes to provide different implementations of methods that are called through the same name.
    //Overloading a method simply involves having another method with the same prototype.
    //Compile time polymorphism is method and operators overloading. It is also called early binding.
    //In method overloading method performs the different task at the different input parameters.
    //Runtime Time Polymorphism
    //Runtime time polymorphism is done using inheritance and virtual functions. Method overriding is called runtime polymorphism.
    //It is also called late binding.
    //When overriding a method, you change the behavior of the method for the derived class. 
    //Overloading a method simply involves having another method with the same prototype.
    //Use method overloading in situation where you want a class to be able to do something, 
    //but there is more than one possibility for what information is supplied to the method that carries out the task. 
    //You should consider overloading a method when you for some reason need a couple of methods that take different parameters,
    //but conceptually do the same thing.
    //public class Baze
    //{
    //    public void Display()
    //    {
    //        Console.WriteLine("Base Method");
    //    }
    //}
    //public class Derived : Baze
    //{
    //    public new void Display()
    //    {
    //        Console.WriteLine("Derived Method");
    //   se.Display();
    //    }
    //}
    //public class Execute
    //{
    //    static void Main(string[] args)
    //    {
    //   rived dr = new Derived();
    //   .Display();
    //        Console.ReadLine();
    //    }
    //}
    //========================Polymorphism and overloading===============    
    //public class OverLoad
    //{
    //    public void Display()
    //    {
    //     isplayOverLoad(200);
    //     isplayOverLoad(200, 300);
    //     isplayOverLoad(200, 300, 500, 600);
    //    }
    //    private void DisplayOverLoad(int x, int y)
    //    {
    //        Console.WriteLine("Two integer: " + x + " " + y);
    //    }
    //    private void DisplayOverLoad(params int[] paramsArray)
    //    {
    //        Console.WriteLine("array");
    //    }
    //}
    //public class CallOvL
    //{
    //    static void Main(string[] args)
    //    {
    //        OverLoad over = new OverLoad();
    //        over.Display();
    //        Console.ReadLine();
    //    }
    //}
    //=========================================
    //public class overload
    //{
    //    private string name = "Steph";
    //    public void Display()
    //    {
    //     isplayOverload(100, "Steph", "Mark", "Asi");
    //     isplayOverload(100, "Stephen");
    //     isplayOverload(100);
    //     isplay2(out name, out name);
    //        Console.WriteLine(name);
    //    }
    //    private void DisplayOverload(int a, params string[] paramArray)
    //    {
    //        foreach (string str in paramArray)
    //        {
    //            Console.WriteLine(str + " " + a);
    //        }
    //    }
    //    public void Display2(out string x, out string y)
    //    {
    //        Console.WriteLine(name);
    //        x = "Stephenx";
    //        Console.WriteLine(name);
    //        y = "Stepheny";
    //        Console.WriteLine(name);
    //        name = "Stephenz";
    //    }
    //}
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        overload ovL = new overload();
    //        ovL.Display();
    //        Console.ReadLine();
    //    }
    //}
    //========================================
    //namespace Polymorphism
    //{
    //class A
    //{
    //    public virtual void Foo() { Console.WriteLine("A::Foo()"); }
    //}
    //class B : A
    //{
    //    public override void Foo() { Console.WriteLine("B::Foo()"); }
    //}

    //class Test
    //{
    //    static void Main(string[] args)
    //    {
    //    ;
    //    ;

    //      = new A();
    //      = new B();
    //     .Foo();  // output –> “A::Foo()”
    //     .Foo();  // output –> “B::Foo()”

    //      = new B();
    //     .Foo();  // output –> “B::Foo()”
    //        Console.ReadLine();
    //    }
    //}
    // }
    //
    //class Shape
    //{
    //    protected int width, height;
    //    public Shape(int a = 0, int b = 0)
    //    {
    //        width = a;
    //        height = b;
    //    }
    //    public virtual int area()
    //    {
    //        Console.WriteLine("Parent class area :");
    //   turn 0;
    //    }
    //}
    //class Rectangle : Shape
    //{
    //    public Rectangle(int a = 0, int b = 0)
    //        : base(a, b)
    //    {

    //    }
    //    public override int area()
    //    {
    //        Console.WriteLine("Rectangle class area :");
    //   turn (width * height);
    //    }
    //}
    //class Triangle : Shape
    //{
    //    public Triangle(int a = 0, int b = 0)
    //        : base(a, b)
    //    {

    //    }
    //    public override int area()
    //    {
    //        Console.WriteLine("Triangle class area :");
    //   turn (width * height / 2);
    //    }
    //}
    //class Caller
    //{
    //    public void CallArea(Shape sh)
    //    {
    //        int a;
    //      = sh.area();
    //        Console.WriteLine("Area: {0}", a);
    //    }
    //}
    //class Tester
    //{

    //    static void Main(string[] args)
    //    {
    //        Caller c = new Caller();
    //   ctangle r = new Rectangle(10, 7);
    //   iangle t = new Triangle(10, 5);
    //        c.CallArea(r);
    //        c.CallArea(t);
    //        Console.ReadKey();
    //    }
    //}
    #endregion
    #region Nullable types
    //===================================Nullable types=============================//
    //A nullable Type is a  data type  that contain the defined data type or the value of null.
    //Any DataType  can be declared  nullable type with the help of operator "?". 
    //Main usage of this nullable type is when we are passing any parameter to Stored Procedure or Database objects.
    //If a column in a Table allows Null value , then in this case we should use Nullable type.
    //This nullable type concept is not comaptible with "var".
    //public class Nullable
    //{
    //    static void Main(string[] args)
    //    {
    //        int? x = 1;
    //        int y = x ?? 0;
    //        int? result = null;
    //        int? c = 4;
    //        int v = c ?? 0;
    //        // result = x ?? y;
    //int value=Int32.TryParse(dr.GetValue(0).ToString(), out value) ? value : 0;
    //        Console.WriteLine(y.ToString());
    //        Console.WriteLine(v.ToString());
    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region LINQ
    //======================================LINQ===================================
    //LINQ stands for Language Integrated Query. LINQ was introduced with .NET framework 3.5 and C# 3.
    //LINQ allows you to write structured and type safe queries. 
    //It allows you to query local data (e.g LINQ to Objects) as well as remote data (LINQ to SQL).
    //You can query any data which implements IEnumerable<T> interface.
    //The basic building blocks of LINQ are sequences and elements. 
    //A sequence is an object that implements IEnumerable<T> interface and an element is each item in that sequence.
    //You can write a LINQ query in VB as well as C#. LINQ query can be written in three ways,
    //Query expression
    //Fluent Syntax
    //Mixed Syntax    
    //class Linq
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] number = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    //        //=============Query Expression========
    //        //var result = from n in number
    //        //             where n % 2 == 1
    //        //             select n;
    //        // =============Fluent Syntax============
    //        //var result = number.Where(x => x % 2 == 0);
    //        //=============Mixed Syntax==============
    //        string[] name = new string[]{
    //            "Steph",
    //            "Mark",
    //            "Asi",
    //            "Dray",
    //            "aXy",
    //            "Xyron",
    //            "Xsteph"
    //        };
    //        var result = (from s in name where s.Contains("X") select s).OrderBy(x => x.ToUpper());
    //        foreach (var item in result)
    //        {
    //            Console.WriteLine(item);
    //        }
    //        Console.ReadLine();
    //    }
    //}
    //====================================================
    //class Program
    //{

    //    static List<MusicalArtist> GetMusicalArtists()
    //    {
    //   turn new List<MusicalArtist>
    //        {
    //            new MusicalArtist 
    //            { 
    //                Name = "Adele", 
    //                Genre = "Pop", 
    //                LatestHit = "Someone Like You",
    //             lbums = new List<Album>
    //                {
    //                    new Album { Name = "21", RecordingLabel = "2011" },
    //                    new Album { Name = "19", RecordingLabel = "2008" },
    //                }
    //            },
    //            new MusicalArtist 
    //            { 
    //                Name = "Maroon 5", 
    //                Genre = "Adult Alternative", 
    //                LatestHit = "Moves Like Jaggar",
    //             lbums = new List<Album>
    //                {
    //                    new Album { Name = "Misery", RecordingLabel = "2010" },
    //                    new Album { Name = "It Won't Be Soon Before Long", RecordingLabel = "2008" },
    //                    new Album { Name = "Wake Up Call", RecordingLabel = "2007" },
    //                    new Album { Name = "Songs About Jane", RecordingLabel = "2006" },
    //                }
    //            },
    //            new MusicalArtist 
    //            { 
    //                Name = "Lady Gaga", 
    //                Genre = "Pop", 
    //                LatestHit = "You And I",
    //             lbums = new List<Album>
    //                {
    //                    new Album { Name = "The Fame", RecordingLabel = "2008" },
    //                    new Album { Name = "The Fame Monster", RecordingLabel = "2009" },
    //                    new Album { Name = "Born This Way", RecordingLabel = "2011" },
    //                }
    //            }
    //        };

    //    }
    //    static void Main()
    //    {
    //        List<MusicalArtist> artistsDataSource = GetMusicalArtists();

    //        //IEnumerable<MusicalArtist> artistsResult =
    //        //    from artist in artistsDataSource
    //        //    select artist;
    //        IEnumerable<MusicalArtist> artistsResult =
    //            from artist in artistsDataSource
    //            select new MusicalArtist
    //            {
    //                Name = artist.Name,
    //                LatestHit = artist.LatestHit
    //            };

    //        Console.WriteLine("\nQuerying Custom Types");
    //        Console.WriteLine("---------------------\n");

    //        foreach (MusicalArtist artist in artistsResult)
    //        {
    //            Console.WriteLine(
    //                "Name: {0}\nGenre: {1}\nLatest Hit: {2}\n",
    //        ist.Name,
    //        ist.Genre,
    //        ist.LatestHit);
    //        }
    //    }
    //}
    //public class MusicalArtist
    //{
    //    public string Name { get; set; }

    //    public string Genre { get; set; }

    //    public string LatestHit { get; set; }

    //    public List<Album> Albums { get; set; }
    //}
    //public class Album
    //{
    //    public string Name { get; set; }

    //    public string RecordingLabel { get; set; }
    //}
    //=========================================================
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["LinqToSQLDBConnectionString"].ToString();

    //        string sqlSelect = "SELECT * FROM Department;" + "SELECT * FROM Employee;";

    //        // Create the data adapter to retrieve data from the database
    //        SqlDataAdapter da = new SqlDataAdapter(sqlSelect, connectString);

    //        // Create table mappings
    //   .TableMappings.Add("Table", "Department");
    //   .TableMappings.Add("Table1", "Employee");

    //        // Create and fill the DataSet
    //   taSet ds = new DataSet();
    //   .Fill(ds);

    //   taRelation dr = ds.Relations.Add("FK_Employee_Department",
    //                       s.Tables["Department"].Columns["DepartmentId"],
    //                       s.Tables["Employee"].Columns["DepartmentId"]);

    //   taTable department = ds.Tables["Department"];
    //   taTable employee = ds.Tables["Employee"];

    //        var query = from d in department.AsEnumerable()
    //                    join e in employee.AsEnumerable()
    //                    on d.Field<int>("DepartmentId") equals
    //                 .Field<int>("DepartmentId")
    //                    select new
    //                    {
    //                   ployeeId = e.Field<int>("EmployeeId"),
    //                        Name = e.Field<string>("Name"),
    //                   partmentId = d.Field<int>("DepartmentId"),
    //                   partmentName = d.Field<string>("Name")
    //                    };

    //        foreach (var q in query)
    //        {
    //            Console.WriteLine("Employee Id = {0} , Name = {1} , Department Name = {2}",
    //               q.EmployeeId, q.Name, q.DepartmentName);
    //        }

    //        Console.WriteLine("\nPress any key to continue.");
    //        Console.ReadKey();
    //    }
    //}
    //====================================
    #endregion
    #region Extension Methods
    //==============================Extension Methods===========================
    //Extension methods enable you to add methods to existing types without creating a new derived type, 
    //recompiling, or otherwise modifying the original type. 
    //An extension method is a special kind of static method, but they are called as if they were instance methods on the extended type.
    //An extension method is a static method of a static class, where the "this" modifier is applied to the first parameter. 
    //The type of the first parameter will be the type that is extended.
    //Extension methods are only in scope when you explicitly import the namespace into your source code with a using directive.
    //public static class extended
    //{
    //    public static void AddToMain(this Main xclass)
    //    {
    //        Console.WriteLine("Extended Method Here!");
    //    }
    //}
    //public class callExtended
    //{
    //    static void Main(string[] args)
    //    {
    //   in ob = new Main();
    //        ob.Display();
    //        ob.Print();
    //        ob.AddToMain();
    //        Console.ReadLine();
    //    }
    //}
    //public static class Extension
    //{
    //    public static int IntegerExtension(this string str)
    //    {
    //   turn Int32.Parse(str);
    //    }
    //}
    //class Test
    //{
    //    static void Main(string[] args)
    //    {
    //        string str = "123546";
    //        int num = str.IntegerExtension();
    //        Console.WriteLine("Output of using extension method: {0}", num);
    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region Serializer
    //===============================Serializer=====================
    //internal static class Extension
    //{
    //    internal static string serialize(this ISerializer ser)
    //    {
    //        var data = new JavaScriptSerializer();
    //        var loginfo = data.Serialize(ser);
    //   turn loginfo;
    //    }
    //}
    #endregion
    #region Lamda Expression
    //============================Lamda Expression=======================//
    //Lambda expressions are how anonymous functions are created.
    //Lambda expressions are anonymous functions that contain expressions or sequence of operators.
    //All lambda expressions use the lambda operator =>, that can be read as “goes to” or “becomes”. 
    //public class Dog
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //}
    //public class Test
    //{
    //    static void Main()
    //    {
    //        List<Dog> dogs = new List<Dog>() 
    //        {
    //            new Dog{Name="Clark",Age=2},
    //            new Dog{Name="Juf",Age=4},
    //            new Dog{Name="Maoy",Age=6}
    //        };
    //        var sortDogs = dogs.OrderByDescending(x => x.Age);
    //        foreach (var dog in sortDogs)
    //        {
    //            Console.WriteLine(String.Format("Dog {0} is {1} years old.", dog.Name, dog.Age));
    //        }
    //        //Console.ReadLine();
    //        //====================================Using Lambda Expressions with Anonymous Types========
    //        var getLastLetter = dogs.Select(x => new { Age = x.Age, Name = x.Name, LastLetter = x.Name[x.Name.Length - 1] });
    //        foreach (var letter in getLastLetter)
    //        {
    //            Console.WriteLine(letter);
    //        }
    //        var getFirstLetter = dogs.Select(x => new { Age = x.Age, Name = x.Name, FirstLetter = x.Name[0] });
    //        foreach (var letter in getFirstLetter)
    //        {
    //            Console.WriteLine(letter);
    //        }
    //        var names = dogs.Select(x => x.Name);
    //        var ages = dogs.Select(x => x.Age);
    //        foreach (var name in names)
    //        {
    //            Console.WriteLine("Dog: " + name);
    //        }
    //        foreach (var age in ages)
    //        {
    //            Console.WriteLine("Age: " + age);
    //        }
    //        Console.ReadLine();
    //    }
    //}
    //public static class Lamda
    //{
    //    public static void Main()
    //    {
    //        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
    //        List<int> EvenNumbers = list.FindAll(x => (x % 2) == 0);
    //        List<int> OddNumbers = list.FindAll(x => (x % 2) == 1);

    //        foreach (var num in EvenNumbers)
    //        {
    //            Console.WriteLine("{0} ", num);
    //        }
    //        foreach (var num in OddNumbers)
    //        {
    //            Console.WriteLine("{0} ", num);
    //        }
    //        Console.ReadLine();
    //    }
    //}
    #endregion
    #region Delegate and Events
    //==========================Delegate And Events=================================//
    //A delegate is a C# language element that allows you to reference a method. 
    //A delegate is a type that represents references to methods with a particular parameter list and return type. 
    //When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type.
    //You can invoke (or call) the method through the delegate instance.
    //Event handlers are nothing more than methods that are invoked through delegates.
    //If you were a C or C++ programmer, this would sound familiar because a delegate is basically a function pointer. 
    //A C# event is a class member that is activated whenever the event it was designed for occurs. 
    //“Events enable a class or object to notify other classes or objects when something of interest occurs. 
    //The class that sends (or raises) the event is called the publisher 
    //and the classes that receive (or handle) the event are called subscribers.”    
    //The class containing the event is used to publish the event. This is called the publisher class.
    // Some other class that accepts this event is called the subscriber class
    //public delegate string MyDel(string str);

    //class EventProgram
    //{
    //    event MyDel MyEvent;

    //    public EventProgram()
    //    {
    //        this.MyEvent += new MyDel(this.WelcomeUser);
    //    }
    //    public string WelcomeUser(string username)
    //    {
    //        return "Welcome " + username;
    //    }
    //    static void Main(string[] args)
    //    {
    //        EventProgram obj1 = new EventProgram();
    //        string result = obj1.MyEvent("Tutorials Point");
    //        Console.WriteLine(result);
    //    }
    //}
    //public delegate void StartDelegate();
    //class Eventdemo : Form
    //{
    //    public event StartDelegate StartEvent;
    //    public Eventdemo()
    //    {
    //     Button clickMe = new Button();
    //        clickMe.Parent = this;
    //        clickMe.Text = "Click Me!";
    //        clickMe.Click += new EventHandler(OnClickMeClicked);
    //        StartEvent += new StartDelegate(OnStartEvent);
    //        StartEvent();
    //    }
    //    public void OnClickMeClicked(object sender, EventArgs ea)
    //    {
    //   ssageBox.Show("You Clicked My Button!");
    //    }
    //    public void OnStartEvent()
    //    {
    //   ssageBox.Show("I Just Started!");
    //    }
    //    static void Main(string[] args)
    //    {
    //     pplication.Run(new Eventdemo());
    //    }
    //}
    //public delegate int Comparer(object obj1, object obj2);
    //public class Name
    //{
    //    private string FirstName = string.Empty;
    //    private string LasttName = string.Empty;
    //    public Name(string FirstName, string LasttName)
    //    {
    //     his.FirstName = FirstName;
    //     his.LasttName = LasttName;
    //    }
    //    public static int CompareFirstNames(object name1, object name2)
    //    {
    //        string n1 = ((Name)name1).FirstName;
    //        string n2 = ((Name)name2).LasttName;
    //        if (String.Compare(n1, n2) > 0)
    //        {
    //    urn 1;
    //        }
    //     lse if (String.Compare(n1, n2) < 0)
    //        {
    //    urn -1;
    //        }
    //     lse
    //        {
    //    urn 0;
    //        }
    //    }
    //    public override string ToString()
    //    {
    //   turn FirstName + " " + LasttName;
    //    }
    //}
    //class SimpleDeleage
    //{
    //    Name[] name = new Name[5];
    //    public SimpleDeleage()
    //    {
    //        name[0] = new Name("Joe", "Mayo");
    //        name[1] = new Name("John", "Hancock");
    //        name[2] = new Name("Jane", "Doe");
    //        name[3] = new Name("John", "Doe");
    //        name[4] = new Name("Jack", "Smith");
    //    }
    //    static void Main(string[] args)
    //    {
    //        SimpleDeleage sd = new SimpleDeleage();
    //        Comparer cmp = new Comparer(Name.CompareFirstNames);
    //        Console.WriteLine("\nBefore Sort: \n");
    //        sd.PrintNames();
    //        sd.Sort(cmp);
    //        Console.WriteLine("\nAfter Sort: \n");
    //        sd.PrintNames();
    //        Console.ReadLine();
    //    }
    //    public void Sort(Comparer compare)
    //    {
    //        object temp;
    //        for (int i = 0; i < name.Length; i++)
    //        {
    //            for (int x = i; x < name.Length; x++)
    //            {
    //                if (compare(name[i], name[x]) > 0)
    //                {
    //            p = name[i];
    //                    name[i] = name[x];
    //                    name[x] = (Name)temp;
    //                }
    //            }
    //        }
    //    }
    //    public void PrintNames()
    //    {
    //        Console.WriteLine("Names: \n");
    //        foreach (Name names in name)
    //        {
    //            Console.WriteLine(names.ToString());
    //        }
    //    }
    //}   
    //=========================================
    //public delegate string FirstDelegate(int x);
    //class DelegateTest
    //{
    //    string name;
    //    static void Main()
    //    {
    //        FirstDelegate d1 = new FirstDelegate(DelegateTest.StaticMethod);
    //   legateTest instance = new DelegateTest();
    //        instance.name = "My Instance! ";
    //        FirstDelegate d2 = new FirstDelegate(instance.InstanceMethod);
    //        Console.WriteLine(d1(10));
    //        Console.WriteLine(d2(5));
    //        Console.ReadLine();
    //    }
    //    static string StaticMethod(int z)
    //    {
    //   turn string.Format("Static Method: {0} ", z);
    //    }
    //    string InstanceMethod(int b)
    //    {
    //   turn string.Format("{0} : {1}", name, b);
    //    }
    //}
    //======================================
    //public class DelegateExercises
    //{
    //    public delegate int MyDelegate(int intValue);
    //    public int Method1(int intMethod1)
    //    {
    //   turn intMethod1 * 2;
    //    }
    //    public int Method2(int intMethod2)
    //    {
    //   turn intMethod2 * 10;
    //    }
    //    public void Method3()
    //    {
    //     yDelegate myDelegate = new MyDelegate(Method1);
    //        int result1 = myDelegate(10);
    //        System.Console.WriteLine(result1);
    //     yDelegate = new MyDelegate(Method2);
    //        int result2 = myDelegate(10);
    //        System.Console.WriteLine(result2);
    //    }
    //}
    //public class Program
    //{
    //    public static void Main()
    //    {
    //   legateExercises delegateExercises = new DelegateExercises();
    //   legateExercises.Method3();
    //        Console.ReadLine();
    //    }
    //}
    //===============================================
    //public class Program
    //{
    //    public static void Main()
    //    {
    //   legateExercises delegateExercises = new DelegateExercises();
    //   legateExercises.Method3();
    //        Console.ReadLine();
    //    }
    //}
    //public class DelegateExercises
    //{
    //    public delegate int MyDelegate(int intValue);
    //    int Method1(int intMethod1)
    //    {
    //   turn intMethod1 * 2;
    //    }
    //    int Method2(int intMethod1)
    //    {
    //   turn intMethod1 * 10;
    //    }
    //    public void Method4(MyDelegate myDelegate)
    //    {
    //        int result = myDelegate(10);
    //        Console.WriteLine(result);
    //    }
    //    public void Method3()
    //    {
    //     yDelegate myDelegate = new MyDelegate(Method1);
    //   thod4(myDelegate);
    //     yDelegate = new MyDelegate(Method2);
    //   thod4(myDelegate);
    //    }
    //}  
    //=======================================
    //public class Program
    //{
    //    public static void Main()
    //    {
    //   legateExercises delegateExercises = new DelegateExercises();
    //   legateExercises.Method3();
    //        Console.ReadLine();
    //    }
    //}
    //public class DelegateExercises
    //{
    //    public delegate int MyDelegate(int intValue);
    //    int Method1(int intMethod1)
    //    {
    //   turn intMethod1 * 4;
    //    }
    //    int Method2(int intMethod1)
    //    {
    //   turn intMethod1 * 20;
    //    }
    //    public void Method4(MyDelegate myDelegate)
    //    {
    //        for (int i = 1; i <= 5; i++)
    //            System.Console.Write(myDelegate(i) + " ");
    //    }
    //    public void Method3()
    //    {
    //     yDelegate myDelegate = new MyDelegate(Method1);
    //   thod4(myDelegate);
    //     yDelegate = new MyDelegate(Method2);
    //   thod4(myDelegate);
    //    }
    //}  
    //=================================
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //   legateExercise delegateEx = new DelegateExercise();
    //   legateEx.Method3();
    //        Console.ReadLine();
    //    }
    //}
    //public delegate void MyDelegate(ref int i);
    //public class DelegateExercise
    //{
    //    void Method(ref int i)
    //    {
    //        i = i + 5;
    //        Console.WriteLine("Method1: " + i);
    //    }
    //    public void Method3()
    //    {
    //     yDelegate myDelegate = new MyDelegate(Method);
    //     yDelegate myDelegate1 = new MyDelegate(Method);
    //     yDelegate myDelegate2 = myDelegate + myDelegate1;
    //        int intValue = 5;
    //     yDelegate2(ref intValue);
    //    }
    //}
    //========================Events=======================
    //public delegate void MyDelegate();
    //class Program
    //{
    //    public static void Main()
    //    {
    //     ventExercises ee = new EventExercises();
    //   .myDelegate += new MyDelegate(ee.Method1);
    //   .Method2();
    //   .myDelegate -= new MyDelegate(ee.Method1);
    //   .Method2();
    //        Console.ReadLine();
    //    }
    //}
    //class EventExercises
    //{
    //    public event MyDelegate myDelegate;
    //    public void Method2()
    //    {
    //        if (myDelegate != null)
    //        {
    //    hod1();
    //        }
    //    }
    //    public void Method1()
    //    {
    //        Console.WriteLine("Hello");
    //    }
    //}
    //=============================
    //public delegate void MyDelegate();
    //class Program
    //{
    //    static void Main()
    //    {
    //     ventExecises ee = new EventExecises();
    //   ._myDelegate += new MyDelegate(ee.Method);
    //   .pqr();
    //    }
    //}
    //class EventExecises
    //{
    //    public event MyDelegate _myDelegate;
    //    public void pqr()
    //    {
    //        _myDelegate();
    //        Console.ReadLine();
    //    }
    //    public void Method()
    //    {
    //        Console.WriteLine("This is a Method.");
    //    }
    //}
    //================Executes 2 methods====================
    //public delegate void MyDelegate();
    //class Program
    //{
    //    static void Main()
    //    {
    //     ventExercise ee = new EventExercise();
    //   ._myDelegate += new MyDelegate(ee.Method);
    //        xxx x = new xxx();
    //   ._myDelegate += new MyDelegate(x.xyz);
    //   .pqr();
    //        Console.ReadLine();
    //    }
    //}
    //class EventExercise
    //{
    //    public event MyDelegate _myDelegate;
    //    public void pqr()
    //    {
    //        _myDelegate();
    //    }
    //    public void Method()
    //    {
    //        Console.WriteLine("Method");
    //    }
    //}
    //class xxx
    //{
    //    public void xyz()
    //    {
    //        Console.WriteLine("xyz");
    //    }
    //}
    //==============================
    //class Program : EventExercises
    //{
    //    public delegate void MyDelegate();
    //    public void PQR()
    //    {
    //     yDelegate del = new MyDelegate(base.Method1);
    //   l();
    //    }
    //    public static void Main()
    //    {
    //        Program programInstance = new Program();
    //        programInstance.PQR();
    //        Console.ReadLine();
    //    }
    //    //public void Method1()
    //    //{
    //    //    System.Console.WriteLine("Method1 from Program");
    //    //}
    //}
    //class EventExercises
    //{
    //    public void Method1()
    //    {
    //        System.Console.WriteLine("Method1 from EventExercises");
    //    }
    //}
    #endregion
    #region Generics
    //============================Generic Stack======================//
    //A Stack collection is an abstraction of LIFO (last in, first out). 
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] Array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //        Stack obj = new Stack(Array);
    //        Console.WriteLine("Total: " + obj.Count);

    //        for (int i = 0; i <= obj.Count; i++)
    //        {
    //            obj.Pop();// removes collection after returning it
    //            Console.WriteLine(i);
    //            //Console.WriteLine(obj.Peek());
    //        }
    //        Console.ReadKey();
    //    }
    //}
    //====================Generics Queue==================
    //Queues are a special type of container that ensures the items are being accessed in a FIFO (first in, first out) manner. 
    //Queue collections are most appropriate for implementing messaging components.
    //We can define a Queue collection object using the following syntax:
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Queue obj = new Queue();
    //        obj.Enqueue("Step");
    //        obj.Enqueue("Phen");
    //        obj.Enqueue("Mark");
    //        obj.Enqueue("Asi");
    //        obj.Enqueue("Mudin");
    //        while (obj.Count != 0)
    //        {
    //            Console.WriteLine(obj.Dequeue());
    //        }
    //        Console.ReadKey();
    //    }
    //}
    //===========================Dictionary====================
    //Dictionaries are also known as maps or hash tables. 
    //The Dictionary class is a generic class and can store any data types.
    //It represents a data structure that allows you to access an element based on a key.
    //One of the significant features of a dictionary is faster lookup; 
    //you can add or remove items without the performance overhead.
    //public class emp
    //{
    //    private string name;
    //    private int salary;
    //    public emp(string name, int salary)
    //    {
    //        this.name = name;
    //        this.salary = salary;
    //    }
    //    public override string ToString()
    //    {
    //        StringBuilder sb = new StringBuilder(200);
    //        sb.AppendFormat("{0},{1}", name, salary);
    //        return sb.ToString();
    //    }
    //}
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Dictionary<string, emp> Obj = new Dictionary<string, emp>(2);

    //        emp tom = new emp("TOM", 2000);
    //        Obj.Add("tom Details: ", tom);
    //        emp john = new emp("John", 4000);
    //        Obj.Add("John Details: ", john);
    //        foreach (var item in Obj.Values)
    //        {
    //            Console.WriteLine(item);
    //        }
    //        Console.ReadKey();
    //    }
    //}
    //====================Generics==========================
    //allow you to delay the specification of the data type of programming elements in a class or a method,
    //until it is actually used in the program. In other words,
    //generics allow you to write a class or method that can work with any data type.
    //The Generic class can be defined by putting the <T> sign after the class name. 
    //It isn't mandatory to put the "T" word in the Generic type definition. 
    //You can use any word in the TestClass<> class declaration.
    //public class TestClass<T> { }
    //=============T is like a datatype ex: string,int,bool======
    //class sample
    //{

    //    static void Swap<T>(ref T a, ref T b)
    //    {
    //        T temp;
    //        temp = a;
    //        a = b;
    //        b = temp;
    //    }
    //    static void Main(string[] args)
    //    {
    //        int a = 40, b = 60;
    //        Console.WriteLine("Before: " + a + " " + b);
    //        Swap<int>(ref a, ref b);
    //        Console.WriteLine("After Swap: " + a + " " + b);
    //        Console.ReadLine();
    //    }
    //}
    //============================
    //public class MyGenericArray<T>
    //{
    //    private T[] array;
    //    public MyGenericArray(int size)
    //    {
    //   ray = new T[size + 1];
    //    }
    //    public T getItem(int index)
    //    {
    //   turn array[index];
    //    }
    //    public void setItem(int index, T value)
    //    {
    //   ray[index] = value;
    //    }
    //}
    //class Tester
    //{
    //    static void Main(string[] args)
    //    {
    //        //declaring an int array
    //     yGenericArray<int> intArray = new MyGenericArray<int>(5);
    //        //setting values
    //        for (int c = 0; c < 5; c++)
    //        {
    //            intArray.setItem(c, c * 5);
    //        }
    //        //retrieving the values
    //        for (int c = 0; c < 5; c++)
    //        {
    //            Console.Write(intArray.getItem(c) + " ");
    //        }
    //        Console.WriteLine();
    //        //declaring a character array
    //     yGenericArray<char> charArray = new MyGenericArray<char>(5);
    //        //setting values
    //        for (int c = 0; c < 5; c++)
    //        {
    //            charArray.setItem(c, (char)(c + 97));
    //        }
    //        //retrieving the values
    //        for (int c = 0; c < 5; c++)
    //        {
    //            Console.Write(charArray.getItem(c) + " ");
    //        }
    //        Console.WriteLine();
    //        Console.ReadKey();
    //    }
    //}
    #endregion
    #region Out and ref parameters
    ////=======================Out and ref parameters=======================
    ////The ref keyword passes arguments by reference. 
    ////It means any changes made to this argument in the method will be 
    ////reflected in that variable when control returns to the calling method    
    ////Ref
    ////The parameter or argument must be initialized first before it is passed to ref.
    ////It is not compulsory to initialize a parameter value before using it in a calling method.
    ////Out
    ////It is not compulsory to initialize a parameter or argument before it is passed to an out.
    ////A parameter value must be initialized within the calling method before its use.
    //class Program
    //{
    //    static void Output(out int val, out string val2, out string val3)
    //    //static void Output(ref int val, ref string val2, ref string val3)
    //    {
    //        val = 23;
    //        val2 = "I am ";
    //        val3 = " years young!";
    //    }
    //    static void Main(string[] args)
    //    {
    //        int val;
    //        string val2 = string.Empty;
    //        string val3 = string.Empty;
    //        //int value = Int32.TryParse(dr.GetValue(0).ToString(), out value) ? value : 0;
    //        Output(out val, out val2, out val3);
    //        //Output(ref val, ref val2, ref val3);
    //        Console.WriteLine(val2 + val + val3);
    //        Console.ReadLine();
    //    }
    //}
    #endregion
}

