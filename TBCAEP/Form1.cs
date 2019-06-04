using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBCAEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "TBC AEP Calculator";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            calculateAEP();
        }

        public void calculateAEP()
        {
            double AEPTotal = 0;
            bool isFucked = false;

            if (IsNumeric(agilityTextbox.Text))
            {
                agilityAEPLabel.Text = "AEP: " + double.Parse(agilityValue.Text) * Convert.ToDouble(agilityTextbox.Text);
                agilityPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(agilityValue.Text) * Convert.ToDouble(agilityTextbox.Text));
            }
            if(!IsNumeric(agilityTextbox.Text) && agilityTextbox.Text != "")
            {
                agilityPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(strengthTextbox.Text))
            {
                strengthAEPLabel.Text = "AEP: " + double.Parse(strengthValue.Text) * Convert.ToDouble(strengthTextbox.Text);
                strengthPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(strengthValue.Text) * Convert.ToDouble(strengthTextbox.Text));
            }
            if (!IsNumeric(strengthTextbox.Text) && strengthTextbox.Text != "")
            {
                strengthPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(meleeDpsTextbox.Text))
            {
                meleeDpsAEPLabel.Text = "AEP: " + double.Parse(meleeDpsValue.Text) * Convert.ToDouble(meleeDpsTextbox.Text);
                meleeDpsPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(meleeDpsValue.Text) * Convert.ToDouble(meleeDpsTextbox.Text));
            }
            if (!IsNumeric(meleeDpsTextbox.Text) && meleeDpsTextbox.Text != "")
            {
                meleeDpsPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(rangedDpsTextbox.Text))
            {
                rangedDpsAEPLabel.Text = "AEP: " + double.Parse(rangedDpsValue.Text) * Convert.ToDouble(rangedDpsTextbox.Text);
                rangedDpsPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(rangedDpsValue.Text) * Convert.ToDouble(rangedDpsTextbox.Text));
            }
            if (!IsNumeric(rangedDpsTextbox.Text) && rangedDpsTextbox.Text != "")
            {
                rangedDpsPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(rangedAPTextbox.Text))
            {
                rangedAPAEPLabel.Text = "AEP: " + double.Parse(rangedAPValue.Text) * Convert.ToDouble(rangedAPTextbox.Text);
                rangedAPPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(rangedAPValue.Text) * Convert.ToDouble(rangedAPTextbox.Text));
            }
            if (!IsNumeric(rangedAPTextbox.Text) && rangedAPTextbox.Text != "")
            {
                rangedAPPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(hitTextbox.Text))
            {
                hitAEPLabel.Text = "AEP: " + double.Parse(hitValue.Text) * Convert.ToDouble(hitTextbox.Text);
                hitPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(hitValue.Text) * Convert.ToDouble(hitTextbox.Text));
            }
            if (!IsNumeric(hitTextbox.Text) && hitTextbox.Text != "")
            {
                hitPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(expertiseTextbox.Text))
            {
                expertiseAEPLabel.Text = "AEP: " + double.Parse(expertiseValue.Text) * Convert.ToDouble(expertiseTextbox.Text);
                expertisePic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(expertiseValue.Text) * Convert.ToDouble(expertiseTextbox.Text));
            }
            if (!IsNumeric(expertiseTextbox.Text) && expertiseTextbox.Text != "")
            {
                expertisePic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(critTextbox.Text))
            {
                critAEPLabel.Text = "AEP: " + double.Parse(critValue.Text) * Convert.ToDouble(critTextbox.Text);
                critPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(critValue.Text) * Convert.ToDouble(critTextbox.Text));
            }
            if (!IsNumeric(critTextbox.Text) && critTextbox.Text != "")
            {
                critPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(hasteTextbox.Text))
            {
                hasteAEPLabel.Text = "AEP: " + double.Parse(hasteValue.Text) * Convert.ToDouble(hasteTextbox.Text);
                hastePic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(hasteValue.Text) * Convert.ToDouble(hasteTextbox.Text));
            }
            if (!IsNumeric(hasteTextbox.Text) && hasteTextbox.Text != "")
            {
                hastePic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(armorPenTextbox.Text))
            {
                armorPenAEPLabel.Text = "AEP: " + double.Parse(armorPenValue.Text) * Convert.ToDouble(armorPenTextbox.Text);
                armorPenPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(armorPenValue.Text) * Convert.ToDouble(armorPenTextbox.Text));
            }
            if (!IsNumeric(armorPenTextbox.Text) && armorPenTextbox.Text != "")
            {
                armorPenPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(intellectTextbox.Text))
            {
                intellectAEPLabel.Text = "AEP: " + double.Parse(intellectValue.Text) * Convert.ToDouble(intellectTextbox.Text);
                intellectPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(intellectValue.Text) * Convert.ToDouble(intellectTextbox.Text));
            }
            if (!IsNumeric(intellectTextbox.Text) && intellectTextbox.Text != "")
            {
                intellectPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(manaTextbox.Text))
            {
                manaAEPLabel.Text = "AEP: " + double.Parse(manaValue.Text) * Convert.ToDouble(manaTextbox.Text);
                manaPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(manaValue.Text) * Convert.ToDouble(manaTextbox.Text));
            }
            if (!IsNumeric(manaTextbox.Text) && manaTextbox.Text != "")
            {
                manaPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(spiritTextbox.Text))
            {
                spiritAEPLabel.Text = "AEP: " + double.Parse(spiritValue.Text) * Convert.ToDouble(spiritTextbox.Text);
                spiritPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(spiritValue.Text) * Convert.ToDouble(spiritTextbox.Text));
            }
            if (!IsNumeric(spiritTextbox.Text) && spiritTextbox.Text != "")
            {
                spiritPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(manaP5Textbox.Text))
            {
                manaP5AEPLabel.Text = "AEP: " + double.Parse(manaP5Value.Text) * Convert.ToDouble(manaP5Textbox.Text);
                manaP5Pic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(manaP5Value.Text) * Convert.ToDouble(manaP5Textbox.Text));
            }
            if (!IsNumeric(manaP5Textbox.Text) && manaP5Textbox.Text != "")
            {
                manaP5Pic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(staminaTextbox.Text))
            {
                staminaAEPLabel.Text = "AEP: " + double.Parse(staminaValue.Text) * Convert.ToDouble(staminaTextbox.Text);
                staminaPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(staminaValue.Text) * Convert.ToDouble(staminaTextbox.Text));
            }
            if (!IsNumeric(staminaTextbox.Text) && staminaTextbox.Text != "")
            {
                staminaPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(healthTextbox.Text))
            {
                healthAEPLabel.Text = "AEP: " + double.Parse(healthValue.Text) * Convert.ToDouble(healthTextbox.Text);
                healthPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(healthValue.Text) * Convert.ToDouble(healthTextbox.Text));
            }
            if (!IsNumeric(healthTextbox.Text) && healthTextbox.Text != "")
            {
                healthPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(healthP5Textbox.Text))
            {
                healthP5AEPLabel.Text = "AEP: " + double.Parse(healthP5Value.Text) * Convert.ToDouble(healthP5Textbox.Text);
                healthP5Pic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(healthP5Value.Text) * Convert.ToDouble(healthP5Textbox.Text));
            }
            if (!IsNumeric(healthP5Textbox.Text) && healthP5Textbox.Text != "")
            {
                healthP5Pic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(armorTextbox.Text))
            {
                armorAEPLabel.Text = "AEP: " + double.Parse(armorValue.Text) * Convert.ToDouble(armorTextbox.Text);
                armorPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(armorValue.Text) * Convert.ToDouble(armorTextbox.Text));
            }
            if (!IsNumeric(armorTextbox.Text) && armorTextbox.Text != "")
            {
                armorPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(defenseTextbox.Text))
            {
                defenseAEPLabel.Text = "AEP: " + double.Parse(defenseValue.Text) * Convert.ToDouble(defenseTextbox.Text);
                defensePic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(defenseValue.Text) * Convert.ToDouble(defenseTextbox.Text));
            }
            if (!IsNumeric(defenseTextbox.Text) && defenseTextbox.Text != "")
            {
                defensePic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(dodgeTextbox.Text))
            {
                dodgeAEPLabel.Text = "AEP: " + double.Parse(dodgeValue.Text) * Convert.ToDouble(dodgeTextbox.Text);
                dodgePic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(dodgeValue.Text) * Convert.ToDouble(dodgeTextbox.Text));
            }
            if (!IsNumeric(dodgeTextbox.Text) && dodgeTextbox.Text != "")
            {
                dodgePic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(parryTextbox.Text))
            {
                parryAEPLabel.Text = "AEP: " + double.Parse(parryValue.Text) * Convert.ToDouble(parryTextbox.Text);
                parryPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(parryValue.Text) * Convert.ToDouble(parryTextbox.Text));
            }
            if (!IsNumeric(parryTextbox.Text) && parryTextbox.Text != "")
            {
                parryPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(resilienceTextbox.Text))
            {
                resilienceAEPLabel.Text = "AEP: " + double.Parse(resilienceValue.Text) * Convert.ToDouble(resilienceTextbox.Text);
                resiliencePic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(resilienceValue.Text) * Convert.ToDouble(resilienceTextbox.Text));
            }
            if (!IsNumeric(resilienceTextbox.Text) && resilienceTextbox.Text != "")
            {
                resiliencePic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(allResistTextbox.Text))
            {
                allResistAEPLabel.Text = "AEP: " + double.Parse(allResistValue.Text) * Convert.ToDouble(allResistTextbox.Text);
                allResistPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(allResistValue.Text) * Convert.ToDouble(allResistTextbox.Text));
            }
            if (!IsNumeric(allResistTextbox.Text) && allResistTextbox.Text != "")
            {
                allResistPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(frostResistTextbox.Text))
            {
                frostResistAEPLabel.Text = "AEP: " + double.Parse(frostResistValue.Text) * Convert.ToDouble(frostResistTextbox.Text);
                frostResistPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(frostResistValue.Text) * Convert.ToDouble(frostResistTextbox.Text));
            }
            if (!IsNumeric(frostResistTextbox.Text) && frostResistTextbox.Text != "")
            {
                frostResistPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(arcaneResistTextbox.Text))
            {
                arcaneResistAEPLabel.Text = "AEP: " + double.Parse(arcaneResistValue.Text) * Convert.ToDouble(arcaneResistTextbox.Text);
                arcaneResistPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(arcaneResistValue.Text) * Convert.ToDouble(arcaneResistTextbox.Text));
            }
            if (!IsNumeric(arcaneResistTextbox.Text) && arcaneResistTextbox.Text != "")
            {
                arcaneResistPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(shadowResistTextbox.Text))
            {
                shadowResistAEPLabel.Text = "AEP: " + double.Parse(shadowResistValue.Text) * Convert.ToDouble(shadowResistTextbox.Text);
                shadowResistPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(shadowResistValue.Text) * Convert.ToDouble(shadowResistTextbox.Text));
            }
            if (!IsNumeric(shadowResistTextbox.Text) && shadowResistTextbox.Text != "")
            {
                shadowResistPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(natureResistTextbox.Text))
            {
                natureResistAEPLabel.Text = "AEP: " + double.Parse(natureResistValue.Text) * Convert.ToDouble(natureResistTextbox.Text);
                natureResistPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(natureResistValue.Text) * Convert.ToDouble(natureResistTextbox.Text));
            }
            if (!IsNumeric(natureResistTextbox.Text) && natureResistTextbox.Text != "")
            {
                natureResistPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(redSocketTextbox.Text))
            {
                redSocketAEPLabel.Text = "AEP: " + double.Parse(redSocketValue.Text) * Convert.ToDouble(redSocketTextbox.Text);
                redSocketPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(redSocketValue.Text) * Convert.ToDouble(redSocketTextbox.Text));
            }
            if (!IsNumeric(redSocketTextbox.Text) && redSocketTextbox.Text != "")
            {
                redSocketPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(yellowSocketTextbox.Text))
            {
                yellowSocketAEPLabel.Text = "AEP: " + double.Parse(yellowSocketValue.Text) * Convert.ToDouble(yellowSocketTextbox.Text);
                yellowSocketPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(yellowSocketValue.Text) * Convert.ToDouble(yellowSocketTextbox.Text));
            }
            if (!IsNumeric(yellowSocketTextbox.Text) && yellowSocketTextbox.Text != "")
            {
                yellowSocketPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(blueSocketTextbox.Text))
            {
                blueSocketAEPLabel.Text = "AEP: " + double.Parse(blueSocketValue.Text) * Convert.ToDouble(blueSocketTextbox.Text);
                blueSocketPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(blueSocketValue.Text) * Convert.ToDouble(blueSocketTextbox.Text));
            }
            if (!IsNumeric(blueSocketTextbox.Text) && blueSocketTextbox.Text != "")
            {
                blueSocketPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(colorlessSocketTextbox.Text))
            {
                colorlessSocketAEPLabel.Text = "AEP: " + double.Parse(colorlessSocketValue.Text) * Convert.ToDouble(colorlessSocketTextbox.Text);
                colorlessSocketPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(colorlessSocketValue.Text) * Convert.ToDouble(colorlessSocketTextbox.Text));
            }
            if (!IsNumeric(colorlessSocketTextbox.Text) && colorlessSocketTextbox.Text != "")
            {
                colorlessSocketPic.Visible = true;
                isFucked = true;
            }

            if (IsNumeric(metaSocketTextbox.Text))
            {
                metaSocketAEPLabel.Text = "AEP: " + double.Parse(metaSocketValue.Text) * Convert.ToDouble(metaSocketTextbox.Text);
                metaSocketPic.Visible = false;

                AEPTotal = AEPTotal + (double.Parse(metaSocketValue.Text) * Convert.ToDouble(metaSocketTextbox.Text));
            }
            if (!IsNumeric(metaSocketTextbox.Text) && metaSocketTextbox.Text != "")
            {
                metaSocketPic.Visible = true;
                isFucked = true;
            }




            if(!isFucked)
            {
                finalAEPBelow.Text = AEPTotal.ToString("#.##");
            }
            else
            {
                finalAEPBelow.Text = "";
            }
        }

        public bool IsNumeric(string value)
        {
            double tf;
            return double.TryParse(value, out tf);
        }

        private void ManaP5AEPLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }

    
}
