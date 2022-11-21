using UnityEngine;

public class FadeOutBehaviour : MonoBehaviour
{
    [SerializeField]
    [Range(0, 1)]
    private float targetAlpha = 0;

    [SerializeField]
    [Range(0, 1)]
    private float startAlpha = 1;

    [SerializeField]
    [Range(0, 10)]
    private float fadeTimeSecs;

    [SerializeField]
    private AnimationCurve fadeOutCurve;

    [SerializeField]
    private LeanTweenType fadeInTweenType;

    private bool isFaded = false;

    public void Fade()
    {
        if (!isFaded) //fade out
        {
            LeanTween.alpha(gameObject, targetAlpha, fadeTimeSecs).setEase(fadeOutCurve);
            isFaded = true;
        }
        else         //fade in
        {
            LeanTween.alpha(gameObject, startAlpha, fadeTimeSecs).setEase(fadeInTweenType);
            isFaded = false;
        }
    }
}