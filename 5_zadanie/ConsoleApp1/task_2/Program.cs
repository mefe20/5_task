using System;
using System.IO;
using System.Text;

namespace Geeks
{

    class kekw
    {

        // Main Method 
        static void Main(string[] args)
        {

            // taking full path of a file 
            string strPath = "C:\\Users\\Azerty\\Desktop\\Realnaya praktika\\Kotocafe4\\img\\1235366.jpg";

            // initialize the value of filename 
            string filename = null;

            // using the method 
            filename = Path.GetFileName(strPath);
            Console.WriteLine("File = " + filename);

            Console.ReadLine();
        }
    }
}