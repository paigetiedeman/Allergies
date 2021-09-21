using System;
using System.Collections.Generic;

namespace Allergies.Models
{
  public class AllergyScore
  {
    public static List<string> Allergies = new List<string>();

    public static string AllergyOutput(int score)
    {
      int trackedScore = score;
      if (trackedScore == 0) {
        return "You have no allergies.";
      }
      if (trackedScore - 128 >= 0)
      {
        Allergies.Add("cats");
        trackedScore -= 128;
      }
      if (trackedScore - 64 >= 0)
      {
        Allergies.Add("pollen");
        trackedScore -= 64;
      }
      if (trackedScore - 32 >= 0)
      {
        Allergies.Add("chocolate");
        trackedScore -= 32;
      }
      if (trackedScore - 16 >= 0)
      {
        Allergies.Add("tomatoes");
        trackedScore -= 16;
      }
      if (trackedScore - 8 >= 0)
      {
        Allergies.Add("strawberries");
        trackedScore -= 8;
      }
      if (trackedScore - 4 >= 0)
      {
        Allergies.Add("shellfish");
        trackedScore -= 4;
      }
      if (trackedScore - 32 >= 0)
      {
        Allergies.Add("peanuts");
        trackedScore -= 32;
      }
      if (trackedScore - 1 >= 0)
      {
        Allergies.Add("eggs");
        trackedScore -= 1;
      }
      string allergyList = String.Join(" ", Allergies);
      return $"You have the following allergies: {allergyList}";
    }
  }
}

//public static List<string> Allergies = new List<string>() {}
//create int score
//create list object
// //if (score - 128 >= 0)
// //{
//   Allergies.add("cats");
// //add "cats" to list;
// //score -= 128;
// //}
// //if (score - 64 >= 0)
// //{
//   Allergies.add("pollen");
// //add "pollen" to list;
// //score - 64;
//}
//...etc
  // return output = String.Join(" ", Allergies);
//return final list object as string.