using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g2.Visible = false;
            g34.Visible = false;
            g5.Visible = false;
            comboBox1.Text = "โสด";
            comboBox2.Text = "ไม่มี";
            comboBox3.Text = "ไม่มี";
        }
        public double money,sum1,sum2,sum3,sum4,sum5,sumall;

        private void button6_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            g34.Visible = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            g34.Visible = true;
            g5.Visible = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            g1.Visible = true;
            g2.Visible = false;
            g34.Visible = false;
            g5.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            g5.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            g2.Visible = true;
            g34.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            g2.Visible = true;
            g34.Visible = false;
            g5.Visible = false;
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {
            sum4 = 0;
            double สังคม = Convert.ToDouble(numericUpDown12.Value);
            double ชีวิต = Convert.ToDouble(numericUpDown13.Value);
            double สุขภาพ1 = Convert.ToDouble(numericUpDown14.Value);
            double สุขภาพ2 = Convert.ToDouble(numericUpDown15.Value);
            double คู่สมรส = Convert.ToDouble(numericUpDown16.Value);
            double กอช = Convert.ToDouble(numericUpDown17.Value);
            double สำรอง = Convert.ToDouble(numericUpDown18.Value);
            double บำนาญ = Convert.ToDouble(numericUpDown19.Value);
            double กบข = Convert.ToDouble(numericUpDown20.Value);
            double LTF = Convert.ToDouble(numericUpDown21.Value);
            double RMF = Convert.ToDouble(numericUpDown22.Value);
            
            if(สุขภาพ1 + ชีวิต > 100000) 
            {
                sum4 += 100000;
            }
            else
            {
                sum4 += สุขภาพ1 + ชีวิต;
            }

            if(สำรอง > 490000)
            {
                sum4 += 490000;
            }
            else
            {
                numericUpDown18.Maximum = Convert.ToInt64(money * 0.15);
                sum4 += สำรอง;
            }

            if (กบข > 500000)
            {
                sum4 += 500000;
            }
            else
            {
                numericUpDown20.Maximum = Convert.ToInt64(money * 0.15);
                sum4 += กบข;
            }

            if (บำนาญ > 200000)
            {
                sum4 += 200000;
            }
            else
            {
                numericUpDown19.Maximum = Convert.ToInt64(money * 0.15);
                sum4 += บำนาญ;
            }

            if (LTF > 500000)
            {
                sum4 += 500000;
            }
            else
            {
                numericUpDown21.Maximum = Convert.ToInt64(money * 0.15);
                sum4 += LTF;
            }

            if (RMF > 500000)
            {
                sum4 += 500000;
            }
            else
            {
                numericUpDown22.Maximum = Convert.ToInt64(money * 0.15);
                sum4 += RMF;
            }

            if (บำนาญ + สำรอง + กบข + RMF + คู่สมรส > 500000)
            {
                sum4 += 500000;
            }
            else
            {
                sum4 += บำนาญ + สำรอง + กบข + RMF + คู่สมรส;
            }
            sum4 += สังคม + สุขภาพ2 + LTF + กอช;
            textBox6.Text = sum4.ToString();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            sum3 = 0;
            double บริจาคทั่วไป = Convert.ToDouble(numericUpDown9.Value);
            double บริจาคสนับสนุน = Convert.ToDouble(numericUpDown10.Value) * 2;
            double บริจาคพรรคการเมือง = Convert.ToDouble(numericUpDown11.Value);
            double บริจาคโรงบาล = Convert.ToDouble(numericUpDown29.Value) * 2;

            if (บริจาคทั่วไป + บริจาคสนับสนุน + บริจาคโรงบาล > (money - (sum1 + sum2 + sum4 + sum5)) * 0.1)
            {
                sum3 += (money - (sum1 + sum2 + sum4 + sum5)) * 0.1;
            }
            else
            {
                sum3 += บริจาคทั่วไป + บริจาคสนับสนุน + บริจาคโรงบาล;
            }
            sum3 += บริจาคพรรคการเมือง;
            textBox5.Text = sum3.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            g1.Visible = true;
            g34.Visible = false;
            g2.Visible = false;
            g5.Visible = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            numericUpDown13.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown17.Value = 0;
            numericUpDown18.Value = 0;
            numericUpDown19.Value = 0;
            numericUpDown20.Value = 0;
            numericUpDown21.Value = 0;
            numericUpDown22.Value = 0;
            numericUpDown23.Value = 0;
            numericUpDown24.Value = 0;
            numericUpDown25.Value = 0;
            numericUpDown26.Value = 0;
            numericUpDown27.Value = 0;
            numericUpDown28.Value = 0;
            sum1 = 0;
            sum2 = 0;
            sum3 = 0;
            sum4 = 0;
            sum5 = 0;
            sumall = 0;
        }

        private void numericUpDown23_ValueChanged(object sender, EventArgs e)
        {


            sum5 = 0;
            double shop = Convert.ToDouble(numericUpDown23.Value);
            double edu = Convert.ToDouble(numericUpDown24.Value);
            double book = Convert.ToDouble(numericUpDown25.Value);
            double otop = Convert.ToDouble(numericUpDown26.Value);
            double main = Convert.ToDouble(numericUpDown27.Value);
            double second = Convert.ToDouble(numericUpDown28.Value);

            if(main + second > 20000)
            {
                sum5 += 20000;
            }
            else
            {
                sum5 += main + second;
            }
            sum5 += shop + edu + book + otop ;
            textBox7.Text = sum5.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
            if (sumall >= 0 && sumall <= 150000)
            {
                sumall = 0;
            }
            else if (sumall > 150000 && sumall <= 300000)
            {
                sumall = (sumall - 150000) * 0.05;
            }
            else if (sumall > 300000 && sumall <= 500000)
            {
                sumall = ((sumall - 300000) * 0.1) + 7500;
            }
            else if (sumall > 500000 && sumall <= 7500000)
            {
                sumall = ((sumall - 500000) * 0.15) + 27500;
            }
            else if (sumall > 750000 && sumall <= 1000000)
            {
                sumall = ((sumall - 750000) * 0.2) + 65000;
            }
            else if (sumall > 1000000 && sumall <= 2000000)
            {
                sumall = ((sumall - 1000000) * 0.25) + 115000;
            }
            else if (sumall > 2000000 && sumall <= 5000000)
            {
                sumall = ((sumall - 2000000) * 0.3) + 365000;
            }
            else if (sumall > 5000000)
            {
                sumall = ((sumall - 5000000) * 0.35) + 1265000;
            }
            textBox2.Text = sumall.ToString();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            sum2 = 0;
            double ดอกบ้าน = Convert.ToDouble(numericUpDown6.Value);
            double บ้าน58 = Convert.ToDouble(numericUpDown7.Value);
            double บ้าน62 = Convert.ToDouble(numericUpDown8.Value);

            if(บ้าน58 > 3000000)
            {
                sum2 += 0;
            }
            else
            {
                sum2 += บ้าน58 * 0.04;
            }

            if(บ้าน62 > 5000000)
            {
                sum2 += 0;
            }
            else
            {
                sum2 += บ้าน62 * 0.04;
            }
            sum2 += ดอกบ้าน;
            textBox4.Text = sum2.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sum1 = 0;
            money = Convert.ToDouble(numericUpDown1.Value) * 12;
            double บุตร60 = Convert.ToDouble(numericUpDown2.Value) * 30000;
            double บุตร61 = Convert.ToDouble(numericUpDown3.Value);
            double ครรภ์ = Convert.ToDouble(numericUpDown4.Value);
            double พิการ = Convert.ToDouble(numericUpDown5.Value) * 60000;
            double sumn = money * 0.5;

            if(sumn > 100000)
            {
                sum1 += 100000;
            }
            else
            {
                sum1 += sumn;
            }
            
            if(comboBox1.Text == "คู่สมรสไม่มีรายได้")
            {
                sum1 += 120000;
            }
            else
            {
                sum1 += 60000;
            }
            if( บุตร61 > 0 )
            {
                บุตร61 = ((บุตร61 - 1) * 60000) + 30000;
            }
            else
            {
                บุตร61 = 0;
            }
            sum1 += บุตร61;

            if(comboBox2.Text == "ไม่มี")
            {
                sum1 += 0;
            }
            else if(comboBox2.Text == "บิดาหรือมารดา")
            {
                sum1 += 30000;
            }
            else if (comboBox2.Text == "บิดาเเละมารดา")
            {
                sum1 += 60000;
            }

            if (comboBox3.Text == "ไม่มี")
            {
                sum1 += 0;
            }
            else if (comboBox3.Text == "บิดาหรือมารดา")
            {
                sum1 += 30000;
            }
            else if (comboBox3.Text == "บิดาเเละมารดา")
            {
                sum1 += 60000;
            }
            sum1 += บุตร60 + ครรภ์ + พิการ;
            textBox3.Text = sum1.ToString();
            sumall = money - (sum1 + sum2 + sum3 + sum4 + sum5);
            if(sumall < 0)
            {
                sumall = 0;
            }
            textBox1.Text = sumall.ToString();
        }
    }
}
