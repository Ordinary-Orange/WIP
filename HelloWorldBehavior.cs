using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorldBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Hello world!");
        Cursor.lockState = CursorLockMode.Locked;
        print("Hah, messed up your cursor");
        print("Now you have to alt f4");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
