using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;
    [SerializeField] private string _changingText;
    [SerializeField] private string _additionalText;
    [SerializeField] private string _hackText;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.AppendInterval(_delay);
        sequence.Append(_text.DOText(_changingText, _duration));
        sequence.AppendInterval(_delay);
        sequence.Append(_text.DOText(_additionalText, _duration)
            .SetRelative());
        sequence.AppendInterval(_delay);
        sequence.Append(_text.DOText(_hackText, _duration, true, ScrambleMode.All));
        sequence.AppendInterval(_delay);
        sequence.SetLoops(-1, LoopType.Yoyo);
    }
}
