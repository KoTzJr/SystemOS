using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Janela_arrastar_calculadora : MonoBehaviour, IDragHandler, IDropHandler
{

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        calculadora.b_soltar = true;
    }

    public void OnDrop(PointerEventData eventData)
    {
        calculadora.b_soltar = false;
    }

}