using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Global
{
    public static List<Ball> bolas = new List<Ball>();

    public static List<string> textoInstrucciones = new List<string>
    {
        "Elige tamaño del palo y pulsa click derecho",
        "1. Muévete con las flechas de dirección.\n2. Gira la vista y mira a tu alrededor con WASD.\n3. Mueve el palo adelante y atrás con el teclado numérico",
        "Texto3"
    };

    public static void InsertBall(Ball bola)
    {
        bolas.Add(bola);
        UpdateText(bola);
    }

    public static void InsertBall(int numero, TipoBola tipo)
    {
        InsertBall(new Ball { tipo = tipo, numero = numero });
    }

    public static void UpdateText(Ball bola)
    {
        var text = GameObject.Find("Text").GetComponent<Text>();
        text.text = "Bola introducida: nº " + bola.numero + " ; tipo = " + bola.tipo.ToString();
        if (bola.tipo == TipoBola.Lisa)
        {

            var textMesh = GameObject.Find("TextLisas").GetComponent<TextMeshPro>();
            textMesh.text = ToString(TipoBola.Lisa);
        }
        else
        {
            ToString(TipoBola.Rayada);
            var textMesh = GameObject.Find("TextRayadas").GetComponent<TextMeshPro>();
            textMesh.text = ToString(TipoBola.Rayada);
        }


    }

    public static string ToString(TipoBola tipo)
    {
        List<Ball> balls = bolas.Where(b => b.tipo == tipo).OrderBy(b => b.numero).ToList();
        string list = "";
        foreach (Ball ball in balls)
        {
            list += ball.numero + ".\n";
        }
        return list;
    }

    public static void InstructionsText(TipoTexto texto)
    {
        var textMesh = GameObject.Find("Instrucciones_2").GetComponent<TextMeshPro>();
        textMesh.text = textoInstrucciones[(int)texto];
    }
}

public enum TipoTexto
{
    StickSize,
    MovementInstructions
}