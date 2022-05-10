using System.Collections.Generic;
using System;

namespace Observer
{
    public interface IObserver<T>
    {
        void Update (T value);
        
    }
}