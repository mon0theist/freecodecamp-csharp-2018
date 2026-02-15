namespace Giraffe
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;
        // only code inside the Movie class can access "rating"
        // whereas any other code can access public attributes

        // Constructors
        public Movie(){}
        public Movie(string aTitle, string aDirector, string aRating){
            title = aTitle;
            director = aDirector;
            Rating = aRating;
            // captial Rating for getter and setter
        }

        // Create Getters and Setters for private "rating" attribute
        public string Rating // usually same as private attribute, just capitalized
        {
            get { return rating; }
            set {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR"){
                    rating = value;
                }
                else {
                    rating = "NR";
                }
            }
        }
    }
}