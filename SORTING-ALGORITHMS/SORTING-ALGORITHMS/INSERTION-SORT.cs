using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SORTING_ALGORITHMS
{
    public partial class INSERTION_SORT : DevExpress.XtraEditors.XtraForm
    {
        public INSERTION_SORT()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string s = textEdit1.EditValue.ToString();                  // GIKUHA ANG STRING GIKAN SA textEdit1
            string[] values = s.Split(',');                             // GI SPLIT ANG STRING S SA COMMA PADULONG SA COMMA
            int[] myInts = values.Select(int.Parse).ToArray();          // GIHIMONG INTEGER ANG VALUES
            INSERTION_SORT ob = new INSERTION_SORT();                   // GIDECLARE ANG OBJECT OB NGA CLASS INSERT_SORT
            ob.insertion_sort(myInts);                                  // GI SORT ANG IMONG MGA GI CONVERT NGA INTEGER


            // KANI NGA CODE BUTANGAN UG SPACE KAY MOTAPO ANG INTEGER SA ARRAY DIRI NGA PART UG WALAY PADDING, 
            // EXAMPLE ARRAY NIMO 2,3,4, MAHIMO NA SIYANG 2, ,3, ,4, 
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int n = myInts.Length;
            for (int i = 0; i < n; i++) {
                sb.Append(myInts[i]);
                sb.Append("".PadRight(4));
            }

            // TAPOS IMONG ARRAY NGA INTEGER ICONCATENATE NIMO OR I SUMPAY ICONVERT BALIK UG STRING
            string arrayStr = string.Concat(myInts);
            // PARA MAKA DISPLAY KA SA LABELCONTROL DAPAT STRING IMONG DATA TYPE
            labelControl1.Text = sb + " ";
          
        }

        // CODE SA INSERTON CODE GIKAN GEEKS FOR GEEKS
        int [] insertion_sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], 
                // that are greater than key, 
                // to one position ahead of 
                // their current position 
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            return arr;
        }

    }
}