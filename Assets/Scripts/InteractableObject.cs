using UnityEngine;
using UnityEngine.AI;

public class InteractableObject : MonoBehaviour
{
    private NavMeshAgent playerAgent;
    private bool haveInteracted = false;

    public void OnClick(NavMeshAgent playerAgent)
    {
        this.playerAgent = playerAgent;
        playerAgent.stoppingDistance = 2f;
        playerAgent.SetDestination(transform.position);
        haveInteracted = false;
    }

    private void Update()
    {
        if (playerAgent != null && !haveInteracted && !playerAgent.pathPending)
        {
            if (playerAgent.remainingDistance <= playerAgent.stoppingDistance)
            {
                Interact();
                haveInteracted = true;
            }
        }
    }

    protected virtual void Interact()
    {
        print("Interacted with Interactable Object.");
    }
}
