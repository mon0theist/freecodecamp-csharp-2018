namespace Giraffe 
{
    class Student 
    {
        public string name;
        public string major;
        public double gpa;

        // Constructors
        public Student(){}
        public Student(string aName, string aMajor, double aGpa){
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool HasHonors(){
            if (gpa >= 3.5){
                return true;
            } else {
                return false;
            }
        }
    }

}