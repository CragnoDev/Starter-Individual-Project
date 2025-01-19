using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TheEarth : MonoBehaviour
{

    [SerializeField] UnityEvent onTriggerEnter2D;

    void OnTriggerEnter2D(Collider2D other)
    {
        onTriggerEnter2D.Invoke();
    }

}
