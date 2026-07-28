using System.Globalization;
using UnityEngine;

public class FundamentosProgramacion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Tipos de Datos
    private int myNumber = 20; // int - número entero 
    public float myFloatNumber = 25.20f;//float - numero con punto decimal
    public string myString = "Put your message here"; // string - cadena de texto

    public int health; // variables globales


    void Start()
    {
        int localHealth = 50; // variable locales
        //Debug.Log("Hola, estoy en la función start");
        //Debug.LogWarning("My number is: " + myNumber);
        //Debug.Log("Message is: " + myString);
        health = 100; // guardando un valor en una varaiable global

        int newHealth = health + localHealth; // sumando el valor de una variable global y local
        Debug.Log("New Health: " + newHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Hola, estoy en la función update");
    }
}
