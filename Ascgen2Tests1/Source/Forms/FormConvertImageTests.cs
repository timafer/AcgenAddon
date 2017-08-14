using Microsoft.VisualStudio.TestTools.UnitTesting;
using JMSoftware.AsciiGeneratorDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace JMSoftware.AsciiGeneratorDotNet.Tests
{
    [TestClass()]
    public class FormConvertImageTests
    {
        [TestMethod()]
        public void CloseBrowserTest()
        {
            int i = Directory.GetFiles("C:\\Users\\Timafer\\Desktop\\Ascgen2-2.0.0-source\\AcgenAddon\\Downloaded_pics").Length;
            FormConvertImage f = new FormConvertImage(new List<string>());
            f.CloseBrowser("something", new EventArgs());
            if (Directory.GetFiles("C:\\Users\\Timafer\\Desktop\\Ascgen2-2.0.0-source\\AcgenAddon\\Downloaded_pics").Length != i-1&& i!=0)
            {
                Assert.Fail();
            }
        }
    }
}