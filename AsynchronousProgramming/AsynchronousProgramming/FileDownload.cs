using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    internal class FileDownload
    {
        public static async Task<string> DownloadFileAsync()
        {
            Console.WriteLine("Downloading file...");
            await Task.Delay(2000);
            return "File downloaded!";
        } 
    }
}