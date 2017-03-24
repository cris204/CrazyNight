using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Contadores : MonoBehaviour {


    public Text nivel11;
    public Text nivel22;
    public Text nivel33;
    public Text nivel44;


    void Start()
    {
        
    }
    void Update()
    {

     


        nivel11.text = "player 1:  " + Movimiento.nivel_alcohol[0].ToString();
        nivel22.text = "player 2:  " + Movimiento.nivel_alcohol[1].ToString();
        nivel33.text = "player 3:  " + Movimiento.nivel_alcohol[2].ToString();
        nivel44.text = "player 4:  " + Movimiento.nivel_alcohol[3].ToString();
    }

   

}
