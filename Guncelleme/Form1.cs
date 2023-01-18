using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using HtmlAgilityPack;
using System.IO.Compression;
using System.Reflection;
using System.Deployment.Application;

namespace Guncelleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {/*
            WebRequest wr = WebRequest.Create(new Uri("https://docs.google.com/document/d/1iIBCY6P5EHFJpkenYPHcuNlvZLmo3WpYXnXJvYXhz-E/edit?usp=sharing/test.txt"));
            WebResponse ws = wr.GetResponse();
            StreamReader sr = new StreamReader(ws.GetResponseStream());
            string currentversion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            string newversion = sr.ReadToEnd();
            if (currentversion.Contains(newversion))
            {
                MessageBox.Show("Sürüm Güncel");
            }
            else
            {
                MessageBox.Show("Yeni Sürüm var!");
            }
            */
        }
    }
}
