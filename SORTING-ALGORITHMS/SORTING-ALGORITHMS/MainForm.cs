using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace SORTING_ALGORITHMS
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private const int MAX_ITEMS = 10;          // This is a good idea but you don't use it everywhere you could
        //private int CurrentIndex = 0;           // This is never used so remove it - stay tidy!
        private double[] numArray = new double[MAX_ITEMS];  // You've declared this array as a double but only ever use ints in it
        private int index = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            INSERTION_SORT n = new INSERTION_SORT();
            n.ShowDialog();
        }


    }
}