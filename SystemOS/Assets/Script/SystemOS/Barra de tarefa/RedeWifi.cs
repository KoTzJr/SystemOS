using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
public class RedeWifi : MonoBehaviour {
     
  [SerializeField] private Image Wificonectado; 
  [SerializeField] private Image Wifidesconetado;
  [SerializeField] private Image[] listwifi;
  [SerializeField] private Text[] ListNomewifi;

  string[] Nome_rede = {"ght", "657ng","MR32", "Cak","Storel5","arrow", "Ambu", "VLW74", "ratop", "Swer", "soll" ,"NBF", "JsLS","Buihi","Cadue", "Muin","Couzu","Gene", "Dolxoer", "Nyufe", "Xaosn","Fomar", "Pixu", "Vowui", "Cadeus"};
  string[] PasswowrdRandom = {"kww1787", "SubMICUl","oLmosBaR", "KeRicida","dapsonde","nelecrip","ownpogei", "xastesma","denelevo", "orandita", "compulaz", "horyolew","se84861"};

  private void Start() 
  {   
       NomeredeRandom();
       PasswordRandom();
       Debug.Log(senha0.ToString());
       Wificonectado.enabled = false;
       Wifidesconetado.enabled = true;
       //------------------------------------------------
       this.Txt_btn_conecta.enabled  = false;  // A placa de nome rede texto 
       this.Txt_btn_conecta1.enabled = false;
       this.Txt_btn_conecta2.enabled = false;
       this.Txt_btn_conecta3.enabled = false;
       
       ScriptImagemRandom();
     //----------------------------------------------------
       btn_0 = false; // A clicar dos botoes
       btn_1 = false;
       btn_2 = false;
       btn_3 = false;
       //-------------------------------------------------

       for (int i0 = 0; i0 < PlacaWifi_0.Length; i0++)
       {
           for (int i1 = 0; i1 < Placawifi_1.Length; i1++)
           {
               for (int i2 = 0; i2 < Placawifi_2.Length; i2++)
               {
                  for (int i3 = 0; i3 < PlacaWifi_3.Length; i3++)
                  {
                      PlacaWifi_0[i0].enabled = false;
                      Placawifi_1[i1].enabled = false;
                      Placawifi_2[i2].enabled = false;
                      PlacaWifi_3[i3].enabled = false;
                  }
               }
           }
       }

      foreach (Image listimg in  listwifi)
      {
        foreach (Text listtxt in ListNomewifi)
        {
             listimg.enabled = false;
             listtxt.enabled = false;
        }
      }
  }
  
  private void Update() {
    redesegure();
  }
  
  public void openListWifi ()  // Abrir o lista de wifi
  {
       foreach (Image ListImg in listwifi)
       {
          ListImg.enabled = !ListImg.enabled;
            
          foreach (Text ListTxt in ListNomewifi)
          {
            ListTxt.enabled = !ListTxt.enabled;
          }
       }
  }

//================================================RANDOM==========================================================================
    int Nome0;
    int Nome1;
    int Nome2;
    int Nome3;
    System.Random r = new System.Random();
   public void NomeredeRandom ()
  {
    for (int i = 0; i < Nome_rede.Length; i++)
    {
     Nome0 = r.Next(0,Nome_rede.Length);
     Nome1 = r.Next(0,Nome_rede.Length);
     Nome2 = r.Next(0,Nome_rede.Length);
     Nome3 = r.Next(0,Nome_rede.Length);
     ListNomewifi[0].text = $"{Nome_rede[Nome0]}";
     ListNomewifi[1].text = $"{Nome_rede[Nome1]}";
     ListNomewifi[2].text = $"{Nome_rede[Nome2]}";
     ListNomewifi[3].text = $"{Nome_rede[Nome3]}";
    }
     
    if (ListNomewifi[0].text == ListNomewifi[1].text)
    {
        Nome0 = r.Next(0,Nome_rede.Length);
        ListNomewifi[0].text = $"{Nome_rede[Nome0]}";
    } 
   
    if (ListNomewifi[2].text == ListNomewifi[3].text)
    {
      Nome2 = r.Next(0,Nome_rede.Length);
      ListNomewifi[2].text = $"{Nome_rede[Nome2]}";
    }

    if (ListNomewifi[1].text == ListNomewifi[3].text)
    {
      Nome3 = r.Next(0,Nome_rede.Length);
      ListNomewifi[3].text = $"{Nome_rede[Nome3]}";
    }
  }


  int valor0;
  int valor1;
  int valor2;
  int valor3;


  string senha0;
  string senha1;
  string senha2;
  string senha3;
 
  public void PasswordRandom ()
  {
    for (int i = 0; i < PasswowrdRandom.Length; i++)
    {
        valor0 = r.Next(0,PasswowrdRandom.Length);
        valor1 = r.Next(0,PasswowrdRandom.Length);
        valor2 = r.Next(0,PasswowrdRandom.Length);
        valor3 = r.Next(0,PasswowrdRandom.Length);
        
        senha0 = $"{PasswowrdRandom[valor0]}";
        senha1 = $"{PasswowrdRandom[valor1]}";
        senha2 = $"{PasswowrdRandom[valor2]}";
        senha3 = $"{PasswowrdRandom[valor3]}";
    }
  }


  
  [SerializeField] private Sprite[] sinaisRede;
  int v;  // O posição de imagem random
  int v1;
  int v2;
  int v3;

  bool b_v;
  bool b_v1;
  bool b_v2;
  bool b_v3;

//-------------------------------------------
  bool Redesegura;

//----------------------------------
  public void ScriptImagemRandom (){   // random de imagem wifi 

    for (int i = 0; i < sinaisRede.Length; i++)  // 0 seguro ou 1 nao estava seguro
    {
        v =  r.Next(0,sinaisRede.Length);
        v1 = r.Next(0,sinaisRede.Length);
        v2 = r.Next(0,sinaisRede.Length);
        v3 = r.Next(0,sinaisRede.Length);
        listwifi[5].sprite = sinaisRede[v];
        listwifi[6].sprite = sinaisRede[v1];
        listwifi[7].sprite = sinaisRede[v2];
        listwifi[8].sprite = sinaisRede[v3];
    }

  }
 
  public void redesegure ()
  {
    b_v =  Convert.ToBoolean(v.GetHashCode());
    b_v1 = Convert.ToBoolean(v1.GetHashCode());
    b_v2 = Convert.ToBoolean(v2.GetHashCode());
    b_v3 = Convert.ToBoolean(v3.GetHashCode());
  }

 

// ===========================================Text==========================================================================================

[SerializeField] private Text[] Plnomerede;

///========================= Imagem ======================================================================================================
[SerializeField] private Image[] PlacaWifi_0;
[SerializeField] private Image[] Placawifi_1;
[SerializeField] private Image[] Placawifi_2;
[SerializeField] private Image[] PlacaWifi_3;

//============================================barra de senha input =================================================================================================

[SerializeField] private InputField Br_input0;
[SerializeField] private InputField Br_input1;
[SerializeField] private InputField br_input2;
[SerializeField] private InputField br_input3;

//===================================================================================================================================

[SerializeField] private Text Txt_btn_conecta;
 public void List0 ()
 {
   if (b_v == true){Redesegura = false; Wificonectado.enabled = true; Wifidesconetado.enabled = false; connect = true;}else{Redesegura = true;}
     for (int i = 0; i < PlacaWifi_0.Length; i++)
     {
       if (Redesegura)
       {
         PlacaWifi_0[i].enabled = !PlacaWifi_0[i].enabled;
       }  
         if (PlacaWifi_0[i].enabled == true)
         {
            Txt_btn_conecta.enabled = true;
            this.Plnomerede[0].enabled = true;
         }
         else 
         {
           Txt_btn_conecta.enabled = false;
            this.Plnomerede[0].enabled = false;
         }
     }

     Plnomerede[0].text = $"Rede {Nome_rede[Nome0]}";

 }

[SerializeField] private Text Txt_btn_conecta1;
 public void List1 ()
 {
   if (b_v1 == true){ Redesegura = false; Wificonectado.enabled = true; Wifidesconetado.enabled = false; connect = true;} else {Redesegura = true;}

    for (int i = 0; i < Placawifi_1.Length; i++)
    {  
       if (Redesegura)
       { 
         Placawifi_1[i].enabled = !Placawifi_1[i].enabled;
       }
        if (Placawifi_1[0].enabled == true)
        {
          Txt_btn_conecta1.enabled = true;
          Plnomerede[1].enabled = true;
        }
        else 
        {
          Txt_btn_conecta1.enabled = false;
          Plnomerede[1].enabled = false;
        }  
    }
    Plnomerede[1].text = $"Rede {Nome_rede[Nome1]}";
 }

[SerializeField] private Text Txt_btn_conecta2;
 public void List2 ()
 {
   if (b_v2 == true){Redesegura = false; Wificonectado.enabled = true; Wifidesconetado.enabled = false; connect = true;}else {Redesegura = true;}
   for (int i = 0; i < Placawifi_2.Length; i++)
   {
     if (Redesegura)
     {
       Placawifi_2[i].enabled = !Placawifi_2[i].enabled;
     }
       if (Placawifi_2[i].enabled == true)
       {
          Txt_btn_conecta2.enabled = true;
          Plnomerede[2].enabled = true;
       }else
       {
         Txt_btn_conecta2.enabled = false;
         Plnomerede[2].enabled = false;
       }
   }
    Plnomerede[2].text = $"Rede {Nome_rede[Nome2]}";
 }


[SerializeField] private Text Txt_btn_conecta3;
 public void List3 ()
 { if (b_v3 == true){Redesegura = false; Wificonectado.enabled = true; Wifidesconetado.enabled = false; connect = true;}else{Redesegura = true;}
   for (int i = 0; i < PlacaWifi_3.Length; i++)
   { 
     if (Redesegura)
     {
       PlacaWifi_3[i].enabled = !PlacaWifi_3[i].enabled;
     }
       if (PlacaWifi_3[i].enabled == true)
       {
         Txt_btn_conecta3.enabled = true;
         this.Plnomerede[3].enabled = true;
       }
       else 
       {
         Txt_btn_conecta3.enabled = false;
         this.Plnomerede[3].enabled = false;
         
       }
   }

    Plnomerede[3].text = $"Rede {Nome_rede[Nome3]}";
 }

//----------------------------------------------------
  bool btn_0;  // Para clicar dos botoes condicoes
  bool btn_1;  
  bool btn_2;  
  bool btn_3;
//-------------------------------------------------------
  public void btn_connect_0 ()
  {
    btn_0 = true;
    btn_1 = false;
    btn_2 = false;
    btn_3 = false;
    StartCoroutine ("timeconnect");
  }
  public void btn_connect_1 ()
  {  
    btn_1 = true;
    btn_2 = false;
    btn_0 = false;
    btn_3 = false;
    StartCoroutine ("timeconnect");
  }

  public void btn_connect_2 (){
   
    btn_2 = true;
    btn_0 = false;
    btn_1 = false;
    btn_3 = false;
    StartCoroutine ("timeconnect");
  }

  public void btn_connect_3 ()
  { 
    btn_3 = true;
    btn_1 = false;
    btn_2 = false;
    btn_0 = false;
    StartCoroutine ("timeconnect");
  }

 public static bool connect; // ou seja se a rede esta conectado ou nao esta conectado
 IEnumerator timeconnect (){
   
   yield return new WaitForSeconds(4f);
   
   switch (btn_0 || btn_1 || btn_2 || btn_3)
   {
      case true:
       if (Br_input0.text == senha0.ToString())
       {
          Wificonectado.enabled = true;
          connect = true;
          Wifidesconetado.enabled = false;
       }
       
       if (Br_input1.text == senha1.ToString())
       {
          Wificonectado.enabled = true;
          connect = true;
          Wifidesconetado.enabled = false;
       }  

       if (br_input2.text == senha2.ToString())
       {
          Wificonectado.enabled = true;
          connect = true;
          Wifidesconetado.enabled = false;
       }

       if (br_input3.text == senha3.ToString())
       {
          Wificonectado.enabled = true;
          connect = true;
          Wifidesconetado.enabled = false;
       }
       break;    
   }
   
 }
 
}