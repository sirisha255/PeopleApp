namespace PeopleApp.Models.ViewModels
{
    public class PersonLanguageViewModel
    {
        public Person Person { get; set; }
        public List<Language> AllLanguages { get; set; }
        public List<Language> SpeakesLanguage { get; set; }


        public PersonLanguageViewModel()
        {
            AllLanguages = new List<Language>();
            SpeakesLanguage = new List<Language>();
        }
    }
}
