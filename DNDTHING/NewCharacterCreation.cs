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
    public partial class NewCharacterCreation : UserControl
    {
        //this form is for creating characters it take inputs from all of the text boxes and saves them to the XML file
        List<Characters> CharacterDB = new List<Characters>();

        public NewCharacterCreation()
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
                    CharacterDB.Add(character);
                }
            }
            reader.Close();
        }

        private void NewCharacterCreation_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            Form ncc = this.FindForm();
            ncc.Controls.Remove(this);

            Menu_Screen ms = new Menu_Screen();
            ncc.Controls.Add(ms);
            ms.Focus();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Characters character = new Characters(NameInput.Text, ClassLevelInput.Text, BackgroundInput.Text, PlayerNameInput.Text, RaceInput.Text, AlignmentInput.Text,
            XPInput.Text, StrStatInput.Text, StrModInput.Text, DexStatInput.Text, DexModInput.Text, ConStatInput.Text, ConModInput.Text, IntStatInput.Text, 
            IntModInput.Text, WisStatInput.Text, WisModInput.Text, ChaStatInput.Text, ChaModInput.Text, ACInput.Text, HPInput.Text, PerTraInput.Text, FlawsInput.Text,
            BondInput.Text, IdealsInput.Text, EquipmentInput.Text, Attack1Input.Text, Attack2Input.Text, Attack3Input.Text, Atk1BonInput.Text, Atk2BonInput.Text, 
            Atk3BonInput.Text, Atk1DmgInput.Text, Atk2DmgInput.Text, Atk3DmgInput.Text, SpecialTraitsInput.Text, ProficienciesInput.Text);
            CharacterDB.Add(character);

            XmlWriter writer = XmlWriter.Create("Characters.xml", null);
            writer.WriteStartElement("Characters");
            foreach (Characters cha in CharacterDB)
            {
                writer.WriteStartElement("Character");
                writer.WriteElementString("Name", cha.name);
                writer.WriteElementString("ClassLevel", cha.classLevel);
                writer.WriteElementString("BackGround", cha.background);
                writer.WriteElementString("PlayerName", cha.playerName);
                writer.WriteElementString("Race", cha.race);
                writer.WriteElementString("Alignment", cha.alignment);
                writer.WriteElementString("XP", cha.XP);
                writer.WriteElementString("StrStat", cha.strStat);
                writer.WriteElementString("StrMod", cha.strMod);
                writer.WriteElementString("DexStat", cha.dexStat);
                writer.WriteElementString("DexMod", cha.dexMod);
                writer.WriteElementString("ConStat", cha.conStat);
                writer.WriteElementString("ConMod", cha.conMod);
                writer.WriteElementString("IntStat", cha.intStat);
                writer.WriteElementString("IntMod", cha.intMod);
                writer.WriteElementString("WisStat", cha.wisStat);
                writer.WriteElementString("WisMod", cha.wisMod);
                writer.WriteElementString("chaStat", cha.charStat);
                writer.WriteElementString("ChaMod", cha.charMod);
                writer.WriteElementString("Ac", cha.AC);
                writer.WriteElementString("HP", cha.HP);
                writer.WriteElementString("PersonalityTraits", cha.personalityTraits);
                writer.WriteElementString("Flaws", cha.flaws);
                writer.WriteElementString("Bond", cha.bond);
                writer.WriteElementString("Ideals", cha.ideals);
                writer.WriteElementString("Equipment", cha.equipment);
                writer.WriteElementString("Attack1", cha.attack1);
                writer.WriteElementString("Attack1Bonus", cha.attackBon1);
                writer.WriteElementString("Attack1Damage", cha.attackDmg1);
                writer.WriteElementString("Attack2", cha.attack2);
                writer.WriteElementString("Attack2Bonus", cha.attackBon2);
                writer.WriteElementString("Attack2Damage", cha.attackDmg2);
                writer.WriteElementString("Attack3", cha.attack3);
                writer.WriteElementString("Attack3Bonus", cha.attackBon3);
                writer.WriteElementString("Attack3Damage", cha.attackDmg3);
                writer.WriteElementString("SpecialTraits", cha.specialTraits);
                writer.WriteElementString("ProficienciesInput", cha.proficiencies);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            writer.Close();

            ClearLabels();
        }

        private void ClearLabels()
        {
            NameInput.Text = ClassLevelInput.Text = BackgroundInput.Text = PlayerNameInput.Text = RaceInput.Text = AlignmentInput.Text = XPInput.Text =
            StrStatInput.Text = StrModInput.Text = DexStatInput.Text = DexModInput.Text = ConStatInput.Text = ConModInput.Text = IntStatInput.Text =
            IntModInput.Text = WisStatInput.Text = WisModInput.Text = ChaStatInput.Text = ChaModInput.Text = ACInput.Text = HPInput.Text = PerTraInput.Text =
            FlawsInput.Text = BondInput.Text = IdealsInput.Text = EquipmentInput.Text = Attack1Input.Text = Attack2Input.Text = Attack3Input.Text =
            Atk1BonInput.Text = Atk2BonInput.Text = Atk3BonInput.Text = Atk1DmgInput.Text = Atk2DmgInput.Text = Atk3DmgInput.Text = SpecialTraitsInput.Text =
            ProficienciesInput.Text = "";
        }
    }
}
