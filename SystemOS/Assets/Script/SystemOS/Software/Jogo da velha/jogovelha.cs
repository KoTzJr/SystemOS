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

    EmpateImg.enabled = false;
    Txt_empate.enabled = false;

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
    Pl1.text = PLAYER_1.ToString();
    Pl2.text = PLAYER_2.ToString();
    EmpateGame();
  }

 //===========================================================================Vitoria=========================================================================================================== 
 [SerializeField] private GameObject linha036 , linha048 , linha147, linha258 , linha345 , linha246 , linha012 , linha678;
 [SerializeField] private Text Pl1,Pl2;
  bool Wins_P1 , Wins_P2;
  int PLAYER_1 , PLAYER_2;
  bool empate;
  public void Wins_Player () //  Caso jogador ganhar este jogo 
  {
   for (int i = 0; i < BTN_O.Length; i++)
   {
     for (int a = 0; a < BTN_X.Length; a++)
    {
      for (int ca = 0; ca < Button_Clicked_bool.Length; ca++)
      {
        switch (BTN_X[i] || BTN_O[i])       
      { 
       case true:

          if (BTN_X[0] && BTN_X[3] && BTN_X[6])
          {
            Wins_P1 = true;
            empate = false;
            Button_Clicked_bool[ca] = false;
            Disable_Button();
            linha036.SetActive(true);
          }
          else if (BTN_O[0] && BTN_O[3] && BTN_O[6])
          {
            Wins_P2 = true;
            Button_Clicked_bool[ca] = false;
            Disable_Button();
            linha036.SetActive(true);
          }
          else if (BTN_X[0] && BTN_X[4] && BTN_X[8])
          { 

            Wins_P1 = true;
            Button_Clicked_bool[ca] = false;
            empate = false;
            Disable_Button();
            linha048.SetActive(true);
          }
          else if (BTN_O [0] && BTN_O[4] && BTN_O[8])
          {   
             Wins_P2 = true;
             Button_Clicked_bool[ca] = false;
             empate = false;
             Disable_Button();
             linha048.SetActive(true);
          }
          else if (BTN_X[1] && BTN_X[4] && BTN_X[7])
          {
             Wins_P1 = true;
             Button_Clicked_bool[ca] = false;
             empate = false;
             Disable_Button();
             linha147.SetActive(true);
          }
          else if (BTN_O[1] && BTN_O[4] && BTN_O[7])
          {
            Wins_P2 = true;
            Button_Clicked_bool[ca] = false;
            empate = false;
            Disable_Button();
            linha147.SetActive(true);
          }
          else if (BTN_X[2] && BTN_X[5] && BTN_X[8])
          {
            Wins_P1 = true;
            Button_Clicked_bool[ca] = false;
            empate = false;
            Disable_Button();
            linha258.SetActive(true);
          }
          else if (BTN_O[2] && BTN_O[5] && BTN_O[8])
          {
            Wins_P2 = true;
            Button_Clicked_bool[ca] = false;
            empate = false;
            Disable_Button();
            linha258.SetActive(true);
          }
          else if (BTN_X[3] && BTN_X[4] && BTN_X[5])
          {
            Wins_P1 = true;
            Button_Clicked_bool[ca] = false;
            empate = false;
            Disable_Button();
            linha345.SetActive(true);
          }
          else if (BTN_O[3] && BTN_O[4] && BTN_O[5])
          {
            Wins_P2 = true;
            Button_Clicked_bool[ca] = false;
            empate = false;
            Disable_Button();
            linha345.SetActive(true);
          }
          else if (BTN_X[2] && BTN_X[4] && BTN_X[6])
          {
            Wins_P1 = true;
            Button_Clicked_bool[ca] = false;
            empate = false;
            Disable_Button();
            linha246.SetActive(true);
          }
          else if (BTN_O[2] && BTN_O[4] && BTN_O[6])
          {
            Wins_P2 = true;
            Button_Clicked_bool[ca] = false;
            empate = false;
            Disable_Button();
            linha246.SetActive(true);
          }
          else if (BTN_X[0] && BTN_X[1] && BTN_X[2])
          {
            Wins_P1 = true;
            Button_Clicked_bool[ca] = false;
            empate = false;
            Disable_Button();
            linha012.SetActive(true);
          }
          else if (BTN_O[0] && BTN_O[1] && BTN_O[2])
          {
            Wins_P2 = true;
            Button_Clicked_bool[ca] = false;
            empate = false;
            Disable_Button();
            linha012.SetActive(true);
          }
          else if (BTN_X[6] && BTN_X[7] && BTN_X[8])
          {
            Wins_P1 = true;
            Button_Clicked_bool[ca] = false;
            empate = false;
            Disable_Button();
            linha678.SetActive(true);
          }
           else if (BTN_O[6] && BTN_O[7] && BTN_O[8])
          {
            Wins_P2 = true;
            Button_Clicked_bool[ca] = false;
            empate = false;
            Disable_Button();
            linha678.SetActive(true);
          }

           foreach (bool ba in Button_Clicked_bool)
          { 
            empate = ba;
          }
            
           if (Button_Clicked_bool[0] && Button_Clicked_bool[1] && Button_Clicked_bool[2] && Button_Clicked_bool[3] && Button_Clicked_bool[4] && Button_Clicked_bool[5] && Button_Clicked_bool[6] && Button_Clicked_bool[7] && Button_Clicked_bool[8] && empate)
           { 
             Tie_Bool = true;   // Empate ativar 
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
    bool Tie_Bool;
    float Time_Tie;
   public void Disable_Button ()
   {
      for (int i = 0; i < Button_brand.Length; i++)
      {
         Button_brand[i].enabled = false;
      }
   }

   public void Plate_Player () 
   {
     if (Click_X_O == true)
     {
        Player2Img.enabled = true;
        Player1Img.enabled = false;
     }
     else if (Click_X_O == false)
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
                for (int c = 0; c < Button_brand.Length; c++)
                {
                  for (int ca = 0; ca < Button_Clicked_bool.Length  ; ca++)
                  {
                   Button_brand[c].enabled = true; 
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
                   Click_X_O = !true;
                   Wins_P1 = false;
                   Wins_P2 = false;
                   Button_Clicked_bool[ca] = false;
                   empate = false;
                   Tie_Bool = false;
                 }
               }
             }   
           }
        }
     }
   }
  [SerializeField] private Image EmpateImg; 
  [SerializeField] private Text  Txt_empate;
   IEnumerator TimeWins ()
   {
     yield return new WaitForSeconds(1.8f);
     Reset();
   }

   public void EmpateGame (){
      
       if (Tie_Bool)  // se empate
     {
        Time_Tie += Time.deltaTime;
        EmpateImg.enabled = true;
        Txt_empate.enabled = true;
       
        if (Time_Tie > 2f)
        { 
           Reset();
           EmpateImg.enabled = false;
           Txt_empate.enabled = false;
           Time_Tie = 0f;
           Tie_Bool = false;

        }
     }
   }
   

 //=============================================================================================================================================================================================

  // X = true & O = false
  public Button[] Button_brand = new Button[9];  // O botão de marcar
  [SerializeField] private GameObject[] x;   // A imagem de X
  [SerializeField] private GameObject[] circulo; // A imagem de O
  bool Click_X_O; // Clicar X ou O 
  public bool[] BTN_X , BTN_O;
  public bool[] Button_Clicked_bool;
 public void Btn_0 ()
 { 
   Click_X_O = !Click_X_O;
   Button_Clicked_bool[0] = true;
   Plate_Player();
  
   if (Click_X_O) 
   {
     for (int i = 0; i < Button_brand.Length; i++)
     {   
         
         BTN_X[0] = true;
         x[0].SetActive(true);
         Button_brand[0].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < Button_brand.Length; i++)
      {
          BTN_O[0] = true;
          circulo[0].SetActive(true);
          Button_brand[0].enabled = false;
      }
   }
   Wins_Player();
 }
 public void Btn_1 ()
 {
   Click_X_O = !Click_X_O;
   Button_Clicked_bool[1] = true;

   Plate_Player();
   
   if (Click_X_O)
   {
     for (int i = 0; i < Button_brand.Length; i++)
     {   
        
         BTN_X[1] = true;
         x[1].SetActive(true);
         Button_brand[1].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < Button_brand.Length; i++)
      {
          BTN_O[1] = true;
          circulo[1].SetActive(true);
          Button_brand[1].enabled = false;
      }
   }
   Wins_Player();
 }

 public void Btn_2 ()
 {
    Click_X_O = !Click_X_O;
    Button_Clicked_bool[2] = true;
    Plate_Player();

   if (Click_X_O)
   {
     for (int i = 0; i < Button_brand.Length; i++)
     {   
         BTN_X[2] = true;
         x[2].SetActive(true);
         Button_brand[2].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < Button_brand.Length; i++)
      {
          BTN_O[2] = true;
          circulo[2].SetActive(true);
          Button_brand[2].enabled = false;
      }
   }
   Wins_Player();
 }

 public void Btn_3 ()
 {
   Click_X_O = !Click_X_O;
   Button_Clicked_bool[3] = true;
   Plate_Player();

   if (Click_X_O)
   {
     for (int i = 0; i < Button_brand.Length; i++)
     {   
         BTN_X[3] = true;
         x[3].SetActive(true);
         Button_brand[3].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < Button_brand.Length; i++)
      {
          BTN_O[3] = true;
          circulo[3].SetActive(true);
          Button_brand[3].enabled = false;
      }
   }
   Wins_Player();
 }

 public void Btn_4 ()
 {
    Click_X_O = !Click_X_O;
    Button_Clicked_bool[4] = true;
    Plate_Player();

   if (Click_X_O)
   {
     for (int i = 0; i < Button_brand.Length; i++)
     {   
         BTN_X[4] = true;
         BTN_O[4] = false;
         x[4].SetActive(true);
         Button_brand[4].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < Button_brand.Length; i++)
      {
          BTN_O[4] = true;
          BTN_X[4] = false;
          circulo[4].SetActive(true);
          Button_brand[4].enabled = false;
      }
   }
   Wins_Player();
 }

 public void Btn_5 ()
 {
    Click_X_O = !Click_X_O;
    Button_Clicked_bool[5] = true;
    Plate_Player();

   if (Click_X_O)
   {
     for (int i = 0; i < Button_brand.Length; i++)
     {   
         BTN_X[5] = true;
         x[5].SetActive(true);
         Button_brand[5].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < Button_brand.Length; i++)
      {
          BTN_O[5] = true;
          circulo[5].SetActive(true);
          Button_brand[5].enabled = false;
      }
   }
   Wins_Player();
 }

 public void Btn_6 ()
 {
    Click_X_O = !Click_X_O;
    Button_Clicked_bool[6] = true;
    Plate_Player();

   if (Click_X_O)
   {
     for (int i = 0; i < Button_brand.Length; i++)
     {   
         BTN_X[6] = true;
         x[6].SetActive(true);
         Button_brand[6].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < Button_brand.Length; i++)
      {
          BTN_O[6] = true;
          circulo[6].SetActive(true);
          Button_brand[6].enabled = false;
      }
   }
   Wins_Player();
 }

 public void Btn_7 ()
 { 
   
   Click_X_O = !Click_X_O;
   Button_Clicked_bool[7] = true;
   Plate_Player();

   if (Click_X_O)
   {
     for (int i = 0; i < Button_brand.Length; i++)
     {   
         BTN_X[7] = true;
         x[7].SetActive(true);
         Button_brand[7].enabled = false;
     }
   }
   else 
   {
      for (int i = 0; i < Button_brand.Length; i++)
      {
          BTN_O[7] = true;
          circulo[7].SetActive(true);
          Button_brand[7].enabled = false;
      }
   }
   Wins_Player();
 }

 public void Btn_8 ()
 {
    Click_X_O = !Click_X_O;
    Button_Clicked_bool[8] = true;
    Plate_Player();

   if (Click_X_O)
   {
     for (int i = 0; i < Button_brand.Length; i++)
     {   
        BTN_X[8] = true;
        x[8].SetActive(true);
        Button_brand[8].enabled = false;
     }

   }
   else 
   {
      for (int i = 0; i < Button_brand.Length; i++)
      {
        BTN_O[8] = true;
        circulo[8].SetActive(true);
        Button_brand[8].enabled = false;
      }
   }
   Wins_Player();
 }

}