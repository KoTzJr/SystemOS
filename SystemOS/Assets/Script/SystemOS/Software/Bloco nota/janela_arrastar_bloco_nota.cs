using UnityEngine;
using UnityEngine.EventSystems;

public class janela_arrastar_bloco_nota : MonoBehaviour, IDropHandler ,IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
       transform.position = eventData.position;
       bloco_nota.Soltar_b = true;
    }

    public void OnDrop(PointerEventData eventData)
    {
        bloco_nota.Soltar_b = false;
    }
}