using Brutal.Logging;
using StarMap.API;
using KSA;

namespace Purr_suit_of_Science
{
    [StarMapMod]
    public class ScienceModCore
    {
        private static bool _afterOnFrame = false;
        private static bool _beforeGui = false;
        private static bool _afterGui = false;

        [StarMapBeforeMain]
        public void BeforeMain()
        {
            Console.WriteLine("Purr-suit of Science | Before Main function call");
        }

        [StarMapImmediateLoad]
        public void ImmediateLoad(Mod mod)
        {
            DefaultCategory.Log.Info("Purr-suit of Science | Immediate Load function call");
        }

        [StarMapAllModsLoaded]
        public void AllModsLoaded()
        {
            DefaultCategory.Log.Info("Purr-suit of Science | All Mods Loaded function call");
        }

        [StarMapAfterOnFrame]
        public void AfterOnFrame(double currentPlayerTime, double dtPlayer)
        {
            if(!_afterOnFrame)
            {
                DefaultCategory.Log.Info("Purr-suit of Science | After On Frame function call");
                _afterOnFrame = true;
            }
        }

        [StarMapBeforeGui]
        public void BeforeGui(double dt)
        {
            if (!_beforeGui)
            {
                DefaultCategory.Log.Info("Purr-suit of Science | Before Gui function call");
                _beforeGui = true;
            }
        }

        [StarMapAfterGui]
        public void AfterGui(double dt)
        {
            if (!_afterGui)
            {
                DefaultCategory.Log.Info("Purr-suit of Science | After Gui function call");
                _afterGui = true;
            }
        }

        [StarMapUnload]
        public void Unload()
        {
            Console.WriteLine("Purr-suit of Science | Unload function call");
        }
    }
}
