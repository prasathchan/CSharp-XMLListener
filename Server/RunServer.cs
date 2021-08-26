using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using XMLListener.XML;

namespace XMLListener.Server
{
    public class RunServer
    {
        public void Run()
        {
            var prefix = "http://localhost:4333/";

            HttpListener listener = new HttpListener();
            listener.Prefixes.Add(prefix);
            try
            {
                listener.Start();
            }
            catch (HttpListenerException hlex)
            {
                var catchd = hlex;
                return;
            }
            while (listener.IsListening)
            {
                var context = listener.GetContext();
                ProcessRequest.Process(context);
            }
            listener.Close();
        }
    }
}
