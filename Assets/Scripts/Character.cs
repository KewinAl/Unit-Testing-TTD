using UnityEngine;

public interface ICharacter
{
    Inventory Inventory { get;  }
    int Health { get; }
    int Level { get; }
}

public class Character : MonoBehaviour, ICharacter
{
    public Inventory Inventory { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
}
