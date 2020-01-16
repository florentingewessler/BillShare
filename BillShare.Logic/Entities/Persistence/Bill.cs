using System;
using System.Collections.Generic;
using System.Text;
using BillShare.Contracts.Persistence;
using CommonBase.Extensions;

namespace BillShare.Logic.Entities.Persistence
{
    internal class Bill : IdentityObject, Contracts.Persistence.IBill
    {

        
        

        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Friends { get; set; }
        public string Currency { get; set; }
        //Navigation Property
        public IEnumerable<Expense> Expenses { get; set; }

        public void CopyProperties(IBill other)
        {
            Date = other.Date;
            Id = other.Id;
            Description = other.Description;
            Friends = other.Friends;
            Title = other.Title;
            Currency = other.Currency;
        }
    }
}
