using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{

    Vector3 mov;
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 5.0f;
    public float sensitivityVert = 5.0f;
    public float minimumVert = -45.0f;
    public float maximumVert = 45.0f;
    private float _rotationX = 0;
    // Start is called before the first frame update
    public enum RotationAxes{
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    void Start()
    {
        mov.x = 0.0f;
        mov.y = 0.0f;
        mov.z = 0.0f;
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
            body.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
			mov.x = 0.02f;
			movimento(mov);
			mov.x = 0.0f;
        }  
        if (Input.GetKey(KeyCode.A)) {

			mov.x = -0.02f;
			movimento(mov);
			mov.x = 0.0f;

		}  
        if (Input.GetKey (KeyCode.S)) {
			mov.z = -0.02f;
			movimento(mov);
			mov.z = 0.0f;
		}  
        if (Input.GetKey (KeyCode.W)) {
			mov.z = 0.02f;
			movimento(mov);
            mov.z = 0.0f;
		}
        
        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        else
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }  
    }
    void movimento(Vector3 mov){
        transform.Translate(mov);
    }
}
