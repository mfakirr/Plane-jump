using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class planecode : MonoBehaviour
{
    public Transform startpoint;
    public float speed, risingspeed,mesafe, tutucu2;
    public int score, tutucu,restartt=0;
    // Start is called before the first frame update
    public GameObject gameovercon;
    public Text endscoretext,bestscoretext,mesafetext,panelmesafetext,bestmesafetext,panelscoretext;
    public GameObject endgamepanel,gamepanel,startpanel,pausepanel,resumepanel;
    void Start()
    {
        endgamepanel.SetActive(false);
        gamepanel.SetActive(false);
        startpanel.SetActive(true);
        pausepanel.SetActive(false);
        resumepanel.SetActive(false);
        speed = risingspeed = 0;
        GetComponent<Rigidbody2D>().gravityScale = 0;
        restartt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed*Time.deltaTime, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Mouse0) )
            {
            //GetComponent. < Rigidbody2D > ().AddForce(Vector2.up * risingspeed * Time.deltaTime);
           // transform.Translate(Vector2.up * risingspeed * Time.deltaTime);
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * risingspeed);//ileri gidilen yer
        }
        //scoree.text = (int)score+"P" ;
        mesafe = Vector2.Distance(startpoint.position, transform.position);
        panelmesafetext.text =  (int)mesafe + "m";panelscoretext.text = (int)score+"";
    }
    private void OnTriggerEnter2D(Collider2D nesne)
    {
        //nesnenin triggerı açıksa yani içinden(box collider) geçme durumu
        if (nesne.gameObject.tag == "ileriacma")
        {
            nesne.gameObject.transform.root.gameObject.GetComponent<gecis>().ileriacma = true;//geçtiğimiz nesnenin tagı geçiş ise aktif kodunu bir yap
        }
        if (nesne.gameObject.tag == "degistirme")
        {

            nesne.gameObject.transform.root.gameObject.GetComponent<gecis>().degistirme = true;//geçtiğimiz nesnenin tagı geçiş ise aktif kodunu bir yap
        }
        if (nesne.gameObject.tag == "degistirmee")
        {

            nesne.gameObject.transform.root.gameObject.GetComponent<gecis>().degistirmee = true;//geçtiğimiz nesnenin tagı geçiş ise aktif kodunu bir yap
        }
        if (nesne.gameObject.tag == "pass")
        {
            score++;
            nesne.gameObject.transform.root.gameObject.GetComponent<gecis>().aktif = true;//geçtiğimiz nesnenin tagı geçiş ise aktif kodunu bir yap
        }
        if (nesne.gameObject.tag == "passs")
        {
            score++;
            nesne.gameObject.transform.root.gameObject.GetComponent<gecis>().aktifiki = true;
        }
        if (nesne.gameObject.tag == "passss")
        {
            score++;
            nesne.gameObject.transform.root.gameObject.GetComponent<gecis>().aktifüc = true;
        }


    }


    private void OnCollisionEnter2D(Collision2D nesne)
    {
        if(nesne.gameObject.tag == "engel")
        
        {
            resumepanel.SetActive(false);
            pausepanel.SetActive(false);

            Debug.Log("engele carbildi");
            if (restartt == 0) { Time.timeScale = 0; }
            
            gameovercon.SetActive(true);
            mesafetext.text = "Distance : " + (int)mesafe + "m";

            endscoretext.text = "Score:" + (int)score;
            tutucu = PlayerPrefs.GetInt("bestscore");
            if (score < tutucu)
            { 
                bestscoretext.text = "High score : " + (int)tutucu;
               
            }
            else
            {
                tutucu = score;
                PlayerPrefs.SetInt("bestscore", tutucu);
                bestscoretext.text = "High score :" + (int)tutucu;
            }
            tutucu2 = PlayerPrefs.GetFloat("bestdistance");
            if (mesafe < tutucu2)
            {
                bestmesafetext.text = "Best Distance : " + (int)tutucu2 + "m";

            }
            else
            {
                tutucu2 = mesafe;
                PlayerPrefs.SetFloat("bestdistance", tutucu2);
                bestmesafetext.text = "Best Distance :" + (int)tutucu2 + "m";
            }
            /* if (mesafe < tutucu2)
             {
                 bestscoretext.text = "High score : " + (int)tutucu;

             }
             else
             {
                 tutucu0 = mesafe;
                 PlayerPrefs.SetInt("mesafe", tutucu);
                 bestscoretext.text = "High score :" + (int)tutucu;
             }*/
            // score =0;
        }
    }
    public void butons (int i)
    {
        if (i == 0) { speed = 4;
            risingspeed = 250;
            GetComponent<Rigidbody2D>().gravityScale = 1;
            endgamepanel.SetActive(false);
            gamepanel.SetActive(true);
            startpanel.SetActive(false);
            pausepanel.SetActive(false); resumepanel.SetActive(true);
        }
    }

    public void restart()
    {
        /* Start();
         Scene vbn = SceneManager.GetActiveScene();
         SceneManager.LoadScene(vbn.name);
         Start();*/
        //SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        restartt =1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;

    }
    public void Pausee()
    {
        pausepanel.SetActive(true);
        resumepanel.SetActive(false);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pausepanel.SetActive(false);
        resumepanel.SetActive(true);
        Time.timeScale = 1;
    }

    /*  void endgame ()
      {
          endgamepanel.SetActive(true);
          gamepanel.SetActive(false);
          endscoretext.text = (int)score+"m";     
      }*/

}


