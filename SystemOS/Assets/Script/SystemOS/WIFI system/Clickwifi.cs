using UnityEngine;
using UnityEngine.UI;


public class Clickwifi : MonoBehaviour {

 [SerializeField] private Image[] ClickImagem;
 [SerializeField] private Text[] Txtrede;
    private void Start()
  {
      
    for (int i = 0; i < ClickImagem.Length; i++)
    {
      for (int v = 0; v < Txtrede.Length; v++)
      {
           ClickImagem[i].enabled = false;
           Txtrede[v].enabled = false;
      }    
    }
  }

  public void ClickWifi ()
 {
    for (int i = 0; i < ClickImagem.Length; i++)
    {
        ClickImagem[i].enabled = !ClickImagem[i].enabled;
       
       for (int a = 0; a < Txtrede.Length; a++)
       {
            if (ClickImagem[i].enabled == true)
            {
               Txtrede[a].enabled = true;
            }
            else 
            {
               Txtrede[a].enabled = false;
            }
       }  
    }
 }


}