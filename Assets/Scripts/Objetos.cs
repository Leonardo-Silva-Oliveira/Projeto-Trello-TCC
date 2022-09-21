using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Objetos : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform ArmarioConsertado;
    void OnTriggerEnter(Collider colisao){
        if(colisao.gameObject.tag == "Conserto"){
            consertado();
        }
    }
    public void consertado(){
        Destroy (gameObject);
        Instantiate(ArmarioConsertado, transform.position, transform.rotation);
    }
}
