// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Form1.cs" company="vsk">
//   veronika-nika1504@yandex.ru
// </copyright>
// <summary>
//   Defines the FormCalc type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Calculator
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    
    /// <summary>
    /// The form calc.
    /// </summary>
    public partial class FormCalc : Form
    {
        // (Fields) 

        /// <summary>
        /// The result.
        /// </summary>
        private double result = 0;

        /// <summary>
        /// The operation.
        /// </summary>
        private string operation = string.Empty;

        /// <summary>
        /// The first num.
        /// </summary>
        private string fstNum, secNum;

        /// <summary>
        /// The new equals.
        /// </summary>
        private bool newEquals = false;

        /// <summary>
        /// The enter value.
        /// </summary>
        private bool enterValue = false;

        /// <summary>
        /// The clicked - sign of window resizing.
        /// </summary>
        private int clicked = 0;

        /// <summary>
        /// The memory - for buttons with hidden memory.
        /// </summary>
        private double memory = 0;

        /// <summary>
        /// The last point - to move the calculator around the screen.
        /// </summary>
        private Point lastPoint;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormCalc"/> class.
        /// </summary>
        public FormCalc()
        {
            this.KeyPreview = true;
            this.InitializeComponent();
        }

        /// <summary>
        /// The btn math operation_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender - the buttons: + - * /
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void BtnMathOperation_Click(object sender, EventArgs e)
        {
            if (this.TxtDisplay.Text == @",")
            {
                this.ActiveControl = null; 
                return;
            }

            if (this.result != 0)
            {
                this.BtnEquals.PerformClick();
            }
            else
            {
                this.result = double.Parse(this.TxtDisplay.Text);
            }

            var button = (Button)sender;
            this.operation = button.Text;
            this.enterValue = true;

            if (this.TxtDisplay.Text != @"0")
            {
                this.newEquals = false;
                this.TxtEstimation.Text = this.fstNum = $"{this.result}{this.operation}";
                this.TxtDisplay.Text = string.Empty;               
            }

            this.ActiveControl = null;
        }

        /// <summary>
        /// The btn equals_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender - Button =
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if ((this.TxtEstimation.Text == string.Empty)
                || (this.TxtEstimation.Text.Substring(this.TxtEstimation.Text.Length - 1, 1) == "="))
            {
                this.ActiveControl = null; 
                return;
            }

            if (this.TxtDisplay.Text == string.Empty)
            {
                this.ActiveControl = null; 
                return;
            }

            this.secNum = this.TxtDisplay.Text;
            this.TxtEstimation.Text = $@"{this.TxtEstimation.Text}{this.TxtDisplay.Text}=";
            if (this.TxtDisplay.Text != string.Empty)
            {
                if (this.TxtDisplay.Text == @"0")
                {
                    this.TxtEstimation.Text = string.Empty;
                }

                switch (this.operation)
                {
                    case "+":
                        this.TxtDisplay.Text = (this.result + double.Parse(this.TxtDisplay.Text)).ToString();
                        this.newEquals = true;
                        this.RtBoxDisplayHistory.AppendText($"{this.fstNum}{this.secNum}={this.TxtDisplay.Text}\n");                        
                        break;

                    case "-":
                        this.TxtDisplay.Text = (this.result - double.Parse(this.TxtDisplay.Text)).ToString();
                        this.newEquals = true;
                        this.RtBoxDisplayHistory.AppendText($"{this.fstNum}{this.secNum}={this.TxtDisplay.Text}\n");
                        break;

                    case "×":
                        this.TxtDisplay.Text = (this.result * double.Parse(this.TxtDisplay.Text)).ToString();
                        this.newEquals = true;
                        this.RtBoxDisplayHistory.AppendText($"{this.fstNum}{this.secNum}={this.TxtDisplay.Text}\n");
                        break;

                    case "÷":
                        this.TxtDisplay.Text = (this.result / double.Parse(this.TxtDisplay.Text)).ToString();
                        this.newEquals = true;
                        this.RtBoxDisplayHistory.AppendText($"{this.fstNum}{this.secNum}={this.TxtDisplay.Text}\n");
                        break;
                    default:
                        this.TxtEstimation.Text = $@"{this.TxtDisplay.Text}=";                        
                        break;
                }

                this.result = double.Parse(this.TxtDisplay.Text);
                this.operation = string.Empty;
            }

            this.ActiveControl = null;
        }

        /// <summary>
        /// The btn operations_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender - buttons: √x x² ⅟x %
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void BtnOperations_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            this.operation = button.Text;

            if ((this.TxtDisplay.Text == string.Empty) &&
                (this.TxtEstimation.Text != string.Empty) && 
                !"013456789".Contains(this.TxtEstimation.Text.Substring(this.TxtEstimation.Text.Length - 1, 1)))
            {
                this.TxtDisplay.Text = this.TxtEstimation.Text.Substring(0, this.TxtEstimation.Text.Length - 1);
                this.result = 0;
            }

            if (this.TxtDisplay.Text == @",")
            {
                this.ActiveControl = null;
                return;
            }

            this.result = double.Parse(this.TxtDisplay.Text);

            switch (this.operation)
            {
                case "√x":
                    this.TxtEstimation.Text = $@"√({this.TxtDisplay.Text})";
                    this.newEquals = true;
                    this.TxtDisplay.Text = Convert.ToString(Math.Sqrt(double.Parse(this.TxtDisplay.Text)));
                    break;

                case "x²":
                    this.TxtEstimation.Text = $@"({this.TxtDisplay.Text})²";
                    this.newEquals = true;
                    this.TxtDisplay.Text = Convert.ToString(Math.Pow(Convert.ToDouble(this.TxtDisplay.Text), 2)); // (Convert.ToDouble(TxtDisplay.Text) * Convert.ToDouble(TxtDisplay.Text));
                    break;

                case "⅟x":
                    this.TxtEstimation.Text = $@"⅟({this.TxtDisplay.Text})";
                    this.newEquals = true;
                    this.TxtDisplay.Text = Convert.ToString(1.0 / Convert.ToDouble(this.TxtDisplay.Text));
                    break;

                case "%":
                    this.TxtEstimation.Text = $@"%({this.TxtDisplay.Text})";
                    this.newEquals = true;
                    this.TxtDisplay.Text = Convert.ToString(Convert.ToDouble(this.TxtDisplay.Text) / Convert.ToDouble(100));
                    break;
            }

            this.result = 0;

            this.RtBoxDisplayHistory.AppendText($"{this.TxtEstimation.Text}{this.TxtDisplay.Text}\n");
            this.ActiveControl = null;
        }

        /// <summary>
        /// The btn num_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender - buttons: 0 - 9
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (this.newEquals)
            {
                this.newEquals = false;
                this.TxtDisplay.Text = @"0";
                this.TxtEstimation.Text = string.Empty;
                this.result = 0;
            }

            if (this.TxtDisplay.Text == @"0" || this.enterValue)
            {
                this.TxtDisplay.Text = string.Empty;
            }

            this.enterValue = false;
            var button = (Button)sender;

            if (button.Text == @",")
            {
                if (!this.TxtDisplay.Text.Contains(","))
                {
                    this.TxtDisplay.Text = this.TxtDisplay.Text + button.Text;
                }
            }
            else
            {
                this.TxtDisplay.Text = this.TxtDisplay.Text + button.Text;
            }

            this.ActiveControl = null;
        }

        /// <summary>
        /// The btn history_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender - view history.
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void BtnHistory_Click(object sender, EventArgs e)
        {
            this.PnlHistory.Height = (this.PnlHistory.Height == 5) ? this.PnlHistory.Height = 400 : 5;

            if (this.RtBoxDisplayHistory.Text == @"История очищена")
            {
                this.RtBoxDisplayHistory.Clear();
            }

            this.ActiveControl = null;
        }

        /// <summary>
        /// The btn clear history_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender - button trash on history.
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            this.RtBoxDisplayHistory.Clear();
            if (this.RtBoxDisplayHistory.Text == string.Empty)
            {
                this.RtBoxDisplayHistory.Text = @"История очищена";
            }

            this.ActiveControl = null;
        }

        /// <summary>
        /// The btn back space_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender - button backspace.
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (this.TxtDisplay.Text.Length > 0)
            {
                this.TxtDisplay.Text = this.TxtDisplay.Text.Remove(this.TxtDisplay.Text.Length - 1, 1);
            }

            if (this.TxtDisplay.Text == string.Empty)
            {
                this.TxtDisplay.Text = @"0";
            }

            this.ActiveControl = null;
        }

        /// <summary>
        /// The btn c_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender - button clear.
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void BtnC_Click(object sender, EventArgs e)
        {
            this.TxtDisplay.Text = @"0";
            this.TxtEstimation.Text = string.Empty;
            this.result = 0;
            this.ActiveControl = null;
        }

        /// <summary>
        /// The btn c e_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender - button clear field entry.
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void BtnCE_Click(object sender, EventArgs e)
        {
            this.TxtDisplay.Text = @"0";
        }

        /// <summary>
        /// The btn exit_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender - button exit.
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void BtnExit_Click(object sender, EventArgs e)
        {           
            Application.Exit();            
        }

        /// <summary>
        /// The btn roll_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender - button minimize.
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void BtnRoll_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// The btn transform_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender - button change size.
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void BtnTransform_Click(object sender, EventArgs e)
        {
            // StartPosition = FormStartPosition.CenterScreen;
            this.clicked++;
            if (this.clicked >= 10)
            {
                this.BtnTransform.Visible = false;
            }            
                              
            if (this.clicked % 2 == 0)
            {
                this.Location = new Point(500, 80);
                this.Width = 350;
                this.Height = 570;
            } 
            else
            {
                this.Location = new Point(400, 20);
                this.Width = 550;
                this.Height = 670;

                // this.WindowState = FormWindowState.Maximized;                    
            }

            this.ActiveControl = null;
        }

        /// <summary>
        /// The b memory_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender - button save to memory.
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void BMemory_Click(object sender, EventArgs e)
        {
            if (this.TxtDisplay.Text == string.Empty && ((Button)sender).Name != "BtnMR" && ((Button)sender).Name != "BtnMC")
            {
                this.ActiveControl = null; 
                return;
            }

            switch (((Button)sender).Name)
            {
                case "BtnMS":
                    if (this.TxtDisplay.Text == @",")
                    {
                        break;
                    }

                    this.memory = double.Parse(this.TxtDisplay.Text);
                    break;
                case "BtnMC":
                    this.memory = 0;
                    break;
                case "BtnMR":
                    this.TxtDisplay.Text = this.memory.ToString();
                    break;
                case "BtnMplus":
                    this.memory += double.Parse(this.TxtDisplay.Text);
                    break;
                case "BtnMminus":
                    this.memory -= double.Parse(this.TxtDisplay.Text);
                    break;
            }

            if (this.Mindicate.Visible = this.memory != 0)
            {
                this.Help.SetToolTip(this.Mindicate, "В памяти число = " + this.memory); 
            }

            this.ActiveControl = null;
        }

        /// <summary>
        /// The form calc_ load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void FormCalc_Load(object sender, EventArgs e)
        {
            // ClientSize = new Size(350, 570);
            // FormBorderStyle = FormBorderStyle.FixedSingle;
            foreach (Control value in this.Controls)
            {
                if (value.Name.Substring(0, 3) == "Btn")
                {
                    this.BtnCircle((Button)value);
                }
            }
        }

        /// <summary>
        /// The btn circle.
        /// </summary>
        /// <param name="btn">
        /// Rounding for all buttons.
        /// </param>
        private void BtnCircle(Control btn) 
        {            
            var gp = new GraphicsPath();
            
            var g = this.CreateGraphics();

            // Create a new rectangle with button dimensions
            var smallRectangle = btn.ClientRectangle;

            // reduce the size of the rectangle 
            smallRectangle.Inflate(10, 10);

            // create an ellipse using the obtained dimensions 
            gp.AddEllipse(smallRectangle);
            btn.Region = new Region(gp);

            // draw a border for a round button 
            g.DrawEllipse(
                new Pen(Color.Gray, 2),
                btn.Left + 1,
                btn.Top + 1,
                    btn.Width - 3,
                    btn.Height - 3);

            // free up resources 
            g.Dispose();
        }

        /// <summary>
        /// The panel menu_ paint.
        /// </summary>
        /// <param name="sender">
        /// Panel corner rounding.
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void PanelMenu_Paint(object sender, PaintEventArgs e) 
        {
                var gp = new GraphicsPath();

            var g = this.CreateGraphics();

            // Create a new rectangle with panel dimensions
            var smallRectangle = this.PanelMenu.ClientRectangle;

            // reduce the size of the rectangle 
            smallRectangle.Inflate(30, 30);

            // create an ellipse using the obtained dimensions
            gp.AddEllipse(smallRectangle);
            this.PanelMenu.Region = new Region(gp);

            // draw a border for a round panel
            g.DrawEllipse(
                new Pen(Color.Gray, 2),
                this.PanelMenu.Left + 1,
                this.PanelMenu.Top + 1,
                    this.PanelMenu.Width - 3,
                    this.PanelMenu.Height - 3);

            // free up resources 
            g.Dispose();
        }

        /// <summary>
        /// The menu click_ click.
        /// </summary>
        /// <param name="sender">
        /// Closing the menu by clicking the button again
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void MenuClick_Click(object sender, EventArgs e)
        {
            this.PanelMenu.Visible = this.PanelMenu.Visible == false;

            /*
            if (this.PanelMenu.Visible == false) this.PanelMenu.Visible = true;            
            else this.PanelMenu.Visible = false;
            */
            this.ActiveControl = null;
        }

        /// <summary>
        /// The calculator types_ click.
        /// </summary>
        /// <param name="sender">
        /// Menu buttons
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void CalculatorTypes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Будет реализовано в следующей версии",
            "Сообщение",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.DefaultDesktopOnly);
            this.Activate();
        }

        /// <summary>
        /// The form calc_ mouse down.
        /// </summary>
        /// <param name="sender">
        /// To close menu on click outside
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void FormCalc_MouseDown(object sender, MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left)
            {
                var index = e.Y;
                if (index == e.Y)
                {
                    this.PanelMenu.Visible = false;
                }
            }
        }

        /// <summary>
        /// The ky down.
        /// </summary>
        /// <param name="sender">
        /// The sender - handling keystrokes.
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void KyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 16:
                case 17:
                case 18:
                    break;
                case 48:
                case 96:
                    this.Btn0.PerformClick();
                    break;
                case 49:
                case 97:
                    this.Btn1.PerformClick();
                    break;
                case 50:
                case 98:
                    this.Btn2.PerformClick();
                    break;
                case 51:
                case 99:
                    this.Btn3.PerformClick();
                    break;
                case 52:
                case 100:
                    this.Btn4.PerformClick();
                    break;
                case 53:
                    if (e.Shift)
                    {
                        this.BtnPercent.PerformClick();
                    }
                    else
                    {
                        this.Btn5.PerformClick();
                    }

                    break;
                case 101:
                    this.Btn5.PerformClick();
                    break;
                case 54:
                case 102:
                    this.Btn6.PerformClick();
                    break;
                case 55:
                case 103:
                    this.Btn7.PerformClick();
                    break;
                case 56:
                    if (e.Shift)
                    {
                        this.BtnMultiply.PerformClick();
                    }
                    else
                    {
                        this.Btn8.PerformClick();
                    }

                    break;

                case 104:
                    this.Btn8.PerformClick();
                    break;
                case 57:
                case 105:
                    this.Btn9.PerformClick();
                    break;
                case 110:
                case 190:
                case 188:
                    this.BtnDesimal.PerformClick();
                    break;
                case 111:
                    this.BtnDivision.PerformClick();
                    break;
                case 106:
                    this.BtnMultiply.PerformClick();
                    break;
                case 109:
                case 189:
                    this.BtnSubstraction.PerformClick();
                    break;
                case 107:
                    this.BtnAdd.PerformClick();
                    break;
                case 67:
                    this.BtnC.PerformClick();
                    break;
                case 187:
                    if (e.Shift)
                    {
                        this.BtnAdd.PerformClick();
                    }
                    else
                    {
                        this.BtnEquals.PerformClick();
                    }

                    break;
                case 13:
                    this.BtnEquals.PerformClick();
                    break;
                case 8:
                    this.BtnBackSpace.PerformClick();
                    break;
            }
        }

        /// <summary>
        /// The lost focus.
        /// </summary>
        /// <param name="sender">
        /// The sender: RtBoxDisplayHistory, TxtDisplay, TxtEstimation.
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private new void LostFocus(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        /// <summary>
        /// The txt display_ text changed - change font size.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtDisplay_TextChanged(object sender, EventArgs e)
        {
            if (this.TxtDisplay.Text.Length > 13)
            {
                this.TxtDisplay.Font = new Font("Gadugi", 15, this.TxtDisplay.Font.Style);
            }
            else
            {
                this.TxtDisplay.Font = new Font("Gadugi", 30, this.TxtDisplay.Font.Style);
            }
        }

        /// <summary>
        /// The txt estimation_ text changed - - change font size.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void TxtEstimation_TextChanged(object sender, EventArgs e)
        {
            if (this.TxtEstimation.Text.Length > 30)
            {
                this.TxtEstimation.Font = new Font("Gadugi", 8, this.TxtEstimation.Font.Style);
            }
            else
            {
                this.TxtEstimation.Font = new Font("Gadugi", 14, this.TxtEstimation.Font.Style);
            }
        }

        /// <summary>
        /// The pnl title_ mouse move - moving around the screen.
        /// </summary>
        /// <param name="sender">
        /// The sender - my mouse.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void PnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - this.lastPoint.X;
                this.Top += e.Y - this.lastPoint.Y;
            }
        }

        /// <summary>
        /// The pnl title_ mouse down - moving around the screen.
        /// </summary>
        /// <param name="sender">
        /// The sender - mouse coordinates.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void PnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            this.lastPoint = new Point(e.X, e.Y);
        }

        /// <summary>
        /// The btn pl mn_ click.
        /// </summary>
        /// <param name="sender">
        /// The sender - button: ±
        /// </param>
        /// <param name="e">
        /// The e - event.
        /// </param>
        private void BtnPlMn_Click(object sender, EventArgs e)
        {
            switch (this.TxtDisplay.Text)
            {
                case ",":
                case "":
                case " ":
                    break;
                default:
                    if ((this.TxtEstimation.Text != string.Empty)
                        && "=".Contains(this.TxtEstimation.Text.Substring(this.TxtEstimation.Text.Length - 1, 1))
                        && this.TxtDisplay.Text != string.Empty && this.TxtDisplay.Text != "0")
                    {
                        this.TxtEstimation.Text = string.Empty;
                        this.result = 0;
                        this.TxtDisplay.Text = Convert.ToString(-1 * Convert.ToDouble(this.TxtDisplay.Text));
                    }
                    else
                    {
                        this.TxtDisplay.Text = Convert.ToString(-1 * Convert.ToDouble(this.TxtDisplay.Text));
                    }
                   
                    break;
            }

            this.ActiveControl = null;
        }

        /* for debugging:
         MessageBox.Show(
              "Куку",
              "Сообщение",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Information,
              MessageBoxDefaultButton.Button1,
              MessageBoxOptions.DefaultDesktopOnly);
        */
    }
}
