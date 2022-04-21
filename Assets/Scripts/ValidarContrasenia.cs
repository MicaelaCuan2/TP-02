using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContrasenia : MonoBehaviour
{
    string contraseniaCorrecta;
    string contraseniaUsuario;
    public Text IngresoUsuario;

    // Start is called before the first frame update
    void Start()
    {
        contraseniaCorrecta = "12345";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarContrasenia()
    {
        contraseniaUsuario = IngresoUsuario.text;
        if (contraseniaUsuario == contraseniaCorrecta)
        {
            Debug.Log("Bienvendido");
        }
        else
        {
            Debug.Log("Contraseña incorrecta");
        }
    }
}
