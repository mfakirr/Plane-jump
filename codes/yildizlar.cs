using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yildizlar : MonoBehaviour
{
    public gecis otherscript;
    // Start is called before the first frame update


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="engel" || other.gameObject.tag == "Respawn" ) 
        {
            Debug.Log("girdi");
            other.gameObject.transform.root.gameObject.GetComponent<gecis>().xxxx = true;
           // otherscript.GetComponent<gecis>().yildiztasi();
           // otherscript.yildiztasi();
        }


    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "engel" || collision.gameObject.tag == "Respawn" )
        {
            Debug.Log("cıkti"); //collision.gameObject.transform.root.gameObject.GetComponent<gecis>().xxxx = false;
           
        }
    }
    }







