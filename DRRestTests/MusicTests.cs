﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using DRRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRRest.Tests
{
    [TestClass()]
    public class MusicTests
    {
        [TestMethod()]
        public void ValidateDurationTest()
        {
           // Arrange
           Music music = new Music() { Title="Hip", Artist="MyOwn", Duration=1, PublicationYear=2014};
           // Act and Assert
            Assert.ThrowsException<ArgumentException>(()=>music.ValidateDuration());
        }
        [TestMethod()]
        public void ValidateDonotthrowExceptionDurationTest()
        {
            // Arrange
            Music music = new Music() { Title = "Hip", Artist = "MyOwn", Duration = 4, PublicationYear = 2014 };
            // Act and Assert
             music.ValidateDuration();
        }
        [TestMethod()]
        public void ValidateTitle()
        {
            // Arrange
            Music music = new Music() { Title = "", Artist = "MyOwn", Duration = 1, PublicationYear = 2014 };
            // Act and Assert
            Assert.ThrowsException<ArgumentNullException>(() => music.ValidateTitlle());
        }
        //[TestMethod()]
        //public void DoNotThrowExceptionValidateTitle()
        //{
        //    // Arrange
        //    Music music = new Music() { Title = "", Artist = "MyOwn", Duration = 1, PublicationYear = 2014 };
        //    // Act and Assert
        //    music.ValidateTitlle();
        //}

        [TestMethod()]
        public void ValidateArtist()
        {
            // Arrange
            Music music = new Music() { Title = "", Artist = "", Duration = 1, PublicationYear = 2014 };
            // Act and Assert
            Assert.ThrowsException<ArgumentNullException>(() => music.ValidateArtist());
        }

        //[TestMethod()]
        //public void DonotThrowExceptionValidateArtist()
        //{
        //    // Arrange
        //    Music music = new Music() { Title = "Thanks", Artist = "", Duration = 1, PublicationYear = 2014 };
        //    // Act and Assert
        //    music.ValidateArtist();
        //}


    }
}