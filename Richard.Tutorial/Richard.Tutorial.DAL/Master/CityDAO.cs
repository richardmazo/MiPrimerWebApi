
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Richard.Tutorial.DTL;
using Richard.Tutorial.Model;
using AutoMapper;

namespace Richard.Tutorial.DAL
{
    public class CityDAO : ICityDAO
    {
        #region Private variables
        RichardTutorialEntities Context;
        #endregion

        #region Constructors
        public CityDAO(RichardTutorialEntities _context)
        {
            Context = _context;
        }
        #endregion

        #region Public Methods

        public async Task<List<CityDTO>> GetAll()
        {

            return await Task.Run(() =>
            {
                return Mapper.Map<List<CityDTO>>(Context.Cities.ToList());
            });
        }

        public async Task<List<CityDTO>> GetAll(int CityId)
        {
            return await Task.Run(() =>
            {
                return Mapper.Map<List<CityDTO>>(Context.Cities.Where(x=>x.CityId == CityId).ToList());
            });
        }

        public async Task Create(CityDTO eCity)
        {
            Cities city = Mapper.Map<Cities>(eCity);
            Context.Cities.Add(city);
            await Context.SaveChangesAsync(); 
        }

        public async Task Update(CityDTO eCity)
        {
            Cities city = Mapper.Map<Cities>(eCity);
            Context.Cities.Attach(city);
            await Context.SaveChangesAsync();
        }

        public async Task Delete(int CityId)
        {
            Cities city = Context.Cities.FirstOrDefault(x=>x.CityId==CityId);
            Context.Cities.Remove(city);
            await Context.SaveChangesAsync();
        }
        #endregion


    }
}
