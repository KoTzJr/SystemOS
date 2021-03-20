using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class escolha_sem_com : MonoBehaviour {
     


  public static bool bool_com_Conta;
  public static bool bool_sem_Conta;
  public static int int_conta;
  public static int int_sem_Conta;

    private void Awake() 
    {   
         Cursor.visible = true;
         bool_com_Conta = false;
         bool_sem_Conta = false;
         Carregar_dados();
    }
   
    private void Update() 
    {
         int_conta = bool_com_Conta.GetHashCode();
         int_sem_Conta = bool_sem_Conta.GetHashCode();
         Salvar_Dados();
    }

   public void Clicar_btn_criarconta ()
   {
       bool_com_Conta = true;

       if (bool_com_Conta == true)
       {
          SceneManager.LoadScene(1);
       }
      
       
   }

   public void Clicar_btn_sem_conta ()
   {
       bool_sem_Conta = true;
     
       if (bool_sem_Conta == true)
       {
           SceneManager.LoadScene(3);
       }
      
   }

   public void Salvar_Dados ()
   {
       PlayerPrefs.SetInt("bool_com_Conta",bool_com_Conta.GetHashCode());
       PlayerPrefs.SetInt("bool_sem_Conta",bool_sem_Conta.GetHashCode());
       PlayerPrefs.Save();
   }

   public static void Carregar_dados (){
      
      int_conta = PlayerPrefs.GetInt("bool_com_Conta",bool_com_Conta.GetHashCode());
      int_sem_Conta = PlayerPrefs.GetInt("bool_sem_Conta",bool_sem_Conta.GetHashCode());
   }
}