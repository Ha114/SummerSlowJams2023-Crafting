using UnityEngine;
using TMPro;

public class OrderUI : MonoBehaviour
{
    [SerializeField] TMP_Text _TitleOfOrderText;
    [SerializeField] TMP_Text _FromText;
    [SerializeField] TMP_Text _OrderContentText;
    [SerializeField] TMP_Text _SignatureText;

    OrderData _orderData;


    class OrderData
    {
        private string _Title;
        private string _FromText;
        private string _OrderContent;
        private string _SignatureText;

        public OrderData(string title, string from, string order, string signature)
        {
            _Title = title;
            _FromText = from;
            _OrderContent = order;
            _SignatureText = signature;
        }
    }

    private void Start()
    {
    }

    private void SetDataOrder()
    {
        _orderData = new OrderData("a", "b", "c", "d");
    }

    #region Buttons
    public void CloseButton() => gameObject.SetActive(false);
    public void AcceptOrder()
    {
        Debug.Log("ACCEPT order");
        CloseButton();
        //do staff to accept SQL/JSON
    }
    public void DenyOrder()
    {
        Debug.Log("DENY order");
        CloseButton();
        //do staff to deny order SQl/JSON
    }
    #endregion
}
