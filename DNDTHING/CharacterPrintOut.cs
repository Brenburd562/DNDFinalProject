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
    //This prints out the character information based on a search.

    public partial class CharacterPrintOut : UserControl
    {
        List<Characters> CharacterList = new List<Characters>();

        public CharacterPrintOut()
        {
            InitializeComponent();
        }

        private void CharacterPrintOut_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

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

            nameLabel.Text = CharacterList[Form1.index].name;
            classLevelLabel.Text = CharacterList[Form1.index].classLevel;
            backgroundLabel.Text = CharacterList[Form1.index].background;
            playerNameLabel.Text = CharacterList[Form1.index].playerName;
            raceLabel.Text = CharacterList[Form1.index].race;
            alignmentLabel.Text = CharacterList[Form1.index].alignment;
            xpLabel.Text = CharacterList[Form1.index].XP;
            strStatLabel.Text = CharacterList[Form1.index].strStat;
            strModLabel.Text = CharacterList[Form1.index].strMod;
            dexStatLabel.Text = CharacterList[Form1.index].dexStat;
            dexModLabel.Text = CharacterList[Form1.index].dexMod;
            conStatLabel.Text = CharacterList[Form1.index].conStat;
            conModLabel.Text = CharacterList[Form1.index].conMod;
            intStatLabel.Text = CharacterList[Form1.index].intStat;
            intModLabel.Text = CharacterList[Form1.index].intMod;
            wisStatLabel.Text = CharacterList[Form1.index].wisStat;
            wisModLabel.Text = CharacterList[Form1.index].wisMod;
            chaStatLabel.Text = CharacterList[Form1.index].charStat;
            chaModLabel.Text = CharacterList[Form1.index].charMod;
            acLabel.Text = CharacterList[Form1.index].AC;
            hpLabel.Text = CharacterList[Form1.index].HP;
            perTraitLabel.Text = CharacterList[Form1.index].personalityTraits;
            flawsLabel.Text = CharacterList[Form1.index].flaws;
            bondLabel.Text = CharacterList[Form1.index].bond;
            idealsLabel.Text = CharacterList[Form1.index].ideals;
            equipmentLabel.Text = CharacterList[Form1.index].equipment;
            attack1Label.Text = CharacterList[Form1.index].attack1;
            attack1BonLabel.Text = CharacterList[Form1.index].attackBon1;
            attack1dmgLabel.Text = CharacterList[Form1.index].attackDmg1;
            attack2Label.Text = CharacterList[Form1.index].attack2;
            attack2BonLabel.Text = CharacterList[Form1.index].attackBon2;
            attack2dmgLabel.Text = CharacterList[Form1.index].attackDmg2;
            attack3Label.Text = CharacterList[Form1.index].attack3;
            attack3BonLabel.Text = CharacterList[Form1.index].attackBon3;
            attack3dmgLabel.Text = CharacterList[Form1.index].attackDmg3;
            specialTraitsLabel.Text = CharacterList[Form1.index].specialTraits;
            proficienciesLabel.Text = CharacterList[Form1.index].proficiencies;
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Form cpo = this.FindForm();
            cpo.Controls.Remove(this);

            Menu_Screen ms = new Menu_Screen();
            cpo.Controls.Add(ms);
            ms.Focus();
        }
    }
}
