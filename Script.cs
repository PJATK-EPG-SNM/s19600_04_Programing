using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //typ_zmiennej nazwa;
        //deklaracja
        int a;
        //inicjalizacja
        a = 10;
        //2w jednym
        int b = 20;
        Debug.Log(b);

        {//skakanie
            Debug.Log(b);

        }

        {//chodzenie
            int c = 30;
        }
        //Debug.Log(c);

        float fa = 20.0f;
        fa = 20.0f;

        bool logiczna = true; //false
        string str = "jakis napis";

        Debug.Log("fa:" + fa + " logiczna" + logiczna + " str:" + str);
        //operacje na zmiennych + * - /
        Debug.Log(a / b);
        Debug.Log(a / fa);
        Debug.Log(Mathf.Sqrt(2));

        //operacje logiczne
        Debug.Log(a == b);
        Debug.Log(a != b);
        Debug.Log(a > b);
        Debug.Log(a < b);
        Debug.Log(a <= b);
        Debug.Log(a >= b);

        //if(warunek)

        if (a == b)
        {
            Debug.Log("tak sa takie same");


        }
        else if (a > b)
        {
            Debug.Log("a > b");
        }
        else
        {
            Debug.Log("żadne z powyższych");
        }


        Koniunkcja(a, b);


    }
       


       

   
    
    public void Koniunkcja(int a,int b)
    {
        //koniunkcja
        Debug.Log((a != b) && (a > 0));

        if (a != b)
        {
        }
        if (a > 0)
        {
            //kod
        }

        if ((a != b) && (a > 0))
        {
            //kod
        }
    }



    public void Alternatywa()
    {
            //brzydka wersja
            int hp = 2, time = 1;
            bool amulet = true;

            if (hp <= 0)
            {
                if (!amulet)
                {

                }
                else
                {

                }
            }

            //ladna wersja

            if (hp <= 0 || time <= 0)
            {
                if (!amulet)
                {

                }
                else
                {

                }

            }

        
    }








    // Update is called once per frame
    void Update()
    {
        
    }
}
