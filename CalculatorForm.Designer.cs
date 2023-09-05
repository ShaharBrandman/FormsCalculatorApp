namespace WindowsFormsApp1
{
    partial class CalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FuckMicrosoft = new System.Windows.Forms.Label();
            this.firstNumber = new System.Windows.Forms.TextBox();
            this.MathOperator = new System.Windows.Forms.TextBox();
            this.secondNumber = new System.Windows.Forms.TextBox();
            this.EQUALS = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.getResult = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FuckMicrosoft
            // 
            this.FuckMicrosoft.AutoSize = true;
            this.FuckMicrosoft.Location = new System.Drawing.Point(181, 45);
            this.FuckMicrosoft.Name = "FuckMicrosoft";
            this.FuckMicrosoft.Size = new System.Drawing.Size(77, 13);
            this.FuckMicrosoft.TabIndex = 0;
            this.FuckMicrosoft.Text = "Fuck Microsoft";
            // 
            // firstNumber
            // 
            this.firstNumber.Location = new System.Drawing.Point(184, 77);
            this.firstNumber.Name = "firstNumber";
            this.firstNumber.Size = new System.Drawing.Size(88, 20);
            this.firstNumber.TabIndex = 1;
            this.firstNumber.TextChanged += new System.EventHandler(this.firstNumber_TextChanged);
            this.firstNumber.MouseEnter += new System.EventHandler(this.firstNumber_MouseEnter);
            // 
            // MathOperator
            // 
            this.MathOperator.Location = new System.Drawing.Point(279, 77);
            this.MathOperator.Name = "MathOperator";
            this.MathOperator.Size = new System.Drawing.Size(50, 20);
            this.MathOperator.TabIndex = 3;
            this.MathOperator.TextChanged += new System.EventHandler(this.MathOperator_TextChanged);
            // 
            // secondNumber
            // 
            this.secondNumber.Location = new System.Drawing.Point(346, 73);
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(50, 20);
            this.secondNumber.TabIndex = 5;
            this.secondNumber.TextChanged += new System.EventHandler(this.secondNumber_TextChanged);
            this.secondNumber.MouseEnter += new System.EventHandler(this.secondNumber_MouseEnter);
            // 
            // EQUALS
            // 
            this.EQUALS.AutoSize = true;
            this.EQUALS.Location = new System.Drawing.Point(417, 77);
            this.EQUALS.Name = "EQUALS";
            this.EQUALS.Size = new System.Drawing.Size(13, 13);
            this.EQUALS.TabIndex = 6;
            this.EQUALS.Text = "=";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Result.Location = new System.Drawing.Point(457, 78);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(16, 15);
            this.Result.TabIndex = 7;
            this.Result.Text = "X";
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(183, 120);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(74, 38);
            this.one.TabIndex = 8;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(289, 118);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(53, 39);
            this.two.TabIndex = 9;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(395, 125);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(78, 32);
            this.three.TabIndex = 10;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(189, 183);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(68, 62);
            this.four.TabIndex = 11;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(279, 181);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(63, 63);
            this.five.TabIndex = 12;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(393, 183);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(64, 60);
            this.six.TabIndex = 13;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(187, 274);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(70, 50);
            this.seven.TabIndex = 14;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(293, 271);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(68, 52);
            this.eight.TabIndex = 15;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(396, 270);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(61, 52);
            this.nine.TabIndex = 16;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(501, 130);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(44, 27);
            this.add.TabIndex = 17;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(496, 184);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(48, 58);
            this.minus.TabIndex = 18;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(486, 274);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(58, 47);
            this.divide.TabIndex = 19;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(484, 346);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(59, 40);
            this.multiply.TabIndex = 20;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(395, 351);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(59, 34);
            this.dot.TabIndex = 21;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // getResult
            // 
            this.getResult.Location = new System.Drawing.Point(279, 358);
            this.getResult.Name = "getResult";
            this.getResult.Size = new System.Drawing.Size(70, 27);
            this.getResult.TabIndex = 22;
            this.getResult.Text = "=";
            this.getResult.UseVisualStyleBackColor = true;
            this.getResult.Click += new System.EventHandler(this.getResult_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(183, 359);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(66, 26);
            this.zero.TabIndex = 23;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // CalculatorForm
            // 
            this.ClientSize = new System.Drawing.Size(720, 512);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.getResult);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.EQUALS);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.MathOperator);
            this.Controls.Add(this.firstNumber);
            this.Controls.Add(this.FuckMicrosoft);
            this.Name = "CalculatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label FuckMicrosoft;
        private System.Windows.Forms.TextBox firstNumber;
        private System.Windows.Forms.TextBox MathOperator;
        private System.Windows.Forms.TextBox secondNumber;
        private System.Windows.Forms.Label EQUALS;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button getResult;
        private System.Windows.Forms.Button zero;

        #endregion
    }
}

