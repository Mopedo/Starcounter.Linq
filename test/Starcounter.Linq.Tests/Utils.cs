﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace Starcounter.Linq.Tests
{
    public static class Utils
    {
        public static string Sql<T>(Expression<Func<IQueryable<T>>> exp) => new CompiledQuery<T>(exp, new QueryExecutor<T>()).SqlStatement;

        public static string Sql<T>(Expression<Func<T>> exp) => new CompiledQuery<T>(exp, new QueryExecutor<T>()).SqlStatement;

        public static string Sql<T>(Expression<Action> exp) => new CompiledQuery<T>(exp, new QueryExecutor<T>()).SqlStatement;
    }
}
