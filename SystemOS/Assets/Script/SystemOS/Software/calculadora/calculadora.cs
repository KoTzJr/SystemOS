using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;
public class calculadora : MonoBehaviour {
     
     
     [SerializeField] private Text resultado;
     [SerializeField] private Text Mostrasoma;
     [SerializeField] private Text[] TxTNumeroscaract;
     public Image[] Calculadora;

    private void Start() 
     {
        resultado.text = ""; 
        Mostrasoma.text = "";
        
       foreach (Image c in Calculadora)
       { 
         foreach (Text t in TxTNumeroscaract)
         {
            c.enabled = false;
            t.enabled = false;
         }
          
       }

     }
     
     public void Btn_close (){
        
        foreach (Image c in Calculadora)
        { 
          foreach (Text t in TxTNumeroscaract)
          {
            t.enabled = false;
            c.enabled = false;
            Btn_removerAll();
          }
        }
     }
      
    public static bool click_c;
    public static bool b_soltar;
    public void Btn_abrir ()
     {
       
        if (b_soltar == false)
        {
            foreach (Image c in Calculadora)
            {
                TxtNumber();
                c.enabled = !c.enabled;
                click_c = c.enabled;
            }

        }
        
    }

    public void TxtNumber (){
      foreach (Text t in TxTNumeroscaract)
      {
         if (click_c == true)
         {
           t.enabled = true;
         }
         else 
         {
           t.enabled = false;
         }
      }
    }

  #region //  Os botoes 0 ate 9 ========================================================================================================
     public void Btn_0 ()
     {
      int zero = 0;
      resultado.text += zero.ToString();
     }

     public void btn_1 ()
     {
      int um = 1;
      resultado.text += um.ToString();
     }

     public void btn_2 ()
     {
      int dois = 2;
      resultado.text += dois.ToString();
     }

     public void btn_3 ()
     {
      int treis = 3;
      resultado.text += treis.ToString();

     }

     public void btn_4 ()
     {
       int quatro = 4;
       resultado.text += quatro.ToString();
     }

     public void btn_5 ()
     {
       int cinco = 5;
       resultado.text += cinco.ToString();
     }

     public void btn_6 ()
     {
       int seis = 6;
       resultado.text += seis.ToString();
     }

     public void Btn_7 (){
       int sente = 7;
       resultado.text += sente.ToString();
     }

     public void Btn_8 ()
     {
       int oito = 8;
       resultado.text += oito.ToString();
     }

     public void Btn_9 ()
     {
       int nove = 9;
       resultado.text += nove.ToString();
     }
     
   #endregion   

   
  
  // mostrar somar =====================================================================================================================
  public void MostrarSomar ()
  {
  
     if (b_MostresomarMais == true ) 
   {
    
     switch (intr.Count)
     {   
       
            case 2 :
              this.Mostrasoma.text = $"{intr[0]} + {intr[1]}";
               break;
             case 3:
              this.Mostrasoma.text = $"{intr[0]} + {intr[1]} + {intr[2]}";
                break;
              case 4: 
              this.Mostrasoma.text = $"{intr[0]} + {intr[1]} + {intr[2]} + {intr[3]}";
                break;
              case 5:
                this.Mostrasoma.text = $"{intr[0]} + {intr[1]} + {intr[2]} + {intr[3]} + {intr[4]}";
                break;
              case 6 :
                this.Mostrasoma.text = $"{intr[0]} + {intr[1]} + {intr[2]} + {intr[3]} + {intr[4]} + {intr[5]}";
                break;
              case 7 : 
                this.Mostrasoma.text = $"{intr[0]} + {intr[1]} + {intr[2]} + {intr[3]} + {intr[4]} + {intr[5]} + {intr[6]}";
                break;
              case 8 : 
                this.Mostrasoma.text = $"{intr[0]} + {intr[1]} + {intr[2]} + {intr[3]} + {intr[4]} + {intr[5]} + {intr[6]} + {intr[7]}";
                break;
              case 9 :
                this.Mostrasoma.text = $"{intr[0]} + {intr[1]} + {intr[2]} + {intr[3]} + {intr[4]} + {intr[5]} + {intr[6]} + {intr[7]} + {intr[8]}";
                break;
              case 10 :
                this.Mostrasoma.text = $"{intr[0]} + {intr[1]} + {intr[2]} + {intr[3]} + {intr[4]} + {intr[5]} + {intr[6]} + {intr[7]} + {intr[8]} + {intr[9]}";
                break;
      }
   }


   if (b_MostresomaMenos == true)
   {
            switch (intr.Count)
            {
                case 2:
                    this.Mostrasoma.text = $"{intr[0]} - {intr[1]}";
                    break;
                case 3:
                    this.Mostrasoma.text = $"{intr[0]} -  {intr[1]} - {intr[2]}";
                    break;
                case 4:
                    this.Mostrasoma.text = $"{intr[0]} - {intr[1]} - {intr[2]} - {intr[3]}";
                    break;
                case 5:
                    this.Mostrasoma.text = $"{intr[0]}  - {intr[1]} - {intr[2]}  - {intr[3]} - {intr[4]}";
                    break;
            }
        }

    if (b_mostresomamultiplicação == true)
    {
        switch (intr.Count)
        {

           case 2:
                    this.Mostrasoma.text = $"{intr[0]} x {intr[1]}";
                    break;
                case 3:
                    this.Mostrasoma.text = $"{intr[0]} x  {intr[1]} x {intr[2]}";
                    break;
                case 4:
                    this.Mostrasoma.text = $"{intr[0]} x {intr[1]} x {intr[2]} x {intr[3]}";
                    break;
                case 5:
                    this.Mostrasoma.text = $"{intr[0]}  x {intr[1]} x {intr[2]} x {intr[3]} x {intr[4]}";
                    break;
        }
    }


    if (b_divisao == true)
    {
      switch (intr.Count)
        {

           case 2:
                    this.Mostrasoma.text = $"{intr[0]} ÷ {intr[1]}";
                    break;
                case 3:
                    this.Mostrasoma.text = $"{intr[0]} ÷  {intr[1]} ÷ {intr[2]}";
                    break;
                case 4:
                    this.Mostrasoma.text = $"{intr[0]} ÷ {intr[1]} ÷ {intr[2]} ÷ {intr[3]}";
                    break;
                case 5:
                    this.Mostrasoma.text = $"{intr[0]} ÷ {intr[1]} ÷ {intr[2]} ÷ {intr[3]} ÷ {intr[4]}";
                    break;
        }
    }    

        
  }

 
  // Botões mais ou menos , divisão , igual , multiplicação =========================================================================================================
    
   public void Btn_igual ()
  {
     SomarMais();
     SomarMenos();
     Somardivisao();
     Somarmultiplicação();
    this.resultado.text = resposta.ToString($"{resposta.ToString(".")}");

    
  } 
  
   public List<int> intr = new List<int>();
   public int resposta;
   public int tr;
   
   // As condições clicou algumas dos botões 
   bool Clicoumais;
   bool Clicoumenos;
   bool ClicouDivisão;
   bool clicoumultiplicação;


   bool b_MostresomarMais;
   bool b_MostresomaMenos;
   bool b_mostresomamultiplicação;
   bool b_divisao;


    public void Btn_mais ()  // botão mais
   {  
      Clicoumais = true;
      b_MostresomarMais = true;
     
      Clicoumenos = false;
      b_MostresomaMenos = false;

      var n = resultado.text;
      tr = Convert.ToInt32(resultado.text);
      intr.Add(tr);
      this.Mostrasoma.text = tr.ToString();
      MostrarSomar();
      Debug.Log(intr.Count);
      resultado.text = "";  
   }

   public void Btn_menos () // botão de menos
   {
      Clicoumenos = true;
      b_MostresomaMenos = true;
      Clicoumais = false;
      b_MostresomarMais = false;
      
      var n = resultado.text;
      tr = Convert.ToInt32(resultado.text);
      intr.Add(tr);
      this.Mostrasoma.text = tr.ToString();
      MostrarSomar();
      resultado.text = "";  
   }


   public void Btn_multiplicação ()
   {
        clicoumultiplicação = true;
        b_mostresomamultiplicação = true;

        b_MostresomaMenos = false;
        b_MostresomarMais = false;
        Clicoumais = false;
        Clicoumenos = false;

        var n = resultado.text;
        tr = Convert.ToInt32(resultado.text);
        intr.Add(tr);
        this.Mostrasoma.text = tr.ToString();
        MostrarSomar();
        resultado.text = "";  
    }


    public void Btn_divisão (){

        ClicouDivisão = true;
        b_divisao = true;

        clicoumultiplicação = false;
        b_mostresomamultiplicação = false;
        b_MostresomaMenos = false;
        b_MostresomarMais = false;
        Clicoumais = false;
        Clicoumenos = false;

        var n = resultado.text;
        tr = Convert.ToInt32(resultado.text);
        intr.Add(tr);
        this.Mostrasoma.text = tr.ToString();
        MostrarSomar();
        resultado.text = "";  

    }

   // Btn remover ou remover full ==================================================================================================================================================
   public void Btn_removerAll (){  // Btn clearall
     
      this.resultado.text = "";
      this.Mostrasoma.text = "";
      resposta = 0;
      tr = 0;
      intr.Clear();
   }

   // Somar mais ou menos ==============================================================================================================================================================

 #region Somar mais
  public void SomarMais ()
  {
    
    if (Clicoumais == true) 
   {
    
    switch (intr.Count)
            {
                case 2:
                    resposta = intr[0] += intr[1];
                    break;
                case 3:
                    resposta = intr[0] += intr[1] += intr[2];
                    break;
                case 4:
                    resposta = intr[0] += intr[1] += intr[2] += intr[3];
                    break;
                case 5:
                      resposta = intr[0] += intr[1] += intr[2] += intr[3] += intr[4];
                    break;
                case 6 :
                      resposta = intr[0] += intr[1] += intr[2] += intr[3] += intr[4] += intr[5];
                    break;
                case 7 :
                      resposta = intr[0] += intr[1] += intr[2] += intr[3] += intr[4] += intr[5] += intr[6];
                    break;
                case 8:
                      resposta = intr[0] += intr[1] += intr[2] += intr[3] += intr[4] += intr[5] += intr[6] += intr[7];
                    break;
                case 9:
                      resposta = intr[0] += intr[1] += intr[2] += intr[3] += intr[4] += intr[5] += intr[6] += intr[7] += intr[8];
                    break;
                case 10:
                    resposta = intr[0] += intr[1] += intr[2] += intr[3] += intr[4] += intr[5] += intr[6] += intr[7] += intr[8] += intr[9]; 
                    break;
                default:
                    Btn_removerAll();
                    break;
            }
    
   }
 
  } 
  #endregion

 #region  // somar menos 
  public void SomarMenos()
  { 
    if (Clicoumenos == true)
    {
            switch (intr.Count)
            {
                case 2:
                    resposta = intr[0] -= intr[1];
                    break;
                case 3:
                    resposta = intr[0] -= intr[1] -= intr[2];
                    break;
                case 4:
                    resposta = intr[0] -= intr[1] -= intr[2] -= intr[3];
                    break;
                case 5:
                      resposta = intr[0] -= intr[1] -= intr[2] -= intr[3] -= intr[4];
                    break;
                case 6 :
                      resposta = intr[0] -= intr[1] -= intr[2] -= intr[3] -= intr[4] -= intr[5];
                    break;
                case 7 :
                      resposta = intr[0] -= intr[1] -= intr[2] -= intr[3] -= intr[4] -= intr[5] -= intr[6];
                    break;
                case 8:
                      resposta = intr[0] -= intr[1] -= intr[2] -= intr[3] -= intr[4] -= intr[5] -= intr[6] -= intr[7];
                    break;
                case 9:
                      resposta = intr[0] -= intr[1] -= intr[2] -= intr[3] -= intr[4] -= intr[5] -= intr[6] -= intr[7] -= intr[8];
                    break;
                case 10:
                    resposta = intr[0] -= intr[1] -= intr[2] -= intr[3] -= intr[4] -= intr[5] -= intr[6] -= intr[7] -= intr[8] -= intr[9]; 
                    break;
                default:
                    Btn_removerAll();
                    break;
            }

        }
  
  }
#endregion
  public void Somarmultiplicação ()
  {
      if (clicoumultiplicação == true)
      {
         switch (intr.Count)
            {
                case 2:
                    resposta = intr[0] *= intr[1];
                    break;
                case 3:
                    resposta = intr[0] *= intr[1] *= intr[2];
                    break;
                case 4:
                    resposta = intr[0] *= intr[1] *= intr[2] *= intr[3];
                    break;
                case 5:
                      resposta = intr[0] *= intr[1] *= intr[2] *= intr[3] *= intr[4];
                    break;
                case 6 :
                      resposta = intr[0] *= intr[1] *= intr[2] *= intr[3] *= intr[4] *= intr[5];
                    break;
                case 7 :
                      resposta = intr[0] *= intr[1] *= intr[2] *= intr[3] *= intr[4] *= intr[5] *= intr[6];
                    break;
                case 8:
                      resposta = intr[0] *= intr[1] *= intr[2] *= intr[3] *= intr[4] *= intr[5] *= intr[6] *= intr[7];
                    break;
                case 9:
                      resposta = intr[0] *= intr[1] *= intr[2] *= intr[3] *= intr[4] *= intr[5] *= intr[6] *= intr[7] *= intr[8];
                    break;
                case 10:
                    resposta = intr[0] *= intr[1] *= intr[2] *= intr[3] *= intr[4] *= intr[5] *= intr[6] *= intr[7] *= intr[8] *= intr[9]; 
                    break;
                default:
                    Btn_removerAll();
                    break;
            }

      } 
  }

  public void Somardivisao (){
     
     if (ClicouDivisão == true){
        switch (intr.Count)
            {
                case 2:
                    resposta = intr[0] /= intr[1];
                    break;
                case 3:
                    resposta = intr[0] /= intr[1] /= intr[2];
                    break;
                case 4:
                    resposta = intr[0] /= intr[1] /= intr[2] /= intr[3];
                    break;
                case 5:
                      resposta = intr[0] /= intr[1] /= intr[2] /= intr[3] /= intr[4];
                    break;
                case 6 :
                      resposta = intr[0] /= intr[1] /= intr[2] /= intr[3] /= intr[4] /= intr[5];
                    break;
                case 7 :
                      resposta = intr[0] /= intr[1] /= intr[2] /= intr[3] /= intr[4] /= intr[5] /= intr[6];
                    break;
                case 8:
                      resposta = intr[0] /= intr[1] /= intr[2] /= intr[3] /= intr[4] /= intr[5] /= intr[6] /= intr[7];
                    break;
                case 9:
                      resposta = intr[0] /= intr[1] /= intr[2] /= intr[3] /= intr[4] /= intr[5] /= intr[6] /= intr[7] /= intr[8];
                    break;
                case 10:
                    resposta = intr[0] /= intr[1] /= intr[2] /= intr[3] /= intr[4] /= intr[5] /= intr[6] /= intr[7] /= intr[8] /= intr[9]; 
                    break;
                default:
                    Btn_removerAll();
                    break;
            }

     }


  }

}

