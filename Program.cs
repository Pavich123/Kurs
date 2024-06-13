using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageRichnessAnalyzer
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Включення візуальних стилів для додатку
            Application.SetCompatibleTextRenderingDefault(false); // Встановлення сумісності з рендерингом тексту за замовчуванням
            Application.Run(new Form1()); // Запуск головної форми додатку
        }
    }
}
