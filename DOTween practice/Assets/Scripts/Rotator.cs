using DG.Tweening;

public class Rotator : BasicTransform
{
    private void Start()
    {
        Tween tween = transform.DORotate(_transformParametår, _duration).SetLoops(-1, _loopType);
        tween.SetEase(Ease.Linear);
    }
}
