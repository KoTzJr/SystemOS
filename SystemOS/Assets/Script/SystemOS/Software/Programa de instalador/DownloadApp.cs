using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DownloadApp : MonoBehaviour
{

    [SerializeField] private Image[] storeOn;
    [SerializeField] private Image[] Storeoff;
    
     private void Start() {
         
         for (int i = 0; i < storeOn.Length; i++)
         {
             for (int v = 0; v < Storeoff.Length; v++)
             {
                 Storeoff[v].enabled = true;
                 storeOn[i].enabled = false;
             }
         }
     }
   
   
    private void Update()
    {
        ConnectStore();
    }
  
   


  public void ConnectStore ()
  {
     if (RedeWifi.connect)
        {
         for (int i = 0; i < storeOn.Length; i++)
          {
               storeOn[i].enabled = true; 
          }
        }
        else 
        {
           for (int i = 0; i < Storeoff.Length; i++)
           {
               Storeoff[i].enabled = true;
           }
        }
  }















}
