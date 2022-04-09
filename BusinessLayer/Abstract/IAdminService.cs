﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService:IGenericService<Admin>
    {
        List<Admin> GetadminRole(string username);
        List<Admin> GetByIdData(int id);
    }
}
