using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class ArrayTasks : MonoBehaviour
{

    public int[] Numbers;
    public List<string> PokemonTypes = new List<string>();
    public Dictionary<string, int> Inventory = new Dictionary<string, int>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(SumArray(Numbers));
        RemoveType("Stellar");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int SumArray(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    public void RemoveType(string type)
    {
        if (PokemonTypes.Contains(type))
        {

            PokemonTypes.Remove(type);
        }
    }
}
