using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public int numero;
    public TipoBola tipo;
}

public enum TipoBola
{
    Blanca,
    Negra,
    Lisa,
    Rayada
}