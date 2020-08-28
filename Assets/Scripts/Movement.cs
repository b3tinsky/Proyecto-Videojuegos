using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Script inciado");
		Debug.Log("Script editado");
    }

    // Update is called once per frame
    void Update()
    {
        Movimiento();

    }

    void Movimiento()
    {
        // W A S D
        // Al presiona W, queremos que el cubo suba, es decir, incremente en Y

        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        //{
        //    Debug.Log("W Presionada");
        //    //transform.position = new Vector3(transform.position.x, transform.position.y + 1, 0);
        //    transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        //{
        //    Debug.Log("S Presionada");
        //    //transform.position = new Vector3(transform.position.x, transform.position.y - 1, 0);
        //    transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        //{
        //    Debug.Log("A Presionada");
        //    //transform.position = new Vector3(transform.position.x - 1, transform.position.y, 0);
        //    transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
        //}

        //if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        //{
        //    Debug.Log("D Presionada");
        //    //transform.position = new Vector3(transform.position.x + 1, transform.position.y, 0);
        //    transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        //}

        transform.Translate(new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * speed * Time.deltaTime);
    }
}
