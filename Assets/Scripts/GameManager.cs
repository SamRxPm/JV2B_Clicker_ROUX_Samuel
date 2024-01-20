using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public int clicks = 0;
    public TMP_Text clickText;
    public ParticleSystem Blood;

    public int power=1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void RiseClickPower()
    {
        power = power*2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicks() {
        clicks+=power;
        clickText.text = "W coins: " + clicks.ToString("000");
        Blood.Play();

    }

    void OnMouseDown()
    {
        // Destroy the gameObject after clicking on it
        Clicks();
    }

}
