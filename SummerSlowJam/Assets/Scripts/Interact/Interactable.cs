using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField, Range(0, 10f)] float _range;

    private InteractableUI _interactableUI;
    private bool _isInteract = false;

    public virtual void Interact()
    {
        Debug.Log("Interact");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _isInteract = true;
            _interactableUI = GetComponent<InteractableUI>();
            _interactableUI.ShowInteractTip();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _isInteract = false;
            _interactableUI.CloseInteractTip();
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _isInteract)
        {
            Interact();
        }
    }

    private void OnDrawGizmos()
    {
        object value = _isInteract ? Gizmos.color = Color.red: Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, _range);
    }
}
