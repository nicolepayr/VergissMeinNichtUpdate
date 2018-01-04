﻿using UnityEngine;
using System.Collections;

public class LookAtList : MonoBehaviour, ILookAtHandler
{

    public void OnLookatEnter()
    {
        this.GetComponent<Renderer>().material.color = Color.white;
    }

    public void OnLookatExit()
    {
        this.GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void OnLookatInteraction()
    {
        Debug.Log("Interaction!");
    }
}