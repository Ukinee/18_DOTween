using DG.Tweening;
using Sources;
using UnityEngine;

public class LoopedRotator : DotweenLooperBase
{
    private void Start()
    {
        transform
            .DOLocalRotateQuaternion
            (
                Quaternion.LookRotation(Vector3.back),
                Duration
            )
            .SetLoops(LoopCount, LoopType.Restart);
    }
}
