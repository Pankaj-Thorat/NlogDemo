using System;
using NLog;

namespace NlogDemoApplication
{
    class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Console.WriteLine($"Working Directory: {Environment.CurrentDirectory}");
            NLog.LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration("NLog.config", true);

            try
            {
                Logger.Info("Starting the application...");

                // Simulate some code that might throw an exception
                int result = DivideNumbers(10, 05);

                Logger.Info($"Result: {result}");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "An error occurred in the application.");
            }
            finally
            {
                Logger.Info("Exiting the application...");
            }
        }

        static int DivideNumbers(int a, int b)
        {
            Logger.Info($"Dividing {a} by {b}");
            return a / b;
        }
    }
}
