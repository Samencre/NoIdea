using UnityEngine;
using System.Collections.Generic;
public class Detect_Potions : MonoBehaviour
{
    public List<GameObject> solution ;

    public int indexsolution = 0;

    [SerializeField] private string tagName;

    void OnTriggerEnter(Collider potion)
    {

        // potion.tag == tagName
        if (potion.CompareTag(tagName))
        {

            Debug.Log($"Le chaudron reagit à {potion.name}");


            if (potion.name == solution[indexsolution].name)
            {

                Debug.Log($"{potion.name} est le bon choix!");
                indexsolution++;

            }
            else
            {

                Debug.Log($"{potion.name} est le mauvais choix! BOUM!!!!!!!");
                indexsolution = 0;

            }

            if (indexsolution >= solution.Count)
            {
                Debug.Log("Filicitation, ta potion est réussi");
            }
        }
    }
}
