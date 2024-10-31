using System;

public class Recipe
{
    public string name { get; set; }
    public string category { get; set; }
    public string ingridents { get; set; }
    public string instructions { get; set; }

    public Recipe(string name, string category, string ingridents, string instructions)
    {
        this.name = name;
        this.category = category;
        this.ingridents = ingridents;
        this.instructions = instructions;
    }

    public void Display()
    {
        Console.WriteLine($"\nRecipe Name: {name}");
        Console.WriteLine($"Category: {category}");
        Console.WriteLine($"Ingredients: {ingridents}");
        Console.WriteLine($"Instructions: {instructions}");
    }
}

public class RecipeBook
{
    private Recipe[] recipes = new Recipe[20];
    private int recipecount = 0;

    public void Addrecipe()
    {
        if (recipecount >= recipes.Length)
        {
            Console.WriteLine("Recipe Book is full");
            return;
        }
        Console.WriteLine("Enter Recipe Name");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Category");
        string category = Console.ReadLine();

        Console.WriteLine("Enter Ingredients (separate by commas)");
        string ingridents = Console.ReadLine();

        Console.WriteLine("Enter Instructions");
        string instructions = Console.ReadLine();

        Recipe newRecipe = new Recipe(name, category, ingridents, instructions);
        recipes[recipecount] = newRecipe;
        recipecount++;
        Console.WriteLine("Recipe added successfully!");
    }

    public void Viewrecipe()
    {
        if (recipecount == 0)
        {
            Console.WriteLine("No recipes are available");
            return;
        }
        Console.WriteLine("\nRecipes List");
        for (int i = 0; i < recipecount; i++)
        {
            recipes[i].Display();
        }
    }

    public void DeleteRecipe()
    {
        Console.WriteLine("Enter the name of the recipe to delete");
        string name = Console.ReadLine();

        for (int i = 0; i < recipecount; i++)
        {
            if (recipes[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                for (int j = i; j < recipecount - 1; j++)
                {
                    recipes[j] = recipes[j + 1];
                }
                recipes[recipecount - 1] = null;
                recipecount--;
                Console.WriteLine("Recipe deleted successfully");
                return;
            }
        }
        Console.WriteLine("Recipe not found");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        RecipeBook book = new RecipeBook();
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nRecipe Book Application");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. View Recipes");
            Console.WriteLine("3. Delete Recipe");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Select an Option");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    book.Addrecipe();
                    break;

                case "2":
                    book.Viewrecipe();
                    break;

                case "3":
                    book.DeleteRecipe();
                    break;

                case "4":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid Option, try again");
                    break;
            }
        }
        Console.WriteLine("Thank you for using the recipe book");
    }
}