using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarteloAnimacao : MonoBehaviour
{
    Animator animacao;
    bool isLeftButtonDown;
    // Start is called before the first frame update
    void Start()
    {
        animacao = GetComponent<Animator>();
        isLeftButtonDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        isLeftButtonDown = Input.GetMouseButton(0);
        if(isLeftButtonDown){
        animacao.Play("HammerAttack");
        }
        else{
        animacao.Play("Hammer");
        }
    }
}
