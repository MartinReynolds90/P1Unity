using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Jugador : MonoBehaviour
{
    [Header("Configuracion")]
    [SerializeField] private int vida = 5;
    [SerializeField] private UnityEvent OnDetenerMovimiento;
    [SerializeField] private UnityEvent<string> OnTextFin;

    public void ModificarVida(int puntos)
    {
        vida += puntos;
        Debug.Log(EstasVivo());
        OnTextFin.Invoke("vid" + vida);
        if (EstasVivo() == false) {
            OnDetenerMovimiento.Invoke();
            OnTextFin.Invoke("GAME OVER");
        }
    }

    public int GetVidas() {
        return vida;
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
