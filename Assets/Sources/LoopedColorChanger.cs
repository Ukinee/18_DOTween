using DG.Tweening;
using Sources;
using UnityEngine;

public class LoopedColorChanger : DotweenLooperBase
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _startColor = Color.blue;
    [SerializeField] private Color _targetColor = Color.green;
    
    private void Start()
    {
        _material.color = _startColor;
        
        _material.DOColor(_targetColor, Duration).SetLoops(LoopCount, LoopType.Yoyo);
    }
}
