using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saveSlides
{
    class Program
    {
        static string currentClass="";
        static void Main(string[] args)
        {
            Console.WriteLine("Materie: ");
            currentClass=Console.ReadLine();
            HotKeyManager.RegisterHotKey(Keys.A, KeyModifiers.Alt);
            HotKeyManager.HotKeyPressed += new EventHandler<HotKeyEventArgs>(HotKeyManager_HotKeyPressed);
            Console.ReadLine();
        }

        static void HotKeyManager_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            string imageName = ImageName(currentClass);
            Console.WriteLine("A fost salvata o noua imagine cu numele "+imageName);

            Printscreen.Save(imageName);
        }

        static string ImageName(string currentClass)
        {
            string today = DateTime.Now.ToString("dd_MMMM_yyyy_HH_mm_ss");
            switch (DateTime.Now.DayOfWeek.ToString())
            {
                case "Monday":
                    return currentClass+"_Luni_" + today;
                case "Tuesday":
                    return currentClass+"_Marti_" + today;
                case "Wednesday":
                    return currentClass+"_Miercuri_" + today;
                case "Thursday":
                    return currentClass+"_Joi_" + today;
                case "Friday":
                    return currentClass+"_Vineri_" + today;
                case "Saturday":
                    return currentClass+"_Sambata_" + today;
                case "Sunday":
                    return currentClass+"_Duminica_" + today;
                default:
                    return "Undefined" + today;
            }
        }
    }
}

