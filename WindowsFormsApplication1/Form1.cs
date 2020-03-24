using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlusV_Click(object sender, EventArgs e)
        {
            Vector v1 = getV1();
            Vector v2 = getV2();
            Vector v = v1 + v2;
            vToStr(v);
        }

        private Vector getV1()
        {
            return new Vector(Convert.ToDouble(X1.Text), Convert.ToDouble(Y1.Text), Convert.ToDouble(Z1.Text));
        }

        private Vector getV2()
        {
            return new Vector(Convert.ToDouble(X2.Text), Convert.ToDouble(Y2.Text), Convert.ToDouble(Z2.Text));
        }
        
        private void vToStr(Vector v)
        {
            lbX.Text = Convert.ToString(v.x);
            lbY.Text = Convert.ToString(v.y);
            lbZ.Text = Convert.ToString(v.z);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            Vector v1 = getV1();
            Vector v2 = getV2();
            Vector v = v1 - v2;
            vToStr(v);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Vector v1 = getV1();
            Vector v2 = getV2();
            lbRes.Text = Vector.scalar(v1, v2).ToString();
        }

        private void btnMuldR_Click(object sender, EventArgs e)
        {
            Vector v1 = getV1();
            Vector v2 = getV2();
            Vector v = v1 * v2 ;
            vToStr(v);
        }

        private void btnLeng_Click(object sender, EventArgs e)
        {
            Vector v1 = getV1();
          
            lbRes.Text = Vector.lengthV(v1).ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
