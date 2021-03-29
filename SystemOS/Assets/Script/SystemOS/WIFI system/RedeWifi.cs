using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class RedeWifi : MonoBehaviour {


  private void Start()
    {
      NomeRandom();
      ImagemRandom();
      RandomPassword();
      Wificonectado.SetActive(false);

      disconnect0.SetActive(false);
      disconnect1.SetActive(false);
      disconnect2.SetActive(false);
      disconnect3.SetActive(false);

      txtconnect0.enabled = false;
      txtconnect1.enabled = false;
      txtconnect2.enabled = false;
      txtconnect3.enabled = false;
 
      //Debug.Log(pas0);
      Debug.Log(pas3);

        for (int i = 0; i < Placawifi_0.Length; i++)
      {
        for (int i1 = 0; i1 < Placawifi_1.Length; i1++)
        {
            for (int i2 = 0; i2 < Placawifi_2.Length; i2++)
            {
                for (int i3 = 0; i3 < Placawifi_3.Length; i3++)
                {
                        Placawifi_0[i].enabled = false;
                        Placawifi_1[i1].enabled = false;
                        Placawifi_2[i2].enabled = false;
                        Placawifi_3[i3].enabled = false; 
                }
            }
        }
      }

      foreach (Image i in Verficado)
      {
            i.enabled = false;
      }
    }

    private void Update() 
    {
      Disconnect();
    }
    

 // o Wifi de rede dos nomes /======================================================================================
    string[] NomeRedeRandom = { "Issage", "Firo", "Timeric", "Feuan", "Dudir", "Motin","Durci","Wuigen","Oroak"};
    [SerializeField] private Text txt_nomelist_0, txt_nomelist_1,txt_nomelist_2,txt_nomelist_3;
    int nome_0 , nome_1 , nome_2 , nome_3;
    System.Random r = new System.Random();
    public void NomeRandom ()
  {
     for (int i = 0; i < NomeRedeRandom.Length; i++)
     {
            nome_0 = r.Next(0, NomeRedeRandom.Length);
            nome_1 = r.Next(0, NomeRedeRandom.Length);
            nome_2 = r.Next(0, NomeRedeRandom.Length);
            nome_3 = r.Next(0, NomeRedeRandom.Length);

            txt_nomelist_0.text = $"{NomeRedeRandom[nome_0]}";
            txt_nomelist_1.text = $"{NomeRedeRandom[nome_1]}";
            txt_nomelist_2.text = $"{NomeRedeRandom[nome_2]}";
            txt_nomelist_3.text = $"{NomeRedeRandom[nome_3]}";
     }
  }



    // Random Password ========================================================================================================


    string[] Password = { "up2GEB", "kErwfR","CcMp17","uzfuy7","noiqoo","teigmp","insuqn","tznqat"};
    int passaword_0, passaword_1, passaword_2, passaword_3;


    string pas0, pas1, pas2, pas3;

    public void RandomPassword ()
    {
       for (int i = 0; i < Password.Length; i++)
       {
            passaword_0 = r.Next(0, Password.Length);
            passaword_1 = r.Next(0, Password.Length);
            passaword_2 = r.Next(0, Password.Length);
            passaword_3 = r.Next(0, Password.Length);

            pas0 = $"{Password[passaword_0]}";
            pas1 = $"{Password[passaword_1]}";
            pas2 = $"{Password[passaword_2]}";
            pas3 = $"{Password[passaword_3]}";
        }
    }


    // Random Imagem da list wifi ==============================================================================================
    [SerializeField] private Sprite[] SinalrandomWifi;
    [SerializeField] private Image imglist0,imglist1,imglist2,imglist3;
    int img0 , img1 , img2 ,img3;
    public void ImagemRandom ()
    {
        for (int i = 0; i < SinalrandomWifi.Length; i++)
        {
            img0 = r.Next(0, SinalrandomWifi.Length);
            img1 = r.Next(0, SinalrandomWifi.Length);
            img2 = r.Next(0, SinalrandomWifi.Length);
            img3 = r.Next(0, SinalrandomWifi.Length);

            imglist0.sprite = SinalrandomWifi[img0];
            imglist1.sprite = SinalrandomWifi[img1];
            imglist2.sprite = SinalrandomWifi[img2];
            imglist3.sprite = SinalrandomWifi[img3];
        }
    }

    //==========================================Clicar dos botões lista rede =========================================================================================   


    bool os,os1,os2,os3;
    bool clickbtn0, clickbtn1, clickbtn2, clickbtn3;
    [SerializeField] private Image[] Placawifi_0 , Placawifi_1,Placawifi_2,Placawifi_3;
    [SerializeField] private Text namerede0,namerede1,namerede2,namerede3;

    [SerializeField] private Text txtconnect0, txtconnect1 , txtconnect2 , txtconnect3;
    public void btnlist0 ()
    {
        os = Convert.ToBoolean(img0);

        if (os)
        {
          for (int i = 0; i < Placawifi_0.Length; i++)
          {
                Placawifi_0[i].enabled = !Placawifi_0[i].enabled;
                clickbtn0 = true;
                clickbtn1 = false;
                clickbtn2 = false;
                clickbtn3 = false;
          }
        }
        else 
        {
            StartCoroutine("Tempoconectar");
        }

        for (int i = 0; i < Placawifi_0.Length; i++)
        {
            if (Placawifi_0[i].enabled == true)
            {
               namerede0.text = $"{NomeRedeRandom[nome_0]}";
               namerede0.enabled = true;
               txtconnect0.enabled = true;
            }
            else 
            {
              namerede0.enabled = false;
              txtconnect0.enabled = false;
            }

        }
         
    }

    public void btnlist1 ()
    {
        os1 = Convert.ToBoolean(img1);
       
        if (os1)
       {
         for (int i = 0; i < Placawifi_1.Length; i++)
         {
            Placawifi_1[i].enabled = !Placawifi_1[i].enabled;  
            clickbtn1 = true;
            clickbtn0 = false;
            clickbtn2 = false;
            clickbtn3 = false;
         }
       }
       else 
       {
            StartCoroutine("Tempoconectar");
       }

       for (int i = 0; i < Placawifi_1.Length; i++)
       {
           if (Placawifi_1[i].enabled == true)
           {
             namerede1.text = $"{NomeRedeRandom[nome_1]}";
             txtconnect1.enabled = true;
             namerede1.enabled = true;
           }
           else 
           {  
              txtconnect1.enabled = false;
              namerede1.enabled = false;
           }
       }
    }
    public void btnlist2 ()
    {

       os2 = Convert.ToBoolean(img2);
        
        if (os2)
      {
         for (int i = 0; i < Placawifi_2.Length; i++)
         {
           Placawifi_2[i].enabled = !Placawifi_2[i].enabled;  
           clickbtn2 = true;
           clickbtn0 = false;
           clickbtn1 = false;
           clickbtn3 = false;   
         }
      }
      else 
      {
         StartCoroutine("Tempoconectar");
      }

      for (int i = 0; i <Placawifi_2.Length; i++)
      {
          if (Placawifi_2[i].enabled == true)
          {
             namerede2.text = $"{NomeRedeRandom[nome_2]}";
             txtconnect2.enabled = true;
             namerede2.enabled = true;
          }
          else 
          {
            txtconnect2.enabled = false;
            namerede2.enabled = false;
          }
      }
    }

    public void btnlist3 ()
    {
       os3 = Convert.ToBoolean(img3);
       
        if (os3)
       {
          for (int i = 0; i < Placawifi_3.Length; i++)
          {
              Placawifi_3[i].enabled = !Placawifi_3[i].enabled;
              clickbtn3 = true;
              clickbtn2 = false;
              clickbtn1 = false;
              clickbtn0 = false;
          }
       }

       for (int i = 0; i < Placawifi_3.Length; i++)
       {
          if (Placawifi_3[i].enabled == true)
          {
             namerede3.text = $"{NomeRedeRandom[nome_3]}";
             namerede3.enabled = true;
             txtconnect3.enabled = true;
          }
          else
          {
            namerede3.enabled = false;
            txtconnect3.enabled = false;
          }  
       }
    }

    //=============================================================================================================================

    public void btnconectado ()
    {
        StartCoroutine("Tempoconectar");
    }

    //==================================================================================================================================
    IEnumerator Tempoconectar()
    {
        print("connect....");
        yield return new WaitForSeconds(5f);
        comsenharede();
    }
  
    public static bool isconnect;

    [SerializeField] private InputField ip0, ip1, ip2, ip3;
    [SerializeField] private GameObject Wificonectado;
    [SerializeField] private GameObject WifiDesconectado;
    [SerializeField] private Image[] Verficado;
    public void comsenharede ()
    {
       if ( clickbtn0 && ip0.text == pas0)
       {
         for (int i = 0; i < Verficado.Length; i++)
         {
            Verficado[0].enabled = true;
            Wificonectado.SetActive(true);
            WifiDesconectado.SetActive(false);
            disc0 = true;
            disc1 = false;
            disc2 = false;
            disc3 = false;
            isconnect = true;
         }
       }


        if (clickbtn1 && ip1.text == pas1)
       {
          for (int i = 0; i < Verficado.Length; i++)
         {
            Verficado[1].enabled = true;
            Wificonectado.SetActive(true);
            WifiDesconectado.SetActive(false);
            disc1 = true;
            disc2 = false;
            disc3 = false;
            disc0 = false;
            isconnect = true;
         }
       }

       if (clickbtn2 && ip2.text == pas2)
       {
          for (int i = 0; i < Verficado.Length; i++)
         {
            Verficado[2].enabled = true;
            Wificonectado.SetActive(true);
            WifiDesconectado.SetActive(false);
            disc2 = true;
            disc0 = false;
            disc3 = false;
            disc1 = false;
            isconnect = true;
         }
   
       }

       if (clickbtn3 && ip3.text == pas3)
       {
           for (int i = 0; i < Verficado.Length; i++)
         {
            Verficado[3].enabled = true;
            Wificonectado.SetActive(true);
            WifiDesconectado.SetActive(false); 
            disc3 = true;
            disc0 = false;
            disc2 = false;
            disc1 = false;
            isconnect = true;
         }
       }
    }
 ///======================================================================================================================
   
    [SerializeField] private GameObject disconnect0 , disconnect1, disconnect2, disconnect3;

    bool disc0 , disc1, disc2, disc3;
    public void Disconnect ()
    {
        if (disc0)
        {
           disconnect0.SetActive(true);
           for (int i = 0; i < Placawifi_0.Length; i++)
            {
                Placawifi_3[i].enabled = false;
            }
        }
        else if (disc1)
        {
           disconnect1.SetActive(true);
           for (int i = 0; i < Placawifi_1.Length; i++)
            {
                Placawifi_3[i].enabled = false;
            }
        } 
        else if (disc2)
        {
           disconnect2.SetActive(true);
           for (int i = 0; i < Placawifi_2.Length; i++)
            {
                Placawifi_3[i].enabled = false;
            }
        } 
        else if (disc3)
        {
            disconnect3.SetActive(true);
            for (int i = 0; i < Placawifi_3.Length; i++)
            {
                Placawifi_3[i].enabled = false;
            }
        }
    }

 
 //=========================================================================================================================
  public void Btn_disconnect0 ()
  {
     WifiDesconectado.SetActive(true);
     Verficado[0].enabled = false;
     isconnect = false;
     disc0 = false;
     disconnect0.SetActive(false);
     Wificonectado.SetActive(false);
  }

  public void Btn_disconnect1 ()
  {
     WifiDesconectado.SetActive(true);
     Verficado[1].enabled = false;
     isconnect = false;
     disc1 = false;
     disconnect1.SetActive(false);
     Wificonectado.SetActive(false);
  }

  public void Btn_disconnect2 ()
  { 
     WifiDesconectado.SetActive(true);
     Verficado[2].enabled = false;
     disc2 = false;
     disconnect2.SetActive(false);
     Wificonectado.SetActive(false);
     ip2.text = "";
     isconnect = false;
  }

  public void Btn_disconnect3 ()
  {
     WifiDesconectado.SetActive(true);
     Wificonectado.SetActive(false);
     disc3 = false;
     disconnect3.SetActive(false);
     Verficado[3].enabled = false;
     ip3.text = "";
     isconnect = false;
  }
  
   
}