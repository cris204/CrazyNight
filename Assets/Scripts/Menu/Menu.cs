using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
      
	}

    public void Jugar()
    {
        SceneManager.LoadScene("Instrucciones");
      
    }

    public void Opciones()
    {
        SceneManager.LoadScene("Opciones");
    }
    public void Creditos()
    {
        SceneManager.LoadScene("creditos");
    }
    public void menu()
    {
        SceneManager.LoadScene("Inicio");
    }
    public void Escoger()
    {
        SceneManager.LoadScene("Escoger_Avatar");
    }
    public void InicioRestar()
    {

          for (int x = 0; x < 4; x++)
        {
            Movimiento.nivel_alcohol[x].ToString();
            ImageTurn.caras[x].SetActive(false);

        }
        Destroy(GameObject.Find("Jugadores"));

        SceneManager.LoadScene("Inicio");
    }
    public void Salir()
    {
        Application.Quit();
    }
}
