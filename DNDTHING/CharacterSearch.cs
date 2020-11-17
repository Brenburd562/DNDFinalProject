using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DNDTHING
{
    public partial class CharacterSearch : UserControl
    {
        List<Characters> CharacterList = new List<Characters>();

        public CharacterSearch()
        {
            InitializeComponent();

            XmlReader reader = XmlReader.Create("Resources/Characters.xml", null);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    string name = reader.ReadString();

                    reader.ReadToNextSibling("ClassLevel");
                    string classLevel = reader.ReadString();

                    reader.ReadToNextSibling("BackGround");
                    string background = reader.ReadString();

                    reader.ReadToNextSibling("PlayerName");
                    string playerName = reader.ReadString();

                    reader.ReadToNextSibling("Race");
                    string race = reader.ReadString();

                    reader.ReadToNextSibling("Alignment");
                    string alignment = reader.ReadString();

                    reader.ReadToNextSibling("XP");
                    string XP = reader.ReadString();

                    reader.ReadToNextSibling("StrStat");
                    string strStat = reader.ReadString();

                    reader.ReadToNextSibling("StrMod");
                    string strMod = reader.ReadString();

                    reader.ReadToNextSibling("DexStat");
                    string dexStat = reader.ReadString();

                    reader.ReadToNextSibling("DexMod");
                    string dexMod = reader.ReadString();

                    reader.ReadToNextSibling("ConStat");
                    string conStat = reader.ReadString();

                    reader.ReadToNextSibling("ConMod");
                    string conMod = reader.ReadString();

                    reader.ReadToNextSibling("IntStat");
                    string intStat = reader.ReadString();

                    reader.ReadToNextSibling("IntMod");
                    string intMod = reader.ReadString();

                    reader.ReadToNextSibling("WisStat");
                    string wisStat = reader.ReadString();

                    reader.ReadToNextSibling("WisMod");
                    string wisMod = reader.ReadString();

                    reader.ReadToNextSibling("chaStat");
                    string charStat = reader.ReadString();

                    reader.ReadToNextSibling("ChaMod");
                    string charMod = reader.ReadString();

                    reader.ReadToNextSibling("Ac");
                    string AC = reader.ReadString();

                    reader.ReadToNextSibling("HP");
                    string HP = reader.ReadString();

                    reader.ReadToNextSibling("PersonalityTraits");
                    string personalityTraits = reader.ReadString();

                    reader.ReadToNextSibling("Flaws");
                    string flaws = reader.ReadString();

                    reader.ReadToNextSibling("Bond");
                    string bond = reader.ReadString();

                    reader.ReadToNextSibling("Ideals");
                    string ideals = reader.ReadString();

                    reader.ReadToNextSibling("Equipment");
                    string equipment = reader.ReadString();

                    reader.ReadToNextSibling("Attack1");
                    string attack1 = reader.ReadString();

                    reader.ReadToNextSibling("Attack1Bonus");
                    string attackBon1 = reader.ReadString();

                    reader.ReadToNextSibling("Attack1Damage");
                    string attack1Dmg = reader.ReadString();

                    reader.ReadToNextSibling("Attack2");
                    string attack2 = reader.ReadString();

                    reader.ReadToNextSibling("Attack2Bonus");
                    string attackBon2 = reader.ReadString();

                    reader.ReadToNextSibling("Attack2Damage");
                    string attack2Dmg = reader.ReadString();

                    reader.ReadToNextSibling("Attack3");
                    string attack3 = reader.ReadString();

                    reader.ReadToNextSibling("Attack3Bonus");
                    string attackBon3 = reader.ReadString();

                    reader.ReadToNextSibling("Attack3Damage");
                    string attack3Dmg = reader.ReadString();

                    reader.ReadToNextSibling("SpecialTraits");
                    string specialTraits = reader.ReadString();

                    reader.ReadToNextSibling("ProficienciesInput");
                    string proficiencies = reader.ReadString();


                    Characters character = new Characters(name, classLevel, background, playerName, race, alignment, XP, strStat, strMod, dexStat, dexMod, conStat, conMod, intStat, intMod, wisStat,
                    wisMod, charStat, charMod, AC, HP, personalityTraits, flaws, bond, ideals, equipment, attack1, attackBon1, attack1Dmg, attack2, attackBon2, attack2Dmg
                    , attack3, attackBon3, attack3Dmg, specialTraits, proficiencies);
                    CharacterList.Add(character);
                }
            }
            reader.Close();

            ChaListLabel.Text = "Characters: ";
            foreach (Characters c in CharacterList)
            {
                ChaListLabel.Text += c.name + ", ";
            }
        }

        private void CharacterSearch_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Form cs = this.FindForm();
            cs.Controls.Remove(this);

            Menu_Screen ms = new Menu_Screen();
            cs.Controls.Add(ms);
            ms.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchName = "";
            searchName = nameInput.Text;
            Form1.index = CharacterList.FindIndex(n => n.name == searchName);
            if (Form1.index > -1)
            {
                ErrorLabel.Text = "";

                Form cs = this.FindForm();
                cs.Controls.Remove(this);

                CharacterPrintOut cpo = new CharacterPrintOut();
                cs.Controls.Add(cpo);
                cpo.Focus();
            }
            else
            {
                ErrorLabel.Text = "Error Character Not Found\nPlease Ensure The Character\nIs Listed Above.";
            }
        }
    }
}
