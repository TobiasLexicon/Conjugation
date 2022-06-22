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

		public static string? GetVerb()
        {
			Console.WriteLine("Please enter a regular verb in french:");
			return Console.ReadLine().ToLower();
		}

		public static string GetFinalResult(string tenseChosen, string enteredWord)
        {
			var (verbTense, lettersToCut) = tenseChosen switch
			{
				"1" => ("futur", 2),
				"2" => ("conditionnel", 1),
				"3" => ("passé composé", 2),
				_ => ("", 0),
			};
			string verbKind = GetVerbKind(enteredWord);
			string suffix = (tenseChosen, verbKind) switch
			{
				("1", "the first") => "erai",
				("1", "the second") => "rai",
				("1", "the third") => "rai",
				("2", "the first") => "erais",
				("2", "the second") => "rais",
				("2", "the third") => "rais",
				("3", "the first") => "é",
				("3", "the second") => "",
				("3", "the third") => "u",
				(_, _) => ""
			};
			string verbBase = GetBase(enteredWord, lettersToCut);
			string pronoun = tenseChosen == "3" ? "j'ai" : "je";
			string finalOutput = $"The right verb form for {verbTense} of {enteredWord} is {pronoun} {verbBase}{suffix}";
			return finalOutput;
        }

		public static string GetBase(string verb, int lettersToCut)
        {
			int fromEnd = verb.Length - lettersToCut;
			return verb.Remove(fromEnd);
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

