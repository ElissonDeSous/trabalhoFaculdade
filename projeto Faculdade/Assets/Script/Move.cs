using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D rig;
    public Animator animAnda;
    

    public float vel;
    public float Forcapulo;
    public bool EstaPulando;

    // Update is called once per frame
    void Update()
    {
       Pulo();
        movi();

         
    }
    void movi()
    {
          
         float Movimento = Input.GetAxis("Horizontal");
          rig.velocity = new Vector2(Movimento*vel, rig.velocity.y);


            if(Movimento > 0)
            {
                     animAnda.SetBool("Andar",true);
            }else{
                animAnda.SetBool("Andar",false);
            }
        if(Movimento > 0)
        {
            transform.eulerAngles = new Vector2(0,0);
            
        }
        if(Movimento < 0)
        {
            transform.eulerAngles = new Vector2(0,180);
            
            animAnda.SetBool("Andar1",true);
            
        }else{
            animAnda.SetBool("Andar1",false);
        }
    }
    void Pulo()
    {
      if(Input.GetKey(KeyCode.Space)&& !EstaPulando){
       rig.AddForce(Vector2.up*Forcapulo,ForceMode2D.Impulse);
      }
    }
}
