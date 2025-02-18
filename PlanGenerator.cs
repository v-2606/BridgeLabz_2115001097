//using System;
//using System.Collections.Generic;


//public interface IMealPlan
//{
//    string MealType { get; }
//    void DisplayMeal();
//}

//public class VegetarianMeal : IMealPlan
//{
//    public string MealType => "Vegetarian";

//    public void DisplayMeal()
//    {
//        Console.WriteLine("Meal Type: Vegetarian");
//    }
//}

//public class VeganMeal : IMealPlan
//{
//    public string MealType => "Vegan";

//    public void DisplayMeal()
//    {
//        Console.WriteLine("Meal Type: Vegan");
//    }
//}

//public class KetoMeal : IMealPlan
//{
//    public string MealType => "Keto";

//    public void DisplayMeal()
//    {
//        Console.WriteLine("Meal Type: Keto");
//    }
//}

//public class HighProteinMeal : IMealPlan
//{
//    public string MealType => "High-Protein";

//    public void DisplayMeal()
//    {
//        Console.WriteLine("Meal Type: High-Protein");
//    }
//}

//public class Meal<T> where T : IMealPlan
//{
//    public string Name { get; set; }
//    public T MealCategory { get; set; }

//    public Meal(string name, T mealCategory)
//    {
//        Name = name;
//        MealCategory = mealCategory;
//    }

//    public void DisplayMeal()
//    {
//        Console.WriteLine("Meal: " + Name);
//        MealCategory.DisplayMeal();
//    }
//}


//public static class MealPlanGenerator
//{
//    public static void GenerateMealPlan<T>(Meal<T> meal) where T : IMealPlan
//    {
//        Console.WriteLine("Generated Meal Plan:");
//        meal.DisplayMeal();
//    }
//}

//class PlanGenerator
//{
//    static void Main(string[] args)
//    {
      
//        var vegMeal = new Meal<VegetarianMeal>("Grilled Veggie Bowl", new VegetarianMeal());
//        var ketoMeal = new Meal<KetoMeal>("Avocado Salad", new KetoMeal());

        
//        MealPlanGenerator.GenerateMealPlan(vegMeal);
//        MealPlanGenerator.GenerateMealPlan(ketoMeal);
//    }
//}
