namespace SimpleFileIO.FileInfoType
{
    public class FileInfoTypeOperations
    {
        public static void CreateAFile()
        {
            //Change to a folder on your machine that you have read/write access to, or run as administrator
            var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}React{Path.
                DirectorySeparatorChar}Test.txt";

            // Make a new file on the C drive.
            FileInfo f = new(fileName);

            FileStream fs = f.Create();
            // Use the FileStream object...
            // Close down file stream.
            fs.Close();
        }

        public static void CreateAndDeleteAFile()
        {
            var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}React{Path.
                DirectorySeparatorChar}Test.txt";

            // Make a new file via FileInfo.Open().
            FileInfo f2 = new FileInfo(fileName);

            using (FileStream fs2 = f2.Open(FileMode.OpenOrCreate,
             FileAccess.ReadWrite, FileShare.None))
            {
                // Use the FileStream object...
            }
            f2.Delete();
        }

        public static void OpenRead() 
        {
            var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat";

            // Get a FileStream object with read-only permissions.
            FileInfo f3 = new(fileName);

            //File must exist before using OpenRead
            f3.Create().Close();
            using (FileStream readOnlyStream = f3.OpenRead())
            {
                // Use the FileStream object...
            }
            f3.Delete();
        }

        public static void OpenWrite()
        {
            var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat";

            // Now get a FileStream object with write-only permissions.
            FileInfo f4 = new(fileName);
            using (FileStream writeOnlyStream = f4.OpenWrite())
            {
                // Use the FileStream object...
            }
            f4.Delete();
        }

        public static void OpenText() 
        {
            var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat";
            // Get a StreamReader object.
            //If not on a Windows machine, change the file name accordingly
            FileInfo f5 = new(fileName);

            //File must exist before using OpenText
            f5.Create().Close();
            using (StreamReader sreader = f5.OpenText())
            {
                // Use the StreamReader object...
            }
            f5.Delete();
        }

        public static void CreateTextAppendText() 
        {
            var fileName = $@"C{Path.VolumeSeparatorChar}{Path.DirectorySeparatorChar}Test.dat";
            
            FileInfo f6 = new(fileName);
            using (StreamWriter swriter = f6.CreateText())
            {
                // Use the StreamWriter object...
            }
            f6.Delete();

            FileInfo f7 = new(fileName);
            using (StreamWriter swriterAppend = f7.AppendText())
            {
                // Use the StreamWriter object...
            }
            f7.Delete();
        }
    }
}
