using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Minhaconta : MonoBehaviour
{ 
  
  [SerializeField] public InputField Minha_nome;
  [SerializeField] public InputField Minha_senha;
  [SerializeField] private GameObject Olho_aberto;
  [SerializeField] private GameObject Olho_fechado;
  bool correta;
  bool correta_nomes;
  bool correta_senha;
    private void Start() 
    {   
        Cursor.visible = true;
        Criar_conta.Carregar_dados_nomes_senha();
       // print(Criar_conta.N_Nomes);
       // print(Criar_conta.N_senha);
    }

    private void Update() 
    {
       if (Input.GetKey(KeyCode.T)){
          PlayerPrefs.DeleteAll();
       }
    }
  
  #region  /// botao mostrar a senha 
  public void olho_aberto ()
  {
    bool clicou;

    clicou = true;
      
    if (clicou == true)
    {   
       this.Olho_fechado.gameObject.SetActive(false);
       Minha_senha.contentType = InputField.ContentType.Name;
    }else 
    {
      clicou = false;
    }
    
  }

  public void olho_fechado ()
  {
    bool clicou;
    clicou = true;
    
    if (clicou == true)
    { 
      this.Olho_aberto.gameObject.SetActive(true);
      this.Olho_fechado.gameObject.SetActive(false);
      Minha_senha.contentType = InputField.ContentType.Password;
    }
    else
    {
      clicou = false;

    }

  }
  #endregion
  #region 
  public void Botão_entrar ()
  {  
     correta = true;

     if (Minha_nome.text == "" || Minha_senha.text == "")
     {
       correta = false;
     }

    if (correta)
    {
     if (Minha_nome.text == Criar_conta.N_Nomes )
     {
        correta_nomes = true;
     }
     else
     {
        correta_nomes = false;
     }


     if (Minha_senha.text == Criar_conta.N_senha)
     {
       correta_senha = true;
     }
     else
     {
       correta_senha = false;
     }

     if (correta_nomes == true && correta_senha == true )
     {
       SceneManager.LoadScene(3);
     } 
     
    }

  }
#endregion
  

}

