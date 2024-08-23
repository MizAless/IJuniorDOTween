using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform _traget;
    [SerializeField] private float _duration;

    private void Start()
    {
        transform.DOMove(_traget.position, _duration)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear);
    }
}
