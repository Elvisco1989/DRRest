namespace DRRest
{
    public class Music
    {    
        public int Id;
        public  string? Title  { get; set; }

        public string? Artist { get; set; }


        public int PublicationYear { get; set; }

        public int Duration { get; set;}

        public override string ToString()
        {
            return $"{Title},{Artist},{PublicationYear}, {Duration}";
        }

        public void ValidateTitlle()
        {
            if (Title != null)
            {
                throw new ArgumentNullException("title should not be empty");
            }
        }
        public void ValidateArtist()
        {
            if (Artist != null)
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

    }
}
