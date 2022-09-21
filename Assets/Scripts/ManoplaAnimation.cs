using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManoplaAnimation : MonoBehaviour
{
    private Animator animar;
    bool isLeftButtonDown;
    // Start is called before the first frame update
    void Start()
    {
        animar = GetComponent<Animator>();
        isLeftButtonDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        isLeftButtonDown = Input.GetMouseButton(0);
        if(isLeftButtonDown){
        animar.Play("GloveAttack");
        }
        else{
        animar.Play("Glove");
        }
    }
}
