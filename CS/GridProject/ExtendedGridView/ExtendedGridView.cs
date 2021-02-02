using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;

namespace ExtendedGridViewSpace
{
    [System.ComponentModel.DesignerCategory("")]
    public class ExtendedGridView : GridView
    {

        public ExtendedGridView()
        {}
        public ExtendedGridView(GridControl ownerGrid)
            : base(ownerGrid)
        {
            
        }

        protected override string ViewName
        {
            get
            {
                return "ExtendedGridView";
            }
        }

        public override EditorShowMode GetShowEditorMode(int rowHandle)
        {
            ExtendedGridColumn col = FocusedColumn as ExtendedGridColumn;
            if (col != null)
            {
                return col.EditorShowMode;
            }
            return base.GetShowEditorMode();
        }

        protected override GridColumnCollection CreateColumnCollection()
        {
            GridColumnCollection columns = new ExtendedGridColumnCollection(this);
            return columns;
        }
    }
}