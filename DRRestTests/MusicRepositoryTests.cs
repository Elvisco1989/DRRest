using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRRest.Tests
{
    [TestClass()]
    public class MusicRepositoryTests
    {
        [TestMethod()]
        public void MusicRepositoryTest()
        {
            // Arrange
            MusicRepository repository = new MusicRepository();
            // Act
            var Expected = repository.GetMusicList().Count;
           // Assert
            Assert.AreEqual(4, Expected);
        }
    }
}