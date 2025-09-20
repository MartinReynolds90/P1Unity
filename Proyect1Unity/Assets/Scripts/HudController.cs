using TMPro;
using UnityEngine;

public class VidasManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textoVida;

    private int cantidadVida;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cantidadVida = 0;
    }

    // Update is called once per frame
    public void ModificarVidas()
    {
        cantidadVida--;
        textoVida.text = "" + cantidadVida;
    }
}
