﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IUserService
	{
		void UserAdd(User user);
		//void UserRemove(User user);
		//void UserUpdate(User user);
		//List<User> ListAll();

		//User GetById(int id);
	}
}
