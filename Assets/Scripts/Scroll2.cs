using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroll2 : MonoBehaviour
{
    public float speed;
    public GameObject camara;
    public GameObject background;
    public GameObject background2;
    public SpriteRenderer anchoFondo;
    public SpriteRenderer anchoFondo2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        camara.transform.Translate(Time.deltaTime * speed, 0, 0);
        if (background.transform.position.x + anchoFondo.sprite.bounds.size.x < camara.transform.position.x)
        {

            background.transform.position = new Vector3(background2.transform.position.x + anchoFondo.sprite.bounds.size.x, 0, 0);

        }
         if (background2.transform.position.x + anchoFondo2.sprite.bounds.size.x < camara.transform.position.x)
            background2.transform.position = new Vector3(background.transform.position.x + anchoFondo2.sprite.bounds.size.x, 0, 0);

    }

}

