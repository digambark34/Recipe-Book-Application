
# Recipe Book Console Application

A simple C# console application to manage recipes. Users can add, view, and delete recipes from a recipe book.

## Features

- **Add Recipes**: Enter details like the recipe name, category, ingredients, and instructions.
- **View Recipes**: Display a list of all saved recipes.
- **Delete Recipes**: Remove a recipe by specifying its name.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed on your system (version 5.0 or above is recommended).

### Installation

1. Clone this repository to your local machine:
   ```bash
   git clone https://github.com/yourusername/RecipeBookConsoleApp.git
   cd RecipeBookConsoleApp
   ```

2. Compile and run the application:
   ```bash
   dotnet run
   ```

### Usage

1. **Start the Application**: After running the application, you will see a menu with options:
   ```
   Recipe Book Application
   1. Add Recipe
   2. View Recipes
   3. Delete Recipe
   4. Exit
   ```

2. **Add a Recipe**:
   - Choose option `1` to add a new recipe.
   - Enter the required information (recipe name, category, ingredients, and instructions).
   - After entering the details, the recipe is saved to the recipe book.

3. **View Recipes**:
   - Choose option `2` to view all recipes saved in the book.
   - Each recipe’s name, category, ingredients, and instructions are displayed.

4. **Delete a Recipe**:
   - Choose option `3` to delete a recipe.
   - Enter the recipe name you wish to delete. If it exists, it will be removed from the recipe book.

5. **Exit the Application**:
   - Choose option `4` to exit.

### Code Structure

- `Recipe`: Represents a recipe with properties like `name`, `category`, `ingredients`, and `instructions`.
- `RecipeBook`: Manages an array of `Recipe` objects. Contains methods to add, view, and delete recipes.
- `Program`: The main class that contains the program flow and user interaction logic.
- 

### Limitations

- Currently, the application stores recipes in memory only. Recipes will not persist after closing the application.
- Limited to storing a maximum of 20 recipes.

### Future Enhancements

- Add file storage to save recipes permanently.
- Implement a search feature to find recipes based on ingredients or category.
- Expand the recipe limit or make it dynamically resizable.

### Contributing

Contributions are welcome! Feel free to fork the repository and submit pull requests.

This README provides a basic overview of the app and includes instructions on how to install, run, and use it. Let me know if you'd like to add or customize any sections further!
