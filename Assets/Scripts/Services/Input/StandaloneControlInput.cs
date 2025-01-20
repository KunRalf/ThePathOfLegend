using UnityEngine;

namespace Services.Input
{
    public class StandaloneControlInput : InputControlService
    {
        public override Vector2 Axis => InputAxis();

        public StandaloneControlInput()
        {
            Debug.Log("Standalone Control Input");
        }
    }
}