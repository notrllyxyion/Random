using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class PlayerOne : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_Text;
     private int Age = 36;
     private int PhysicalDamage = 128;
     private int Armor = 256;
     private int MagicDamage = 300;
     private int MagicResistance = 200;
     private float Speed = 158.3f;
     public void ButtonPressed()
    {

        m_Text.text = $"Name: Yuki Kaji \n Age: {Age} \n Race: Isda \n Physical Damage: {PhysicalDamage} \n Armor: {Armor} \n MagicDamage: {MagicDamage} \n MagicResistance: {MagicResistance} \n Speed: {Speed}";
   }

}
