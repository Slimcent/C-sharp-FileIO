using System.Text;

namespace StringReaderWriterApp
{
    public static class StringWriterOperations
    {
        public static void WriteStringsToConsole() 
        {
            Console.WriteLine("***** Fun with StringWriter / StringReader *****\n");
            // Create a StringWriter and emit character data to memory.
            using (StringWriter strWriter = new())
            {
                strWriter.WriteLine("Don't forget Mother's Day this year...");
                // Get a copy of the contents (stored in a string) and dump
                // to console.
                Console.WriteLine("Contents of StringWriter:\n{0}", strWriter);
            }
            Console.ReadLine();
        }

        public static void WriteStringsToConsoleUsingGetStringBuilder()
        {
            using (StringWriter strWriter = new())
            {
                strWriter.WriteLine("Don't forget Mother's Day this year...");
                Console.WriteLine("Contents of StringWriter:\n{0}", strWriter);

                // Get the internal StringBuilder.
                StringBuilder sb = strWriter.GetStringBuilder();
                sb.Insert(0, "Hey!! ");
                Console.WriteLine("-> {0}", sb.ToString());
                sb.Remove(0, "Hey!! ".Length);
                Console.WriteLine("-> {0}", sb.ToString());
            }
        }
    }
}
