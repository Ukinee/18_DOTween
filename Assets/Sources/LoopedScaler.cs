using DG.Tweening;
using Sources;
using UnityEngine;

public class LoopedScaler : DotweenLooperBase
{
    [SerializeField] private float _endValue = 3f;
    
    private void Start() => 
        transform.DOScale(_endValue, Duration).SetLoops(LoopCount, LoopType.Yoyo);
}
