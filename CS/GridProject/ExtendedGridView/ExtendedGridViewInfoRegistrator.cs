using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;

namespace ExtendedGridViewSpace
{
    public class ExtendedGridViewInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName { get { return "ExtendedGridView"; } }

        public override BaseView CreateView(GridControl grid)
        {
            return new ExtendedGridView(grid as GridControl);
        }

    }
}
