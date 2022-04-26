using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tp3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int num1;
    public int num2;

    public void escribirconsola()
    {
        if (num1 == num2 || num1 < num2)
        {
            Debug.Log("Erros, los numeros no pueden ser iguales y el segundo no puede ser menor al primero");
        }
        else
        {

            while (num2 <= num1)
            {
                Debug.Log(num1);
                    num1--;
            }
        }
       
    }
}
