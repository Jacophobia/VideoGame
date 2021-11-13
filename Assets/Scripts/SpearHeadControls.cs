using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearHeadControls : MonoBehaviour
{
    public bool isPiercing = false;
    private Collision2D stabbedGameObject;

    private void Start()
    {
        gameObject.tag = "spearhead";
    }

    public void OnCollisionEnter2D(Collision2D otherObject)
    {
        if (otherObject.gameObject.CompareTag("ground") || otherObject.gameObject.CompareTag("soft-material"))
        {
            isPiercing = true;
            stabbedGameObject = otherObject;
        }
    }

    public void OnCollisionExit2D(Collision2D otherObject)
    {
        if (otherObject.Equals(stabbedGameObject))
        {
            isPiercing = false;
        }
    }
}
