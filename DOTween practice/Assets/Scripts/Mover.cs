using DG.Tweening;

public class Mover : BasicTransform
{
    private void Start()
    {
       Tween tween = transform.DOMove(_transformParamet�r, _duration).SetLoops(-1, _loopType);
        tween.SetEase(Ease.Linear);
    }
}
