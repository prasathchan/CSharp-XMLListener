using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace XMLListener
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var Class = new XMLListener.Server.RunServer();
            Class.Run();

        }
    }
}
