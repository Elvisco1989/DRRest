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
            Assert.AreEqual(12, Expected);
        }
        [TestMethod()]
        public void AddmusicTest()
        {
            //Arrange
            MusicRepository musicRepository = new MusicRepository();
            Music mo = new Music();

            //Act
            musicRepository.AddMusic(mo);

            //Assert
            var Expected = musicRepository.GetMusicList().Count;
            Assert.AreEqual(13, Expected);
        }
        [TestMethod()]
        public void DeleteMusic()
        {
            //Arrange
            MusicRepository musicRepository = new MusicRepository();
            Music mo = new Music();
            mo.Id = 1;

            //Act
            musicRepository.Delete(1);


            //Assert
            var Expected = musicRepository.GetMusicList().Count;
            Assert.AreEqual(11, Expected);

        }
        [TestMethod()]
        public void UpdateMusic()
        {
            MusicRepository musicRepository = new MusicRepository();
            Music mo = new Music() { Artist="Ndum", Title="Football", PublicationYear=2024, Duration=4};
            int id = 1;

            //Act
            musicRepository.Update(1, mo);
            var Expected = musicRepository.GetMusicList();
            var data = Expected[0];


            //Assert
           
            Assert.AreEqual(data.Artist, mo.Artist);

        }
    }
}