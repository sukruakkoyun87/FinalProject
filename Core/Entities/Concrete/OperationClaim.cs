﻿using System;
using System.Collections.Generic;
using System.Text;
using Castle.DynamicProxy.Generators.Emitters;

namespace Core.Entities.Concrete
{
    public class OperationClaim:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}