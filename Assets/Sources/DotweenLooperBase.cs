using UnityEngine;

namespace Sources
{
    public class DotweenLooperBase : MonoBehaviour
    {
        [field: SerializeField] protected float Duration { get; private set; } = 3f;
        [field: SerializeField] protected int LoopCount { get; private set; } = -1;
    }
}
