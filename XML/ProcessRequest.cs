using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace XMLListener.XML
{
    public class ProcessRequest
    {
        public static Stream Process(HttpListenerContext context)
        {
            // Get the data from the HTTP stream
            var body = new StreamReader(context.Request.InputStream).ReadToEnd();

            byte[] b = Encoding.UTF8.GetBytes("ACK");
            context.Response.StatusCode = 200;
            context.Response.KeepAlive = false;
            context.Response.ContentLength64 = b.Length;

            var output = context.Response.OutputStream;
            output.Write(b, 0, b.Length);
            context.Response.Close();
            return output;
        }
    }
}
