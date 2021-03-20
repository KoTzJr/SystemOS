using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Criar_conta : MonoBehaviour {
     
  [SerializeField] private Text txt_aviso_u_s;   
  [SerializeField] private Text text_precisa_criar_conta;
  [SerializeField] public InputField[] Nova_Nomes;  
  [SerializeField] public InputField[] Nova_Senha; 
  [SerializeField] private InputField[] Confirmar_senha; 
  [SerializeField] private Text text_aviso;
  public static bool conta_existe;
  public static int valor_existe;
  public static string N_Nomes;
  public static bool nao_quero_criar_minha_conta;
  public static int valor_sem_conta;
  public static string N_senha;
  bool Clicou_Botão;
  bool nome_senha_iguais;


    private void Start() 
    {
      Cursor.visible = true;
      text_aviso.gameObject.SetActive(false);
      nao_quero_criar_minha_conta = false;
      this.txt_aviso_u_s.gameObject.SetActive(false);
      this.text_precisa_criar_conta.gameObject.SetActive(false);
    }
     
   private void Update() 
   {
      valor_existe = conta_existe.GetHashCode();
      valor_sem_conta = nao_quero_criar_minha_conta.GetHashCode();
      Salvar_dados_nomes();  
      Salvar_dados_senha(); 
   }

    public void Botão_crie ()
  {
      Clicou_Botão = true;

      if (Nova_Nomes[0].text == Nova_Senha[0].text)
       {  
          nome_senha_iguais = true;
          this.txt_aviso_u_s.gameObject.SetActive(true);
          this.text_aviso.gameObject.SetActive(true);
          this.text_precisa_criar_conta.gameObject.SetActive(false);
       }
       else
       {
          nome_senha_iguais = false; 
          this.txt_aviso_u_s.gameObject.SetActive(false);
          this.text_precisa_criar_conta.gameObject.SetActive(false);
       }

     if (Nova_Nomes[0].text == "" || Nova_Senha[0].text == "" || Confirmar_senha[0].text == "")
     {
        //Debug.Log("preciasr criar a conta");
        Clicou_Botão = false;
        this.text_aviso.gameObject.SetActive(false);
        this.txt_aviso_u_s.gameObject.SetActive(false);
        this.text_precisa_criar_conta.gameObject.SetActive(true);
     }

      if (Clicou_Botão)
      {
        text_aviso.gameObject.SetActive(false);

       foreach (InputField senha in Nova_Senha)
       {
           foreach (InputField confirmar_senha in Confirmar_senha)
        {
           if (nome_senha_iguais == false)
          {
            if (senha.text == confirmar_senha.text)
            {
              SceneManager.LoadScene(2);
              conta_existe = true;
              Salvar_existe();
              N_Nomes = Nova_Nomes[0].text;
              N_senha = Nova_Senha[0].text;
            } 
            else
            { 
            conta_existe = false;
            text_aviso.gameObject.SetActive(true);
            senha.text = "";
            confirmar_senha.text = "";
            }  
          }
        }
      } 
    }
  }  
  
   #region // salvar os nomes as senhas
    public void Salvar_dados_nomes ()
    {
        PlayerPrefs.SetString("N_Nomes",N_Nomes);
        PlayerPrefs.Save();
    }

    public void Salvar_dados_senha ()
    {
        PlayerPrefs.SetString("N_senha", N_senha);
        PlayerPrefs.Save();
        
    }

    public static void Carregar_dados_nomes_senha ()
    {    
       N_Nomes = PlayerPrefs.GetString("N_Nomes",N_Nomes);
       N_senha = PlayerPrefs.GetString("N_senha", N_senha);
    }
   
   #endregion

   #region // salvar ao existe nesse da conta =====
   public void Salvar_existe ()
   {
        PlayerPrefs.SetInt("conta_existe",conta_existe.GetHashCode());
        PlayerPrefs.Save();
   }

   public static void Carregar_conta_existe ()
   {
        valor_existe = PlayerPrefs.GetInt("conta_existe",conta_existe.GetHashCode());
   }

  #endregion
}


