using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gmz : MonoBehaviour {
    public GameObject[] gmox;// gmox to get instantiable gameobjects 
    [SerializeField]List<GameObject> listx = new List<GameObject>();// to get hols of instantiated gmos
    GameObject choose,inst;
    int objno =0;
    float x;
    float time =0,ti =0;
    float timez =1,timex =35;

	// Update is called once per frame
	void Update () {
        
        if (time > timez )
        {
            instant();
            time = 0;
            timez = Random.Range(3,5 );
        }
        time = Time.deltaTime + time;
        //deleteobjs();
        deleteobjsbeta();

    }
    public GameObject chosen()
    {
        int indx = Random.Range(0, gmox.Length);
        choose = gmox[indx];
        return choose;
    }
    public void instant()
    {
        int xvalue = Random.Range(0,2);
        Vector3 pos = new Vector3(10, 0,0);
        GameObject obj = chosen();
        GameObject holder = (GameObject)Instantiate(obj,pos,Quaternion.identity);
        listx.Add(holder);
    }
   public void deleteobjs()
    {
        for (int i = 0; i < listx.Count; i++)
        {
            if (listx[i].transform.position.x == -10)
            {
                Destroy(listx[i].gameObject);
                listx.RemoveAt(i);
                listx[i] = listx[i + 1];
                Debug.Log("inside del");
            }
        }
    }
    public void deleteobjsbeta()
    {
        if (ti > timex)
        {
            for (int i = 0; i < 4; i++)
            {
               Destroy(listx[i].gameObject,1);
            }
            listx.RemoveRange(0, 4);
            ti = 0;
            timex = 15;
        }
        ti = ti + Time.deltaTime;
    }
}
