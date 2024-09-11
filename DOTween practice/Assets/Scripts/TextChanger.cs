using DG.Tweening;
using System;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private string _message;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        Tween tween = _text.DOText(_message, _duration);
        _text.DOText(_message, _duration);
        sequence.Append(tween)
            .SetRelative()
            .SetDelay(_duration);
        tween = _text.DOText(_message, _duration, true, ScrambleMode.All);
        sequence.Append(tween);
    }
}
