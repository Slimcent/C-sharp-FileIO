namespace BinaryWriterReaderApp
{
    public static class BinaryReaderOpeartions
    {
        public static void ReadBinary() 
        {
            FileInfo f = new("BinFile.txt");
           
            // Read the binary data from the stream.
            using (BinaryReader br = new(f.OpenRead()))
            {
                Console.WriteLine(br.ReadDouble());
                Console.WriteLine(br.ReadInt32());
                Console.WriteLine(br.ReadString());
            }
            Console.ReadLine();
        }
    }
}
