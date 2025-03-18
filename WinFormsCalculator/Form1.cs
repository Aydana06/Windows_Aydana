using LibraryCalc.Calculator;
using LibraryCalc.Mem;


namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        private double num1;
        private string option;
        private readonly Calculator calculator = new Calculator();
        public Form1()
        {
            InitializeComponent();

        }
        private void UpdateMemoryList()
        {}
        private void BtnMPlus_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is MemoryItem item)
            {
                item.Add(1);
                UpdateMemoryList();
            }
        }

        private void BtnMMinus_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is MemoryItem item)
            {
                item.Subtract(calculator.Result); 
                UpdateMemoryList();
            }
        }

        private void BtnMC_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is MemoryItem item)
            {
                calculator.RemoveMemoryItem(item); 
                UpdateMemoryList();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        private void btnMS_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtResult.Text, out int y))
            {
                calculator.memory.Save(y);
                var addedItem = calculator.memory.memoryItems.Last();
                AddMemoryItemToPanel(addedItem);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calculator.Reset();
            num1 = 0;
            txtResult.Text = "0";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out num1))
            {
                option = "-";
                txtResult.Text = "";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out num1))
            {
                option = "+";
                txtResult.Text = "";
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Clear();
            }

            if (sender is Button b)
            {
                txtResult.Text += b.Text;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out double num2))
            {
                if (option == "+")
                {
                    calculator.Reset();
                    calculator.Result = num1;
                    calculator.Add(num2);
                }
                else if (option == "-")
                {
                    calculator.Reset();
                    calculator.Result = num1;
                    calculator.Subtract(num2);
                }

                txtResult.Text = calculator.Result.ToString();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {}

        private void btn2_Click(object sender, EventArgs e)
        {}
        private void btn3_Click(object sender, EventArgs e)
        {}

        private void btn4_Click(object sender, EventArgs e)
        {}

        private void btn5_Click(object sender, EventArgs e)
        {}

        private void btn6_Click(object sender, EventArgs e)
        {}

        private void btn7_Click(object sender, EventArgs e)
        {}

        private void btn8_Click(object sender, EventArgs e)
        {}

        private void btn9_Click(object sender, EventArgs e)
        {}

        private void listBoxMemory_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void Form1_Load(object sender, EventArgs e)
        {}
        private void UpdateMemoryDisplay()
        {
            panel1.Controls.Clear();
            foreach (var item in calculator.memory.memoryItems)
            {
                AddMemoryItemToPanel(item);
            }
        }

        private void AddMemoryItemToPanel(MemoryItem memoryItem)
        {
            Panel itemPanel = new Panel
            {
                Size = new Size(280, 50),
                BackColor = Color.White,
            };

            Label label = new Label
            {
                Text = memoryItem.Value.ToString(),
                Size = new Size(100, 30),
                Location = new Point(10, 10),
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.White,
            };

            Button buttonMC = CreateButton("MC", () =>
            {
                panel1.Controls.Remove(itemPanel);
                calculator.memory.clearItem(memoryItem);
            });

            Button buttonMPlus = CreateButton("M+", () =>
            {
                if (int.TryParse(txtResult.Text, out int y))
                {
                    memoryItem.Add(y);
                    label.Text = memoryItem.Value.ToString();
                }
            });

            Button buttonMMinus = CreateButton("M-", () =>
            {
                if (int.TryParse(txtResult.Text, out int y))
                {
                    memoryItem.Subtract(y);
                    label.Text = memoryItem.Value.ToString();
                }
            });

            buttonMC.Location = new Point(120, 10);
            buttonMPlus.Location = new Point(170, 10);
            buttonMMinus.Location = new Point(220, 10);

            itemPanel.Controls.Add(label);
            itemPanel.Controls.Add(buttonMC);
            itemPanel.Controls.Add(buttonMPlus);
            itemPanel.Controls.Add(buttonMMinus);

            panel1.Controls.Add(itemPanel);
            panel1.Controls.SetChildIndex(itemPanel, 0);

            UpdatePanelLocations();
        }

        private void UpdatePanelLocations()
        {
            int y = 10;
            foreach (Control control in panel1.Controls)
            {
                control.Location = new Point(10, y);
                y += control.Height + 5;
            }
        }

        private Button CreateButton(string text, Action onClick)
        {
            Button btn = new Button
            {
                Text = text,
                Size = new Size(40, 30),
                Visible = true
            };
            btn.Click += (s, e) => onClick();
            return btn;
        }
        private void btnMC_Click_1(object sender, EventArgs e)
        {
            calculator.memory.Clear();
            panel1.Controls.Clear();
        }

        private void btnMAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtResult.Text, out int value))
            {
                var lastItem = calculator.memory.memoryItems.LastOrDefault();
                if (lastItem != null)
                {
                    lastItem.Add(value);
                    UpdateMemoryDisplay();
                }
            }
        }

        private void btnMSub_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtResult.Text, out int value))
            {
                var lastItem = calculator.memory.memoryItems.LastOrDefault();
                if (lastItem != null)
                {
                    lastItem.Subtract(value);
                    UpdateMemoryDisplay();
                }

            }
        }
    }
}
