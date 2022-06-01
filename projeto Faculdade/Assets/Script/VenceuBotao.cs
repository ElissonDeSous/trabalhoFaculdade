using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VenceuBotao : MonoBehaviour
{
   public string voltarVenceu;

   public void Volta()
   {
       SceneManager.LoadScene(voltarVenceu);
   }
}
