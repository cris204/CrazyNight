using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EscogerPersonaje : MonoBehaviour {
    [SerializeField]
    private AudioSource click;
    

    [SerializeField]
    private Button[] personajes = new Button[7];
    [SerializeField]
    private GameObject cargando;

    private  bool boton0 = true;
    private bool boton1 = true;
    private bool boton2 = true;
    private bool boton3 = true;
    private bool boton4 = true;
    private bool boton5 = true;
    private bool boton6 = true;

    int Eligieron=0;

    public  GameObject[] imagesPlayer = new GameObject[4];

    [SerializeField]
    private GameObject[] Turno = new GameObject[4];

    int i=0;
        int posicion = 0;
    void Enable()
    {
        cargando.SetActive(false);
        Turno[0].SetActive(false);
        Turno[1].SetActive(false);
        Turno[2].SetActive(false);
        Turno[3].SetActive(false);
    }

        // Use this for initialization
        void Awake()
    {
        click.Stop();
        cargando.SetActive(false);
        Turno[0].SetActive(false);
        Turno[1].SetActive(false);
        Turno[2].SetActive(false);
        Turno[3].SetActive(false);
    }

    void Start()
    {
        Eligieron = 0;
     
    }
    void Update()
    {

        if (Eligieron == 4)
        { for (int x = 0; x < 7; x++) {
                personajes[x].enabled = false;
                }
    GameObject.Find("Hombre1_0").SetActive(false);
            GameObject.Find("Hombre2_0").SetActive(false);
            GameObject.Find("Hombre3_0").SetActive(false);
            GameObject.Find("Mujer1_0").SetActive(false);
            GameObject.Find("Mujer4_0").SetActive(false);
            GameObject.Find("Mujer3_0").SetActive(false);
            GameObject.Find("Mujer2_0").SetActive(false);
            cargando.SetActive(true);
            SceneManager.LoadSceneAsync("Game");
           
        }

        if (ImageTurn.caras[0] == null)// && imagesPlayer[1] == null && imagesPlayer[2] == null && imagesPlayer[3] == null
        {
            Turno[0].SetActive(true);
         
        }

        if (ImageTurn.caras[0] != null && ImageTurn.caras[1] == null)//&& imagesPlayer[2] == null && imagesPlayer[3] == null
        {
            Turno[0].SetActive(false);
            Turno[1].SetActive(true);
            
        }

        if (ImageTurn.caras[0] != null && ImageTurn.caras[1] != null && ImageTurn.caras[2] == null)//&& imagesPlayer[3] == null
        {
            Turno[0].SetActive(false);
            Turno[1].SetActive(false);
            Turno[2].SetActive(true);
            
        }

        if (ImageTurn.caras[0] != null && ImageTurn.caras[1] != null && ImageTurn.caras[2] != null && ImageTurn.caras[3] == null)
        {
            Turno[0].SetActive(false);
            Turno[1].SetActive(false);
            Turno[2].SetActive(false);
            Turno[3].SetActive(true);
 
        }

    }
	
   public void OnMouseDown()
    {
        personajes[0].enabled = false;
        personajes[0].image.color = new Color(1f, 1f, 1f, .5f);
        if (boton0)
        {
            boton0 = false;
            Eligieron += 1;
            

        }
        click.Play();
        for ( i=posicion; i < 4; i++)
        {
          
            if (imagesPlayer[i] == null)
            {

                ImageTurn.caras[i] = GameObject.Find("Hombre1_0");//

                if (ImageTurn.caras[i] == GameObject.Find("Hombre1_0"))
                {
                    posicion++;
              

                }
          

                        


                break;
            }
          
           
        }

        

    }


    public void OnMouseDown1()
    {
        personajes[1].enabled = false;

        personajes[1].image.color = new Color(1f, 1f, 1f, .5f);
        if (boton1)
        {
            boton1 = false;
            Eligieron += 1;
        }
        click.Play();
        for ( i = posicion; i < 4; i++)
        {
           
            if (imagesPlayer[i] == null)
            {
                ImageTurn.caras[i] = GameObject.Find("Hombre2_0");//

                if (ImageTurn.caras[i] == GameObject.Find("Hombre2_0"))
                {
                    posicion++;
                
                }

                break;
            }
        }
    }


    public void OnMouseDown2()
    {
        personajes[2].enabled = false;

        personajes[2].image.color = new Color(1f, 1f, 1f, .5f);
        if (boton2)
        {
          
            boton2 = false;
            Eligieron += 1;
        }
        click.Play();
        for ( i = posicion; i < 4; i++)
        {
         
            if (imagesPlayer[i] == null)
            {
                ImageTurn.caras[i] = GameObject.Find("Hombre3_0");//
                if (ImageTurn.caras[i] == GameObject.Find("Hombre3_0"))
                {
                    posicion++;
                  
                }
                break;
            }
        }
    }


    public void OnMouseDown3()
    {
        personajes[3].enabled = false;

        personajes[3].image.color = new Color(1f, 1f, 1f, .5f);
        if (boton3)
        {
            boton3 = false;
               Eligieron += 1;
        }
        click.Play();
        for ( i = posicion; i < 4; i++)
        {
           
            if (imagesPlayer[i] == null)
            {
                ImageTurn.caras[i] = GameObject.Find("Mujer1_0");//
                if (ImageTurn.caras[i] == GameObject.Find("Mujer1_0"))
                {
                    posicion++;
               
                }
                break;
            }
        }
    }


    public void OnMouseDown4()
    {
        personajes[4].enabled = false;

        personajes[4].image.color = new Color(1f, 1f, 1f, .5f);
        if (boton4)
        {

            boton4 = false;
            Eligieron += 1;
        }
        click.Play();
        for ( i = posicion; i < 4; i++)
        {
           
            if (imagesPlayer[i] == null)
            {
                ImageTurn.caras[i] = GameObject.Find("Mujer4_0");//
                if (ImageTurn.caras[i] == GameObject.Find("Mujer4_0"))
                {
                    posicion++;
                
                }
                break;
            }
        }
    }


    public void OnMouseDown5()
    {
        personajes[5].enabled = false;

        personajes[5].image.color = new Color(1f, 1f, 1f, .5f);
        if (boton5)
        {
            boton5 = false;
            Eligieron += 1;
        }
        click.Play();
        for ( i = posicion; i < 4; i++)
        {
      
            if (imagesPlayer[i] == null)
            {
                ImageTurn.caras[i] = GameObject.Find("Mujer3_0");//
                if (ImageTurn.caras[i] == GameObject.Find("Mujer3_0"))
                {
                    posicion++;
           
                }
                break;
            }
        }
    }


    public void OnMouseDown6()
    {

        personajes[6].enabled = false;

        personajes[6].image.color = new Color(1f, 1f, 1f, .5f);
        if (boton6)
        {
            boton6 = false;
            Eligieron += 1;
        }
        click.Play();
        for ( i = posicion; i < 4; i++)
        {
          
            if (imagesPlayer[i] == null)
            {
                ImageTurn.caras[i] = GameObject.Find("Mujer2_0");//

                if (ImageTurn.caras[i] == GameObject.Find("Mujer2_0"))
                {
                    posicion++;
          
                    break;
                }

                
            }
        }
    }

}
