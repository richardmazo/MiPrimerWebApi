using AutoMapper;
using Richard.Tutorial.DTL;
using Richard.Tutorial.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Richard.Tutorial.DAL
{
    public class CountryDAO : ICountryDAO
    {
        #region Private variables
        RichardTutorialEntities Context;
        #endregion

        #region Constructor
        public CountryDAO(RichardTutorialEntities _context)
        {
            Context = _context;
        }
        #endregion

        #region Public Methods

        public async Task<List<CountryDTO>> GetAll()
        {

            return await Task.Run(() =>
            {
                return Mapper.Map<List<CountryDTO>>(Context.Countries.ToList());
            });
        }

        public async Task<List<CountryDTO>> GetAll(int CountryId)
        {

            return await Task.Run(() =>
            {
                return Mapper.Map<List<CountryDTO>>(Context.Countries.Where(x=>x.CountryId==CountryId));
            });
        }

        public async Task Create(CountryDTO eCountry)
        {
            Countries country = Mapper.Map<Countries>(eCountry);
            Context.Countries.Add(country);
            await Context.SaveChangesAsync();
        }

        public async Task Update(CountryDTO eCountry)
        {
            Countries country = Mapper.Map<Countries>(eCountry);
            Context.Countries.Attach(country);
            await Context.SaveChangesAsync();
        }

        public async Task Delete(int CountryId)
        {
            Countries country = Context.Countries.FirstOrDefault(x=>x.CountryId==CountryId);
            Context.Countries.Attach(country);
            await Context.SaveChangesAsync();
        }
        #endregion

    }
}
