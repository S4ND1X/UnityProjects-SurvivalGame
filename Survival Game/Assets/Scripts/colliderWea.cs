using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class colliderWea : MonoBehaviour
{  
   
    private void OnCollisionEnter(Collision collision)
    {
        //Si colisiona con el objeto con el nombre Wea
        if(collision.gameObject.name =="Wea")
        {
            //Se destruye el objeto tocado.

            Destroy(collision.gameObject);
        }
    }
}
