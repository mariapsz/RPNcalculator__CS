namespace ONPcalculator {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.reset = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.memoryMinus = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.memoryPlus = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.rightBracket = new System.Windows.Forms.Button();
            this.leftBracket = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.BackColor = System.Drawing.Color.OrangeRed;
            this.reset.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(15, 122);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(90, 47);
            this.reset.TabIndex = 0;
            this.reset.Text = "AC";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.resetClick);
            // 
            // delete
            // 
            this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.delete.BackColor = System.Drawing.Color.OrangeRed;
            this.delete.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(108, 122);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(90, 47);
            this.delete.TabIndex = 1;
            this.delete.Text = "C";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.deleteClick);
            // 
            // memoryMinus
            // 
            this.memoryMinus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoryMinus.BackColor = System.Drawing.Color.Silver;
            this.memoryMinus.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryMinus.Location = new System.Drawing.Point(201, 70);
            this.memoryMinus.Name = "memoryMinus";
            this.memoryMinus.Size = new System.Drawing.Size(90, 47);
            this.memoryMinus.TabIndex = 2;
            this.memoryMinus.Text = "M-";
            this.memoryMinus.UseVisualStyleBackColor = false;
            this.memoryMinus.Click += new System.EventHandler(this.memoryMinusClick);
            // 
            // division
            // 
            this.division.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.division.BackColor = System.Drawing.Color.Silver;
            this.division.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(294, 70);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(90, 47);
            this.division.TabIndex = 3;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.operatorClick);
            // 
            // multiply
            // 
            this.multiply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiply.BackColor = System.Drawing.Color.Silver;
            this.multiply.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(294, 175);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(90, 47);
            this.multiply.TabIndex = 7;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.operatorClick);
            // 
            // three
            // 
            this.three.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.three.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.Location = new System.Drawing.Point(201, 175);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(90, 47);
            this.three.TabIndex = 6;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.numberClick);
            // 
            // two
            // 
            this.two.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.two.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.Location = new System.Drawing.Point(108, 175);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(90, 47);
            this.two.TabIndex = 5;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.numberClick);
            // 
            // one
            // 
            this.one.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.one.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.Location = new System.Drawing.Point(15, 175);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(90, 47);
            this.one.TabIndex = 4;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.numberClick);
            // 
            // plus
            // 
            this.plus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plus.BackColor = System.Drawing.Color.Silver;
            this.plus.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(294, 227);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(90, 47);
            this.plus.TabIndex = 11;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.operatorClick);
            // 
            // six
            // 
            this.six.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.six.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.Location = new System.Drawing.Point(201, 227);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(90, 47);
            this.six.TabIndex = 10;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.numberClick);
            // 
            // five
            // 
            this.five.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.five.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.Location = new System.Drawing.Point(108, 227);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(90, 47);
            this.five.TabIndex = 9;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.numberClick);
            // 
            // four
            // 
            this.four.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.four.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.Location = new System.Drawing.Point(15, 227);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(90, 47);
            this.four.TabIndex = 8;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.numberClick);
            // 
            // minus
            // 
            this.minus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minus.BackColor = System.Drawing.Color.Silver;
            this.minus.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(294, 279);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(90, 47);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.operatorClick);
            // 
            // nine
            // 
            this.nine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nine.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nine.Location = new System.Drawing.Point(201, 279);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(90, 47);
            this.nine.TabIndex = 14;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.numberClick);
            // 
            // eight
            // 
            this.eight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eight.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight.Location = new System.Drawing.Point(108, 279);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(90, 47);
            this.eight.TabIndex = 13;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.numberClick);
            // 
            // seven
            // 
            this.seven.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seven.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.Location = new System.Drawing.Point(15, 279);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(90, 47);
            this.seven.TabIndex = 12;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.numberClick);
            // 
            // equal
            // 
            this.equal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equal.BackColor = System.Drawing.Color.Silver;
            this.equal.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(294, 331);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(90, 47);
            this.equal.TabIndex = 20;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equalClick);
            // 
            // power
            // 
            this.power.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.power.BackColor = System.Drawing.Color.Silver;
            this.power.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.power.Location = new System.Drawing.Point(201, 331);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(90, 47);
            this.power.TabIndex = 19;
            this.power.Text = "^";
            this.power.UseVisualStyleBackColor = false;
            this.power.Click += new System.EventHandler(this.operatorClick);
            // 
            // zero
            // 
            this.zero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zero.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(108, 331);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(90, 47);
            this.zero.TabIndex = 18;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.numberClick);
            // 
            // dot
            // 
            this.dot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dot.BackColor = System.Drawing.Color.Silver;
            this.dot.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot.Location = new System.Drawing.Point(15, 331);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(90, 47);
            this.dot.TabIndex = 17;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.commaClick);
            // 
            // memoryPlus
            // 
            this.memoryPlus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoryPlus.BackColor = System.Drawing.Color.Silver;
            this.memoryPlus.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryPlus.Location = new System.Drawing.Point(108, 70);
            this.memoryPlus.Name = "memoryPlus";
            this.memoryPlus.Size = new System.Drawing.Size(90, 47);
            this.memoryPlus.TabIndex = 24;
            this.memoryPlus.Text = "M+";
            this.memoryPlus.UseVisualStyleBackColor = false;
            this.memoryPlus.Click += new System.EventHandler(this.memoryPlusClick);
            // 
            // MR
            // 
            this.MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MR.BackColor = System.Drawing.Color.Silver;
            this.MR.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MR.Location = new System.Drawing.Point(15, 70);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(90, 47);
            this.MR.TabIndex = 23;
            this.MR.Text = "MR";
            this.MR.UseVisualStyleBackColor = false;
            this.MR.Click += new System.EventHandler(this.MRClick);
            // 
            // rightBracket
            // 
            this.rightBracket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightBracket.BackColor = System.Drawing.Color.Silver;
            this.rightBracket.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBracket.Location = new System.Drawing.Point(294, 122);
            this.rightBracket.Name = "rightBracket";
            this.rightBracket.Size = new System.Drawing.Size(90, 47);
            this.rightBracket.TabIndex = 22;
            this.rightBracket.Text = ")";
            this.rightBracket.UseVisualStyleBackColor = false;
            this.rightBracket.Click += new System.EventHandler(this.operatorClick);
            // 
            // leftBracket
            // 
            this.leftBracket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftBracket.BackColor = System.Drawing.Color.Silver;
            this.leftBracket.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBracket.Location = new System.Drawing.Point(201, 122);
            this.leftBracket.Name = "leftBracket";
            this.leftBracket.Size = new System.Drawing.Size(90, 47);
            this.leftBracket.TabIndex = 21;
            this.leftBracket.Text = "(";
            this.leftBracket.UseVisualStyleBackColor = false;
            this.leftBracket.Click += new System.EventHandler(this.operatorClick);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.BackColor = System.Drawing.Color.FloralWhite;
            this.inputTextBox.Font = new System.Drawing.Font("Impact", 20F);
            this.inputTextBox.Location = new System.Drawing.Point(15, 21);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(369, 40);
            this.inputTextBox.TabIndex = 25;
            this.inputTextBox.Text = "0";
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 26;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(396, 390);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.memoryPlus);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.rightBracket);
            this.Controls.Add(this.leftBracket);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.power);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.division);
            this.Controls.Add(this.memoryMinus);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.reset);
            this.Name = "MainWindow";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button memoryMinus;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button memoryPlus;
        private System.Windows.Forms.Button MR;
        private System.Windows.Forms.Button rightBracket;
        private System.Windows.Forms.Button leftBracket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

