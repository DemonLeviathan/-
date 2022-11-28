﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_07
{
    public interface IOptions<T>
    {
        public void Add(T obj);
        public void Remove(T obj);
        public void Watch();

    }
}
