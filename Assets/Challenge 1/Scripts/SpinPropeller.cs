using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
Nombre: Victor Andrés Garay Montes
*/
public class SpinProp : MonoBehaviour
{
    // Start is called before the first frame update

    private float  propellorSpeed = 1000;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward,propellorSpeed * Time.deltaTime);
    }
}
