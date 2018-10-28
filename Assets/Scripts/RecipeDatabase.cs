using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RecipeDatabase : MonoBehaviour {

    public List<Recipe> recipes;

    private ItemDatabase itemDatabase;

    private void Awake() {
        itemDatabase = GetComponent<ItemDatabase>();

        BuildRecipeDatabase();
    }

    public Item CheckRecipe(int[] recipe) {
        foreach (Recipe r in recipes) {
            if (r.requiredItems.OrderBy(i => i).SequenceEqual(recipe.OrderBy(i => i))) {
                return itemDatabase.GetItem(r.itemToCraft);
            }
        }

        return null;
    }

    void BuildRecipeDatabase() {
        recipes = new List<Recipe>()
        {
            new Recipe(1, 
                new int[] {
                    0, 0, 0,
                    0, 2, 0,
                    0, 0, 0
                }
            ),
            new Recipe(2,
                new int[] {
                    3, 0, 0,
                    0, 3, 0,
                    0, 0, 3
                }
            ),
            new Recipe(3,
                new int[] {
                    1, 0, 2,
                    0, 2, 0,
                    0, 0, 0
                }
            ),
        };
    }
}
