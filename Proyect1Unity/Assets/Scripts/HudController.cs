using UnityEngine;

using UnityEngine.Events;
using TMPro;

public class HudController : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI miTexto;
    [SerializeField] public UnityEvent OnTextCondition;

    public void ActualizarTexto(string textoActualizado) {
        miTexto.text = "Vidas " + textoActualizado;
    }


}
