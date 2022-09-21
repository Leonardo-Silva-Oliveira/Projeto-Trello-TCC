using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilRelogio : MonoBehaviour
{

    void OnTriggerEnter(Collider arrumar){
        if(arrumar.gameObject.tag == "Objeto"){
            Destroy(gameObject);
        }
    }
}
