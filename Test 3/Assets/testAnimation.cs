using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testAnimation : MonoBehaviour
{

 
    public Animator anima;
    public Button b;
    public Button c; 
    // Start is called before the first frame update
    void Start()
    {
        // b.onClick.AddListener(play);
        Button btn = b.GetComponent<Button>();
        btn.onClick.AddListener(play);

        Button btn1 = c.GetComponent<Button>();
        btn1.onClick.AddListener(play2);
        // a = Resources.Load<Animation>("Take 001");
        //anim = gameObject.GetComponent<Animation>();
        // anim["Take 001"].layer = 0; 
        //  a.Play();
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void play()
    {
        anima.Play("Take 001");
        Debug.Log("Button 1"); 
    }
    void play2() {
        anima.Play("Take 002");
        Debug.Log("Button 2");
    }
}
