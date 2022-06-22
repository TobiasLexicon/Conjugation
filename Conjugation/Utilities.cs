using System;
using System.Text.RegularExpressions;

namespace Conjugation
{
	public class Utilities
	{
		public Utilities()
		{
		}

		public static string GetVerbKind(string wordToCheck)
		{
			string verbKind = "";
			if (wordToCheck.EndsWith("er"))
			{
				verbKind = "the first";
			}
			else if (wordToCheck.EndsWith("ir"))
			{
				verbKind = "the second";
			}
			else if (wordToCheck.EndsWith("re"))
			{
				verbKind = "the third";
			}
			else
			{
				verbKind = "no";
			}

			return verbKind;
		}

		public static string GetVerbTense()
        {
			string tenseChosen;
			do
			{
				Console.Clear();
				Console.WriteLine("Choose a verb tense from the list:");
				Console.WriteLine("1. futur (press 1)");
				Console.WriteLine("2. conditionnel (press 2)");
				Console.WriteLine("3. passé composé (press 3)");
				tenseChosen = Console.ReadKey().KeyChar.ToString();

			} while (tenseChosen != "1" && tenseChosen != "2" && tenseChosen != "3");
			Console.Clear();

			return tenseChosen;
		}

		public static string GetVerb()
        {
			Console.WriteLine("Please enter a regular verb in french:");
			return Console.ReadLine();
		}

		public static string GetFinalResult(string tenseChosen, string enteredWord)
        {
			string verbTense = tenseChosen switch
			{
				"1" => "futur",
				"2" => "conditionnel",
				"3" => "passé composé",
			};

			int lettersToCut = tenseChosen switch
			{
				"1" => 2,
				"2" => 1,
				"3" => 2,
			};

			string verbBase = Utilities.GetFoundation(enteredWord, lettersToCut);


			string finalOutput = $"The right verb form for {verbTense} of {enteredWord} is {verbBase}";
			return finalOutput;
        }

		public static string GetFoundation(string verb, int lettersToCut)
        {
			int fromEnd = verb.Length - lettersToCut;
			return verb.Remove(fromEnd);
        }

		public static string GetFirstPersonFormat()
        {
			string firstPersonForm = "";
			return firstPersonForm;
        }

		public static void OutputFinalResult(string finalOutput, string verbKind)
        {
			Console.Clear();
			Console.WriteLine($"The verb is of {verbKind} kind");
			Console.WriteLine(finalOutput);
			Console.ReadKey();
		}

			
	}
}

