using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	void Update()
    {
        
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 750.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 40.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        //Vector3 pos = transform.position;
        //pos.x = Mathf.Clamp(pos.x + x, -50, 50);
        
        //pos.z = Mathf.Clamp(pos.z + z, -50, 50);
        //transform.position = pos;
        //transform.Translate(pos);

        //rigidbody.transform.Translate(Vector3(0, yMove, 0));

        /*
        var pos : Vector3 = transform.position;
        pos.x = Mathf.Clamp(pos.x + horizontal, -7, 7);
        pos.y = Mathf.Clamp(pos.y + vertical, -7, 7);
        transform.position = pos;
        

        
        */


    }
}
