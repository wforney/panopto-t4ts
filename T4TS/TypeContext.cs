﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4TS
{
    public class TypeContext: Dictionary<string, AttributeDecoratedInstance>
    {
        public TypeContext(IDictionary<string, AttributeDecoratedInstance> dictionary): base(dictionary)
        {

        }
    }
}
