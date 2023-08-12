using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField, Range(0, 10f)] float range;

    private InteractableUI interactableUI;
    private bool isInteract = false;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInteract = true;
            interactableUI = GetComponent<InteractableUI>();
            interactableUI.ShowInteractTip();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInteract = false;
            interactableUI.CloseInteractTip();
        }
    }


    private void OnDrawGizmos()
    {
        object value = isInteract ? Gizmos.color = Color.red: Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
