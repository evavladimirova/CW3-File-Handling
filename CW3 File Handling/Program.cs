class Example
{
    public static void Main()
    {
        DirectoryInfo currDir = new DirectoryInfo(@"C:\Users\sport\Documents\ACS\Others\0210_EvaV");

        currDir.Create();

        string path = @"C:\Users\sport\Documents\ACS\Others\0210_EvaV\old.txt";
        string path2 = @"C:\Users\sport\Documents\ACS\Others\0210_EvaV\new.txt";


        try
        {
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path)) { }
            }

            if (File.Exists(path2))
            {
                File.Delete(path2);
            }

            File.Move(path, path2);
            Console.WriteLine($"File '{path}' has been moved to '{path2}'");

            if (File.Exists(path))
            {
                Console.WriteLine("The original file exists.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

    }

}


