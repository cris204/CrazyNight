using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public delegate void Jugador();

public  class Evento_cambioJugador : MonoBehaviour {

    public static bool termino_turno=true ;
    public static bool lanzar_image=false;
    public static int click=0;
    public static float tiempo;
    public static  int Turn=0;

   



    [SerializeField]
    private GameObject brillo;

    [SerializeField]
    private GameObject P1;

    [SerializeField]
    private GameObject P2;

    [SerializeField]
    private GameObject P3;

    [SerializeField]
    private GameObject P4;


    public static bool paso_o_no = false;
    public int jugando = 0;




    
    public event Jugador turnos;

    [SerializeField]
    private GameObject lanzar;



    [SerializeField]
    private GameObject[] Players=new GameObject[4];

    void Enable()
    {   termino_turno = true;
        lanzar_image = false;
        click = 0;
        Turn = 0;
        jugando = 0;
        paso_o_no = false;
        tiempo = 0;
    }

    void Awake()
    {
        brillo.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.3f);
        P1.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.3f);
        P2.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.3f);
        P3.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.3f);
        P4.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.3f);
        termino_turno = true;
        lanzar_image = false;
        click = 0;
        Turn = 0;
        jugando = 0;
        paso_o_no = false;
        tiempo = 0;
        Movimiento.pass_bool = false;
    }

    void Update () {

       
        if (tiempo <= 3f && click == 0) // sumar el tiempo en el juego
            {
                tiempo = tiempo + 1 * Time.deltaTime;
          
        }


            if (click < 1) // para saber si ya jugo o no contando los clicks
            {



                if (lanzar_image) // si esta disponible el dado activa el script de movimiento
                {
                   
                    Players[jugando].GetComponent<Movimiento>().enabled = true;


                }

            if (!Movimiento.pass_bool)
            {
                

                lanzar.SetActive(false);
                lanzar_image = true;


            }
            else // se habilita el dado y por ende el turno
            {

                if (Movimiento.Animacion && Movimiento.tirar)
               {

                    //Rip codigo
                    
                    if (!Movimiento.finish)
                    {
                        brillo.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
                        P1.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
                        P2.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
                        P3.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
                        P4.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
                    }
                        click += 1;
                    
                    if (Movimiento.tirar)// falta un bool
                    {

                        lanzar.SetActive(false);
                    }
               
                    if (turnos != null)
                    {
                           
                        turnos();

                    }


                   





                
           }
                if (Movimiento.niveldealcohol)    //borrar si se daña
                {
                    Players[jugando].GetComponent<Movimiento>().enabled = false;
                    TurnoDe();


                    turnos = null;

                    
                    click = 0;
                }


            }



            if (Movimiento.nope_bool)
            {
                Players[jugando].GetComponent<Movimiento>().enabled = false;


                TurnoDe();


                turnos = null;
                Movimiento.pass_bool = true;
            }
           


        

            if (click < 1 && Movimiento.pass_bool ) // activar el dado
                {

               
                    lanzar.SetActive(true);
               
            }
          


            }
        
    }

    void  TurnoDe(int Turn)
    {
        jugando = Turn;

        
     
    }

    void TurnoDe()
    {
        Turn =(jugando + 1) % Players.Length;
    
        TurnoDe(Turn);
    }
    




}

