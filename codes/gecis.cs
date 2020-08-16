using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gecis : MonoBehaviour
{
    public float yerdegistirme = 0;
    public bool ileriacma,degistirmee,degistirme;
    public bool aktif;
    public bool aktifiki;
    public bool aktifüc,yildiziki,yildizuc;
    public bool x,xx,xxx,xxxx,a,aa,aaa,girdi;
    // Start is called before the first frame update
    public GameObject[] objeler;
    public GameObject gameovercon,pausepanel;
    void Start()
    {
        objeler[6].transform.localPosition = new Vector3(Random.Range(-6.8f, -2), Random.Range(0.95f, -0.34f), 1);
        objeler[5].transform.localPosition = new Vector3(Random.Range(-1, 3), Random.Range(0.95f, -0.34f), 1);
        objeler[7].transform.localPosition = new Vector3(Random.Range(4, 8), Random.Range(0.95f, -0.34f), 1);
        objeler[3].transform.localPosition = new Vector3(Random.Range(-6.8f, 8.0f), 0.844f, 1);
        objeler[4].transform.localPosition = new Vector3(Random.Range(-6.8f, 8.0f), 1.49743f, 1);
        objeler[1].transform.localPosition = new Vector3(Random.Range(-6.8f, 8.0f), -3.940273f, 1);
        objeler[2].transform.localPosition = new Vector3(Random.Range(-6.8f, 8.0f), -3.755f, 1);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ileriacma)
        {
           
            xxx = true;
            Invoke("yolutasi", 3f);//sahneyi 2.5sn sonra ileri taşı
            ileriacma = false;
            
        }
        //engellerin yerini değiştir plane kodunda aktif oluyorlar
       
        if (degistirme)
        {
            x = true;
            objeler[5].SetActive(false);
            Invoke("yolutasi", 3f);
            degistirme = false;
        }
        if (degistirmee)
        {
            xx = true;
            objeler[5].SetActive(false);
            Invoke("yolutasi", 3f);
            degistirmee = false;
        }
        if (aktif)
        {

            objeler[6].SetActive(false);
            a = true;
            Invoke("yildiztasi", 3f);
           
            aktif = false;
        }
        if (aktifiki)
        {
            
            objeler[5].SetActive(false);
            aa = true;
            Invoke("yildiztasi", 3f);
            aktifiki = false;
        }
        if (aktifüc)
        {
            objeler[7].SetActive(false);
            aaa = true;
            Invoke("yildiztasi", 3f);
            
            aktifüc = false;
        }

        if (xxxx || yildiziki || yildizuc)
        {
            girdi = true;
            Invoke("carpisti",0.2f);
        }
     

    }

   void carpisti()
    {
        if (xxxx)
        {
            objeler[6].transform.localPosition = new Vector3(Random.Range(-6.8f, -1.5f), Random.Range(3.5f, -1.6f), 1);
            xxxx = false;
        }

        if (yildiziki)
        {
            objeler[5].transform.localPosition = new Vector3(Random.Range(-2, 3), Random.Range(2, -1), 1);
            yildiziki = false;
        }

        if (yildizuc)
        {
            objeler[7].transform.localPosition = new Vector3(Random.Range(3.5f, 8), Random.Range(3.2f, -1.4f), 1);
         yildizuc = false;
        }
    }

   public void yildiztasi()


    {
        float yildizaltsayi = Random.Range(0, 2); ;
        float yildizüstsayi = Random.Range(0, 2); ;
        //yildizların açılıp kapanması yer değiştirmesi
        

        if (a)
        {
            if (yildizaltsayi == 0.3f)
            {
                objeler[6].SetActive(false);
                a = false;
                // xxxx = false;
            }
            else
            {   //objeler[6].transform.position = new Vector3(Random.Range(-6.8f, -1.5f), Random.Range(3.5f, -1.6f), 1);
                objeler[6].SetActive(true);
                objeler[6].transform.localPosition = new Vector3(Random.Range(-6.8f, -1.5f), Random.Range(3.5f, -1.6f), 1);
               // xxxx = false;
                a = false;
            }
        }
        if (aa)
        {
            if (yildizüstsayi < 0.2f )
        {
            objeler[5].SetActive(false);
            aa = false; //yildiziki = false;
            }
        else 
        {
            objeler[5].SetActive(true);
          objeler[5].transform.localPosition = new Vector3(Random.Range(-2, 3), Random.Range(2, -1), 1);
            aa = false;    //yildiziki = false;           
        }
        }
        if (aaa)
        {
            if (yildizaltsayi < 0.5f)
        {
            objeler[7].SetActive(false); aaa = false;// yildizuc = false;
            }
        else 
        { objeler[7].SetActive(true);
          objeler[7].transform.localPosition = new Vector3(Random.Range(3.5f, 8), Random.Range(3.2f, -1.4f), 1);
          aaa = false;    // yildizuc = false;
        }
    }
        
}
    
    void yolutasi()

    {
        float altsayi = Random.Range(0, 2.5f);
        float üstsayi = Random.Range(0, 2.5f);
        //tüzde elli ihtimalle aç kapa engelleri

        /************************bulutların yer degisimi************/
        objeler[8].transform.localPosition = new Vector3(Random.Range(-3, 1), Random.Range(2.5f, 1.9f), 0);
        objeler[9].transform.localPosition = new Vector3(Random.Range(1.5f, 4), Random.Range(2.5f, 1.9f), 0);
        objeler[10].transform.localPosition = new Vector3(Random.Range(4.5f, 8), Random.Range(2.5f, 1.9f), 0);
        /******************************************************///engellerin yer değitirmesi
        if (xxx)
        {

            objeler[3].transform.localPosition = new Vector3(Random.Range(-6.8f, 8.0f), 0.844f, 1);

            transform.position = transform.position + new Vector3(32.14f, 0, 0);
            if (altsayi == 1)
            {
                objeler[3].SetActive(false);
            }
            else
            {
                objeler[3].SetActive(true);
            }

            xxx = false;
        }


        if (x)
        {

            objeler[4].transform.localPosition = new Vector3(Random.Range(-6.8f, 8.0f), 1.49743f, 1);
            objeler[1].transform.localPosition = new Vector3(Random.Range(-6.8f, 8.0f), -3.940273f, 1);
            if (üstsayi == 1)
            {
                objeler[1].SetActive(false);
            }
            else
            {
                objeler[1].SetActive(true);

            }

            x = false;
        }
        if (xx)
        {
            
            objeler[2].transform.localPosition = new Vector3(Random.Range(-6.8f, 8.0f), -3.755f, 1);


            xx = false;
        }

    }

 


}


