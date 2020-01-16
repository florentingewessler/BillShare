using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BillShare.Contracts.Persistence
{
    public interface IBill : IIdentifyable, ICopyable<IBill>
    {
        DateTime Date { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string Friends { get; set; }
        string Currency { get; set; }
    }
}
