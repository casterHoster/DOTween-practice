using DG.Tweening;

public class Scaler : BasicTransform
{
    private void Start()
    {
        Tween tween = transform.DOScale(_transformParamet�r, _duration).SetLoops(-1, _loopType);
        tween.SetEase(Ease.Linear);
    }
}
