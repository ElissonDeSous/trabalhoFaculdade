using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoMenu : MonoBehaviour
{
      public string nomeDaCena;
      public void Play(){
         SceneManager.LoadScene(nomeDaCena);
   }

   public void sair(){
       Application.Quit();
   }
}
