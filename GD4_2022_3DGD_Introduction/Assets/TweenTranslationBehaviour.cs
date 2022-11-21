using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenTranslationBehaviour : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Specify final tween position")]
    private Vector3 target = new Vector3(0, 0, -10);

    [SerializeField]
    private float tweenTimeSecs = 5;

    private void Start()
    {
        //LeanTween.move(gameObject, target, tweenTimeSecs)

        LeanTween.moveLocalZ(gameObject, -5, tweenTimeSecs)
          .setEase(LeanTweenType.easeShake).setLoopCount(5);

        //scale?
        LeanTween.scale(gameObject, Vector3.one * 1.25f, 4);
    }
}