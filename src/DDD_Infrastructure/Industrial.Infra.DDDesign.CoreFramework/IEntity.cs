﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industrial.Infra.DDDesign.CoreFramework
{
    public interface IEntity<TEntityId>
    {
        TEntityId Id { get; }
    }
}
