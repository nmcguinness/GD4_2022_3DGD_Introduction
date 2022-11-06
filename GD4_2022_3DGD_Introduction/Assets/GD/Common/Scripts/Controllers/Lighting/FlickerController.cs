using System.Collections;
using UnityEngine;

public class FlickerController : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Minimum random light intensity")]
    private bool IsFlickering;

    [SerializeField]
    [Range(0, 10)]
    [Tooltip("Min random light intensity")]
    private float minIntensity = 5;

    [SerializeField]
    [Range(0.1f, 20)]
    [Tooltip("Max random light intensity")]
    private float maxIntensity = 10;

    [SerializeField]
    [Range(0.2f, 10)]
    [Tooltip("Min time delay between flicker")]
    private float minTimeDelayInSecs = 1;

    [SerializeField]
    [Range(0.2f, 10)]
    [Tooltip("Max time delay between flicker")]
    private float maxTimeDelayInSecs = 5;

    private float timeDelayInSecs;
    private Light attachedLight;

    private void Awake()
    {
        attachedLight = gameObject.GetComponent<Light>();
    }

    private void Update()
    {
        if (IsFlickering)
            StartCoroutine(FlickerLight());
    }

    private IEnumerator FlickerLight()
    {
        //turn off light
        attachedLight.enabled = false;
        //set intensity to min
        attachedLight.intensity = minIntensity;

        //wait for a random amount in secs
        timeDelayInSecs = Random.Range(minTimeDelayInSecs, maxTimeDelayInSecs);
        yield return new WaitForSeconds(timeDelayInSecs);

        //turn the light back on
        attachedLight.intensity = maxIntensity;
        attachedLight.enabled = true;

        //wait for a random amount in secs
        timeDelayInSecs = Random.Range(minTimeDelayInSecs, maxTimeDelayInSecs);
        yield return new WaitForSeconds(timeDelayInSecs);
    }
}