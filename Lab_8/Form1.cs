using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            mainF();
        }

        private void mainF()
        {
            object result = Registry.GetValue(
            "HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0",
            "ProcessorNameString", "");
            cpu.Text = result.ToString();

            result = Registry.GetValue(
           "HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\BIOS",
           "BIOSVersion", "");
            version.Text = result.ToString();

            result = Registry.GetValue(
           "HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\BIOS",
           "BIOSVendor", "");
            producer.Text = result.ToString();
        }
    }
}
