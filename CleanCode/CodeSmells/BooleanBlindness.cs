namespace CleanCode.CodeSmells
{
    public class BooleanBlindness
    {
        public string SaveAnimal(string nickName, string species, float weightKg, bool isDomesticated)
            => $"New Animal: NickName {nickName}, Species: {species}, Weight (Kg): {weightKg}, Type: {BooleanToDomesticatedOrWildDescription(isDomesticated)}";

        private string BooleanToDomesticatedOrWildDescription(bool isDomesticated) 
            => isDomesticated ? "Domesticated" : "Wild";

        public void Execute()
        {
            var animal = SaveAnimal("Fuzzy", "Doggy", 8.11f, true);
        }
    }
}
