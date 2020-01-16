using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BillShare.Contracts;
using BillShare.Logic.Entities;
using BillShare.Contracts;

namespace BillShare.Logic.DataContext
{
    internal partial interface IContext : IDisposable
    {
        Task<int> CountAsync<I, E>()
            where I : IIdentifyable
            where E : IdentityObject, I;

        Task<E> CreateAsync<I, E>()
            where I : IIdentifyable
            where E : IdentityObject, ICopyable<I>, I, new();

        Task<E> InsertAsync<I, E>(I entity)
            where I : IIdentifyable
            where E : IdentityObject, ICopyable<I>, I, new();

        Task<E> UpdateAsync<I, E>(I entity)
            where I : IIdentifyable
            where E : IdentityObject, ICopyable<I>, I, new();

        Task<E> DeleteAsync<I, E>(int id)
            where I : IIdentifyable
            where E : IdentityObject, I;

        Task SaveAsync();

    }
}
