﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.DataAccess.IBaseRepository
{
    public interface IDeleteById<TKey>
    {
        int DeleteById(TKey id);
    }
}
