using System.Collections.Immutable;

namespace DRRest
{
    public class Music
    {    
        public int Id { get; set; }
       
        public  string? Title  { get; set; }

        public string? Artist { get; set; }


        public int PublicationYear { get; set; }

        public int Duration { get; set;}

        public override string ToString()
        {
            return $"Id:{Id},Title:{Title},Artist:{Artist},Publication Year:{PublicationYear},Duration:{Duration}";
        }

        public void ValidateTitlle()
        {
            if (string.IsNullOrEmpty(Title))
            {
                throw new ArgumentNullException("title should not be empty");
            }
        }
        public void ValidateArtist()
        {
            if (string.IsNullOrEmpty(Artist))
            {
                throw new ArgumentNullException("Artist should not be empty");
            }
        }

        public void ValidateDuration()
        {
            if (Duration <2)
            {
                throw new ArgumentException("Duration must be greater than 2 ");
            }
        }

        public void Validate()
        {
            ValidateTitlle();
            ValidateArtist();
            ValidateDuration();
        }

    }
}
