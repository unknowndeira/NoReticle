﻿using System;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace Server
{
    public class Main : BaseScript
    {
        public Main()
        {
            EventHandlers.Add("NoReticle:Server:GetPlayerReticleAceAllowed", new Action<Player>(GetPlayerReticleAceAllowed));
        }

        private void GetPlayerReticleAceAllowed([FromSource] Player p)
        {
            // if ace permission 'Reticle' is allowed for the player then show the reticle..
            if (API.IsPlayerAceAllowed(p.Handle, "Reticle") == true)
            {
                p.TriggerEvent("NoReticle:Client:SetPlayerReticleAceAllowed");
            }
        }
    }
}
