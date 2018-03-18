using AutoMapper;
using Richard.Tutorial.DTL;
using Richard.Tutorial.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richard.Tutorial.DAL
{
    public class UserDAO : IUserDAO
    {
        #region Private variables
        RichardTutorialEntities Context;
        #endregion

        #region Constructors
        public UserDAO(RichardTutorialEntities _context)
        {
            Context = _context;
        }
        #endregion

        #region Public Methods

        public async Task<List<UserDTO>> GetAll()
        {

            return await Task.Run(() =>
            {
                return Mapper.Map<List<UserDTO>>(Context.Users.ToList());
            });
        }

        public async Task<List<UserDTO>> GetAll(int UserId)
        {
            return await Task.Run(() =>
            {
                return Mapper.Map<List<UserDTO>>(Context.Users.Where(x => x.UserId == UserId).ToList());
            });
        }

        public async Task Create(UserDTO eUser)
        {
            Users user = Mapper.Map<Users>(eUser);
            Context.Users.Add(user);
            await Context.SaveChangesAsync();
        }

        public async Task Update(UserDTO eUser)
        {
            // Users user = Mapper.Map<Users>(eUser);
            // Context.Users.Attach(user);
            // await Context.SaveChangesAsync();

            Context.Entry(Mapper.Map<Users>(eUser)).State = EntityState.Modified;
            await Context.SaveChangesAsync();

        }

        public async Task Delete(int UserId)
        {
            Users user = Context.Users.FirstOrDefault(x => x.UserId == UserId);
            Context.Users.Remove(user);
            await Context.SaveChangesAsync();
        }
        #endregion

    }
}
