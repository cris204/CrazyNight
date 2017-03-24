using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movimiento : MonoBehaviour
{
    public static bool niveldealcohol = false;

    int c = 0;
    int final = 0;
   
    public GameObject pass;
    bool activar = false;
    public static bool pass_bool=false;
    public static bool nope_bool=false;
    public GameObject nope;

    [SerializeField]
    private GameObject reiniciar;

    [SerializeField]
    private GameObject Particulas;


    [SerializeField]
    private GameObject Ganadores;

    public static bool tirar = false;

    private float tiempodesaparecer;



    [SerializeField]
    private Vector3 PosicionPLayer;
  

    [SerializeField]
    private Vector3 EscalaPLayer;

    public static bool[] mujeres = new bool[4];
    

    [SerializeField]
    private GameObject Tatto;
    [SerializeField]
    private GameObject Tatto2;
    [SerializeField]
    private GameObject Tatto3;
    [SerializeField]
    private GameObject Tatto4;

    [SerializeField]
    private GameObject[] tatuajes = new GameObject[10];

    [SerializeField]
    private GameObject[] softdrinks = new GameObject[2];

    [SerializeField]
    private int[] softdrinks_lvl = new int[2];

    string card = "";

    [SerializeField]
    private GameObject[] rounds = new GameObject[1];

    [SerializeField]
    private int[] rounds_lvl = new int[1];

    [SerializeField]
    private GameObject[] shots = new GameObject[4];

    
    public static GameObject[] rostro = new GameObject[4];

    [SerializeField]
    private int[] shots_lvl = new int[4];

    [SerializeField]
    private GameObject seguir;

    [SerializeField]
    private GameObject TurnoDe;

    [SerializeField]
    public static  int[] nivel_alcohol = new int[4];

    public static int clicks = 0;

    private int posicion = 0;

    public static int posiciondado;

    public static bool finish = false;

    int rndRetos;
    [SerializeField]
    private GameObject[] retos = new GameObject[2];

    [SerializeField]
    private GameObject tablero;

    [SerializeField]
    private GameObject Player1;

   [SerializeField]
    private GameObject Player2;

    [SerializeField]
    private GameObject Player3;

    [SerializeField]
    private GameObject Player4;

    
    public static float tiempo;

    public static bool Animacion=false;

    int rndsoft;
    int rndshots;
    int rndrounds;

    int i = 0;

    [SerializeField]
    private AudioSource Win;

    [SerializeField]
    private AudioSource Lose;

    Vector3[] Arrayposition = new Vector3[36];

    [SerializeField]
    private GameObject compartir;

    void Awake()
    {
        finish = false;
        Ganadores.SetActive( false);
           posiciondado = 0;
        tirar = true;
        Evento_cambioJugador.tiempo = 0f;
        GetComponent<Movimiento>().enabled = false;
        clicks = 0;
        activar = false;
        TurnoDe.SetActive(true);
        Particulas.SetActive(false);
        reiniciar.SetActive(false);
            c = 0;
        final = 0;
        for (int x = 0; x < 4; x++)
        {
            nivel_alcohol[x] = 0;
        }


            rostro = ImageTurn.caras;

        Tatto.transform.parent = Movimiento.rostro[0].transform;
        Tatto.transform.localPosition = Vector3.zero;

        Tatto2.transform.parent = Movimiento.rostro[1].transform;
        Tatto2.transform.localPosition = Vector3.zero;

        Tatto3.transform.parent = Movimiento.rostro[2].transform;
        Tatto3.transform.localPosition = Vector3.zero;

        Tatto4.transform.parent = Movimiento.rostro[3].transform;
        Tatto4.transform.localPosition = Vector3.zero;

    
        for (int x = 0; x < 4; x++)
        {
            rostro[x].SetActive(true);
            if(rostro[x]== GameObject.Find("Hombre1_0"))
            {
                mujeres[x] = false;
            }
            if (rostro[x] == GameObject.Find("Hombre2_0"))
            {
                mujeres[x] = false;
            }
            if (rostro[x] == GameObject.Find("Hombre3_0"))
            {
                mujeres[x] = false;
            }
            if (rostro[x] == GameObject.Find("Mujer1_0"))
            {
                mujeres[x] = true;
            }
            if (rostro[x] == GameObject.Find("Mujer2_0"))
            {
                mujeres[x] = true;
            }
            if (rostro[x] == GameObject.Find("Mujer3_0"))
            {
                mujeres[x] = true;
            }
            if (rostro[x] == GameObject.Find("Mujer4_0"))
            {
                mujeres[x] = true;
            }
           
        }



        pass.SetActive(false);
        nope.SetActive(false);
      
         TurnoDe.SetActive(true);


        rostro[0].transform.position = new Vector3(-5.2f, 13.88f, 0f);
        rostro[0].transform.localScale = new Vector3(1.207589f, 1.207589f, 1.207589f);

        rostro[1].transform.position = new Vector3(7.16f, 13.8f, 0f);
        rostro[1].transform.localScale = new Vector3(1.207589f, 1.207589f, 1.207589f);

        rostro[2].transform.position = new Vector3(-5.66f, 1.2f, 0f);
        rostro[2].transform.localScale = new Vector3(1.207589f, 1.207589f, 1.207589f);

        rostro[3].transform.position = new Vector3(5.9f, 1.2f, 0f);
        rostro[3].transform.localScale = new Vector3(1.207589f, 1.207589f, 1.207589f);


       
    


  




        Win.Stop();
        Lose.Stop();


    }

    void OnEnable()
    {
        compartir.SetActive(false);
        Particulas.SetActive(true);
        reiniciar.SetActive(false);
        Oscurecer();

      

        tirar = false;
        //Ruleta.girar.SetInteger("Numero",0);
        posiciondado = 0;
        tiempodesaparecer = 0;
        tiempo =0;
        Animacion = true;
        niveldealcohol = false;
        i = 0;
        nope_bool = false;
        pass_bool = false;
        pass.SetActive(false);
        nope.SetActive(false);
        TurnoDe.SetActive(true);

        PosicionPLayer = rostro[Evento_cambioJugador.Turn].transform.position;
        EscalaPLayer = rostro[Evento_cambioJugador.Turn].transform.localScale;

        rostro[Evento_cambioJugador.Turn].transform.position = new Vector3(0.43f, 6.65f, 0);
        rostro[Evento_cambioJugador.Turn].transform.localScale= new Vector3(2.671528f, 2.671528f, 0);

        clicks = 0;
        activar = false;
        Evento_cambioJugador.tiempo = 0f;
        GameObject.FindObjectOfType<Evento_cambioJugador>().turnos += Update;
        

        rndRetos = Random.Range(0, 6);
            retos[rndRetos].SetActive(false);


        Win.Stop();
        Lose.Stop();
     


    }

    void Start()
    {
        

        Arrayposition[0] = new Vector3(-10.3119f, 11.380f, 0f);

        Arrayposition[1] = new Vector3(-9.86f, 8.39f, 0f);
        Arrayposition[2] = new Vector3(-9.8f, 6.34f, 0f);
        Arrayposition[3] = new Vector3(-9.66f, 3.86f, 0f);
        Arrayposition[4] = new Vector3(-8.54f, 1.86f, 0f);
        Arrayposition[5] = new Vector3(-7.26f, 3.54f, 0f);
        Arrayposition[6] = new Vector3(-6.54f, 5.69f, 0f);
        Arrayposition[7] = new Vector3(-6.2f, 8.18f, 0f);
        Arrayposition[8] = new Vector3(-5.76f, 10.45f, 0f);
        Arrayposition[9] = new Vector3(-4.02f, 9.05f, 0f);
        Arrayposition[10] = new Vector3(-4f, 6.65f, 0f);
        Arrayposition[11] = new Vector3(-3.43f, 4.53f, 0f);
        Arrayposition[12] = new Vector3(-2.62f, 2.41f, 0f);
        Arrayposition[13] = new Vector3(-1.6f, 4.19f, 0f);
        Arrayposition[14] = new Vector3(-0.9f, 6.71f, 0f);
        Arrayposition[15] = new Vector3(-0.89f, 9.11f, 0f);
        Arrayposition[16] = new Vector3(0.29f, 10.86f, 0f);
        Arrayposition[17] = new Vector3(1.57f, 8.96f, 0f);
        Arrayposition[18] = new Vector3(1.82f, 6.72f, 0f);
        Arrayposition[19] = new Vector3(2.20f, 4.32f, 0f);
        Arrayposition[20] = new Vector3(3.53f, 2.51f, 0f);
        Arrayposition[21] = new Vector3(4.37f, 4.41f, 0f);
        Arrayposition[22] = new Vector3(4.84f, 6.47f, 0f);
        Arrayposition[23] = new Vector3(5.12f, 8.93f, 0f);
        Arrayposition[24] = new Vector3(6.74f, 11.17f, 0f);
        Arrayposition[25] = new Vector3(7.36f, 9.11f, 0f);
        Arrayposition[26] = new Vector3(8.2f, 6.81f, 0f);
        Arrayposition[27] = new Vector3(8.73f, 4.57f, 0f);
        Arrayposition[28] = new Vector3(8.82f, 2.48f, 0f);
        Arrayposition[29] = new Vector3(8.82f, 2.48f, 0f);
        Arrayposition[31] = new Vector3(8.82f, 2.48f, 0f);
        Arrayposition[32] = new Vector3(8.82f, 2.48f, 0f);
        Arrayposition[33] = new Vector3(8.82f, 2.48f, 0f);
        Arrayposition[34] = new Vector3(8.82f, 2.48f, 0f);
        Arrayposition[35] = new Vector3(8.82f, 2.48f, 0f);
        Arrayposition[36] = new Vector3(8.82f, 2.48f, 0f);
        Arrayposition[37] = new Vector3(8.82f, 2.48f, 0f);
        Arrayposition[38] = new Vector3(8.82f, 2.48f, 0f);
        Arrayposition[39] = new Vector3(8.82f, 2.48f, 0f);
        Arrayposition[40] = new Vector3(8.82f, 2.48f, 0f);


    }


    void Update()

    {
        tiempo = tiempo + 1 * Time.deltaTime;
       

        Alcoholimetro();


       
        if (i < 1)
        {
            pass.SetActive(false);
            nope.SetActive(false);
            retos[rndRetos].SetActive(false);
            i++;
           
        }

        if (Evento_cambioJugador.tiempo > 1.5f) // si tiempo es mayor que 1 quita las imagenes de los rostros
        {
         

            Evento_cambioJugador.lanzar_image = false;
              //rostro[Evento_cambioJugador.Turn].SetActive(false);//Volver a escalar
            if (!finish)
            {
                rostro[Evento_cambioJugador.Turn].transform.position = PosicionPLayer;
                rostro[Evento_cambioJugador.Turn].transform.localScale = EscalaPLayer;
            }
            TurnoDe.SetActive(false);

            if(i==1)
            {
                
                pass.SetActive(true);
                nope.SetActive(true);
                retos[rndRetos].SetActive(true);
                i++;
               
            }


            
            if ( pass_bool) 
            {
                if (clicks < 1 || clicks ==1)// si los clicks son menores a 1 juega
                {


                    pass_bool = true;
                    if (Input.GetButtonDown("Fire1") && clicks<1)
                    {

                        clicks += 1;




                        posiciondado = Random.Range(1, 7);
                        
                        posicion = posicion +posiciondado;

                    }
                  
                       
                        if (Animacion == true || clicks==2)
                        {
                        
                        tiempodesaparecer = tiempodesaparecer + 1 * Time.deltaTime;
                        if (tiempodesaparecer > 6f) // falta un bool
                        {
                            if (transform.position.x < Arrayposition[posicion].x)//posicion
                            {
                                tirar = true;
                                

                                gameObject.transform.position = Vector3.Lerp(transform.position, Arrayposition[posicion], Time.deltaTime * 4000);

                            }
                        }


                    }

                }
            }
        }
        if (niveldealcohol)
        {
            OnMouseDown();
        }
    }

  

    void OnTriggerEnter2D(Collider2D personaje)
    {
        
        switch (personaje.tag )
        {
            case "SoftDrink":
                card = "SoftDrink";
                break;
            case "Rounds":
                card = "Rounds";
                break;
            case "Shots":
                card = "Shots";
                break;
            case "finish":
               

                card = "finish";
                break;
        }
        StopAllCoroutines();
        StartCoroutine(ApareceCarta(card));

    }
 
    IEnumerator ApareceCarta(string carta)
    {

           yield return new WaitForSeconds(2f);
        if (carta .Equals("SoftDrink"))
        {
            Oscurecer();

            

            rndsoft = Random.Range(0, 1);
            softdrinks[rndsoft].SetActive(true);
            seguir.SetActive(true);
            nivel_alcohol[Evento_cambioJugador.Turn] += softdrinks_lvl[rndsoft];

          if(  nivel_alcohol[Evento_cambioJugador.Turn] < 0)
            {
                nivel_alcohol[Evento_cambioJugador.Turn] = 0;

            }

//            niveldealcohol = true;
        }

        if (carta.Equals ("Rounds"))
        {
            Oscurecer(); 

               

            rndrounds = Random.Range(0, 7);
            rounds[rndrounds].SetActive(true);
            seguir.SetActive(true);

            if (rndrounds == 0)
            {
               
                for(int x = 0; x < 4; x++)
                {
                    if (!mujeres[x])
                    {
                        nivel_alcohol[x] += rounds_lvl[0];
                    }
                }
            }
            if (rndrounds == 1)
            {
                for (int x = 0; x < 4; x++)
                {
                    nivel_alcohol[x] += rounds_lvl[1];
                }
                nivel_alcohol[Evento_cambioJugador.Turn] -= rounds_lvl[1];
            }
            if (rndrounds == 2 || rndrounds ==4 || rndrounds==5)
            {
                for (int x = 0; x < 4; x++)
                {
                    nivel_alcohol[x] += rounds_lvl[1];
                }
            }
                  
           
            if (rndrounds == 6)
            {
                for (int x = 0; x < 4; x++)
                {
                    if (mujeres[x])
                    {
                        nivel_alcohol[x] += rounds_lvl[0];
                    }
                }
            }
            
            }

        if (carta.Equals ("Shots"))
        {
            Oscurecer();

            

            rndshots =   Random.Range(0, 5); // Random.Range(0, 6);
            shots[rndshots].SetActive(true);//rndshots
            seguir.SetActive(true);
            if (rndshots == 3)
            {
                if (Evento_cambioJugador.Turn == 0)
                {
                    nivel_alcohol[3] += shots_lvl[rndshots];
                }
                if (Evento_cambioJugador.Turn == 1)
                {
                    nivel_alcohol[0] += shots_lvl[rndshots];
                }
                if (Evento_cambioJugador.Turn == 2)
                {
                    nivel_alcohol[1] += shots_lvl[rndshots];
                }
                if (Evento_cambioJugador.Turn == 3)
                {
                    nivel_alcohol[2] += shots_lvl[rndshots];
                }
                
            }
            else
            {

                nivel_alcohol[Evento_cambioJugador.Turn] += shots_lvl[rndshots];
            }
          
                

            
          //  niveldealcohol = true;
        }
        if (carta.Equals ("finish"))
        {
            Oscurecer();
  
            compartir.SetActive(true);

            Ganadores.SetActive(true);
            reiniciar.SetActive(true);

           
            finish = true;
            rostro[Evento_cambioJugador.Turn].transform.position = new Vector3(3.55f, 6.65f, 0f);
            rostro[Evento_cambioJugador.Turn].transform.localScale = new Vector3(2.320831f, 2.320831f, 0f);
           
           
                for (c = 0; c < 4; c++)
                {
                if (final == 0)
                {
                    if (nivel_alcohol[c] <= nivel_alcohol[0] && nivel_alcohol[c] <= nivel_alcohol[1] && nivel_alcohol[c] <= nivel_alcohol[2] && nivel_alcohol[c] <= nivel_alcohol[3])
                    {
                        rostro[c].transform.position = new Vector3(-6.03f, 6.65f, 0f);
                        rostro[c].transform.localScale = new Vector3(2.320831f, 2.320831f, 0f);
                        final++;
                    }
                    else
                    {
                        rostro[c].SetActive(false);
                    }

                  
                }

            }
            Evento_cambioJugador.click = 0;
            rostro[Evento_cambioJugador.Turn].SetActive(true);

            // niveldealcohol = true;
        }
     
    }

   public  void OnMouseDown()
    {
        softdrinks[rndsoft].SetActive(false);
        rounds[rndrounds].SetActive(false);
        shots[rndshots].SetActive(false);
        seguir.SetActive(false);

   
        Evento_cambioJugador.termino_turno = true;
 
        clicks = 1;
        niveldealcohol = true;
        
        Evento_cambioJugador.lanzar_image = true;
        Evento_cambioJugador.click = 0;

  
    }

    public void Pass()
    {
   

        Win.Play();
        
        pass.SetActive(false);
        nope.SetActive(false);
        retos[rndRetos].SetActive(false);
        activar = true;
        if (activar )
        {
        
            pass_bool = true;
        }

    }
    public void Nope()
    {
   

        Lose.Play();
        nope_bool = true;
        pass.SetActive(false);
        nope.SetActive(false);
        retos[rndRetos].SetActive(false);
        

      
    }
    void OnDisable()
    {
        Particulas.SetActive(false);
    }
    void Alcoholimetro()
    {
        if (nivel_alcohol[Evento_cambioJugador.Turn] == 0)
        {
            //   rostro[Evento_cambioJugador.Turn].GetComponent<Animator>().SetInteger("Caras", 0);
        }

        if (nivel_alcohol[Evento_cambioJugador.Turn] >= 1)
        {


            tatuajes[0].SetActive(true);

        }

        if (nivel_alcohol[Evento_cambioJugador.Turn] >= 2)
        {
            tatuajes[1].SetActive(true);

        }

        if (nivel_alcohol[Evento_cambioJugador.Turn] >= 3)
        {
            tatuajes[2].SetActive(true);

        }

        if (nivel_alcohol[Evento_cambioJugador.Turn] >= 4)
        {
            tatuajes[3].SetActive(true);
        }

        if (nivel_alcohol[Evento_cambioJugador.Turn] >= 5)
        {
            rostro[Evento_cambioJugador.Turn].GetComponent<Animator>().SetInteger("Caras", 1);
            tatuajes[4].SetActive(true);
        }

        if (nivel_alcohol[Evento_cambioJugador.Turn] >= 6)
        {
            tatuajes[5].SetActive(true);
        }

        if (nivel_alcohol[Evento_cambioJugador.Turn] >= 7)
        {
            tatuajes[6].SetActive(true);
        }

        if (nivel_alcohol[Evento_cambioJugador.Turn] >= 8)
        {
            tatuajes[7].SetActive(true);
        }

        if (nivel_alcohol[Evento_cambioJugador.Turn] >= 9)
        {
            rostro[Evento_cambioJugador.Turn].GetComponent<Animator>().SetInteger("Caras", 2);
            tatuajes[8].SetActive(true);
        }

        if (nivel_alcohol[Evento_cambioJugador.Turn] >= 10)
        {
            tatuajes[9].SetActive(true);
        }

        
    }
    void Oscurecer()
    {
        
        tablero.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.3f);
        Player1.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.3f);
        Player2.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.3f);
        Player3.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.3f);
        Player4.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.3f);
    }
}
    

   

