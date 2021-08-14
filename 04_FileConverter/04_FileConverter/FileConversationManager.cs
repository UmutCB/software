using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_FileConverter
{
    class FileConversationManager : IFileConverter
    {
        public string input;
        public string output;
        public string InputFileFormat => input;
        
     
        public string OutputFileFormat => output;
        public object Convert(object input)
        {
            input = "";
            output = "";
            return input; 
        }
    }
}
