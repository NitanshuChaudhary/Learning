
public class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 5, 2, 9, 1, 5, 6 };
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    SwapNumber(ref arr[j], ref arr[j + 1]);
                }
            }

        }

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }

    static void SwapNumber(ref int value_1, ref int value_2)
    {
        value_1 = value_1 + value_2;
        value_2 = value_1 - value_2;
        value_1 = value_1 - value_2;
    }



    //static void Main(string[] arg)
    //{

    //    var arr = new[] { 2, 3, 5, 99, 100, 900 };
    //    for (int i = 0; i < arr.Length - 1; i++)
    //    {
    //        int smallNumber = 0;
    //        int index = 0;

    //        for (int j = i; j < arr.Length - 1; j++)
    //        {
    //            if (smallNumber < arr[j])
    //            {
    //                smallNumber = arr[j];
    //                index = j;
    //            }


    //        }
    //        swipeValues(ref arr[i], ref arr[index]);

    //    }
    //    foreach (var res in arr)
    //    {
    //        Console.WriteLine(res);
    //    }


    //}

    static void swipeValues<Type>(ref Type firstParam, ref Type secondParam)
    {
        Type temp = firstParam;
        firstParam = secondParam;
        secondParam = temp;

    }
    //static void Main(string[] args)
    //{
    //    EmployeCheck dd = new();
    //    // Simulate data
    //    dd.CheckData(5);
    //    var items = GetSampleData();

    //    Console.WriteLine("Enter page number:");
    //    int pageNumber = int.Parse(Console.ReadLine() ?? "1");

    //    Console.WriteLine("Enter page size:");
    //    int pageSize = int.Parse(Console.ReadLine() ?? "5");

    //    // Get paginated result
    //    var paginatedItems = GetPaginatedData(items, pageNumber, pageSize);

    //    // Display the paginated result
    //    Console.WriteLine($"Page {pageNumber} of size {pageSize}:");
    //    foreach (var item in paginatedItems)
    //    {
    //        Console.WriteLine(item);
    //    }

    //    // Display additional pagination info
    //    Console.WriteLine($"\nTotal Items: {items.Count}");
    //    Console.WriteLine($"Total Pages: {Math.Ceiling(items.Count / (double)pageSize)}");
    //}

    // Method to simulate sample data
    static List<string> GetSampleData()
    {
        return Enumerable.Range(1, 50).Select(i => $"Item {i}").ToList();
    }

    // Method to perform pagination
    static IEnumerable<string> GetPaginatedData(List<string> items, int pageNumber, int pageSize)
    {
        return items.Skip(pageNumber - 1).Take(pageSize);
    }
    //public static void Main(string[] args)
    //{

    //    Console.Write("Wellcome to the Url Shorten! Please provide your URL:- ");
    //    string url = Console.ReadLine()!;
    //    Console.WriteLine();
    //    if (rLShorten.urlvalidation(url))
    //    {
    //        string shorturl = rLShorten.ShortenURL(url);
    //        // Simulate progress (replace with actual progress updates)
    //        for (int i = 0; i <= 100; i++)
    //        {
    //            DisplayProgressBar(i, 100, "Shortening URL...");
    //             System.Threading.Thread.Sleep(10);
    //        }
    //        Console.WriteLine("\n");
    //        Console.WriteLine("Your ShortURL please copy or use that {0}", shorturl);
    //    }
    //    else
    //    {
    //        Console.WriteLine("Please Enter valid Url");
    //        return;
    //    }
    //    Console.Write("Please provide your Shorten URL :- ");
    //    string shortenurl = Console.ReadLine()!;
    //     rLShorten.ExpandURL(shortenurl);


    //    void DisplayProgressBar(int progress, int total, string status)
    //    {
    //        int progressBarWidth = 50; // adjust the width of the progress bar
    //        int progressPercentage = (int)(((double)progress / total) * 100);
    //        int progressBarChars = (int)(((double)progress / total) * progressBarWidth);

    //        // Build the progress bar string
    //        string progressBar = new string('=', progressBarChars) + (">") + new string(' ', progressBarWidth - progressBarChars);

    //        // Print the progress bar with status and percentage
    //        Console.Write("\r" + status + " [" + progressBar + "] " + progressPercentage + "%");
    //    }


    //}

    //public class URLShorten
    //{
    //    public Dictionary<string, string> urlDb = new Dictionary<string, string>();
    //    public Dictionary<string, string> reverseurlDb = new Dictionary<string, string>();
    //    public string BaseUrl = "Nitanshu.com";

    //    public URLShorten()
    //    {
    //        urlDb = new Dictionary<string, string>();
    //        reverseurlDb = new Dictionary<string, string>();
    //    }
    //    public string ShortenURL(string url)
    //    {
    //        if (reverseurlDb.ContainsKey(url))
    //        {
    //            return reverseurlDb[url];
    //        }
    //        string shortUrl = $"{BaseUrl}" + GenerateHash(url);
    //        urlDb.Add(shortUrl, url);
    //        reverseurlDb.Add(url, shortUrl);
    //        return shortUrl;
    //    }
    //    public void ExpandURL(string url)
    //    {
    //        string redirectUrl = "";
    //        if (reverseurlDb.ContainsKey(url))
    //        {
    //            redirectUrl = reverseurlDb[url];
    //        }
    //        else
    //        {
    //          redirectUrl = urlDb.FirstOrDefault(x=>x.Key == url).Value;
    //        }
    //        RedirectToUri(redirectUrl);

    //    }

    //    public void RedirectToUri(string uri)
    //    {
    //        try
    //        {
    //            // Validate the URI
    //            if (Uri.IsWellFormedUriString(uri, UriKind.Absolute))
    //            {
    //                // Start the default browser with the URI
    //                Process.Start(new ProcessStartInfo
    //                {
    //                    FileName = uri,
    //                    UseShellExecute = true // Needed for launching the browser in .NET Core
    //                });

    //                Console.WriteLine("Redirected to: " + uri);
    //            }
    //            else
    //            {
    //                Console.WriteLine("Invalid URI");
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine($"Failed to redirect to URI. Error: {ex.Message}");
    //        }
    //    }
    //    public string GenerateHash(string url)
    //    {
    //        using (var sha256 = SHA256.Create())
    //        {
    //            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(url));
    //            return Convert.ToBase64String(hashBytes).Substring(0, 6);
    //        }
    //    }
    //    public Func<string, bool> urlvalidation = (url) =>
    //    {
    //        if (url == null || string.IsNullOrEmpty(url) ||!Uri.IsWellFormedUriString(url, UriKind.Absolute))
    //            return false;
    //        return true;
    //    };
    //}



    public class EmployeCheck
    {
        public void CheckData(int recursivesize)
        {
            int factorialvalue = recursivesize;
            int value = 0;
            for (int i = recursivesize; i > 0; i--)
            {
                if (i == recursivesize)
                {
                    value = i;
                }
                else
                {
                    value = value * i;
                }

                Console.WriteLine("Factorial of {0} is{1}", factorialvalue, value);



            }

            //bool IsEndRescuriion = recursivesize == 0;
            //Console.WriteLine("Employe Payload is valid RecursiveCount:{0}", recursivesize);

            //if (!IsEndRescuriion)
            //{
            //    recursivesize--;

            //    CheckData(recursivesize);
            //}

            //Console.WriteLine("Recussion are End recursioncount:{0}", recursivesize);
            //return;
        }

        //public void recusiveFunction(int currentsize,)
        //{
        //    if (currentsize != endsize)
        //    {

        //        CheckData(currentsize);
        //    }
        //}

        //public void CheckData(Employee employee  int recursivesize)
        //{
        //    if (employee.CheckValidation(employee))
        //    if (recursivesize > 0)
        //    {
        //        recursivesize--;
        //        Console.WriteLine("Employe Payload is valid RecursiveCount:{0}", recursivesize);

        //    }
        //    if (recursivesize >= 0 && )
        //    {
        //        CheckData(new Employee, recursivesize);
        //    }
        //    Console.WriteLine("Employee payload is not valid");
        //}
    }

    public class Messenger
    {
        public Func<int, int, int> Multiply = (x, y) =>
        {
            return x * y;
        };

        public Func<Employee, bool> CheckValidation = (employe) =>
        {
            return (employe.EmpId is < 0
                       || string.IsNullOrEmpty(employe.EmpName)
                       || employe.Phone.Length < 10) ? false : true;

        };
        public string MessengerFunction(string message)
        {
            Console.WriteLine("Function are calling now broker are print the message");
            return "From MessengerFunction";
        }
    }

    public class DelegateBroker
    {
        public string DelegateMessengerFunction(string message)
        {
            Console.WriteLine(message);
            return "From DelegateMessengerFunction";
        }
    }

    public class Employee : Messenger
    {
        public int EmpId { get; set; }

        public required string EmpName { get; set; }
        public string Phone { get; set; }
    }


}

public class A
{
    public virtual void Assignvalue()
    {
        Console.WriteLine("Base Function call");
    }
}

public class B : A
{

    public override void Assignvalue()
    {
        Console.WriteLine("Child Function call");
    }
}




