using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace SoloBedEnergize
{
    /// <summary>The mod entry point.</summary>
    public class ModEntry : Mod
    {
        /*********
        ** Public methods
        *********/
        public override void Entry(IModHelper helper)
        {
            helper.Events.GameLoop.OneSecondUpdateTicking += this.updateStaminaForFarmer;
        }


        /*********
        ** Private methods
        *********/
        private void updateStaminaForFarmer(object sender, OneSecondUpdateTickingEventArgs e)
        {
            if (!Context.IsWorldReady)
                return;

            if (Game1.serverHost != null)
                return;

            if (Game1.player.isInBed)
                Game1.player.Stamina += (float)(2);
            
        }
    }
}
