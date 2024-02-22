using DG.Tweening;
using Sources;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : DotweenLooperBase
{
    [SerializeField] private Text _text;
    
    private readonly string _startText = "Стартовый текст";
    private readonly string _replacedText = "Заменил текс";
    private readonly string _addedText = "Добавил текс";
    private readonly string _compositeText = "Заменил и перебрал";

    private void Start()
    {
        _text.text = _startText;

        Sequence sequence = DOTween.Sequence();
        
        sequence.Append(_text.DOText(_replacedText, Duration));
        sequence.Append(_text.DOText(_addedText, Duration).SetRelative());
        sequence.Append(_text.DOText(_compositeText, Duration, true, ScrambleMode.All));
        sequence.SetLoops(LoopCount);

        sequence.Restart();
    }
}