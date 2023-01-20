namespace StreamWriterReaderApp
{
    public static class StreamReaderOperation
    {
        public static void ReadAFile() 
        {
            Console.WriteLine("***** Fun with StreamWriter / StreamReader *****\n");
           
            // Now read data from file.
            Console.WriteLine("Here are your thoughts:\n");
            using (StreamReader sr = File.OpenText("reminders.txt"))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
            Console.ReadLine();
        }
    }
}
