using GD;
using GD.ScriptableTypes;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public IntVariable currentPlayerHealth;
    public GameObjectVariable currentTeamTarget;

    public void HandlePlayerHealthChanged()
    {
        Debug.Log("HandlePlayerHealthChanged");
    }

    private void OnTriggerEnter(Collider other)
    {
        //is this a NPC?
        //is this characters health < X?
        currentTeamTarget.Value = other.gameObject;
    }
}

/*
public class PlayerController : MonoBehaviour
{
    public IntVariable currentPlayerHealth;
    public GameObjectVariable currentTeamTarget;

    private void Start()
    {
        currentPlayerHealth.OnChanged.AddListener(HandlePlayerHealthChanged);
    }

    private void OnDestroy()
    {
        currentPlayerHealth.OnChanged.RemoveListener(HandlePlayerHealthChanged);
    }

    private void HandlePlayerHealthChanged(string s)
    {
        Debug.Log($"HandlePlayerHealthChanged:{s}");
    }

    private void OnTriggerEnter(Collider other)
    {
        //is this a NPC?
        //is this characters health < X?
        currentTeamTarget.Value = other.gameObject;
    }
}
*/

/*
public class PlayerController : MonoBehaviour, IHandleTicks
{
    public IntVariable currentPlayerHealth;
    public GameObjectVariable currentTeamTarget;

    private void Start()
    {
        TimeTickSystem.Instance.RegisterListener(
            TimeTickSystem.TickRateMultiplierType.RealTime, HandleTick);
    }

    private void OnDestroy()
    {
        TimeTickSystem.Instance.UnregisterListener(
           TimeTickSystem.TickRateMultiplierType.RealTime, HandleTick);
    }

    public void HandleTick()
    {
        if (currentTeamTarget != null) { }
        //now someone's doing something we ALL need to see
    }

    // Update is called once per frame
    private void Update()
    {
        //if (currentTeamTarget != null) { }
        //now someone's doing something we ALL need to see
    }

    private void OnTriggerEnter(Collider other)
    {
        //is this a NPC?
        //is this characters health < X?
        currentTeamTarget.Value = other.gameObject;
    }
}
*/