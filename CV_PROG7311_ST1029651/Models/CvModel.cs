namespace CV_PROG7311_ST1029651.Models
{
    public class CvModel
    {
        public string FirstNames { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public string LinkedIn { get; set; }
        public string Summary { get; set; }
        public List<string> TechnicalSkills { get; set; }
        public List<Education> EducationList { get; set; }
    }

    public class Education
    {
        public string Name { get; set; }
        public string Duration { get; set; }
        public string Achievement {  get; set; }
        public string EducationLevel { get; set; }
    }
}
