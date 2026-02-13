using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace ConsoleForm
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyForm());
        }
    }

    public class MyForm : Form
    {
        private Label messageLabel;
        private Button actionButton;

        public MyForm()
        {
            this.Text = "Пример формы";
            this.Height = 300;
            this.Width = 400;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightBlue;   

            messageLabel = new Label();
            messageLabel.Text = "Привет! Нажми кнопку";
            messageLabel.Top = 50;               
            messageLabel.Left = 50;               
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI", 10);

            actionButton = new Button();
            actionButton.Text = "Нажми меня";
            actionButton.Top = 100;
            actionButton.Left = 50;
            actionButton.Width = 100;
            actionButton.Height = 30;

            actionButton.Click += (sender, e) => messageLabel.Text = "Вы нажали кнопку!";

            this.Controls.Add(messageLabel);
            this.Controls.Add(actionButton);
        }
    }
}