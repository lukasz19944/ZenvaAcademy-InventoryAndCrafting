using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe {

    public int[] requiredItems;
    public int itemToCraft;

    public Recipe(int itemToCraft, int[] requiredItems) {
        this.requiredItems = requiredItems;
        this.itemToCraft = itemToCraft;
    }

}
