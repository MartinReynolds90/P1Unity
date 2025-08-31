using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSalto : MonoBehaviour
{
    [Header("Configuracion")]
    [SerializeField] private float fuerzaSalto = 5f;

    private Rigidbody2D miRigidbody2D;

    // codigo ejecutado cuando el objeto se activa en el nivel
    private void OnEnable()
    {
        miRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        miRigidbody2D.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
    }
}
