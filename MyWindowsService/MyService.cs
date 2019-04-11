using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyWindowsService
{
    public partial class MyService : ServiceBase
    {
        public MyService()
        {
            InitializeComponent();
        }

        string filePath = @"E:\VSworkBench\MyWindowsService\Test.txt";

        protected override void OnStart(string[] args)
        {
            FileStream stream = new FileStream(filePath,FileMode.Append);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine($"{DateTime.Now},服务启动！");
            writer.Close();
            stream.Close();
        }

        protected override void OnStop()
        {
            FileStream stream = new FileStream(filePath,FileMode.Append);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine($"{DateTime.Now},服务关闭！");
            writer.Close();
            stream.Close();
        }
    }
}
