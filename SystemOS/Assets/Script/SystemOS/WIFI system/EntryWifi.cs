using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EntryWifi : MonoBehaviour, IPointerEnterHandler , IPointerExitHandler
{
    [SerializeField] private Image entryImagem;
    private void Start() 
    {
        entryImagem.enabled = false;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        entryImagem.enabled = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        entryImagem.enabled = false;
    }
}