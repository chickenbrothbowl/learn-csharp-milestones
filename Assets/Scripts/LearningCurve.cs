using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int myInt = 0;
    public int myInt2 = 0;
    public double myFloat = 1.0;
    public string myString = "Hello, World!";
    public bool myBool = true;

    void Start()
    {
        Debug.Log(myInt);
        Debug.LogFormat(myString, myString);
        Debug.Log($"Your current in is {myInt}!");
        int sum = AddNumbers(myInt, myInt2);
        Debug.Log($"The sum of {myInt} and {myInt2} is {sum}.");

        Character hero = new Character();
        Debug.LogFormat("Hero: {0} - {1} EXP", hero.Name, hero.Exp);

        Character heroine = new Character("Agatha");
        Debug.LogFormat("Hero: {0} - {1} EXP", heroine.Name, heroine.Exp);

        if (myBool)
        {
            Debug.Log("myBool is TRUE");
        }
        else if (!myBool)
        {
            Debug.Log("myBool is FALSE");
        }
        else
        {
            Debug.Log("Error");
        }

        if (myInt > 0)
        {
            if (myInt2 > 0)
            {
                Debug.Log("Both ints are > 0");
            }
        }

        switch (myInt2)
        {
            case 1:
                Debug.Log("myInt2 is one.");
                break;
            case 5:
                Debug.Log("myInt2 is five.");
                break;
            default:
                Debug.Log("myInt2 is something else.");
                break;
        }

        int[] numbers = { 1, 2, 3, 4, 5 };

        List<string> names = new List<string> { "Richard", "William", "Schuckenbrock" };

        Dictionary<string, int> letterCounts = new Dictionary<string, int>()
        {
            {"dog", 3},
            {"frog", 4},
            {"razzmatazz", 10}
        };

        foreach (string name in names)
        {
            Debug.Log($"Name: {name}");
        }

        foreach (KeyValuePair<string, int> kvp in letterCounts)
        {
            Debug.Log($"Foreach loop - {kvp.Key}: {kvp.Value}");
        }

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        huntingBow.PrintWeaponStats();

        Weapon warBow = huntingBow;
        warBow.Name = "War Bow";
        warBow.Damage = 155;

        int AddNumbers(int a, int b)
        {
            int result = a + b;
            return result;
        }

        void Update()
        {

        }
    }
}