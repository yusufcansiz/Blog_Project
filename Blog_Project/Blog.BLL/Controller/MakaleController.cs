﻿using Blog.BLL.IServices;
using Blog.BLL.Services;
using Blog.DAL.Repositories;
using Blog.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.Controller
{
    public class MakaleController : ServicesBase<Makale, int>, IMakaleServices
    {
        public MakaleController() : base(new MakaleRepository())
        {

        }
    }
}
