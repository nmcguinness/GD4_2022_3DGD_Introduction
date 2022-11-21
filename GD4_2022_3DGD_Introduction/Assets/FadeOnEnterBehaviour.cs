using UnityEngine;

public class FadeOnEnterBehaviour : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Select object to be faded on enter")]
    private GameObject fadeTarget;

    [SerializeField]
    [Tooltip("Specify the tag that triggers this fade")]
    private string activationTag;

    private FadeOutBehaviour fadeOutBehaviour;

    private void Start()
    {
        fadeOutBehaviour = fadeTarget.GetComponent<FadeOutBehaviour>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == activationTag)
            fadeOutBehaviour.FadeOut();
    }
}