﻿using System.Collections.Generic;

namespace Open_Closed_Principle
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> item, ISpecification<T> spec);
    }
}