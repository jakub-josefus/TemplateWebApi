namespace TemplateWebApi.Models
{
    public class Template
    {
        public Template(){}
        public Template(int id, string howTo, string line, string platform)
        {
            Id = id;
            HowTo = howTo;
            Line = line;
            Platform = platform;
        }

        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line  { get; set; }
        public string Platform  { get; set; }
    }
}
