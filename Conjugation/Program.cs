using static Conjugation.Utilities;

// futur
// conditionnal
// passé composé

// Parl-er
// je parl-erai
// je parl-erais
// j'ai parl-é

// Fini-r
// fini-rai
// fini-rais
// fini

// Vend-re
// vend-rai
// vend-rais
// vend-u


string tenseChosen = GetVerbTense();
string enteredWord = GetVerb();
string verbKind = GetVerbKind(enteredWord);
string finalResult = GetFinalResult(tenseChosen, enteredWord);
OutputFinalResult(finalResult, verbKind);



