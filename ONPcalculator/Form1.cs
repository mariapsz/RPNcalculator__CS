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
        }

        ArrayList elements = new ArrayList();
        string currentNumber = null;
        double memory;
        bool isNumberLast = false;
        string result = null;
        bool MRclicked = false;

        private void numberClick(object sender, EventArgs e) {
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
            if (!currentNumber.Contains(',')) {
                inputTextBox.Text += ',';
                currentNumber += ',';
                isNumberLast = false;
            }
            MRclicked = true;
        }

        private void operatorClick(object sender, EventArgs e) {
            string text = ((Button)sender).Text;
            if (!isNumberLast) {
                if (text == "(") {
                    if (elements.Count > 0 && (ONP.isOperator(elements.Last()) || elements.Last() == "(")) {
                        inputTextBox.Text += "(";
                        elements.Add(text);
                    } else if (inputTextBox.Text == "0") {
                        inputTextBox.Text = "(";
                        elements.Add(text);
                    }
                } else if (text == "-" && inputTextBox.Text == "0") {
                    elements.Add(text);
                    inputTextBox.Text = text;
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
                        elements.RemoveLast();
                        elements.Add(text);
                        inputTextBox.Text = inputTextBox.Text.RemoveLastChar();
                        inputTextBox.Text += text;
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
            MRclicked = true;
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

        private void deleteClick(object sender, EventArgs e) {
            if (inputTextBox.Text != "0") {
                if (!isNumberLast) {
                    if (elements.Count > 0) {
                        inputTextBox.Text = inputTextBox.Text.RemoveLastChar();
                        elements.RemoveLast();
                        if (elements.Count > 0 && elements.Last() != ")" && !ONP.isOperator(elements.Last())) {
                            currentNumber = elements.Last();
                            isNumberLast = true;
                        }
                    }
                } else if (elements.Count > 0) {
                    string lastElementInList = elements.Last();
                    if (isANumber(lastElementInList)) {
                        currentNumber = elements.Last();
                        elements.RemoveLast();
                        inputTextBox.Text = inputTextBox.Text.RemoveLastChar();
                        if (inputTextBox.Text.Length > 0 && !isANumber(inputTextBox.Text.LastChar()))
                            isNumberLast = false;
                    } else {
                        inputTextBox.Text = inputTextBox.Text.RemoveLastChar();
                        currentNumber = currentNumber.RemoveLastChar();
                        if (currentNumber.Length == 0)
                            isNumberLast = false;
                    }
                } else {
                    inputTextBox.Text = inputTextBox.Text.RemoveLastChar();
                    currentNumber = currentNumber.RemoveLastChar();
                    if (currentNumber.Length == 0)
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
    }
}
