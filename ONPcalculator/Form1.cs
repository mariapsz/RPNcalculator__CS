using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONPcalculator {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
            this.KeyPreview = true;
        }

        ArrayList elements = new ArrayList();
        string currentNumber = null;
        double memory;
        bool isNumberLast = false;
        string result = null;
        bool MRclicked = false;


        private void numberClick(object sender, EventArgs e) {
            if (inputTextBox.Text.Length > 33) return;
            string text = ((Button)sender).Text;
            if (inputTextBox.Text == "0" || inputTextBox.Text.Contains('=')) {
                inputTextBox.Text = text;
                currentNumber = text;
            } else {
                if (currentNumber == "0") {
                    currentNumber = text;
                    inputTextBox.Text = inputTextBox.Text.RemoveLastChar() + text;
                } else {
                    currentNumber += text;
                    inputTextBox.Text += text;
                }
            }
            isNumberLast = true;
            MRclicked = true;
        }

        private void commaClick(object sender, EventArgs e) {
            if (inputTextBox.Text.Length > 33) return;
            if (!isNumberLast) return;
            if (!currentNumber.Contains(',')) {
                inputTextBox.Text += ',';
                currentNumber += ',';
                isNumberLast = false;
            }
            MRclicked = true;
        }

        private void operatorClick(object sender, EventArgs e) {
            if (inputTextBox.Text.Length > 33) return;
            string text = ((Button)sender).Text;
            if (!isNumberLast) {
                if (text == "(") {
                    if (elements.Count > 0 && (ONP.isOperator(elements.Last()) || elements.Last() == "(")) {
                        if (inputTextBox.Text.LastChar() == ",") return;
                        inputTextBox.Text += "(";
                        elements.Add(text);
                    } else if (inputTextBox.Text == "0") {
                        inputTextBox.Text = "(";
                        elements.Add(text);
                    }
                } else if (inputTextBox.Text == "0") {
                    if (text == "-") {
                        elements.Add(text);
                        inputTextBox.Text = text;
                    }
                } else if (inputTextBox.Text.Contains("=")) {
                    elements.Add(result);
                    elements.Add(text);
                    inputTextBox.Text = result + text;
                    result = null;
                } else if (ONP.isOperator(text)) {
                    if (inputTextBox.Text.Length > 0 && elements.Last() == ")") {
                        elements.Add(text);
                        inputTextBox.Text += text;
                    } else {
                        if (inputTextBox.Text.Length > 1 && elements.Last() == "(") return;
                        else {
                            elements.RemoveLast();
                            elements.Add(text);
                            inputTextBox.Text = inputTextBox.Text.RemoveLastChar();
                            inputTextBox.Text += text;
                        }
                    }
                } else if (text == ")" && isBracketNeeded()) {
                    elements.Add(text);
                    inputTextBox.Text += text;
                }
            } else {
                if (ONP.isOperator(text) || (text == ")" && isBracketNeeded())) {
                    elements.Add(currentNumber);
                    currentNumber = null;
                    isNumberLast = false;
                    elements.Add(text);
                    inputTextBox.Text += text;
                }
            }
            MRclicked = false;
        }

        private void equalClick(object sender, EventArgs e) {
            if (inputTextBox.Text.Length > 1 && areBracketsClosed()) {
                if (currentNumber != null) {
                    if (elements.Count == 0)
                        return;
                    elements.Add(currentNumber);
                    currentNumber = null;
                    isNumberLast = false;
                    result = Convert.ToString(ONP.Calculate(elements));
                    elements.Clear();
                    inputTextBox.Text += "=" + result;
                } else if (elements.Count > 0 && elements.Last() == ")") {
                    result = Convert.ToString(ONP.Calculate(elements));
                    elements.Clear();
                    isNumberLast = false;
                    inputTextBox.Text += "=" + result;
                }
            }
        }
        
        private void deleteClick(object sender, EventArgs e){
            if (inputTextBox.Text != "0") {
                if (!isNumberLast) {
                    inputTextBox.Text = inputTextBox.Text.RemoveLastChar();
                    if (currentNumber != "") {
                        currentNumber = currentNumber.RemoveLastChar();
                        isNumberLast = true;
                    } else {
                        elements.RemoveLast();
                        if (elements.Count > 0 && elements.Last() != ")" && !ONP.isOperator(elements.Last())) {
                            currentNumber = elements.Last();
                            isNumberLast = true;
                            elements.RemoveLast();
                        }
                    }                    
                } else if (elements.Count > 0) {
                    if (isANumber(elements.Last())) {
                        currentNumber = elements.Last().RemoveLastChar();
                        elements.RemoveLast();
                        inputTextBox.Text = inputTextBox.Text.RemoveLastChar();
                        if (inputTextBox.Text.Length > 0 && !isANumber(inputTextBox.Text.LastChar()))
                            isNumberLast = false;
                    } else {
                        inputTextBox.Text = inputTextBox.Text.RemoveLastChar();
                        currentNumber = currentNumber.RemoveLastChar();
                        if (currentNumber == "" || currentNumber.LastChar() == ",")
                            isNumberLast = false;
                    }
                } else {
                    inputTextBox.Text = inputTextBox.Text.RemoveLastChar();
                    currentNumber = currentNumber.RemoveLastChar();
                    if (currentNumber == "" || currentNumber.LastChar() == ",")
                        isNumberLast = false;
                }
                if (inputTextBox.Text.Length == 0)
                    inputTextBox.Text = "0";
            }
        }
        
        private void resetClick(object sender, EventArgs e) {
            inputTextBox.Text = "0";
            elements.Clear();
            MRclicked = false;
        }

        private void MRClick(object sender, EventArgs e) {
            if (MRclicked) {
                inputTextBox.Text = "0";
                memory = 0;
                MRclicked = false;
            } else {
                inputTextBox.Text = Convert.ToString(memory);
                elements.Clear();
                currentNumber = Convert.ToString(memory);
                isNumberLast = true;
                MRclicked = true;
            }
        }

        private void memoryPlusClick(object sender, EventArgs e) {
            memory = Convert.ToDouble(memory) + Convert.ToDouble(currentNumber);
            MRclicked = false;
        }

        private void memoryMinusClick(object sender, EventArgs e) {
            memory = Convert.ToDouble(memory) - Convert.ToDouble(currentNumber);
            MRclicked = false;
        }

        private bool isANumber(string s) {
            return !(ONP.isOperator(s) || s == "(" || s == ")");
        }

        private bool isBracketNeeded() {
            return (Count(inputTextBox.Text, '(') > Count(inputTextBox.Text, ')')) && (isNumberLast || elements.Last() == ")");
        }

        private bool areBracketsClosed() {
            return Count(inputTextBox.Text, '(') == Count(inputTextBox.Text, ')');
        }
        
        public static int Count(string s, char character) {
            char[] array = s.ToCharArray();
            int count = 0;
            foreach (char c in array) {
                if (c == character)
                    count++;
            }
            return count;
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyValue) {
                case (int)Keys.D0:
                    if (e.Shift) {
                        rightBracket.Focus();
                        rightBracket.PerformClick();
                    } else {
                        zero.Focus();
                        zero.PerformClick();
                    }
                    break;
                case (int)Keys.D1:
                    one.Focus();
                    one.PerformClick();
                    break;
                case (int)Keys.D2:
                    two.Focus();
                    two.PerformClick();
                    break;
                case (int)Keys.D3:
                    three.Focus();
                    three.PerformClick();
                    break;
                case (int)Keys.D4:
                    four.Focus();
                    four.PerformClick();
                    break;
                case (int)Keys.D5:
                    five.Focus();
                    five.PerformClick();
                    break;
                case (int)Keys.D6:
                    if (e.Shift) {
                        power.Focus();
                        power.PerformClick();
                    } else {
                        six.Focus();
                        six.PerformClick();
                    }
                    break;
                case (int)Keys.D7:
                    seven.Focus();
                    seven.PerformClick();
                    break;
                case (int)Keys.D8:
                    if (e.Shift) {
                        multiply.Focus();
                        multiply.PerformClick();
                    } else {
                        eight.Focus();
                        eight.PerformClick();
                    }
                    break;
                case (int)Keys.D9:
                    if (e.Shift) {
                        leftBracket.Focus();
                        leftBracket.PerformClick();
                    } else {
                        nine.Focus();
                        nine.PerformClick();
                    }
                    break;
                case (int)Keys.OemQuestion:
                    division.Focus();
                    division.PerformClick();
                    break;
                case (int)Keys.Oemplus:
                    if (e.Shift) {
                        plus.Focus();
                        plus.PerformClick();
                    } else {
                        equal.Focus();
                        equal.PerformClick();
                    }
                    break;
                case (int)Keys.OemMinus:
                    if (e.Shift) {
                        minus.Focus();
                        minus.PerformClick();
                    }
                    break;
                case (int)Keys.Back:
                    delete.Focus();
                    delete.PerformClick();
                    break;
                case (int)Keys.OemPeriod:
                    dot.Focus();
                    dot.PerformClick();
                    break;
                case (int)Keys.Escape:
                    reset.Focus();
                    reset.PerformClick();
                    break;
                case (int)Keys.M:
                    if (e.Shift) {
                        memoryPlus.Focus();
                        memoryPlus.PerformClick();
                    } else if (e.Control) {
                        memoryMinus.Focus();
                        memoryMinus.PerformClick();
                    } else {
                        MR.Focus();
                        MR.PerformClick();
                    }
                    break;
            }
        }

       
    }   
}
