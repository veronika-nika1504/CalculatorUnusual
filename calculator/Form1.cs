using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class FormCalc : Form
    {
        //Поля(Fields)
        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        public bool newEquals = false;
        bool enterValue = false;
        int klik = 0;
        Double memory = 0;

        public FormCalc()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }
        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == ",") return;
            if (result != 0) BtnEquals.PerformClick();
            else result = Double.Parse(TxtDisplay.Text);

            System.Windows.Forms.Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if (TxtDisplay.Text != "0")
            {
                newEquals = false;
                TxtEstimation.Text = fstNum = $"{result}{operation}";
                TxtDisplay.Text = string.Empty;               
            }
        }
        private void BtnEquals_Click(object sender, EventArgs e)
        {           
            if ((TxtEstimation.Text == string.Empty) || (TxtEstimation.Text.Substring(TxtEstimation.Text.Length - 1, 1) == "="))
                return;
            if (TxtDisplay.Text == string.Empty)
                return;            

            secNum = TxtDisplay.Text;
            TxtEstimation.Text = $"{TxtEstimation.Text}{TxtDisplay.Text}=";
            if (TxtDisplay.Text != string.Empty)
            {
               
                if (TxtDisplay.Text == "0") TxtEstimation.Text = string.Empty;
                switch(operation)
                {
                    case "+":
                        TxtDisplay.Text = (result + Double.Parse(TxtDisplay.Text)).ToString();
                        newEquals = true;
                        RtBoxDisplayHistory.AppendText($"{fstNum}{secNum}={TxtDisplay.Text}\n");                        
                        break;

                    case "-":                        
                        TxtDisplay.Text = (result - Double.Parse(TxtDisplay.Text)).ToString();
                        newEquals = true;
                        RtBoxDisplayHistory.AppendText($"{fstNum}{secNum}={TxtDisplay.Text}\n");
                        break;

                    case "×":
                        TxtDisplay.Text = (result * Double.Parse(TxtDisplay.Text)).ToString();
                        newEquals = true;
                        RtBoxDisplayHistory.AppendText($"{fstNum}{secNum}={TxtDisplay.Text}\n");
                        break;

                    case "÷":
                        TxtDisplay.Text = (result / Double.Parse(TxtDisplay.Text)).ToString();
                        newEquals = true;
                        RtBoxDisplayHistory.AppendText($"{fstNum}{secNum}={TxtDisplay.Text}\n");
                        break;
                    default: 
                        TxtEstimation.Text=$"{TxtDisplay.Text}=";                        
                        break;

                }
                result = Double.Parse(TxtDisplay.Text);
                operation = string.Empty;
            }
        }    
        private void BtnOperations_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button = (Button)sender;
            operation = button.Text;

            if (TxtDisplay.Text == ",") return;
            if (result != 0) BtnEquals.PerformClick();
            else result = Double.Parse(TxtDisplay.Text);            
            switch (operation)
            {
                case "√x":
                    TxtEstimation.Text = $"√({TxtDisplay.Text})";
                    TxtDisplay.Text = Convert.ToString(Math.Sqrt(Double.Parse(TxtDisplay.Text)));
                    break;

                case "x²":
                    TxtEstimation.Text = $"({TxtDisplay.Text})²";
                    TxtDisplay.Text = Convert.ToString(Math.Pow(Convert.ToDouble(TxtDisplay.Text), 2)); //(Convert.ToDouble(TxtDisplay.Text) * Convert.ToDouble(TxtDisplay.Text));
                    break;

                case "⅟x":
                    TxtEstimation.Text = $"⅟({TxtDisplay.Text})";
                    TxtDisplay.Text = Convert.ToString(1.0 / Convert.ToDouble(TxtDisplay.Text));
                    break;

                case "%":
                    TxtEstimation.Text = $"%({TxtDisplay.Text})";
                    TxtDisplay.Text = Convert.ToString(Convert.ToDouble(TxtDisplay.Text) / Convert.ToDouble(100));
                    break;

            }
            RtBoxDisplayHistory.AppendText($"{TxtEstimation.Text}{TxtDisplay.Text}\n");
        }
        private void BtnNum_Click(object sender, EventArgs e)
        {
            
            if (newEquals)
            {
                newEquals = false;
                TxtDisplay.Text = "0";
                TxtEstimation.Text = string.Empty;
                result = 0;
            }
            

            if (TxtDisplay.Text == "0" || enterValue) TxtDisplay.Text = string.Empty;

            enterValue = false;
            System.Windows.Forms.Button button = (Button)sender;

            if (button.Text == ",")
            {
                if (!TxtDisplay.Text.Contains(","))
                    TxtDisplay.Text = TxtDisplay.Text + button.Text;
            }
            else TxtDisplay.Text = TxtDisplay.Text + button.Text;
        }
        private void BtnHistory_Click(object sender, EventArgs e)
        {
            PnlHistory.Height = (PnlHistory.Height == 5) ? PnlHistory.Height = 400 : 5;

            if (RtBoxDisplayHistory.Text == "История очищена \n")
                RtBoxDisplayHistory.Clear();
        }
        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
            if (RtBoxDisplayHistory.Text == string.Empty)
                RtBoxDisplayHistory.Text = "История очищена \n";
        }
        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text.Length > 0)
                TxtDisplay.Text = TxtDisplay.Text.Remove(TxtDisplay.Text.Length - 1, 1);
            if (TxtDisplay.Text == string.Empty) TxtDisplay.Text = "0";
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "0";
            TxtEstimation.Text = string.Empty;
            result = 0;
        }
        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "0";
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {           
            Application.Exit();            
        }
        private void BtnRoll_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;                          
        }
        private void BtnTransform_Click(object sender, EventArgs e)
        {
            {
                //StartPosition = FormStartPosition.CenterScreen;
                klik++;
                if (klik >= 10) BtnTransform.Visible = false;            
                              
                if (klik % 2 == 0)
                {
                    
                    Location = new Point(500, 80);
                    this.Width = 350;
                    this.Height = 570;
                } 
                else
                {
                    Location = new Point(400, 20);
                    this.Width = 550;
                    this.Height = 670;
                    //this.WindowState = FormWindowState.Maximized;                    
                }               
            }
        } 
        private void KBPress(object sender, KeyPressEventArgs e)
        {            
             switch (e.KeyChar.ToString())
             {
                case "0": Btn0.PerformClick(); break;
                case "1": Btn1.PerformClick(); break; 
                case "2": Btn2.PerformClick(); break;
                case "3": Btn3.PerformClick(); break;
                case "4": Btn4.PerformClick(); break;
                case "5": Btn5.PerformClick(); break;
                case "6": Btn6.PerformClick(); break;
                case "7": Btn7.PerformClick(); break;
                case "8": Btn8.PerformClick(); break;
                case "9": Btn9.PerformClick(); break;
                case ".": case ",": BtnDesimal.PerformClick(); break;
                case "/": BtnDivision.PerformClick(); break;
                case "*": BtnMultiply.PerformClick(); break;
                case "-": BtnSubstraction.PerformClick(); break;
                case "+": BtnAdd.PerformClick(); break;
                case "%": BtnPercent.PerformClick(); break;
                case "с": case "c": BtnC.PerformClick(); break;
                case "=": BtnEquals.PerformClick(); break;
                case "\x08": BtnBackSpace.PerformClick(); break;

            }
          
        }            
        private void BMemory_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == string.Empty && ((Button)sender).Name != "BtnMR" && ((Button)sender).Name != "BtnMC") return;
            switch (((Button)sender).Name)
            {
                case "BtnMS":
                    if (TxtDisplay.Text == ",") return;
                    memory = Double.Parse(TxtDisplay.Text);
                    break;
                case "BtnMC":
                    memory = 0;
                    break;
                case "BtnMR":
                    TxtDisplay.Text = memory.ToString();
                    break;
                case "BtnMplus":
                    memory += Double.Parse(TxtDisplay.Text);
                    break;
                case "BtnMminus":
                    memory -= Double.Parse(TxtDisplay.Text);
                    break;
            }
            Mindicate.Visible = (memory != 0);
        }
        private void FormCalc_Load(object sender, EventArgs e)
        {
            //ClientSize = new Size(350, 570);
            //FormBorderStyle = FormBorderStyle.FixedSingle;
            foreach (Control value in this.Controls)
            {
               if (value.Name.Substring(0,3) == "Btn")
                    BtnCircle((Button)value);
            }
        }
        private void BtnCircle(Button Btn) //скругление кнопок
        {            
            GraphicsPath gp = new GraphicsPath();
            
            Graphics g = CreateGraphics();
                // Создадим новый прямоугольник с размерами кнопки 
            Rectangle smallRectangle = Btn.ClientRectangle;
                // уменьшим размеры прямоугольника 
            smallRectangle.Inflate(10, 10);
                // создадим эллипс, используя полученные размеры 
            gp.AddEllipse(smallRectangle);
            Btn.Region = new Region(gp);
                // рисуем окантовоку для круглой кнопки 
            g.DrawEllipse(new Pen(Color.Gray, 2),
                    Btn.Left + 1,
                    Btn.Top + 1,
                    Btn.Width - 3,
                    Btn.Height - 3);
                // освобождаем ресурсы 
            g.Dispose();
        }
        private void PanelMenu_Paint(object sender, PaintEventArgs e) // скругление панели меню
        {
                GraphicsPath gp = new GraphicsPath();

            Graphics g = CreateGraphics();
            // Создадим новый прямоугольник с размерами кнопки 
            Rectangle smallRectangle = PanelMenu.ClientRectangle;
            // уменьшим размеры прямоугольника 
            smallRectangle.Inflate(30, 30);
            // создадим эллипс, используя полученные размеры 
            gp.AddEllipse(smallRectangle);
            PanelMenu.Region = new Region(gp);
            // рисуем окантовоку для круглой кнопки 
            g.DrawEllipse(new Pen(Color.Gray, 2),
                    PanelMenu.Left + 1,
                    PanelMenu.Top + 1,
                    PanelMenu.Width - 3,
                    PanelMenu.Height - 3);
            // освобождаем ресурсы 
            g.Dispose();
        }
        private void MenuClick_Click(object sender, EventArgs e) //Закрытие меню
        {   
            if (PanelMenu.Visible == false) PanelMenu.Visible = true;
            else PanelMenu.Visible = false;
        }               
        private void CalculatorTypes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Будет реализовано в следующей версии",
            "Сообщение",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
        }
        private void FormCalc_MouseDown(object sender, MouseEventArgs e) //для закрытия меню
        {
            int index = 0;
            if (e.Button == MouseButtons.Left)
            {
                index = e.Y;
                if (index == e.Y) PanelMenu.Visible = false;                
            }
        }
        private void BtnPlMn_Click(object sender, EventArgs e)
        {
            if (TxtDisplay.Text == ",") return;

            if (TxtDisplay.Text == string.Empty) return;
            TxtDisplay.Text = Convert.ToString(-1 * Convert.ToDouble(TxtDisplay.Text));          
        }
        /*MessageBox.Show(
              "Куку",
              "Сообщение",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Information,
              MessageBoxDefaultButton.Button1,
              MessageBoxOptions.DefaultDesktopOnly);*/
    }
}
