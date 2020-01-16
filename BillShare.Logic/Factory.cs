﻿using System;
using System.Collections.Generic;
using System.Text;
using BillShare.Contracts.Client;

namespace BillShare.Logic
{
    public static class Factory
    {
        public enum PersistenceType
        {
            Db,
            //Csv,
            //Ser,
        }
        /// <summary>
        /// Get and sets the persistence type.
        /// </summary>
        public static PersistenceType Persistence { get; set; } = Factory.PersistenceType.Db;

        /// <summary>
        /// This method creates the 'DataContext' depending on the persist type.
        /// </summary>
        /// <returns>An instance of the 'DataContext' type.</returns>
        private static DataContext.IContext CreateContext()
        {
            DataContext.IContext result = null;

            if (Persistence == PersistenceType.Db)
            {
                result = new DataContext.Db.DbBillShareContext();
            }
            return result;
        }

        public static IControllerAccess<Contracts.Persistence.IBill> CreateBillController()
        {
            return new Controllers.Persistence.BillController(CreateContext());
        }

        public static IControllerAccess<Contracts.Persistence.IExpense> CreateExpenseController()
        {
            return new Controllers.Persistence.ExpenseController(CreateContext());
        }
    }
}
