using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;


namespace ExtendedGridViewSpace
{
    [System.ComponentModel.DesignerCategory("")]
    public class ExtendedGridControl : GridControl
    {
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new ExtendedGridViewInfoRegistrator());
        }
    }
}
