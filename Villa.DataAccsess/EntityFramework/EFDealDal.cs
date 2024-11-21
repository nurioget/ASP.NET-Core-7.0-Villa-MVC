﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.DataAccsess.Abstract;
using Villa.DataAccsess.Context;
using Villa.DataAccsess.Repositories;
using Villa.Entity.Entities;

namespace Villa.DataAccsess.EntityFramework
{
    public class EFDealDal : GenericRepository<Deal>, IDealDal
    {
        public EFDealDal(VillaContext context) : base(context)
        {
        }
    }
}