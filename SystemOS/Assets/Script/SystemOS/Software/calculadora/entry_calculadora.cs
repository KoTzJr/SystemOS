using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class entry_calculadora : MonoBehaviour, IPointerEnterHandler , IPointerExitHandler
{
    [SerializeField] private Image img_icon_calculadora;

    private void Start() {
        img_icon_calculadora.enabled = false;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        img_icon_calculadora.enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        img_icon_calculadora.enabled = false;
    }
}