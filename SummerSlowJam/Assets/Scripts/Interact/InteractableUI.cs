using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableUI : MonoBehaviour
{
    [SerializeField] GameObject _interactTip;
    GameObject _tip;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           // ShowInteractTip();
        }
    }

    public void ShowInteractTip()
    {
        _tip = Instantiate(_interactTip, new Vector2(transform.position.x, transform.position.y + 1f), Quaternion.identity);
        _tip.GetComponent<SpriteRenderer>().sortingOrder = 1;
        _tip.transform.SetParent(transform);
    }

    public void CloseInteractTip()
    {
        Destroy(_tip);
    }


}
