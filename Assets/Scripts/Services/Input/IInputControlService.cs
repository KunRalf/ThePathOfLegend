using UnityEngine;

namespace Services.Input
{
    public interface IInputControlService
    {
        Vector2 Axis { get; }
    }
}