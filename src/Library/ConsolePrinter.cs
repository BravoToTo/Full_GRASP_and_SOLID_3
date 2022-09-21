namespace Full_GRASP_And_SOLID.Library;

public class ConsolePrinter : IPrinter
{
    public void PrintRecipe(Recipe recipe)
    {
        System.Console.WriteLine(recipe.GetTextToPrint());
    }
}