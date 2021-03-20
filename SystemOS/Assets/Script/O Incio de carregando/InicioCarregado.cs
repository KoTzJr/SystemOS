using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class InicioCarregado : MonoBehaviour
{
    
   [SerializeField] private Slider sl;
   float Tempo; 
   int valor;

  private void Start() 
  {
      Tempo = Random.Range(1.5f,9.1f);
      valor = Random.Range(10,30);
      Criar_conta.Carregar_conta_existe();
      escolha_sem_com.Carregar_dados();
      Cursor.visible = false;
  }
  private void Update() 
  {
     Carregado();
     StartCoroutine("Tempo_carregado");
  }

 IEnumerator Tempo_carregado (){
   
     yield return new WaitForSeconds(Tempo);
    
     if (sl.value == 100 || sl.value >= 100)
     {      
         if (Criar_conta.valor_existe == 1)
         {
             SceneManager.LoadScene(2);
         }
         else
         {
             SceneManager.LoadScene(4);
         }
         escolha_sem_conta();
         sem_conta();
     } 
 }

 public void Carregado ()
 {
      sl.value += Time.deltaTime * valor;
      StartCoroutine("Tempo_carregado");
 }

 public void sem_conta (){
     
    if (Criar_conta.valor_sem_conta == 1 || Criar_conta.valor_sem_conta >= 1)
    {
        SceneManager.LoadScene(3);
    }
 }


 public void escolha_sem_conta ()
 {
     
      if (escolha_sem_com.int_sem_Conta == 1)
     {
         SceneManager.LoadScene(3);
     }
 }
 
}
