using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Iniciar : MonoBehaviour {


    [SerializeField] private Image abrir_iniciar;

      

     private void Start() 
     {
       abrir_iniciar.enabled = false;
     }



    private void Update() 
    {
     
    }

    
    public void clicar_iniciar ()
    {
        abrir_iniciar.enabled = !abrir_iniciar.enabled;
    }


    public void Btn_reiniciar ()
    {
      SceneManager.LoadScene(0);
    }

    public void Btn_desligar ()
    {
         Application.Quit();
    }



}

