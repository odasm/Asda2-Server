﻿namespace WCell.RealmServer.Spells.Auras.Handlers
{
    public class ModScaleHandler : AuraEffectHandler
    {
        protected override void Apply()
        {
            this.m_aura.Auras.Owner.ScaleX += (float) this.EffectValue / 100f;
        }

        protected override void Remove(bool cancelled)
        {
            this.m_aura.Auras.Owner.ScaleX -= (float) this.EffectValue / 100f;
        }
    }
}