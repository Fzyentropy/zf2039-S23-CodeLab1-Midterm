using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            GameManager.gameObjectArrayForDetect--;     // Destory Indicator
            Destroy(col.gameObject);
        }
    }
}
