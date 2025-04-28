using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examen1Bimestre : MonoBehaviour
{
    public float kilometrosARecorrer;
    int costo1Litro = 130;
    public int combustibleCargado;
    int periodoDeDias;
    int cantidadDeUnidades;
    float costoTotalCombustible;
    float porcentajeDescuento;

    void Start()
    {
        // 1. Declarar las variables: Veo en la consigna y me fijo que cosas me conviene tener en una variable. EJ HELADERÍA: Todo lo que el usuario debe ingresar: Gustos, cantidad. Afuera de la función, únicamente se declaran las variables.
        // 2. Validar los datos ingresados. Fijarse si los datos están bien o mal, buscar errores.
        
        if (periodoDeDias < 5 || cantidadDeUnidades < 1)
        {
            Debug.Log("Cantidad inválida");
            return;
        }
        if (combustibleCargado >= 100)
        {
            porcentajeDescuento = 20;
        }


        // 3. Procesamiento de datos:
        // 4. Mostrar los resultados
        // Una flota de [cantidadDeUnidades] unidades trabajando durante [periodoDeDias] días implicará un gasto de [costoTotalCombustible] pesos en concepto de combustible
    }
}
