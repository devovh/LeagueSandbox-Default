﻿using System;
using LeagueSandbox.GameServer.Logic.GameObjects;
using LeagueSandbox.GameServer.Logic.Scripting;

namespace Quickdraw
{
    class Quickdraw : BuffGameScript
    {
        ChampionStatModifier statMod = new ChampionStatModifier();

        public void OnUpdate(double diff)
        {
            
        }

        public void OnActivate(Unit unit, Spell ownerSpell)
        {
            statMod.AttackSpeed.PercentBonus = ownerSpell.Level * 10.0f / 100.0f;
            unit.AddStatModifier(statMod);
        }

        public void OnDeactivate(Unit unit)
        {
            unit.RemoveStatModifier(statMod);
        }
    }
}
