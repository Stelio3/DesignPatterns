using UnityEngine;

namespace Enemies
{
    public interface ITarget
    {
        Vector3 CurrentPosition { get; }
    }
}
