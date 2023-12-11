using System;

namespace CH5_ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            try
            {
                // code that might throw an exception
            }
            catch (Exception ex)
            {
                // code that handles the exception
            }

            try
            {
                // code that might throw an exception
            }
            catch (DivideByZeroException ex)
            {
                // code that handles a DivideByZeroException
            }
            catch (IOException ex)
            {
                // code that handles an IOException
            }
            catch (Exception ex)
            {
                // code that handles all other exceptions
            }

            try
            {
                // code that might throw an exception
            }
            catch (Exception ex)
            {
                // code that handles the exception
            }
            finally
            {
                // code that always executes, regardless of whether an exception was thrown or not
            }

            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream("file.txt", FileMode.Open);
                // code that uses the file stream
            }
            catch (Exception ex)
            {
                // code that handles the exception
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Dispose();
                }
            }

            try
            {
                // Some code that may throw exceptions
            }
            catch (Exception ex)
            {
                // Handle all exceptions here
            }

            try
            {
                // Some code that may throw exceptions
            }
            catch (Exception ex)
            {
                // Do nothing with the exception
            }

            try
            {
                // Some code that may throw exceptions
            }
            catch (Exception ex)
            {
                // Swallow the exception by doing nothing
            }

            try
            {
                // Some code that may throw exceptions
            }
            catch (Exception ex)
            {
                // Handle the exception
            }
            finally
            {
                // Cleanup code that needs to run regardless of whether an exception is thrown or not
            }

            try
            {
                // Some code that may throw exceptions
            }
            catch (Exception ex)
            {
                // Handle the exception at a high level
            }

            try
            {
                // Some code that may throw exceptions
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred");
            }


        }

        private void FileOperation()
        {
            try
            {
                using (FileStream fileStream = new FileStream("file.txt", FileMode.Open))
                {
                    // code that uses the file stream
                }
            }
            catch (Exception ex)
            {
                // code that handles the exception
            }
        }

        public void DoSomething()
        {
            try
            {
                // do something that might throw an exception
            }
            catch (Exception ex)
            {
                CustomException customEx = new CustomException("An error occurred while doing something", ex);
                customEx.ErrorCode = 1234;
                throw customEx;
            }
        }

        public void EmployeeManagement()
        {
            EmployeeManager employeeManager = new EmployeeManager();
            try
            {
                int employeeId = 1;
                Employee employee = employeeManager.GetEmployeeById(employeeId);
                Console.WriteLine($"Employee {employee.FirstName} {employee.LastName} found!");
            }
            catch (EmployeeNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Catch any unexpected exceptions
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            try
            {
                Employee newEmployee = new Employee
                {
                    EmployeeId = 2,
                    FirstName = "John",
                    LastName = "Doe",
                    BirthDate = new DateTime(1990, 1, 1)
                };
                employeeManager.SaveEmployeeToFile(newEmployee);
                Console.WriteLine("Employee saved to file successfully!");
            }
            catch (FileIOException ex)
            {
                Console.WriteLine($"Error saving employee to file: {ex.
               Message}");
            }
            catch (Exception ex)
            {
                // Catch any unexpected exceptions
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}