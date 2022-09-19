using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetos : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform ArmarioConsertado;
    void OnCollisionEnter(Collision colisao){
        if(colisao.gameObject.tag == "Conserto"){
            Destroy (gameObject);
            Instantiate(ArmarioConsertado, transform.position, transform.rotation);
        }
    }
}
