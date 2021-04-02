using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class jogovelha : MonoBehaviour {

  public Image Player2Img ,Player1Img;
  private void Start() 
  {  
    linha036.SetActive(false);
    linha048.SetActive(false);
    linha147.SetActive(false);
    linha258.SetActive(false);
    linha246.SetActive(false);
    linha345.SetActive(false);
    linha012.SetActive(false);
    linha678.SetActive(false);

    foreach (GameObject x_ in x)
    {
        x_.SetActive(false);
    }
    foreach (GameObject ciruclo in circulo)
    {
        ciruclo.SetActive(false);
    }

    Plate_Player();

    
  }
  private void Update() 
  {
    //Plate_Player();
   // Wins();
    Pl1.text = PLAYER_1.ToString();
    Pl2.text = PLAYER_2.ToString();

    for (int i = 0; i < bb.Length; i++)
    {
        empate = bb[i];
        
    }
    

  }

 //===========================================================================Vitoria========================================================================== 
 [SerializeField] private GameObject linha036 , linha048 , linha147, linha258 , linha345 , linha246 , linha012 , linha678;
 [SerializeField] private Text Pl1,Pl2;
  bool Wins_P1 , Wins_P2;
  int PLAYER_1 , PLAYER_2;

  int cli;

  bool empate;
  public void Wins () // caso o ganhador do player 
  {
   
   for (int i = 0; i < BTN_O.Length; i++)
   {
       for (int a = 0; a < BTN_X.Length; a++)
    {
      for (int ca = 0; ca < bb.Length; ca++)
      {
        switch (BTN_X[i] || BTN_O[i])       
      { 
       case true:
          if (BTN_X[0] && BTN_X[3] && BTN_X[6])
          {
            Wins_P1 = true;
            empate = false;
            offbutton();
            linha036.SetActive(true);
          }
          else if (BTN_O[0] && BTN_O[3] && BTN_O[6])
          {
            Wins_P2 = true;
            offbutton();
            linha036.SetActive(true);
          }
          else if (BTN_X[0] && BTN_X[4] && BTN_X[8])
          { 
            //
            Wins_P1 = true;
            empate = false;
            offbutton();
            linha048.SetActive(true);
          }
          else if (BTN_O [0] && BTN_O[4] && BTN_O[8])
          {   
             Wins_P2 = true;
             empate = false;
             offbutton();
             linha048.SetActive(true);
          }
          else if (BTN_X[1] && BTN_X[4] && BTN_X[7])
          {
             Wins_P1 = true;
             empate = false;
             offbutton();
             linha147.SetActive(true);
          }
          else if (BTN_O[1] && BTN_O[4] && BTN_O[7])
          {
            Wins_P2 = true;
            empate = false;
            offbutton();
            linha147.SetActive(true);
          }
          else if (BTN_X[2] && BTN_X[5] && BTN_X[8])
          {
            Wins_P1 = true;
            empate = false;
            offbutton();
            linha258.SetActive(true);
          }
          else if (BTN_O[2] && BTN_O[5] && BTN_O[8])
          {
            Wins_P2 = true;
            empate = false;
            offbutton();
            linha258.SetActive(true);
          }
          else if (BTN_X[3] && BTN_X[4] && BTN_X[5])
          {
            Wins_P1 = true;
            empate = false;
            offbutton();
            linha345.SetActive(true);
          }
          else if (BTN_O[3] && BTN_O[4] && BTN_O[5])
          {
            Wins_P2 = true;
            empate = false;
            offbutton();
            linha345.SetActive(true);
          }
          else if (BTN_X[2] && BTN_X[4] && BTN_X[6])
          {
            Wins_P1 = true;
            empate = false;
            offbutton();
            linha246.SetActive(true);
          }
          else if (BTN_O[2] && BTN_O[4] && BTN_O[6])
          {
            Wins_P2 = true;
            empate = false;
            offbutton();
            linha246.SetActive(true);
          }
          else if (BTN_X[0] && BTN_X[1] && BTN_X[2])
          {
            Wins_P1 = true;
            empate = false;
            offbutton();
            linha012.SetActive(true);
          }
          else if (BTN_O[0] && BTN_O[1] && BTN_O[2])
          {
            Wins_P2 = true;
            empate = false;
            offbutton();
            linha012.SetActive(true);
          }
          else if (BTN_X[6] && BTN_X[7] && BTN_X[8])
          {
            Wins_P1 = true;
            empate = false;
            offbutton();
            linha678.SetActive(true);
          }
           else if (BTN_O[6] && BTN_O[7] && BTN_O[8])
          {
            Wins_P2 = true;
            empate = false;
            offbutton();
            linha678.SetActive(true);
          }
           if (bb[0] && bb[1] && bb[2] && bb[3] && bb[4] && bb[5] && bb[6] && bb[7] && bb[8] && empate)
           { 
             Reset();
           }
       break;
      }
     }  
   } 
  }   

     if (Wins_P1)
     {
       StartCoroutine("TimeWins");
       PLAYER_1++;
       Player1Img.enabled = true;
       Player2Img.enabled = false;
     }
     else if (Wins_P2)
     {
       StartCoroutine("TimeWins");
       PLAYER_2++;
       Player2Img.enabled = true;
       Player1Img.enabled = false;
       
     }
   }

   public void offbutton ()
   {
      for (int i = 0; i < ClickButton.Length; i++)
      {
         ClickButton[i].enabled = false;
      }
   }

   public void Plate_Player () 
   {
     if (Clicked_BTN == true)
     {
        Player2Img.enabled = true;
        Player1Img.enabled = false;
     }
     else if (Clicked_BTN == false)
     {
        Player1Img.enabled = true;
        Player2Img.enabled = false;
     }
    
   }


   public void Reset () // reiniciar
   {
     for (int i = 0; i < BTN_O.Length; i++)
     {
         for (int a = 0; a < BTN_X.Length; a++)
         {
            for (int xa= 0; xa < x.Length; xa++)
            {
              for (int o = 0; o < circulo.Length; o++)
              {
                for (int c = 0; c < ClickButton.Length; c++)
                {
                  for (int ca = 0; ca < bb.Length  ; ca++)
                  {
                   ClickButton[c].enabled = true;
                   x[xa].SetActive(false);
                   BTN_O[i] = false;
                   BTN_X[a] = false;
                   circulo[o].SetActive(false);
                   linha012.SetActive(false);
                   linha036.SetActive(false);
                   linha048.SetActive(false);
                   linha147.SetActive(false);
                   linha246.SetActive(false);
                   linha258.SetActive(false);
                   linha345.SetActive(false);
                   linha678.SetActive(false);
                   Clicked_BTN = !Clicked_BTN;
                   Wins_P1 = false;
                   Wins_P2 = false;
                   cli = 0;
                   bb[ca] = false;
                   empate = false;
                  }
                }
              }   
            }
         }
     }
   }

   IEnumerator TimeWins (){

     yield return new WaitForSeconds(1.5f);
     Reset();
   }

 //=============================================================================================================================================================================================

// x = true & O = false
  public Button[] ClickButton = new Button[9];
  [SerializeField] private GameObject[] x;
  [SerializeField] private GameObject[] circulo;
  bool Clicked_BTN;
  public bool[] BTN_X , BTN_O;
  public bool[] bb;
 public void Btn_0 ()
 { 
   Clicked_BTN = !Clicked_BTN;
   bb[0] = true;
   Plate_Player();
   
  
   if (Clicked_BTN) 
   {
     for (int i = 0; i < ClickButton.Length; i++)
     {   
         
         BTN_X[0] = true;
         x[0].SetActive(true);
         ClickButton[0].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < ClickButton.Length; i++)
      {
          cli = 1;
          BTN_O[0] = true;
          circulo[0].SetActive(true);
          ClickButton[0].enabled = false;
      }
   }
   Wins();
 }
 public void Btn_1 ()
 {
   Clicked_BTN = !Clicked_BTN;
   bb[1] = true;

   Plate_Player();
   
   if (Clicked_BTN)
   {
     for (int i = 0; i < ClickButton.Length; i++)
     {   
        
         BTN_X[1] = true;
         x[1].SetActive(true);
         ClickButton[1].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < ClickButton.Length; i++)
      {
          BTN_O[1] = true;
          circulo[1].SetActive(true);
          ClickButton[1].enabled = false;
      }
   }

   Wins();
     
 }

 public void Btn_2 ()
 {
    Clicked_BTN = !Clicked_BTN;
    bb[2] = true;
    Plate_Player();

   if (Clicked_BTN)
   {
     for (int i = 0; i < ClickButton.Length; i++)
     {   
         BTN_X[2] = true;
         x[2].SetActive(true);
         ClickButton[2].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < ClickButton.Length; i++)
      {
          BTN_O[2] = true;
          circulo[2].SetActive(true);
          ClickButton[2].enabled = false;
      }
   }
   Wins();
 }

 public void Btn_3 ()
 {
   Clicked_BTN = !Clicked_BTN;
   bb[3] = true;
   Plate_Player();

   if (Clicked_BTN)
   {
     for (int i = 0; i < ClickButton.Length; i++)
     {   
         BTN_X[3] = true;
         x[3].SetActive(true);
         ClickButton[3].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < ClickButton.Length; i++)
      {
          BTN_O[3] = true;
          circulo[3].SetActive(true);
          ClickButton[3].enabled = false;
      }
   }
   Wins();
 }

 public void Btn_4 ()
 {
    Clicked_BTN = !Clicked_BTN;
    bb[4] = true;
    Plate_Player();

   if (Clicked_BTN)
   {
     for (int i = 0; i < ClickButton.Length; i++)
     {   
         BTN_X[4] = true;
         BTN_O[4] = false;
         x[4].SetActive(true);
         ClickButton[4].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < ClickButton.Length; i++)
      {
          BTN_O[4] = true;
          BTN_X[4] = false;
          circulo[4].SetActive(true);
          ClickButton[4].enabled = false;
      }
   }
   Wins();
 }

 public void Btn_5 ()
 {
    Clicked_BTN = !Clicked_BTN;
    bb[5] = true;
    Plate_Player();

   if (Clicked_BTN)
   {
     for (int i = 0; i < ClickButton.Length; i++)
     {   
         BTN_X[5] = true;
         x[5].SetActive(true);
         ClickButton[5].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < ClickButton.Length; i++)
      {
          BTN_O[5] = true;
          circulo[5].SetActive(true);
          ClickButton[5].enabled = false;
      }
   }
   Wins();
 }

 public void Btn_6 ()
 {
    Clicked_BTN = !Clicked_BTN;
    bb[6] = true;
    Plate_Player();

   if (Clicked_BTN)
   {
     for (int i = 0; i < ClickButton.Length; i++)
     {   
         BTN_X[6] = true;
         x[6].SetActive(true);
         ClickButton[6].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < ClickButton.Length; i++)
      {
          BTN_O[6] = true;
          circulo[6].SetActive(true);
          ClickButton[6].enabled = false;
      }
   }
   Wins();

 }

 public void Btn_7 ()
 { 
   
   Clicked_BTN = !Clicked_BTN;
   bb[7] = true;
   Plate_Player();

   if (Clicked_BTN)
   {
     for (int i = 0; i < ClickButton.Length; i++)
     {   
         BTN_X[7] = true;
         x[7].SetActive(true);
         ClickButton[7].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < ClickButton.Length; i++)
      {
          BTN_O[7] = true;
          circulo[7].SetActive(true);
          ClickButton[7].enabled = false;
      }
   }
   Wins();
 }

 public void Btn_8 ()
 {
    Clicked_BTN = !Clicked_BTN;
    bb[8] = true;
    Plate_Player();

   if (Clicked_BTN)
   {
     for (int i = 0; i < ClickButton.Length; i++)
     {   
        BTN_X[8] = true;
        x[8].SetActive(true);
        ClickButton[8].enabled = false;
     }

   }
   else 
   {
      for (int i = 0; i < ClickButton.Length; i++)
      {
        BTN_O[8] = true;
        circulo[8].SetActive(true);
        ClickButton[8].enabled = false;
      }
   }
   Wins();
 }

}