using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button2 : MonoBehaviour
{
    public Animator anima;
    public Button b;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = b.GetComponent<Button>();
      
        btn.onClick.AddListener(play);
     

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

        anima.Play("Take 002");
        Debug.Log("Button 2");
    }
}
