using System;
using System.Collections.Generic;
using System.Text;
using BillShare.Contracts.Persistence;
using CommonBase.Extensions;

namespace BillShare.Logic.Entities.Persistence
{
    class Expense : IdentityObject, Contracts.Persistence.IExpense
    {
        public void CopyProperties(IExpense other)
        {
            other.CheckArgument(nameof(other));
            BillId = other.BillId;
            Amount = other.Amount;
            Designation = other.Designation;
            Friend = other.Friend;
            Id = other.Id;
        }

        public int BillId { get; set; }
        public string Designation { get; set; }
        public double Amount { get; set; }
        public string Friend { get; set; }

        //Navigation Property
        public Bill bill { get; set; }
    }
}
