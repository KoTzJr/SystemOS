using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Janelaarrastar : MonoBehaviour, IDragHandler
{
     public void OnDrag(PointerEventData eventData)
     {
          transform.position = eventData.position;
     }
}
