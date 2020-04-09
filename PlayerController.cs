using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _moX;
    private float _moZ;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moX = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        _moZ = Input.GetAxisRaw("Vertical") * Time.deltaTime;

    }
}
