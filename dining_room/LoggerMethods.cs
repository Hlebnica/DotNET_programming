using System;
using System.IO;

namespace dining_room
{
    public class LoggerMethods
    {
        public static int Position = 2;
        
        public static void LogInFile(string message)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Config.LOG_PATH, true))
                {
                    writer.WriteLine(message);
                    writer.Close();
                }
            }
            catch
            {
                throw new FileNotFoundException();
            }
        }
        
        public static void LogInConsole(string message)
        {
            Console.SetCursorPosition(3,Position);
            Console.WriteLine(message);
            Position++;
        }
    }
}
