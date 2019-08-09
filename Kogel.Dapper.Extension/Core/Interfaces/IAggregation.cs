﻿using Dapper;
using System;
using System.Linq.Expressions;

namespace Kogel.Dapper.Extension.Core.Interfaces
{
    public interface IAggregation<T>
    {
        /// <summary>
        /// 条数
        /// </summary>
        /// <returns></returns>
        int Count();

        /// <summary>
        /// 总和
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sumExpression"></param>
        /// <returns></returns>
        int Sum<TResult>(Expression<Func<TResult, object>> sumExpression);
    }
}