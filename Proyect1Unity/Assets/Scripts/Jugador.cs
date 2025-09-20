using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Jugador : MonoBehaviour
{
    [Header("Configuracion")]
    [SerializeField] private float vida = 5f;
    [SerializeField] private UnityEvent OnDetenerMovimiento;
    [SerializeField] private UnityEvent<string> OnTextFin;

    public void ModificarVida(float puntos)
    {
        vida += puntos;
        Debug.Log(EstasVivo());
        if (EstasVivo() == false) {
            OnDetenerMovimiento.Invoke();
            OnTextFin.Invoke("GAME OVER");
        }
    }


    private bool EstasVivo()
    {
        return vida > 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Meta")) { return; }
        OnDetenerMovimiento.Invoke();
        OnTextFin.Invoke("GANASTE");
        Debug.Log("GANASTE");
    }
}
