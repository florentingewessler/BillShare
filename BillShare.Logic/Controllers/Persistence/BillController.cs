using System;
using System.Collections.Generic;
using System.Text;
using BillShare.Logic.DataContext;
using BillShare.Logic.Entities;
using BillShare.Logic.Entities.Persistence;

namespace BillShare.Logic.Controllers.Persistence
{
    internal partial class BillController : BillShareController<Entities.Persistence.Bill, Contracts.Persistence.IBill>
    {
        protected override IEnumerable<Entities.Persistence.Bill> Set => MusicStoreContext.Bills;

        public BillController(IContext context) : base(context)
        {
        }

        public BillController(ControllerObject controller) : base(controller)
        {
        }
    }
}
