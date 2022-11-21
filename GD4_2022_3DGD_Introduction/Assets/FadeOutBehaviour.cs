using UnityEngine;

public class FadeOutBehaviour : MonoBehaviour
{
    public float targetAlpha;
    public float fadeTimeSecs;

    public void FadeOut()
    {
        LeanTween.alpha(gameObject, targetAlpha, fadeTimeSecs);
    }
}