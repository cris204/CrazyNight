using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ImageTurn : MonoBehaviour {

    public static GameObject[] caras = new GameObject[4];
    public static bool[] mujeres = new bool[4];

    public static ImageTurn instance = null;

   void Awake()
   {
       DontDestroyOnLoad(this.gameObject);

       if (instance == null)
           instance = this;

       else if (instance != this)
           Destroy(gameObject);
   }

	void Update () {
       
    }

 
}
