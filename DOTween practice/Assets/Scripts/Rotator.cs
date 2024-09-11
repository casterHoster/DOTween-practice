using DG.Tweening;

public class Rotator : BasicTransform
{
    private void Start()
    {
        Tween tween = transform.DORotate(_transformParamet�r, _duration).SetLoops(-1, _loopType);
        tween.SetEase(Ease.Linear);
    }
}
