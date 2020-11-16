using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDTHING
{
    class Characters
    {
        public string name, classLevel, background, playerName, race, alignment, XP, strStat, strMod, dexStat, dexMod, conStat, conMod, intStat, intMod, wisStat,
            wisMod, charStat, charMod, AC, HP, personalityTraits, flaws, bond, ideals, equipment, attack1, attackBon1, attackDmg1, attack2, attackBon2, attackDmg2
            , attack3, attackBon3, attackDmg3, specialTraits, proficiencies;

        public Characters(string _name, string _classLevel, string _background, string _playerName, string _race, string _alignment,
            string _XP, string _strStat, string _strMod, string _dexStat, string _sexMod, string _conStat, string _conMod, string _intStat,
            string _intMod, string _wisStat, string _wisMod, string _charStat, string _charMod, string _AC, string _HP, string _personalityTraits,
            string _flaws, string _bond, string _ideals, string _equipment, string _attack1, string _attackBon1, string _attackDmg1, string _attack2,
            string _attackBon2, string _attackDmg2, string _attack3, string _attackBon3, string _attackDmg3, string _specialTraits, string _proficiencies)
        {
            name = _name;
            classLevel = _classLevel;
            background = _background;
            playerName = _playerName;
            race = _race;
            alignment = _alignment;
            XP = _XP;
            strStat = _strStat;
            strMod = _strMod;
            dexStat = _dexStat;
            dexMod = _sexMod;
            conStat = _conStat;
            conMod = _conMod;
            intStat = _intStat;
            intMod = _intMod;
            wisStat = _wisStat;
            wisMod = _wisMod;
            charStat = _charStat;
            charMod = _charMod;
            AC = _AC;
            HP = _HP;
            personalityTraits = _personalityTraits;
            flaws = _flaws;
            bond = _bond;
            ideals = _ideals;
            equipment = _equipment;
            attack1 = _attack1;
            attackBon1 = _attackBon1;
            attackDmg1 = _attackDmg1;
            attack2 = _attack2;
            attackBon2 = _attackBon2;
            attackDmg2 = _attackDmg2;
;           attack3 = _attack3;
            attackBon3 = _attackBon3;
            attackDmg3 = _attackDmg3;
            specialTraits = _specialTraits;
            proficiencies = _proficiencies;
        }
    }
}
