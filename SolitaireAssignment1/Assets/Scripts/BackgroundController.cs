﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameController.Controller.PlayFromDiscardFlag = false;
        GameController.Controller.PlayFromPileFlag = false;
        Debug.Log("Clear");
    }
}
