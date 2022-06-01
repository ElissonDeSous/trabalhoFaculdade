using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotaoMorreu : MonoBehaviour
{
    
    public string JogarNovamente;
    
    public string voltaParaMenu;

    public void JogarDeNovo(){
        SceneManager.LoadScene(JogarNovamente);

        
    }
    public void voltarMenu(){
        SceneManager.LoadScene(voltaParaMenu);
    }
}
