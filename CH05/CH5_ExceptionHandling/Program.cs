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

    }
}