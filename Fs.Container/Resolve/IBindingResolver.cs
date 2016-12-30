﻿using System;
using System.Collections.Generic;
using Fs.Container.Bindings;

namespace Fs.Container.Resolve
{
    public interface IBindingResolver
    {
        object Resolve(IEnumerable<IBinding> bindings, Type service);
    }
}