using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class bloco_nota : MonoBehaviour {
     

    // imagem ======================================================================
    [SerializeField] private Image[] Imagem_bloco_note; // imagem bloco de nota
    // Text =========================================================================
    [SerializeField] private Text txt_input; //  O Text input bloco de nota
    [SerializeField] private Text txt_br_bloco; // barra o bloco de nota 
    // Input flield =================================================================
    [SerializeField] private InputField ip_bloco_nota;  // input note 
    // GameObject ====================================================================
    [SerializeField] private GameObject avisosave_not_save; // mensagem save ou nao save 

    public static bool Soltar_b;

    public List<string> bloco_dados = new List<string>();

    


   private void Start() {
      
      foreach (Image ip in this.Imagem_bloco_note)
      {
          ip.enabled = false;
      }
      avisosave_not_save.SetActive(false);

      txt_br_bloco.enabled = false;
      txt_input.enabled = false;
    }
    
   private void Update() {
       
       
   }


   public void btn_note (){  // clicar ao bloco de nota
       
       bool c;
       
        if (Soltar_b == false)
        {
            foreach (Image ip in this.Imagem_bloco_note)
            {
                ip.enabled = !ip.enabled;

                this.txt_br_bloco.enabled = !txt_br_bloco.enabled;

                c = ip.enabled;

                if (c == false)
                {
                    txt_input.enabled = false;
                }
                else
                {
                    txt_input.enabled = true;

                }
            }

        }
    }

   public void Btn_close ()  // botão fechar bloco de nota
   {  
      if (ip_bloco_nota.text == "")
      {
        avisosave_not_save.SetActive(false);
        this.txt_br_bloco.enabled = false;
       
        foreach (Image img in this.Imagem_bloco_note)
        {
            img.enabled = !img.enabled;
            txt_input.enabled = false;
        }
      } 
      else
      {
        avisosave_not_save.SetActive(true);
      }
   }



   public void Btn_close_aviso ()
   { 
     
     this.avisosave_not_save.SetActive(false);
   }
   

   public void btn_save ()  //  Clicar o Botão de save 
   {
     this.bloco_dados.Add(txt_input.text);
     
     foreach (Image img in Imagem_bloco_note)
     {   
         
     }
   }

   public void btn_notsave () // Clicar o botão de nao save 
   {
     this.avisosave_not_save.SetActive(false);
   }


}