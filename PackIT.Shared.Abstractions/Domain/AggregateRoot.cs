using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Shared.Abstractions.Domain;

public abstract class AggregateRoot<T>
{
    public T Id { get; protected set; }
    public int Version { get; protected set; }
    public bool _versionIncremented;

    public void IncreamentVersion()
    {
        if(_versionIncremented) return;

        Version++;
        _versionIncremented = true;
    }
}
