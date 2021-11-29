using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Dane, które podaje użytkownik:
 *  1.wielkość naczynia
 *  2.zawartość procentową spirytusu w napoju
 *  3.ilość sztuk "naczynia"
 * Wynikami są:
 *  1.objętość napoju
 *  2.objętość czystego spirytusu
 * Dodatkowo:
 *  1.jedna osoba odpowiada za "logikę" programu, druga za GUI
 *  2.chcemy mieć sensowną historię zmian (tzn. nie na zasadzie,
 *      że mamy tylko jedną dużą zmianę, zawierającą ostateczną wersję)
 * Wersje bogatsze:
 *  1.typowe naczynia (na 4.5)
 *  2.typowe napoje (na 5.5)
 *  3.logika wie wszystko o typowych (na 6)
 */

namespace DrinkPercentages
{
    public partial class Form1 : Form
    {
        private Logic logic;

        public Form1()
        {
            InitializeComponent();
            logic = new Logic();
        }

        private void bCalculate_Click(object sender, EventArgs e)
        {
            if (!float.TryParse(tbContainerSize.Text, out float size))
            {
                labelErrors.Text = "Błąd odczytu rozmiaru naczynia.";
                return;
            }
            if (!float.TryParse(tbAlcoholPercentage.Text, out float percentage))
            {
                labelErrors.Text = "Błąd odczytu zawartości alkoholu.";
                return;
            }
            if (!int.TryParse(tbContainerCount.Text, out int count))
            {
                labelErrors.Text = "Błąd odczytu ilości naczyń.";
                return;
            }
            labelErrors.Text = "";

            try
            {
                logic.AlcoholPercentage = percentage;
                logic.ContainerCount = count;
                logic.ContainerSize = size;
            }
            catch (ArgumentException err)
            {
                labelErrors.Text = err.Message;
            }

            tbDrinkVolume.Text = logic.DrinkVolume.ToString();
            tbAlcoholVolume.Text = logic.AlcoholVolume.ToString();
        }
    }
}
