﻿using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CrossCutting
{
    public abstract class CommandHandler<T> where T : ICommand
    {
        List<IDomainEvent> _domainEvents;

        public CommandHandler()
        {
            this._domainEvents = new List<IDomainEvent>();
        }

        public void AddDomainEvent(IDomainEvent domainEvent)
        {
            this._domainEvents.Add(domainEvent);
        }

        public void RaiseEvents()
        {
            foreach (var domainEvent in this._domainEvents)
            {
                Debug.WriteLine("Raised event: " + domainEvent);
            }
        }

        public abstract void Handle(T command);
    }
}
