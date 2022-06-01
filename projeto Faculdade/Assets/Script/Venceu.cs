using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Venceu : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D Col)
      {
             if(Col.gameObject.CompareTag("Player"))
             {
                 SceneManager.LoadScene("vencer");
             }
       }
}
