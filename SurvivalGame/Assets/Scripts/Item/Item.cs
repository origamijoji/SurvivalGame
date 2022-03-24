using UnityEngine;
using System;

#region Archetypes

public abstract class Item {
    public int MaxStackSize { get; protected set; }
    public Sprite Icon() { return ImageHandler.Instance.GetSprite(GetType().Name.ToString()); }
    public Type ItemType() { return GetType(); }

    public Item() {
        MaxStackSize = 64;
    }
}

public abstract class Tool : Item {
    public int Tier { get; protected set; }
    public string ToolName() { return GetType().Name.Replace("_", " "); }
    public float Durability { get; set; }
    public float Damage { get; set; }
    public double AttackSpeed { get; protected set; }
    public float Range { get; protected set; }
    public Tool() {
        MaxStackSize = 1;
    }
}

public abstract class Sword : Tool {
    public Sword() {

    }
}



public abstract class Placeable : Item {

}

#endregion Archetypes

#region Axe 
public abstract class Axe : Tool {
    public Axe() {
        Range = 1f;
        AttackSpeed = 1f;
    }
}

public sealed class Crafted_Axe : Axe {
    public Crafted_Axe() {
        Tier = 1;
        Durability = 100;
        Damage = 5;
    }
}

public sealed class Copper_Axe : Axe {
    public Copper_Axe() {
        Tier = 2;
        Durability = 150;
        Damage = 6;
    }
}

public sealed class Iron_Axe : Axe {
    public Iron_Axe() {
        Tier = 3;
        Durability = 250;
        Damage = 7.5f;
    }
}

#endregion Axe

#region Pickaxe

public abstract class Pickaxe : Tool {
    public Pickaxe() {
        Range = 1f;
        AttackSpeed = 1.5f;
    }
}

public sealed class Crafted_Pickaxe : Pickaxe {
    public Crafted_Pickaxe() {
        Tier = 1;
        Durability = 100;
        Damage = 4;
    }
}

public sealed class Copper_Pickaxe : Pickaxe {
    public Copper_Pickaxe() {
        Tier = 2;
        Durability = 150f;
        Damage = 5;
    }
}

public class Iron_Pickaxe : Pickaxe {
    public Iron_Pickaxe() {
        Tier = 3;
        Durability = 250f;
        Damage = 6.5f;
    }
}

#endregion Pickaxe

#region Items
public sealed class Wood : Item { }
public sealed class Stick : Item { }
public sealed class Stone : Item { }
public sealed class Iron_Ore : Item { }
public sealed class Iron_Bar : Item { }
public sealed class Copper_Ore : Item { }
public sealed class Copper_Bar : Item { }

#endregion Items

public sealed class Fists : Tool {
    public Fists() {
        Durability = Mathf.Infinity;
        Damage = 2;
        Range = 4f;
        AttackSpeed = 0.5f;
    }
}