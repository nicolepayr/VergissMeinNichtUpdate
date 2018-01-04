  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeList : MonoBehaviour {


    public bool cat = false;
    public bool pencil = false;
    public bool pills = false;
    public bool phone = false;
    //private Material a;

	// Use this for initialization
	void Start () {
        // GetComponent<Image>().sprite = Resources.Load("C: \\Users\\Petra\\Documents\\GitHub\\games\\VergissMeinNichtUpdate\\Prototype1\\Assets\\Liste2.png", typeof(Sprite)) as Sprite;
        // GetComponent<MeshRenderer>().material = GetComponent<MeshRenderer>().materials[0];
        //GetComponent<MeshRenderer>().material = a;
    }
	
	// Update is called once per frame
	void Update () {
		if(cat && pills && phone && pencil)
        {
            GetComponent<MeshRenderer>().material = Resources.Load("Liste4") as Material;
        } else if(cat && pills && pencil)
        {
            GetComponent<MeshRenderer>().material = Resources.Load("Liste3") as Material;
        } else if(cat && pencil)
        {
            GetComponent<MeshRenderer>().material = Resources.Load("Liste2") as Material;
        } /*else
        {
            GetComponent<MeshRenderer>().material = Resources.Load("Liste1") as Material;
        }*/
	}
    bool getCat()
    {
        return cat;
    }
    void setCat(bool NEW) {
        cat = NEW;
        }
    bool getPills()
    {
        return pills;
    }
    void setPills(bool NEW)
    {
        pills = NEW;
    }
    bool getPhone()
    {
        return phone;
    }
    void setPhone(bool NEW)
    {
        phone = NEW;
    }
     bool getPencil()
    {
        return pencil;
    }
    void setPencil(bool NEW) {
        pencil = NEW;
        }
}
