using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LanguageRichnessAnalyzer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Ініціалізація компонентів форми
            InitializeStyles(); // Ініціалізація стилів
            InputTextBox.ScrollToCaret(); // Прокручування до курсору

        }

        private void InitializeStyles()
        {
            BackColor = Color.FromArgb(240, 240, 240); // Встановлення кольору фону форми
            Font = new Font("Segoe UI", 10); // Встановлення шрифту форми

            SetupButtonStyle(AnalyzeButton, Color.FromArgb(52, 152, 219)); // Налаштування стилю кнопки аналізу
            SetupButtonStyle(SaveResultsButton, Color.FromArgb(46, 204, 113)); // Налаштування стилю кнопки збереження результатів

            SetupTextBoxStyle(WordFrequencyTextBox); // Налаштування стилю текстового поля частоти слів

            InputTextBox.ScrollBars = ScrollBars.Both; // Включення прокручування текстового поля для вводу
        }

        private void SetupButtonStyle(Button button, Color backColor)
        {
            button.FlatStyle = FlatStyle.Flat; // Встановлення плоского стилю кнопки
            button.BackColor = backColor; // Встановлення кольору фону кнопки
            button.ForeColor = Color.White; // Встановлення кольору тексту кнопки
            button.FlatAppearance.BorderSize = 0; // Встановлення розміру межі кнопки
            button.FlatAppearance.MouseDownBackColor = ControlPaint.Dark(backColor, 0.2f); // Колір кнопки при натисканні
            button.FlatAppearance.MouseOverBackColor = ControlPaint.Light(backColor, 0.2f); // Колір кнопки при наведенні
            button.MouseDown += Button_MouseDown; // Додавання обробника події при натисканні
            button.MouseUp += Button_MouseUp; // Додавання обробника події при відпусканні
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            // Обробка події натискання кнопки
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
            {
                button.BackColor = ControlPaint.Light(button.BackColor, 0.2f); // Зміна кольору кнопки при відпусканні
            }
        }

        private void SetupTextBoxStyle(TextBox textBox)
        {
            textBox.BackColor = Color.White; // Встановлення кольору фону текстового поля
            textBox.Font = new Font("Segoe UI", 9); // Встановлення шрифту текстового поля
            textBox.ReadOnly = true; // Встановлення текстового поля тільки для читання
            textBox.BorderStyle = BorderStyle.FixedSingle; // Встановлення стилю межі текстового поля
            textBox.Multiline = true; // Включення можливості багаторядкового вводу
            textBox.ForeColor = Color.FromArgb(44, 62, 80); // Встановлення кольору тексту
            textBox.ScrollBars = ScrollBars.Vertical; // Включення вертикальної прокрутки
            textBox.Padding = new Padding(5); // Встановлення внутрішнього відступу
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            string inputText = InputTextBox.Text; // Отримання тексту з текстового поля вводу

            string[] sentences = Regex.Split(inputText, @"[.!?]+"); // Розділення тексту на речення
            string[] words = Regex.Split(inputText, @"\W+"); // Розділення тексту на слова

            int wordCount = words.Length; // Підрахунок кількості слів
            double averageSentenceLength = sentences.Length > 0 ? (double)wordCount / sentences.Length : 0; // Обчислення середньої довжини речення
            int uniqueWordCount = words.Distinct().Count(); // Підрахунок кількості унікальних слів
            var wordFrequency = CalculateWordFrequency(words); // Обчислення частоти слів
            int complexWordCount = words.Count(w => SyllableCount(w) > 3); // Підрахунок кількості складних слів
            double averageWordLength = wordCount > 0 ? (double)inputText.Count(char.IsLetter) / wordCount : 0; // Обчислення середньої довжини слова

            WordCountLabel.Text = $"Кількість слів: {wordCount}"; // Відображення кількості слів
            AverageSentenceLengthLabel.Text = $"Середня довжина речення: {averageSentenceLength:F2}"; // Відображення середньої довжини речення
            UniqueWordCountLabel.Text = $"Унікальних слів: {uniqueWordCount}"; // Відображення кількості унікальних слів
            ComplexWordCountLabel.Text = $"Складних слів: {complexWordCount}"; // Відображення кількості складних слів
            AverageWordLengthLabel.Text = $"Середня довжина слова: {averageWordLength:F2}"; // Відображення середньої довжини слова

            DisplayWordFrequency(wordFrequency); // Відображення частоти слів
        }

        private int SyllableCount(string word)
        {
            return word.Count(c => "aeiouаеіоуиєюя".Contains(char.ToLower(c))); // Підрахунок кількості складів у слові
        }

        private Dictionary<string, int> CalculateWordFrequency(string[] words)
        {
            return words.GroupBy(w => w.ToLower()) // Групування слів за їх значенням в нижньому регістрі
                        .ToDictionary(g => g.Key, g => g.Count()); // Повернення словника з частотою слів
        }

        private void DisplayWordFrequency(Dictionary<string, int> wordFrequency)
        {
            StringBuilder sb = new StringBuilder(); // Створення об'єкта для побудови рядка
            sb.AppendLine("+--------------------+----------+"); // Додавання заголовку таблиці
            sb.AppendLine("| Слово              | Кількість|");
            sb.AppendLine("+--------------------+----------+");

            foreach (var pair in wordFrequency.OrderByDescending(p => p.Value))
            {
                sb.AppendLine($"| {pair.Key.PadRight(18)} | {pair.Value.ToString().PadLeft(8)} |"); // Додавання рядків таблиці з частотою слів
            }

            sb.AppendLine("+--------------------+----------+");

            WordFrequencyTextBox.BackColor = Color.White; // Встановлення кольору фону текстового поля
            WordFrequencyTextBox.Font = new Font("Consolas", 9); // Використання моноширинного шрифту для кращого вирівнювання
            WordFrequencyTextBox.ReadOnly = true; // Встановлення текстового поля тільки для читання
            WordFrequencyTextBox.BorderStyle = BorderStyle.FixedSingle; // Встановлення стилю межі текстового поля
            WordFrequencyTextBox.Multiline = true; // Включення можливості багаторядкового вводу
            WordFrequencyTextBox.ForeColor = Color.FromArgb(44, 62, 80); // Встановлення кольору тексту
            WordFrequencyTextBox.ScrollBars = ScrollBars.Vertical; // Включення вертикальної прокрутки
            WordFrequencyTextBox.Padding = new Padding(5); // Встановлення внутрішнього відступу

            WordFrequencyTextBox.Text = sb.ToString(); // Встановлення тексту текстового поля
        }

        private void SaveResultsButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog(); // Створення діалогового вікна для збереження файлу
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Встановлення фільтру файлів
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string inputText = InputTextBox.Text; // Отримання тексту з текстового поля вводу
                    var wordFrequency = CalculateWordFrequency(Regex.Split(inputText, @"\W+")); // Обчислення частоти слів

                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        writer.WriteLine("Текст для аналізу:"); // Запис тексту для аналізу у файл
                        writer.WriteLine(inputText);
                        writer.WriteLine();
                        writer.WriteLine("Результати аналізу мови:"); // Запис результатів аналізу у файл
                        writer.WriteLine();
                        writer.WriteLine("+--------------------+----------+");
                        writer.WriteLine("| Слово              | Кількість|");
                        writer.WriteLine("+--------------------+----------+");
                        foreach (var pair in wordFrequency.OrderByDescending(p => p.Value))
                        {
                            writer.WriteLine($"| {pair.Key.PadRight(18)} | {pair.Value.ToString().PadLeft(8)} |"); // Запис частоти слів у файл
                        }
                        writer.WriteLine("+--------------------+----------+");
                    }
                    MessageBox.Show("Результати успішно збережено!"); // Повідомлення про успішне збереження
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Виникла помилка під час збереження результатів: {ex.Message}"); // Повідомлення про помилку збереження
                }
            }
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            InputTextBox.SelectionStart = InputTextBox.Text.Length; // Встановлення курсору в кінець тексту
            InputTextBox.ScrollToCaret(); // Прокручування до курсору

            // Прокрутка вправо
            InputTextBox.SelectionStart = InputTextBox.GetFirstCharIndexFromLine(InputTextBox.GetLineFromCharIndex(InputTextBox.TextLength));
            InputTextBox.ScrollToCaret();

            InputTextBox.SelectionLength = 0; // Зняття виділення
            InputTextBox.SelectionStart = InputTextBox.Text.Length; // Встановлення курсору в кінець тексту
            InputTextBox.ScrollToCaret(); // Прокручування до курсору
        }

    }
}
