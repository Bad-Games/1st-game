using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinController : MonoBehaviour
{
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        scoreManager.ScoreManager.RaiseScore(1);
        Destroy(transform.parent.gameObject);
    }
}
