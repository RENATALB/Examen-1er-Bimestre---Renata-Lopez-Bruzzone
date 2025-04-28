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

    float costoCombustiblePorUnidad;
    float costoCombustibleFlota;
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
            costoCombustiblePorUnidad = litrosPorDia * costo1Litro * (1 - porcentajeDescuento) * periodoDeDias;
        }

        else if (combustibleCargado >= 100)
        {
            porcentajeDescuento = 0.2f;
            costoCombustiblePorUnidad = litrosPorDia * costo1Litro * (1 - porcentajeDescuento) * periodoDeDias;
        }


        costoCombustibleFlota = costoCombustiblePorUnidad * cantidadDeUnidades;

        Debug.Log("Una flota de " + cantidadDeUnidades + "unidades trabajando durante " + periodoDeDias + "días implicará un gasto de " + costoCombustibleFlota + "pesos en concepto de combustible. Se ha aplicado un %" + porcentajeDescuento + " de descuento");
    }
}
