using UnityEngine;

namespace Services.Input
{
    public class MobileControlInput : InputControlService
    {
        public override Vector2 Axis => new Vector2(SimpleInput.GetAxis(Horizontal), SimpleInput.GetAxis(Vertical));

        public MobileControlInput()
        {
            Debug.Log("MobileControlInput");
        }
    }
}