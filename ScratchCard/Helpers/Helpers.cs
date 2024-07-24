namespace ScratchCard.Services
{
    public static class Helpers
    {
        public static string GeneratePin()
        {
            Random random = new Random();
            int num1 = random.Next(1, 10);

            long nums = random.Next(0, 1000000000);

            return num1.ToString() + nums.ToString("D9");
        }
    }
}
