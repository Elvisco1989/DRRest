﻿using System.Security.Cryptography.X509Certificates;

namespace DRRest
{
    public class MusicRepository
    {
        List<Music> musicList;

        public MusicRepository()
        {
            musicList = new List<Music>()
            {
                new Music() {Title="Rock", Artist="Klaus", PublicationYear=1990, Duration=4},
                new Music() {Title="Pop", Artist="Frederick", PublicationYear=2000, Duration=3},
                new Music() {Title="Makossa", Artist="Elvis", PublicationYear=2015, Duration=4},
                new Music() {Title="SlowJam", Artist="John", PublicationYear=2024, Duration=4}
            };

           
        }
       
        public List<Music> GetMusicList(string? title=null, string? artist=null)
        {
            List<Music> list = new List<Music>();
            list = musicList.FindAll(m => (title==null || m.Title==title) && (artist==null || m.Artist == artist));
             return list;
        }

        public Music? AddMusic(Music? music)
        {
            if (music != null)
            {
                musicList.Add(music);
            }
            return music;
        }

        public Music? Delete(int id)
        {
            Music? music = musicList.Find(m=>m.Id==id);
            if (music != null)
            {
                musicList.Remove(music);
            }
            return music;

        }

        public Music? Update(int id, Music data)
        {
            Music? music = musicList.Find(m=>m.Id==id);

            if (music != null)
            { 
                music.Title = data.Title;
                music.Artist = data.Artist;
                music.Duration = data.Duration;
                music.PublicationYear = data.PublicationYear;
            }

            return music;

        }

        public Music? GetBy(int id)
        {
            Music? foundMusic = musicList.Find(m=> m.Id==id);
            if(foundMusic == null)
            {
                return null;
            }
            return foundMusic;


        }
    }
}
