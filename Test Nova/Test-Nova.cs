using Life;
using UnityEngine;

namespace Test_Nova
{
    public class TestNova : Plugin
    {
        public TestNova(IGameAPI aPI) : base(aPI)
        {
        }

        public override void OnPluginInit()
        {
            base.OnPluginInit();
            Debug.Log("Test Nova est initialisée avec succées !");
        }
    }
}
