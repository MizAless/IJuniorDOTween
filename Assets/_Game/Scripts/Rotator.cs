using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotateVector;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType = LoopType.Restart;

    private void Start()
    {
        transform.DORotate(_rotateVector, _duration, RotateMode.FastBeyond360)
            .SetLoops(-1, _loopType)
            .SetEase(Ease.InOutCirc);
    }
}
