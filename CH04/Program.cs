using LanguageExt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

using static LanguageExt.Prelude;

namespace CH4;

public class Program
{
    static void Main(string[] args)
    {
        CalculateAreaExampleA();
        CalculateAreaExampleB();
        VendorsLinqExample();
        PrintVendorsList();
        UsingThePersonRecordExample();
        FunctionalProgrammingExample();

        var viewModel = new ViewModel();
        var amount = viewModel.GetAmountByName("Life Insurance");
    }

    static void CalculateAreaExampleA()
    {
        // Create a rectangle object
        Rectangle myRectangle = new Rectangle(5, 3);
        // Calculate and print the area
        Console.WriteLine("Area of the rectangle: " + myRectangle.CalculateArea());
    }

    static void CalculateAreaExampleB()
    {
        // Use the function to calculate and print the area
        double length = 5;
        double width = 3;
        Console.WriteLine("Area of the rectangle: " + CalculateArea(length, width));
    }

    static double CalculateArea(double length, double width)
    {
        return length * width;
    }

    static void VendorsLinqExample()
    {
        var vendors = (from p in GetProducts() select p.Vendor).Distinct().OrderBy(x => x);

        foreach (var vendor in vendors)
            Console.WriteLine(vendor);

        Console.ReadKey();
    }

    private static void PrintVendorsList()
    {
        var vendors = (from p in GetProducts()
                       select p.Vendor)
        .Distinct()
        .OrderBy(x => x);
        foreach (var vendor in vendors)
            Console.WriteLine(vendor);
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    private static List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product("Microsoft", "Microsoft Office"),
            new Product("Oracle", "Oracle Database"),
            new Product("IBM", "IBM DB2 Express"),
            new Product("IBM", "IBM DB2 Express"),
            new Product("Microsoft", "SQL Server 2017 Express"),
            new Product("Microsoft", "Visual Studio 2019 Community Edition"),
            new Product("Oracle", "Oracle JDeveloper"),
            new Product("Microsoft", "Azure"),
            new Product("Microsoft", "Azure"),
            new Product("Microsoft", "Azure Stack"),
            new Product("Google", "Google Cloud Platform"),
            new Product("Amazon", "Amazon Web Services")
        };
    }

    private static void UsingThePersonRecordExample()
    {
        Person person1 = new Person("John", "Doe", 30);
        Person person2 = new Person("Jane", "Smith", 25);
        Person updatedPerson = person1 with { Age = 35 };
        Console.WriteLine(person1.FirstName); // Output: John
        Console.WriteLine(person2.Age);      // Output: 25
        Console.WriteLine($"{updatedPerson.FirstName} {updatedPerson.LastName} is {updatedPerson.Age} years old."); // Output: John Doe is 35 years old.
    }

    public void UpdateUserInfo(int id, string username, string firstName,
string lastName, string addressLine1, string addressLine2, string
addressLine3, string addressLine4, string addressLine5, string city, string
postcode, string region, string country, string homePhone, string
workPhone, string mobilePhone, string personalEmail, string workEmail,
string notes)
    {
        // ### implementation omitted ###
    }

    public void UpdateUserInfo(UserInfo userInfo)
    {
        // ### implementation omitted ###
    }

    public void SrpBrokenMethod(string folder, string filename, string text,
string emailFrom, string password, string emailTo, string subject, string msg, string mediaType)
    {
        var file = $"{folder}{filename}";
        File.WriteAllText(file, text);
        MailMessage message = new MailMessage();
        SmtpClient smtp = new SmtpClient();
        message.From = new MailAddress(emailFrom);
        message.To.Add(new MailAddress(emailTo));
        message.Subject = subject;
        message.IsBodyHtml = true;
        message.Body = msg;
        Attachment emailAttachment = new Attachment(file);
        emailAttachment.ContentDisposition.Inline = false;
        emailAttachment.ContentDisposition.DispositionType = DispositionTypeNames.Attachment;
        emailAttachment.ContentType.MediaType = mediaType;
        emailAttachment.ContentType.Name = Path.GetFileName(filename);
        message.Attachments.Add(emailAttachment);
        smtp.Port = 587;
        smtp.Host = "smtp.gmail.com";
        smtp.EnableSsl = true;
        smtp.UseDefaultCredentials = false;
        smtp.Credentials = new NetworkCredential(emailFrom, password);
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtp.Send(message);
    }

    private static void FunctionalProgrammingExample()
    {
        Console.WriteLine("Hello, and welcome to the functional programming world!");
        ExceptionHandlingUsingMonadSome();
    }

    public static bool IsValidInteger(string input)
    {
        return input is { } && int.TryParse(input, out _);
    }
    public static int GetValidIntegerFromUser(string message)
    {
        int result = 0;
        bool validInput = false;
        while (!validInput)
        {
            Console.Write(message);
            string input = Console.ReadLine();

            if (int.TryParse(input, out result))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        return result;
    }
    public static Option<int> DivideSome(int x, int y)
    {
        return y == 0 ? None : Some(x / y);
    }
    public static void ExceptionHandlingUsingMonadSome()
    {
        int x = GetValidIntegerFromUser("Enter an integer: ");
        int y = GetValidIntegerFromUser("Enter another integer: ");
        var result = DivideSome(x, y);
        result.Match(Some: value => Console.WriteLine($"Result: {value}"), None: () => Console.WriteLine("Error: Division by zero"));
    }

    public static Either<string, int> DivideEither(int x, int y)
    {
        return y == 0 ? "Division by zero" : x / y;
    }
    public static void ExceptionHandlingUsingMonadEither()
    {
        int x = GetValidIntegerFromUser("Enter an integer: ");
        int y = GetValidIntegerFromUser("Enter another integer: ");
        var result = DivideEither(x, y);
        result.Match(Left: value => Console.WriteLine($"Result: {value}"), Right: error => Console.WriteLine("Error: Division by zero"));
    }

    /// <summary>
    /// Calculates the sum of two integers.
    /// </summary>
    /// <param name="a">The first integer.</param>
    /// <param name="b">The second integer.</param>
    /// <returns>The sum of the two integers.</returns>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Demonstrates inline comments.
    /// </summary>
    public void ProcessData()
    {
        // Step 1: Load data from the database
        // ...

        // Step 2: Perform data processing
        // ...

        // Step 3: Save the processed data
        // ...
    }

    public void ReadDataFromFile(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string data = reader.ReadToEnd();
            // Process data
        }
        // 'reader' is automatically disposed of at this point
    }

    public bool AuthenticateUser(string username, string password)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            // Handle invalid input
            return false;
        }
        // Authenticate the user
        // ...
        return true;
    }

    public string EncryptData(string data)
    {
        string encryptedData = string.Empty;
        // Use encryption libraries to encrypt 'data'
        // ...
        return encryptedData;
    }

    public Student Find(List<Student> list, int id)
    {
        Student r = null;
        foreach (var i in list) 
        {
            if (i.Id == id)
            {
                r = i;
                break;
            }
        }
        return r;
    }

    public void CalculateTotalPrice()
    {
        // Code to calculate the total price
    }
    public void CalculateDiscountedPrice()
    {
        // Same code to calculate the discounted price
    }
}
