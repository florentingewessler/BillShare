using System;
using System.Collections.Generic;
using System.Text;
using BillShare.Logic.DataContext;

namespace BillShare.Logic.Controllers.Persistence
{
    internal partial class ExpenseController : BillShareController<Entities.Persistence.Expense, Contracts.Persistence.IExpense>
    {
        protected override IEnumerable<Entities.Persistence.Expense> Set => MusicStoreContext.Expenses;


        public ExpenseController(IContext context) : base(context)
        {
        }

        public ExpenseController(ControllerObject controller) : base(controller)
        {
        }
    }
}
