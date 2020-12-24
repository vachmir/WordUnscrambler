namespace WordUnscrambler
{
    class Constants
    {
        public const string OptionsOnHowToENterScrambledWords = "Enter scrambled words manually or as a file: F - file / M - Manual";
        public const string OptionOnContinuingTheProgram = "Would you like to continue? Y/N";

        public const string EnterScrambledWordsViaFile = "Enter fullname including the file name: ";
        public const string EnterScrambledWordsManually = "Enter word manally (sepatated by commas if multiple): ";
        public const string EnterScrambledWordsOptionNotRecognised = "The option was not recognised.";

        public const string ErrorScrambledWordsCannotBeLoaded = "Scrambled words were not loaded because there was an error";
        public const string ErrorProgramWillBeTerminated = "The program will be terminated";

        public const string MatchFound = "MATCH FOUND FOR {0}: {1}";
        public const string MatchNotFound = "NO MATCHES HAVE BEEN FOUND";

        public const string Yes = "Y";
        public const string No = "No";
        public const string File = "F";
        public const string Manual = "M";

        public const string WordListFileName = "wordlist.txt";
    }
}
