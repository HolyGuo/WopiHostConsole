// Copyright 2014 The Authors Marx-Yu. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WopiCobaltHost
{
    class Program
    {
        static void Main()
        {
            // docsPath parameter may change to the real local path that save demo documents(word or excel file)
            string ip_port = ConfigurationManager.AppSettings.Get("ip_port");
            string file_path = ConfigurationManager.AppSettings.Get("file_path");
            CobaltServer svr = new CobaltServer(file_path, ip_port);
            svr.Start();

            Console.WriteLine("A simple wopi webserver. Press any key to quit.");
            Console.ReadKey();

            svr.Stop();
        }
    }
}
