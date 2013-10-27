using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniProgramGen.Generator;

namespace UnitTests
{
    [TestClass]
    public class ICalGenUnitTests
    {
        [TestMethod]
        public void testReadingFile()
        {
            (new ICalGenerator()).readGeneratedJSON();
        }
    }
}
