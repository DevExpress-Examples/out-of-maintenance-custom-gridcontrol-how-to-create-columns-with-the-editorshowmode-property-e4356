using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;

namespace ExtendedGridViewSpace
{
    [System.ComponentModel.DesignerCategory("")]
    public class ExtendedGridColumn : GridColumn
    {
        public ExtendedGridColumn()
        {
            EditorShowMode = DevExpress.Utils.EditorShowMode.Default;
        }

        public EditorShowMode EditorShowMode { get; set; }
        
    }
}
