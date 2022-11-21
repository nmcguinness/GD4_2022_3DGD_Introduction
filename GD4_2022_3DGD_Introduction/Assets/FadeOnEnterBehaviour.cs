using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOnEnterBehaviour : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Select object to be faded on enter")]
    private GameObject fadeTarget;

    [SerializeField]
    [Tooltip("Specify the tag that triggers this fade")]
    private string activationTag;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.tag}");
    }
}