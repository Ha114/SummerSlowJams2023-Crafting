using UnityEngine;
using TMPro;

public class OrderUI : MonoBehaviour
{
    [SerializeField] TMP_Text _TitleOfOrderText;
    [SerializeField] TMP_Text _FromText;
    [SerializeField] TMP_Text _OrderContentText;
    [SerializeField] TMP_Text _SignatureText;

    public void OrderUiSetData(string _title, string _from, string _order, string _signature) {
        _TitleOfOrderText.text = _title;
        _FromText.text = _from;
        _OrderContentText.text = _order;
        _SignatureText.text = _signature;
    }

    private void Start()
    {
    }
}
