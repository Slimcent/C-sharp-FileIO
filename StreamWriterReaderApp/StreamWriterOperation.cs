namespace StreamWriterReaderApp
{
    public static class StreamWriterOperation
    {
        public static void WriteToFile() 
        {
            Console.WriteLine("***** Fun with StreamWriter / StreamReader *****\n");
            // Get a StreamWriter and write string data.
            using (StreamWriter writer = File.CreateText("reminders.txt"))
            {
                writer.WriteLine("Don't forget Mother's Day this year...");
                writer.WriteLine("Don't forget Father's Day this year...");
                writer.WriteLine("Don't forget these numbers:");
                for (int i = 0; i < 10; i++)
                {
                    writer.Write(i + " ");
                }
                // Insert a new line.
                writer.Write(writer.NewLine);
            }
            Console.WriteLine("Created file and wrote some thoughts...");
            Console.ReadLine();
            //File.Delete("reminders.txt");
        }
    }
}
