using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Animator))]
public class Ruleta : MonoBehaviour {


    [SerializeField]
    private int ruleta;
   
    public static Animator girar;
    void OnEnable()
    {
        girar.SetInteger("Numero", 0);
        
    }

	// Use this for initialization
	void Awake () {
        girar = GetComponent<Animator>();
        girar.SetInteger("Numero", 0);
    }
    	void Start()
    {
        girar = GetComponent<Animator>();
        girar.SetInteger("Numero", 0);
    }

    // Update is called once per frame
    void Update () {
        
            ruleta = Movimiento.posiciondado;
        


        if (ruleta == 1) {
            girar.SetInteger("Numero", 1);
            
           // girar.SetInteger("Numero", 0);
            //    ruleta = 7;
        }
        if (ruleta == 2) {
            girar.SetInteger("Numero", 2);
            
           // girar.SetInteger("Numero", 0);
            // ruleta = 7;
        }
        if (ruleta == 3) {
            girar.SetInteger("Numero", 3);
            
           // girar.SetInteger("Numero", 0);
            //  ruleta = 7;
        }
        if (ruleta == 4) {
            girar.SetInteger("Numero", 4);
            
         //   girar.SetInteger("Numero", 0);
            // ruleta = 7;
        }
        if (ruleta == 5) {
            girar.SetInteger("Numero", 5);
            
           // girar.SetInteger("Numero", 0);
            // ruleta = 7;
        }
        if (ruleta == 6) {
            girar.SetInteger("Numero", 6);
            
          //  girar.SetInteger("Numero", 0);
            // ruleta = 7;
        }
        if (ruleta == 0)
        {
            girar.SetInteger("Numero", 0);
            
            //  girar.SetInteger("Numero", 0);
            // ruleta = 7;
        }



    }
}
