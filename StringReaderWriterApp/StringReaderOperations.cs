﻿namespace StringReaderWriterApp
{
    public static class StringReaderOperations
    {
        public static void ReadStrings()
        {
            using (StringWriter strWriter = new())
            {
                strWriter.WriteLine("Don't forget Mother's Day this year...");
                Console.WriteLine("Contents of StringWriter:\n{0}", strWriter);
                // Read data from the StringWriter.
                using (StringReader strReader = new(strWriter.ToString()))
                {
                    string input = null;
                    while ((input = strReader.ReadLine()) != null)
                    {
                        Console.WriteLine(input);
                    }
                }
            }
        }
    }
}
