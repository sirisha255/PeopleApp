using PeopleApp.Models.ViewModels;

namespace PeopleApp.Models.Services
{
    public interface ICityService
    {
        City Create(CreateCityViewModel createCity);

        List<City> GetAll();

        List<City> FindBy(string search);

        City FindById(int id);

        bool Edit(int id, CreateCityViewModel cityViewModel);

        bool Remove(int id);
    }
}
