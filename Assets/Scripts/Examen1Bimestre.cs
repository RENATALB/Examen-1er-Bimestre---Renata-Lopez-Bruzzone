using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Examen1Bimestre : MonoBehaviour
{
    public float kilometrosARecorrer;
    public int combustibleCargado;
    int litrosPorDia = 6; // 90km dividido 15km
    int costo1Litro = 130;
    int periodoDeDias;
    int cantidadDeUnidades;

    float costoTotalCombustible;
    float porcentajeDescuento;

    void Start()
    {
        if (periodoDeDias < 5 || cantidadDeUnidades < 1)
        {
            Debug.Log("Cantidad inválida");
            return;
        }

        if (combustibleCargado < 100)
        {
            porcentajeDescuento = 0;
            costoTotalCombustible = litrosPorDia * costo1Litro * (1 - porcentajeDescuento);
        }

        else if (combustibleCargado >= 100)
        {
            porcentajeDescuento = 0.2f;
            costoTotalCombustible = litrosPorDia * costo1Litro * (1 - porcentajeDescuento);
        }


        Debug.Log("Una flota de "+ cantidadDeUnidades + "unidades trabajando durante " + periodoDeDias + "días implicará un gasto de "+ costoTotalCombustible + "pesos en concepto de combustible");
    }
}
