﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour {


    private void OnMouseDown()
    {
        Destroy(gameObject);
        Time.timeScale = 0;
    }
}
