using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsServiceClient
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        string serviceFilePath = $"{Application.StartupPath}\\MyWindowsService.exe";
        string serviceName = "MyService";

        //事件：安装服务
        private void install_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(serviceName))
            {
                this.UninstallService(serviceFilePath);
            }
            this.InstallService(serviceFilePath);
        }

        //事件：启动服务
        private void start_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(serviceName))
            {
                this.StartService(serviceName);
            }
        }

        //事件：停止服务
        private void stop_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(serviceName))
            {
                this.StopService(serviceName);
            }
        }

        //事件：卸载服务
        private void uninstall_Click(object sender, EventArgs e)
        {
            if (this.IsServiceExisted(serviceName))
            {
                this.StopService(serviceName);
                this.UninstallService(serviceFilePath);
            }
        }

        //判断服务是否存在
        private bool IsServiceExisted(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController sc in services)
            {
                if (sc.ServiceName.ToLower() == serviceName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        //安装服务
        private void InstallService(string serviceFilePath)
        {
            AssemblyInstaller installer = new AssemblyInstaller();
            installer.UseNewContext = true;
            installer.Path = serviceFilePath;
            IDictionary savedState = new Hashtable();
            installer.Install(savedState);
            installer.Commit(savedState);
        }

        //卸载服务
        private void UninstallService(string serviceFilePath)
        {
            AssemblyInstaller installer = new AssemblyInstaller();
            installer.UseNewContext = true;
            installer.Path = serviceFilePath;
            installer.Uninstall(null);
        }

        //启动服务
        private void StartService(string serviceName)
        {
            ServiceController controller = new ServiceController(serviceName);
            if (controller.Status == ServiceControllerStatus.Stopped)
            {
                controller.Start();
            }
        }

        //停止服务
        private void StopService(string serviceName)
        {
            ServiceController controller = new ServiceController(serviceName);
            if (controller.Status == ServiceControllerStatus.Running)
            {
                controller.Stop();
            }
        }      
    }
}
