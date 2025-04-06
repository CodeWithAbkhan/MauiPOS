using MauiPOS.Data;

namespace MauiPOS.Repositories
{
    public class SettingsRepository
    {
        private const string NameKey = "name";
        private const string TaxPercentageKey = "tax";

        public async Task<string> GetOrSetNameAsync()
        {
            var name = Preferences.Default.Get<string?>(NameKey, null);
            if (name == null)
            {
                // In Blazor, this prompt would be handled in the UI, so return a default and let the component handle it
                name = "Guest";
                Preferences.Default.Set(NameKey, name);
            }
            return name;
        }

        public int GetTaxPercentage()
        {
            return Preferences.Default.Get<int>(TaxPercentageKey, 0);
        }

        public void SetTaxPercentage(int taxPercentage)
        {
            Preferences.Default.Set<int>(TaxPercentageKey, taxPercentage);
        }
    }
}