using UnityEngine;
using DG.Tweening;
using Sources;

public class LoopedMover : DotweenLooperBase
{
    private readonly Vector3 _targetPosition = new Vector3(12, 0.5f, 15);

    private void Start()
    {
        transform.DOMove(_targetPosition, Duration).SetLoops(LoopCount, LoopType.Yoyo);
    }
}
