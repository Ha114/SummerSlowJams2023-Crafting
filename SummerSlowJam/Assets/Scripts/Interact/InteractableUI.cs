using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableUI : MonoBehaviour
{
    [SerializeField] GameObject interactTip;
    GameObject tip;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           // ShowInteractTip();
        }
    }

    public void ShowInteractTip()
    {
        tip = Instantiate(interactTip, new Vector2(transform.position.x, transform.position.y + 1f), Quaternion.identity);
        tip.GetComponent<SpriteRenderer>().sortingOrder = 1;
        tip.transform.SetParent(transform);
    }

    public void CloseInteractTip()
    {
        Destroy(tip);
    }


}
