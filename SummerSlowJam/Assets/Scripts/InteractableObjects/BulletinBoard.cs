using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletinBoard : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject _orderPrefab;
    [SerializeField] Transform _canvas;

    public void Interact()
    {
        Debug.Log("Interact with Bulletin Board"); 
        ShowOrder();
    }

    void ShowOrder()
    {
        Instantiate(_orderPrefab, _canvas);
    }

}
