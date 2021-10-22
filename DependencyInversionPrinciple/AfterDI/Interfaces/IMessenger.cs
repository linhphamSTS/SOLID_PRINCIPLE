using System.Collections.Generic;

namespace DependencyInversionPrinciple.AfterDI.Interfaces
{
    internal interface IMessenger<T>
    {
        List<T> MessageItems { get; }

        void Send();

        void AddMessage(T message);
    }
}