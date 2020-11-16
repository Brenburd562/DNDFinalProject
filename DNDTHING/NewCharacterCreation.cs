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

                    reader.ReadToNextSibling("classLevel");
                    string classLevel = reader.ReadString();

                    reader.ReadToNextSibling("background");
                    string background = reader.ReadString();

                    reader.ReadToNextSibling("playerName");
                    string playerName = reader.ReadString();

                    reader.ReadToNextSibling("race");
                    string race = reader.ReadString();

                    reader.ReadToNextSibling("alignment");
                    string alignment = reader.ReadString();

                    reader.ReadToNextSibling("XP");
                    string XP = reader.ReadString();

                    reader.ReadToNextSibling("strStat");
                    string strStat = reader.ReadString();

                    reader.ReadToNextSibling("strMod");
                    string strMod = reader.ReadString();

                    reader.ReadToNextSibling("dexStat");
                    string dexStat = reader.ReadString();

                    reader.ReadToNextSibling("dexMod");
                    string dexMod = reader.ReadString();

                    reader.ReadToNextSibling("conStat");
                    string conStat = reader.ReadString();

                    reader.ReadToNextSibling("conMod");
                    string conMod = reader.ReadString();

                    reader.ReadToNextSibling("intStat");
                    string intStat = reader.ReadString();

                    reader.ReadToNextSibling("intMod");
                    string intMod = reader.ReadString();

                    reader.ReadToNextSibling("wisStat");
                    string wisStat = reader.ReadString();

                    reader.ReadToNextSibling("wisMod");
                    string wisMod = reader.ReadString();

                    reader.ReadToNextSibling("charStat");
                    string charStat = reader.ReadString();

                    reader.ReadToNextSibling("charMod");
                    string charMod = reader.ReadString();

                    reader.ReadToNextSibling("AC");
                    string AC = reader.ReadString();

                    reader.ReadToNextSibling("HP");
                    string HP = reader.ReadString();

                    reader.ReadToNextSibling("peronalityTraits");
                    string personalityTraits = reader.ReadString();

                    reader.ReadToNextSibling("flaws");
                    string flaws = reader.ReadString();

                    reader.ReadToNextSibling("bond");
                    string bond = reader.ReadString();

                    reader.ReadToNextSibling("ideals");
                    string ideals = reader.ReadString();

                    reader.ReadToNextSibling("equipment");
                    string equipment = reader.ReadString();

                    reader.ReadToNextSibling("attack1");
                    string attack1 = reader.ReadString();

                    reader.ReadToNextSibling("attackBon1");
                    string attackBon1 = reader.ReadString();

                    reader.ReadToNextSibling("attackDmg1");
                    string attackDmg1 = reader.ReadString();

                    reader.ReadToNextSibling("attack2");
                    string attack2 = reader.ReadString();

                    reader.ReadToNextSibling("attackBon2");
                    string attackBon2 = reader.ReadString();

                    reader.ReadToNextSibling("attackDmg2");
                    string attackDmg2 = reader.ReadString();

                    reader.ReadToNextSibling("attack3");
                    string attack3 = reader.ReadString();

                    reader.ReadToNextSibling("attackBon3");
                    string attackBon3 = reader.ReadString();

                    reader.ReadToNextSibling("attackDmg3");
                    string attackDmg3 = reader.ReadString();

                    reader.ReadToNextSibling("specialTraits");
                    string specialTraits = reader.ReadString();

                    reader.ReadToNextSibling("proficiencies");
                    string proficiencies = reader.ReadString();

                    Characters character = new Characters(name, classLevel, background, playerName, race, alignment, XP, strStat, strMod, dexStat, dexMod, conStat, conMod, intStat, intMod, wisStat,
                    wisMod, charStat, charMod, AC, HP, personalityTraits, flaws, bond, ideals, equipment, attack1, attackBon1, attackDmg1, attack2, attackBon2, attackDmg2
                    , attack3, attackBon3, attackDmg3, specialTraits, proficiencies);
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
            ClearLabels();

            XmlWriter writer = XmlWriter.Create("Characters.xml", null);
            writer.WriteStartElement("Characters");
            foreach (Characters cha in CharacterDB)
            {
                writer.WriteStartElement("Character");
                writer.WriteElementString("Name", cha.name);
                writer.WriteElementString("ClassLevel", cha.classLevel);
                writer.WriteElementString("BackGround", cha.);
                writer.WriteElementString("PlayerName", cha.);
                writer.WriteElementString("Race", cha.);
                writer.WriteElementString("Alignment", cha.);
                writer.WriteElementString("XP", cha.);
                writer.WriteElementString("StrStat", cha.);
                writer.WriteElementString("StrMod", cha.);
                writer.WriteElementString("DexStat", cha.);
                writer.WriteElementString("DexMod", cha.);
                writer.WriteElementString("ConStat", cha.);
                writer.WriteElementString("ConMod", cha.);
                writer.WriteElementString("IntStat", cha.);
                writer.WriteElementString("IntMod", cha.);
                writer.WriteElementString("WisStat", cha.);
                writer.WriteElementString("WisMod", cha.);
                writer.WriteElementString("chaStat", cha.);
                writer.WriteElementString("ChaMod", cha.);
                writer.WriteElementString("Ac", cha.);
                writer.WriteElementString("HP", cha.);
                writer.WriteElementString("PersonalityTraits", cha.);
                writer.WriteElementString("Flaws", cha.);
                writer.WriteElementString("Bond", cha.);
                writer.WriteElementString("Ideals", cha.);
                writer.WriteElementString("Equipment", cha.);
                writer.WriteElementString("Attack1", cha.);
                writer.WriteElementString("Attack1Bonus", cha.);
                writer.WriteElementString("Attack1Damage", cha.);
                writer.WriteElementString("Attack2", cha.);
                writer.WriteElementString("Attack2Bonus", cha.);
                writer.WriteElementString("Attack2Damage", cha.);
                writer.WriteElementString("Attack3", cha.);
                writer.WriteElementString("Attack3Bonus", cha.);
                writer.WriteElementString("Attack3Damage", cha.);
                writer.WriteElementString("SpecialTraits", cha.);
                writer.WriteElementString("ProficienciesInput", cha.);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();

            writer.Close();
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
