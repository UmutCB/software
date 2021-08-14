using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FileConverter
{
    class Program
    {

        public static object Convert(FileConversationManager input, string inputFile, string outputFile)
        {
            object output="";
           if(input.InputFileFormat == inputFile && input.OutputFileFormat == outputFile)
            {

            }
            else
            {

            }
            return output;
        }
        static void Main(string[] args)
        {
            object obj;
            FileConversationManager convert = new FileConversationManager();
            convert.Convert(convert);
            string input = "";
            string output = "";
            Convert(convert, input, output);
        }
    }
}
