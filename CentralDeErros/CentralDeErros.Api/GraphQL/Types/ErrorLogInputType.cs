﻿using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentralDeErros.Api.GraphQL.Types
{
    public class ErrorLogInputType : InputObjectGraphType
    {
        public ErrorLogInputType()
        {
            Name = "errorLogInput";
            Field<StringGraphType>("id");
            Field<StringGraphType>("code");
            Field<StringGraphType>("message");
            Field<StringGraphType>("level");
            Field<StringGraphType>("shelved");
            Field<StringGraphType>("environment");
        }
    }
}
