using System.Security.Cryptography.X509Certificates;

namespace DRRest
{
    public class MusicRepository
    {
        List<Music> musicList;

        public MusicRepository()
        {
            musicList = new List<Music>()
            {
                new Music() { Id=1,Title="Rock", Artist="Klaus", PublicationYear=1990, Duration=4},
                new Music() { Id=2,Title="Pop", Artist="Frederick", PublicationYear=2000, Duration=3},
                new Music() {Id=3,Title="Makossa", Artist="Elvis", PublicationYear=2015, Duration=4},
                new Music() {Id= 4,Title="SlowJam", Artist="John", PublicationYear=2024, Duration=4},
                new Music(){Id=5, Title="BottleDance", Artist="Johnminang",PublicationYear=2024, Duration=4},


                new Music(){Id=6, Title="Bone", Artist="Johnminang",PublicationYear=2024, Duration=4}



            };

           
        }
        // This is my DR branch BRANCH
        public List<Music> GetMusicList(string? title=null, string? artist=null)
        {
            List<Music> list = new List<Music>();
            list = musicList.FindAll(m => (title==null || m.Title==title) && (artist==null || m.Artist == artist));
             return list;
        }
    }
}
