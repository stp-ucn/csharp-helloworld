namespace HelpCode.Model
{
    public class Student
    {
        public Student(int id, string? firstName, string? lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id {  get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public override string? ToString()
        {
            //string concatenation
            //string? thisStudent = Id + ", " + FirstName + " " + LastName;

            //string interpolation
            // use double { or } to escape curly braces
            string? thisStudent = $"{Id}: {{}} {FirstName} {LastName}";
            return thisStudent;
        }
    }
}
