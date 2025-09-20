using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

public class Herir : MonoBehaviour
{
    //Variables a configurar desde el editor
    [Header("Configuracion")]
    [SerializeField] int puntos = 5;
    public Jugador jugador;
    public HudController hud;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            Jugador jugador = collision.gameObject.GetComponent<Jugador>();
            jugador.ModificarVida(-puntos);
            hud.ActualizarTexto(jugador.GetVidas().ToString());
           
            Debug.Log("PUNTOS DE DAÑO RERALIZADOS  " + puntos);
        }
    }
}
