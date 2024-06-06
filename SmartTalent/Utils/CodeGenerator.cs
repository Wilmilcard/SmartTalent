namespace SmartTalent.Utils
{
    public class CodeGenerator
    {
        public static string GenerateCode(int length)
        {
            string result = "";
            string pattern = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            
            Random myRndGenerator = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < length; i++)
            {
                int mIndex = myRndGenerator.Next(pattern.Length);
                result += pattern[mIndex];
            }

            return result;
        }
    }
}
