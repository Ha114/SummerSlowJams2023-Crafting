using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private InteractableUI _interactableUI;
    private IInteractable _interactable;
    bool isInteract = false;

    private void Start()
    {
        _interactableUI = GetComponent<InteractableUI>();
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.E)&& isInteract == true)
        {
            _interactable.Interact();
        }
    }

    #region Interact
    private void OnCollisionEnter2D(Collision2D collision)
    {
        _interactable = collision.gameObject.GetComponent<IInteractable>();
        if(_interactable != null)
        {
            isInteract = true;
            _interactableUI.ShowInteractTip();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isInteract = false;
        _interactableUI.CloseInteractTip();
    }
    #endregion

}
