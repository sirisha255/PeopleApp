namespace PeopleApp.Models.Repos
{
    public interface IPeopleRepo
    {
        Person Create(Person person);

        List<Person> GetAll();

        Person GetById(int id);

        bool Update(Person person); 

        void Delete(Person person);
    }
}
