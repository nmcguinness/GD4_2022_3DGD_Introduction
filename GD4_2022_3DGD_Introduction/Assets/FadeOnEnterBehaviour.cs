using UnityEngine;
using UnityEngine.Events;

public class FadeOnEnterBehaviour : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Specify the tag that triggers this fade")]
    private string activationTag;

    [SerializeField]
    private LayerMask activationLayer;

    [SerializeField]
    private UnityEvent onFadeEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == activationTag && activationLayer.OnLayer(other.gameObject))
            onFadeEvent.Invoke();
    }
}

/*
 public class FadeOnEnterBehaviour : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Select object to be faded on enter")]
    private FadeOutBehaviour fadeTarget;

    [SerializeField]
    [Tooltip("Specify the tag that triggers this fade")]
    private string activationTag;

    [SerializeField]
    private LayerMask activationLayer;

    #region Inefficent

    //private FadeOutBehaviour fadeOutBehaviour;

    //private void Start()
    //{
    //    fadeOutBehaviour = fadeTarget.GetComponent<FadeOutBehaviour>();
    //}

    #endregion Inefficent

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == activationTag && activationLayer.OnLayer(other.gameObject))
        {
            fadeTarget.Fade();
        }
    }
}
 */