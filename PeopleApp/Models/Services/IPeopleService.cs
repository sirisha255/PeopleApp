using PeopleApp.Models.ViewModels;

namespace PeopleApp.Models.Services
{
    public interface IPeopleService
    {
        Person Create(CreatePersonViewModel createPerson);
        List<Person> GetAll();
        List<Person> Search(string Search);
        Person FindById(int id);
        bool Edit(int id, CreatePersonViewModel editPerson);
        void Remove(int id);

    }
}
