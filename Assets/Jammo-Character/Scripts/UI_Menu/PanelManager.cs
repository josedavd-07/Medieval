using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{
    public GameObject panelMenuPrincipal;
    public GameObject panelOpciones;

    // Método para mostrar el panel de opciones
    public void MostrarOpciones()
    {
        panelMenuPrincipal.SetActive(false);
        panelOpciones.SetActive(true);
    }

    // Método para volver al menú principal
    public void VolverAlMenu()
    {
        panelOpciones.SetActive(false);
        panelMenuPrincipal.SetActive(true);
    }
}
