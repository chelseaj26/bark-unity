﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

public class ButtonClick : MonoBehaviour
{
    public GameObject Bowl;

    public void AddObject()
{
    Instantiate(Bowl, transform.position, Quaternion.identity);
}
}

