namespace BinaryWriterReaderApp
{
    public static class BinaryWriterOperations
    {
        public static void WriteBinary() 
        {
            Console.WriteLine("***** Fun with Binary Writers / Readers *****\n");
            // Open a binary writer for a file.
            FileInfo f = new("BinFile.txt");
            using (BinaryWriter bw = new(f.OpenWrite()))
            {
                // Print out the type of BaseStream.
                // (System.IO.FileStream in this case).
                Console.WriteLine("Base stream is: {0}", bw.BaseStream);
                // Create some data to save in the file.
                double aDouble = 1234.67;
                int anInt = 34567;
                char character = 'a';
                string aString = "A, B, C";
                // Write the data.
                bw.Write(aDouble);
                bw.Write(anInt);
                bw.Write(aString);
                bw.Write(character);
            }
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
