using UnityEngine;

namespace Services.Input
{
    public abstract class InputControlService : IInputControlService
    {
        protected const string Horizontal = "Horizontal";
        protected const string Vertical = "Vertical";
        public abstract Vector2 Axis { get; }
        
        protected Vector2 InputAxis() => new Vector2(UnityEngine.Input.GetAxis(Horizontal), UnityEngine.Input.GetAxis(Vertical));
    }
}