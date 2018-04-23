using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Helpers;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using ExtendedGridViewSpace;
using DevExpress.XtraGrid.Views.Base;

namespace GridProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataHelper dh = new DataHelper(DSparametr.simpleDS);
            extendedGridControl1.DataSource = dh.DataSet;
            extendedGridControl1.DataMember = dh.DataMember;

            extendedGridControl1.ForceInitialize();

            ((ExtendedGridColumn)extendedGridView1.Columns[0]).EditorShowMode = DevExpress.Utils.EditorShowMode.MouseUp;
            ((ExtendedGridColumn)extendedGridView1.Columns[1]).EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            ((ExtendedGridColumn)extendedGridView1.Columns[2]).EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDown;

        }
    }
}