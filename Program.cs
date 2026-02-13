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
        private TextBox nameTextBox;      // новое поле
        private Button greetButton;       // новая кнопка

        public MyForm()
        {
            this.Text = "Пример формы";
            this.Height = 400;             // немного увеличим высоту
            this.Width = 400;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightBlue;

            // Надпись
            messageLabel = new Label();
            messageLabel.Text = "Привет! Нажми кнопку";
            messageLabel.Top = 50;
            messageLabel.Left = 50;
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI", 10);

            // Первая кнопка (меняет текст)
            actionButton = new Button();
            actionButton.Text = "Нажми меня";
            actionButton.Top = 100;
            actionButton.Left = 50;
            actionButton.Width = 100;
            actionButton.Height = 30;
            actionButton.Click += (sender, e) => messageLabel.Text = "Вы нажали первую кнопку!";

            // Текстовое поле для ввода имени
            nameTextBox = new TextBox();
            nameTextBox.Top = 150;
            nameTextBox.Left = 50;
            nameTextBox.Width = 150;
            nameTextBox.Text = "Введите имя";

            // Вторая кнопка для приветствия
            greetButton = new Button();
            greetButton.Text = "Поздороваться";
            greetButton.Top = 190;
            greetButton.Left = 50;
            greetButton.Width = 120;
            greetButton.Height = 30;
            greetButton.Click += (sender, e) =>
            {
                string name = nameTextBox.Text;
                if (string.IsNullOrWhiteSpace(name) || name == "Введите имя")
                    messageLabel.Text = "Введите имя!";
                else
                    messageLabel.Text = $"Привет, {name}!";
            };

            // Добавляем все элементы на форму
            this.Controls.Add(messageLabel);
            this.Controls.Add(actionButton);
            this.Controls.Add(nameTextBox);
            this.Controls.Add(greetButton);
        }
    }
}