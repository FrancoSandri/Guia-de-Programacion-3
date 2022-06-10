//Definir una función que escriba en consola “Hola Mundo!” al ser invocada.
//Invocar la función al presionar la barra espaciadora.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosTiposNativos : MonoBehaviour
{
    public float miFloat;
    public int numero1, numero2, numero3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HolaMundoEnLaConsola();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EscribirParametroEnConsola("Pablete esta loco");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            EscribirParametroEnConsola(ObtenerParteEnteraEnString(miFloat));
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            EscribirParametroEnConsola(DevolverMayor(numero1, numero2, numero3).ToString());
        }
    }

    void HolaMundoEnLaConsola()
    {
        Debug.Log("Hola Mundo!");
    }
    //Definir una función que escriba en consola la cadena pasada por parámetro.
    void EscribirParametroEnConsola(string cadena)
    {
        Debug.Log(cadena);
    }
    //Recibe un float por parámetro y lo procesa para devolver la parte entera como un string. 
    //Mostrar el dato devuelto en la consola utilizando la función del punto 1.2.

    string ObtenerParteEnteraEnString(float numero)
    {
        string retorno = Mathf.Floor(numero).ToString();
        return retorno;
    }
    //Definir una función que reciba tres enteros y devuelva el mayor de ellos.Si son los tres iguales retornar -1.  
    //Mostrar el dato devuelto en la consola utilizando la función del punto 1.2.
    int DevolverMayor(int num1, int num2, int num3)
    {
        int greater = 0;
        if (num1 > num2)
        {
            greater = num1;
        }
        else
        {
            greater = num2;
        }

        if (num3 > greater)
        {
            greater = num3;
        }
        if(num1 == num2 && num2 ==  num3)
        {
            greater = -1;
        }
        return greater;
    }
}
