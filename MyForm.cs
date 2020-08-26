using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace DemoWindowForms
{
    class MyForm : Form
    {
        Label lbInput;
        TextBox txtBox;
        Button btnAdd;
        ComboBox cbBox;
        RadioButton rdBtn1;
        RadioButton rdBtn2;
        DateTimePicker pickerDate;
        Label lbDob;
        bool toggle = true;
        public MyForm()
        {
            this.Size = new Size(500, 500);
            this.WindowState = FormWindowState.Normal;
            this.DoubleBuffered = true; // tăng bộ đệm

            lbInput = new Label()
            {
                Text = "Input your name",
                Font = new Font("Arial", 20),
                Size = new Size(500, 50),
                Location = new Point(10, 0)
            };
            this.Controls.Add(lbInput);

            txtBox = new TextBox()
            {
                Size = new Size(300, 50),
                Multiline = false,
                Location = new Point(10, 50)
            };
            this.Controls.Add(txtBox);
            btnAdd = new Button()
            {
                Text = "Add",
                Size = new Size(75, 20),
                Location = new Point(350, 50)
            };
            this.Controls.Add(btnAdd);
            btnAdd.Click += BtnAdd_Click;
            cbBox = new ComboBox()
            {
                Size = new Size(450, 20),
                Location = new Point(10, 75),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            this.Controls.Add(cbBox);

            rdBtn1 = new RadioButton()
            {
                Size = new Size(100, 40),
                Location = new Point(10, 90),
                Text = "Female"
            };
            this.Controls.Add(rdBtn1);

            rdBtn2 = new RadioButton()
            {
                Size = new Size(100, 40),
                Location = new Point(10, 120),
                Text = "Male"
            };
            this.Controls.Add(rdBtn2);

            pickerDate = new DateTimePicker()
            {
                Location = new Point(120, 130),
            };
            pickerDate.Format = DateTimePickerFormat.Short;
            this.Controls.Add(pickerDate);

            lbDob = new Label()
            {
                Text = "D.O.B",
                Location = new Point(120, 115),
            };
            this.Controls.Add(lbDob);

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            cbBox.Items.Add(txtBox.Text);
            txtBox.Text = "";
        }
    }
}
