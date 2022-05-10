using System.Collections.Generic;
using System;

namespace Observer
{
    public interface ISubject<T>
    {
        void Subscribe(IObserver<T> subject);
        void Unsubscribe(IObserver<T> subject);
    }
}