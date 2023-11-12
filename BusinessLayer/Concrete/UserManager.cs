using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class UserManager : IUserService
	{
		IUser _user;

		public UserManager(IUser user)
		{
			_user = user;
		}
		public void UserAdd(User user)
		{
			_user.Add(user);
		}
		public User GetById(int id)
		{
			return _user.GetById(id);
		}
		public List<User> ListAll()
		{
			return _user.ListAll();
		}
		
		public void UserRemove(User user)
		{
			_user.Delete(user);
		}

		public void UserUpdate(User user)
		{
			_user.Update(user);
		}
	}
}
