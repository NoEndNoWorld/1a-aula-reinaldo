using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigosAndando  : MonoBehaviour
{


    public bool right;
    public float limitR, limitL;
    // Start is called before the first frame update
    void Start()
    {
        right = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (right)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += new Vector3(0.005f, 0, 0);
            if (transform.position.x > limitR)
            {
                right = false;
            }
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.position -= new Vector3(0.005f, 0, 0);

            if (transform.position.x < limitL)
            {
                right = true;
            }
        }
    }
}
