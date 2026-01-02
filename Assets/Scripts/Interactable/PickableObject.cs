using UnityEngine;

public class PickableObject : InteractableObject
{
    override protected void Interact()
    {
        print("Interacted with Pickable Object.");
    }
}
