using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class entry_bloco_nota : MonoBehaviour, IPointerEnterHandler , IPointerExitHandler
{

    [SerializeField] private Image Img_bloco;

    private void Start() {
        Img_bloco.enabled = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Img_bloco.enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Img_bloco.enabled = false;
    }
}