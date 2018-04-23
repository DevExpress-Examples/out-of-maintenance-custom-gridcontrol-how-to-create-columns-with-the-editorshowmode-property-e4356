using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

namespace ExtendedGridViewSpace
{
    public class ExtendedGridColumnCollection : GridColumnCollection
    {
        public ExtendedGridColumnCollection(ColumnView view)
            : base(view)
        { }

        protected override GridColumn CreateColumn()
        {
            return new ExtendedGridColumn();
        }
    }
}
