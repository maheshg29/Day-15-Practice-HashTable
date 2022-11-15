namespace Day_15_Practice_Hash_Table
{
    class Program
    {
        public static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(18);
            hash.Add("0", "Paranoids");
            hash.Add("1", "ara");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "delibertely");
            hash.Add("15", "into");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situations");

            string hash17 = hash.Get("17");
            hash.Remove("17");

            Console.WriteLine("\n **" + hash17 + "**  is been removed");

            //Console.WriteLine("Hash Table Program. \n");

            //MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            //hash.Add("0", "To");
            //hash.Add("1", "be");
            //hash.Add("2", "or");
            //hash.Add("3", "not");
            //hash.Add("4", "to");
            //hash.Add("5", "be");


            //string hash5 = hash.Get("5");

            //Console.WriteLine("\n 5th index value : " + hash5);

            //string hash2 = hash.Get("2");

            //Console.WriteLine("\n 2th index value : " + hash2);
        }
    }
}

