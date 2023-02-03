using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interctRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interctRange);
            foreach (Collider collider in colliderArray)
            {
               if (collider.TryGetComponent(out Interaction interaction))
                {
                    interaction.Interact();
                }
            }
        }
    }
}