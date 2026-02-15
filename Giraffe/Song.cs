namespace Giraffe
{
    class Song
    {
        public string title;
        public string artist;
        public int seconds;
        public static int songCount = 0; // how many total Song objects created
        // ^ static attribute
        // increment this songCount in the constructor function below

        public Song(string aTitle, string aArtist, int aSeconds)
        {
            title = aTitle;
            artist = aArtist;
            seconds = aSeconds;
            soungCount++;
        }

        // allow songCount method to be called on specific instances
        public int getSongCount()
        {
            return songCount;
        }

    }
}