using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class jogovelha : MonoBehaviour {

 
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

    //Player1Txt.text = $"{"Player" + "\b" + Player1}";

    foreach (GameObject x_ in x)
    {
        x_.SetActive(false);
    }

    foreach (GameObject ciruclo in circulo)
    {
        ciruclo.SetActive(false);
    }

  }

 [SerializeField] private Text Player1Txt , Player2Txt;
  private void Update() 
  {
   WinsPlayer1();
   WinsPlayer2();
  }

 [SerializeField] private GameObject[] x;
 [SerializeField] private GameObject[] circulo;
  
  

  bool play;

 [SerializeField] private Button[] Botoesmarcado;
 
 int Player1, Player2;

[SerializeField] private GameObject linha036 , linha048 , linha147, linha258 , linha345 , linha246 , linha012 , linha678;
 public void WinsPlayer1 (){
   
   for (int i = 0; i < player1Value.Length; i++)
   {
     if (player1Value[0] == 1 && player1Value[3] == 3 && player1Value[6] == 6 && Ply1b && a == true && button[0] == true && button[3] == true && button[6] == true)
     {  
        for (int v = 0; v < Botoesmarcado.Length; v++)               // Ok
        {    
             linha036.SetActive(true);
             Botoesmarcado[i].enabled = false;
             Player1++;
        }
     }
     else if (player1Value[0] == 1 && player1Value[4] == 4 && player1Value[8] == 8 && Ply1b && a == true && button[0] == true && button[4] == true && button[8] == true)
     {
        for (int v = 0; v < Botoesmarcado.Length; v++)
        {
         linha048.SetActive(true);
         Botoesmarcado[v].enabled = false;   
         Debug.Log("Entrou / player 1");    // OK 
         Player1++;  
        }
     }
     else if (player1Value[2] == 2 && player1Value[4] == 4 && player1Value[6] == 6 && Ply1b && a == true && button[2] == true && button[4] && button[6] == true)
     {
       for (int v = 0; v < Botoesmarcado.Length; v++)
       {
          linha246.SetActive(true);
          Botoesmarcado[v].enabled = false;  // Ok
          Player1++;
       }
       
     }
     else if (player1Value[3] == 3 && player1Value[4] == 4 && player1Value[5] == 5 && Ply1b && a == true && button[3] == true && button[4] == true && button[5] == true)
     {  
        for (int v = 0; v < Botoesmarcado.Length; v++){
          Botoesmarcado[v].enabled = false;
          Player1++;                                    //ok
          linha345.SetActive(true);
        }
       
     }
     else if (player1Value[1] == 1 && player1Value[4] == 4 && player1Value[7] == 7 && Ply1b && a == true && button[1] == true && button[4] == true && button[7] == true)
     {
       for (int v = 0; v < Botoesmarcado.Length; v++)
       {
          Botoesmarcado[v].enabled = false;
          Player1++;                            //ok
          linha147.SetActive(true);
       }
     }
     else if (player1Value[2] == 2 && player1Value[5] == 5 && player1Value[8] == 8 && Ply1b && a == true && button[2] == true && button[5] == true && button[8] == true)
     {
       for (int v = 0; v < Botoesmarcado.Length; v++){
         Botoesmarcado[v].enabled = false;
         Player1++;                         //ok
         linha258.SetActive(true);
       }
     }
     else if (player1Value[0] == 1 && player1Value[1] == 1  && player1Value[2] == 2 && Ply1b && a == true && button[0] == true && button[1] == true && button[2] == true)
     { 
       for (int v = 0; v < Botoesmarcado.Length; v++){
          Botoesmarcado[v].enabled = false;
          Player1++;                          //ok
          linha012.SetActive(true);
       }
        
     }
     else if (player1Value[6] == 6 && player1Value[7] == 7 && player1Value[8] == 8 && Ply1b && a == true && button[6] == true && button[7] == true && button[8] == true)
     {
       for (int v = 0; v < Botoesmarcado.Length; v++){
         Botoesmarcado[v].enabled = false;
         Player1++;
         linha678.SetActive(true);
       }
        
     } 
       
   }

 }

 // X = TRUE = 1 , O = FALSE = 0;

 public void WinsPlayer2 ()
 {
 
 
  for (int i = 0;  i < button.Length; i++)
  {
     if (player2Value[0] == 0 && player2Value[3] == 3 && player2Value[6] == 6 && Ply2b && a == false && button[0] == true && button[3] == true && button[6] == true)
   {
     for (int v = 0; v < Botoesmarcado.Length; v++)
     {
      Botoesmarcado[v].enabled = false;
      linha036.SetActive(true);
      Player2++;
     }
   }
   else if (player2Value[0] == 0 && player2Value[4] == 4 && player2Value[8] == 8 && Ply2b && a == false && button[0] == true && button[4] == true && button[8] == true)
   {
     for (int v = 0; v < Botoesmarcado.Length; v++)
     {
       Botoesmarcado[v].enabled = false;
       Debug.Log("entrou / player 2");   ///! error 
       linha048.SetActive(true);
       Player2++;
     }
      
     
   }
   else if (player2Value[2] == 2 && player2Value[4] == 4 && player2Value[6] == 6 && Ply2b && a == false && button[2] == true && button[4] == true && button[6] == true)
   {
      for (int v = 0; v < Botoesmarcado.Length; v++)
      {
        Botoesmarcado[v].enabled = false;
        linha246.SetActive(true);
        Player2++;
      }
     
     
   } 
   else if (player2Value[3] == 3 && player2Value[4] == 4 && player2Value[5] == 5 && Ply2b && a == false && button[3] == true && button[4] == true && button[5] == true)
   {
     for (int v = 0; v < Botoesmarcado.Length; v++)
     {
      linha345.SetActive(true);
      Botoesmarcado[v].enabled = false;
      Player2++;
     }
      
   }
   else if (player2Value[1] == 1 && player2Value[4] == 4 && player2Value[7] == 7 && Ply2b && a == false && button[1] == true && button[4] == true && button[7] == true){
     
      for (int v = 0; v < Botoesmarcado.Length; v++)
      {
        Botoesmarcado[v].enabled = false;
        linha147.SetActive(true);
        Player2++;
      }
      
   }
  else if (player2Value[2] == 2 && player2Value[5] == 5 && player2Value[8] == 8 && Ply2b && a == false && button[2] == true && button[5] == true && button[8] == true){
     
     for (int v = 0; v < Botoesmarcado.Length; v++)
     {
       Botoesmarcado[v].enabled = false;
       linha258.SetActive(true);
       Player2++;
     }
     
  }
  else if (player2Value[0] == 0 && player2Value[1] == 1  && player2Value[2] == 2 && Ply2b  && a == false && button[0] == true && button[1] == true && button[2] == true){
    
     for (int v = 0; v < Botoesmarcado.Length; v++)
     {
       Botoesmarcado[v].enabled = false;
       linha012.SetActive(true);
       Player2++;
     }
      
  }
  else if (player2Value[6] == 6 && player2Value[7] == 7 && player2Value[8] == 8 && Ply2b && a == false && button[6] == true && button[7] == true && button[8] == true)
  {
    for (int v = 0; v < Botoesmarcado.Length; v++)
    {
      Botoesmarcado[v].enabled = false;
      linha678.SetActive(true);
      Player2++;
    }
   }
  }
}
 public int[] player1Value , player2Value;
 
 bool Ply1b , Ply2b;

 bool a;

 public bool[] button;

 public bool[] testar;

 public List<bool> l = new List<bool>();

 ///=========================================================================================================================
 public void Btn_0 ()
 { 

   play = !play;

   //aa

   for (int i = 0; i < testar.Length; i++)
   {
       testar[0] = !testar[0];
       l.Add(testar[0]);
   }

   if (play)   
   {
      int ply1 = 1;
      player1Value[0] = ply1;
      Ply1b = true;
      Ply2b = false;
      a = true;
      Botoesmarcado[0].enabled = false;
      Botoesmarcado[0].interactable = true;
      x[0].SetActive(true);
   }
   else
   {  
      int ply2 = 0;
      player2Value[0] = ply2;
      Ply2b = true;
      Ply1b = false;
      a = false;
      Botoesmarcado[0].enabled = false;
      circulo[0].SetActive(true);
      Botoesmarcado[0].interactable = true;
   }

   for (int i = 0; i < button.Length; i++)
   {
    button[0] = true;
   }

 }
 
 public void Btn_1 ()
 {
   
   play = !play;

   
   for (int i = 0; i < testar.Length; i++)
   {
       testar[1] = !testar[1];
       l.Add(testar[i]);
   }
  
   if (play)
    {  
      int ply1 = 1;
      player1Value[1] = ply1;
      Ply1b = true;
      Ply2b = false;
      a = true;
      Botoesmarcado[1].enabled = false;
      x[1].SetActive(true);
      Botoesmarcado[1].interactable = true;
    }
    else 
    {
     int ply2 = 1;
     player2Value[1] = ply2;
     Ply2b = true;
     Ply1b = false;
     a = false;
     Botoesmarcado[1].enabled = false;
     circulo[1].SetActive(true);
     Botoesmarcado[1].interactable = true;
    }

    for (int i = 0; i < button.Length; i++)
    {
   
    button[1] = true;
   }
     
 }

 public void Btn_2 ()
 {
  
   play = !play;

   if (play)
   {
      int ply1 = 2 ;
      Ply1b = true;
      Ply2b = false;
      a = true;
      player1Value[2] = ply1;
      Botoesmarcado[2].enabled = false;
      x[2].SetActive(true);
      Botoesmarcado[1].interactable = true;
   }
   else 
   { 
     int ply2 = 2;
     Ply2b = true;
     Ply1b = false;
     a = false;
     Botoesmarcado[2].enabled = false;
     player2Value[2] = ply2;
     circulo[2].SetActive(true);
     Botoesmarcado[2].interactable = true;
   }

  for (int i = 0; i < button.Length; i++)
  {
   button[2] = true;
  }
 }

 public void Btn_3 ()
 {
  
   play = !play;

   if (play)
   {
      int ply1 = 3;
      Ply1b = true;
      Ply2b = false;
      a = true;
      player1Value[3] = ply1;
      Botoesmarcado[3].enabled = false;
      x[3].SetActive(true);
      Botoesmarcado[3].interactable = true;
   }
   else 
   {
     int ply2 = 3;
     Ply2b = true;
     Ply1b = false;
     a = false;
     player2Value[3] = ply2;
     Botoesmarcado[3].enabled = false;
     circulo[3].SetActive(true);
     Botoesmarcado[3].interactable = true;
   }
    for (int i = 0; i < button.Length; i++)
  {
   button[3] = true;
  }
 }

 public void Btn_4 ()
 {

   play = !play;

   if (play)
   { 
      int ply1 = 4;
      Ply1b = true;
      Ply2b = false;
      a = true;
      player1Value[4] = ply1;
      Botoesmarcado[4].enabled = false;
      x[4].SetActive(true);
      Botoesmarcado[4].interactable = true;
   }
   else 
   {
     int ply2 = 4;
     Ply2b = true;
     Ply1b = false;
     a = false;
     player2Value[4] = ply2;
     Botoesmarcado[4].enabled = false;
     
     circulo[4].SetActive(true);
     Botoesmarcado[4].interactable = true;
   }

  for (int i = 0; i < button.Length; i++)
  {
    button[4] = true;
  }

 }

 public void Btn_5 ()
 {
    play = !play;

   if (play)
   {
      int ply1 = 5;
      Ply1b = true;
      Ply2b = false;
      a = true;
      player1Value[5] = ply1;
      Botoesmarcado[5].enabled = false;
     
      x[5].SetActive(true);
      Botoesmarcado[5].interactable = true;
   }
   else 
   {
      int ply2 = 5;
      Ply2b = true;
      Ply1b = false;
      a = false;
      player2Value[5] = ply2;
      Botoesmarcado[5].enabled = false;
      circulo[5].SetActive(true);
      Botoesmarcado[5].interactable = true;
   }

   for (int i = 0; i < button.Length; i++)
  {
   button[5] = true;
  }

 }

 public void Btn_6 ()
 {
   play = !play;

   if (play)
   {
      int ply1 = 6;
      Ply1b = true;
      a = true;
      Ply2b = false;
      player1Value[6] = ply1;
      Botoesmarcado[6].enabled = false;
      x[6].SetActive(true);
      Botoesmarcado[6].interactable = true;
   }
   else 
   {
     int ply2 = 6;
     Ply2b = true;
     Ply1b = false;
     a = false;
     player2Value[6] = ply2;
     Botoesmarcado[6].enabled = false;
     
     circulo[6].SetActive(true);
     Botoesmarcado[6].interactable = true;
   }

   for (int i = 0; i < button.Length; i++)
  {
   button[6] = true;
  }

 }

 public void Btn_7 ()
 { 
    play = !play;

   if (play)
   {
      int ply1 = 7;
      Ply1b = true;
      Ply2b = false;
      a = true;
      player1Value[7] = ply1;
      Botoesmarcado[7].enabled = false;
      x[7].SetActive(true);
      Botoesmarcado[7].interactable = true;
   }
   else 
   { 
     int ply2 = 7;
     Ply2b = true;
     a = false;
     Ply1b = false;
     player2Value[7] = ply2;
     Botoesmarcado[7].enabled = false;
     circulo[7].SetActive(true);
     Botoesmarcado[7].interactable = true;
   }

    for (int i = 0; i < button.Length; i++)
  {
   button[7] = true;
  }


 }

 public void Btn_8 ()
 {
    play = !play;

   if (play)
   {
      int ply1 = 8;
      Ply1b = true;
      Ply2b = false;
      a = true;
      player1Value[8] = ply1;
      Botoesmarcado[8].enabled = false;
     
      x[8].SetActive(true);
      Botoesmarcado[8].interactable = true;
   }
   else 
   {
     int ply2 = 9;
     Ply2b = true;
     Ply1b = false;
     a = false;
     player2Value[8] = ply2;
     Botoesmarcado[8].enabled = false;
    
     circulo[8].SetActive(true);
     Botoesmarcado[8].interactable = true;
   }

   for (int i = 0; i < button.Length; i++)
  {
   button[8] = true;
  }

 }

}